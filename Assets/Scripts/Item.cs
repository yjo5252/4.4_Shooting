using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public enum Type {Ammo, Coin, Grenade, Heart, Weapon};
    public Type type; 
    public int value;

    void Update()
    {
        transform.Rotate(Vector3.up * 20 * Time.deltaTime);
    }


     void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Object Entered the trigger");

    }
    void OnTriggerStay(Collider other)
    {
        //Debug.Log("Object is with trigger");
    }


    void OnTriggerExit(Collider other)
    {
        //Debug.Log("exit");

    }
}



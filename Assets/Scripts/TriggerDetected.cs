using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDetected : MonoBehaviour
{
    MeshRenderer mesh;
    Material mat; 

    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;   
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
        if(other.gameObject.name == "Sphere")
        {
            mat.color = new Color(0,0,0);
           // other.meshrenderer.material.color = new Color(0,0,0);
            Debug.Log("Box color change");
        }
         if(other.gameObject.name == "Cube")
        {
            mat.color = new Color(0,0,0);
           // other.meshrenderer.material.color = new Color(0,0,0);
            Debug.Log("Sphere color change");
        }
        
    }
}

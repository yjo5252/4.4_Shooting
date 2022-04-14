using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed; 
    float hAxis;
    float vAxis; 
    bool wDown;


    public GameObject[] graenades;
    public int hasGrenades;

    public int ammo; 
    public int coin; 
    public int health; 

    public int maxAmmo; 
    public int maxCoin; 
    public int maxHealth; 
    public int maxHasGrenades; 


    Vector3 moveVec; 
    Animator anim; 

    GameObject nearObject;



    void Start()
    {
        anim = GetComponentInChildren<Animator>();

    }

    void Update()
    {
        hAxis = Input.GetAxisRaw("Horizontal");
        vAxis = Input.GetAxisRaw("Vertical");
        wDown = Input.GetButton("Walk");

    

        moveVec = new Vector3(hAxis, 0, vAxis).normalized;

        transform.position += moveVec * speed * (wDown? 0.3f:1f) * Time.deltaTime;
        

        anim.SetBool("isRun", moveVec != Vector3.zero);
        anim.SetBool("isWalk", wDown);

        transform.LookAt(transform.position + moveVec);

        
    }

    void onCollisionEnter(Collision collision)
    {
        Debug.Log("Enter Collision");
        if (collision.gameObject.name == "Item")
            Debug.Log("Item");
    }

     void OnTriggerEnter(Collider other)
    {
        Debug.Log("Object enter");
        if(other.tag == "Item"){
            //Debug.Log("Object is item");
            Item item = other.GetComponent<Item>(); 
            switch (item.type) {
                case Item.Type.Ammo:
                    ammo += item.value;
                    if (ammo > maxAmmo)
                        ammo = maxAmmo;
                    break;
                case Item.Type.Coin:
                    coin += item.value;
                    if (coin > maxCoin) 
                        coin = maxCoin;
                    break;
                case Item.Type.Heart:
                    health += item.value;
                    if (health > maxHealth)
                        health = maxHealth;
                    break;
                case Item.Type.Grenade:
                    hasGrenades += item.value;
                    if (hasGrenades > maxHasGrenades)
                        hasGrenades = maxHasGrenades;
                    break;
            }
            Destroy (other.gameObject);
        }
    }

    void OnTriggerStay(Collider other)
    {
        //Debug.Log("Object is with trigger");
         if (other.tag == "Weapon")
            nearObject = other.gameObject;
            
    }


    void OnTriggerExit(Collider other)
    {
        //Debug.Log("exit");
        
        if (other.tag == "weapon")
            nearObject = null;
            


    }
    


}

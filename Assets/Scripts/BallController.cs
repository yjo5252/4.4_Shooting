using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private float _speed = 10.0f;

    MeshRenderer mesh;
    Material mat; 
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * _speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * _speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * _speed * Time.deltaTime);
        }

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Object Entered the trigger");

    }
    void OnTriggerStay(Collider other)
    {
        Debug.Log("Object is with trigger");
    }


    void OnTriggerExit(Collider other)
    {
        Debug.Log("exit");
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

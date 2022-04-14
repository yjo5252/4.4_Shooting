using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public Transform target; // 공전 목표
    public float orbitSpeed; // 공전 속도
    Vector3 offSet; // 목표와의 거리 

    void Start()
    {
        
    }

    void Update()
    {
        transform.RotateAround(target.position, 
                                Vector3.up, 
                                orbitSpeed * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] float speeedX;
    [SerializeField] float speeedY;
    [SerializeField] float speeedZ; 
    
    void Update()
    {
        transform.Rotate(360*speeedX*Time.deltaTime, 360*speeedY*Time.deltaTime,  360*speeedZ*Time.deltaTime);   
    }
}

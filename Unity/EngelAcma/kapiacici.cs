using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kapiacici : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        transform.position += Vector3.up * 5;
    }

    private void OnTriggerExit(Collider other)
    {
        transform.position -=Vector3.up * 5;
    }

    private void OnTriggerStay(Collider other)
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    Vector3 offset;
    public Transform arac;
	// Use this for initialization
	void Start () {
        offset = arac.position - transform.position;//başlangıç ayarı
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = arac.position - offset;//cameraya bu offset uygulanacak.
	}
}

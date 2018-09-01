using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform player;
    Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = player.position - transform.position;	
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = player.position - offset;
        //update yerine lateupdate kullandık çünkü en son yapılan update işlemidir.
        //O arada yapılan tüm işleri kapsaması için.
	}
}

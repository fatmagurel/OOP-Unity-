using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlockWhenInvisible : MonoBehaviour {

    Transform player;
	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player").transform;//ismi player olan nesneyi bulup getirir.
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (player.position.z < transform.position.z) return;//player bloğun gerisindeyse o bloğa dokunma hiçbi şey yapma

        float distance = Vector3.Distance(player.position, transform.position);

        float screenSize = Camera.main.orthographicSize;
        if (distance > screenSize + 1)
            Destroy(gameObject);

    }
}

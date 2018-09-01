using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeTest : MonoBehaviour {

    GameObject sphere;
    public Rigidbody rb;


     void Awake()
    {
        //Debug.Log("game has not started yet");
    }
    // Use this for initialization
    void Start () {
     // cam = Camera.main;
        //Debug.Log("game has already started");
        gameObject.name = "cube2";

        sphere = GameObject.Find("Sphere");
        sphere.name = "sphere2";
    }

    // Update is called once per frame
    void Update () {
          
        //transform.position += new Vector3(0, 0, 5);
	}

    private void FixedUpdate()
    {
        rb.AddForce(Vector3.forward * 11);
        //Debug.Log("Gecen süre" + Time.deltaTime + "FPS:" + 1f / Time.deltaTime);
    }

    //private void OnGUI()
    //{
    //    if(GUI.Button(new Rect(10,10,100,100), "I am a button"))
    //    {
    //        Debug.Log("I am a button");
    //    }
    //}
    public void ShowMessage()
    {
        Debug.Log("You pressed a button!");
    }

    private void OnEnable()
    {
        Debug.Log("the script has been enabled");
    }

    private void OnDisable()
    {
        Debug.Log("the script has been disabled");
    }

  //Camera cam;
    private void LateUpdate()
    {
    //    cam.transform.Translate(new Vector3(0, 0, Time.deltaTime * 5));
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Bir şeye dokundunuz!" + collision.gameObject.name);
    }

    private void OnCollisionExit(Collision collision)
    {

        Debug.Log("Bir şeye dokumayı bitirdiniz!");
    }

    private void OnCollisionStay(Collision collision)
    {

        Debug.Log("Bir şeye dokunuyorsunuz");
    }
}

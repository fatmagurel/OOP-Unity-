using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

    static AudioManager instance;
	// Use this for initialization
	void Start () {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(this.gameObject);//eski müzik kalıyo yeni müziğin gelmesine izin vermiyor.
        }

        DontDestroyOnLoad(instance);//oyunda oyuncu ölsede müzik çalmaya devam eder.bu oyun nesnesini yok etme.

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

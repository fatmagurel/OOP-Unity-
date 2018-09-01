using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneController : MonoBehaviour {

    AudioSource audioSource;//oyunda müziğin çalması için bu ve startın içindeki kodlar yazılır.

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }
    public void SahneyeGit(string name)
    {
        SceneManager.LoadScene(name);//index yani girilen isme göre sahneye götürüyor.
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}

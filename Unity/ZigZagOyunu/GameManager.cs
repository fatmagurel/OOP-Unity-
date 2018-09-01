using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {


    public bool isGameStarted=false;
    int score, highScore=0;
    public Text scoreText, highScoreText;

    private void Awake()
    {
        highScore = PlayerPrefs.GetInt("HS");
        //oyun başladığında highScore değerini getirmek için start yada awake metodunda kullanılır.
        highScoreText.text = highScore.ToString();
    }

    // Use this for initialization
    void Start () {
        isGameStarted = false;

    }
	
	// Update is called once per frame
	void Update () {
       // if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        if (Input.GetKeyDown(KeyCode.Return)) //enter ile koşmaya başlar.yerine telefon için bu yazıldı.hareket varsa oyun başlayacak.
        {
            StartGame();
        }
	}

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

     void StartGame()
    {
        isGameStarted = true;
        FindObjectOfType<WallMaker>().CreateWall();
        //oyun açılır açılmaz duvar oluşumu başlar.
    }

    public void MakeScore()
    {
        score+=10;
        scoreText.text=score.ToString();

        if(score > highScore)
        {
            highScore = score;
            highScoreText.text = highScore.ToString();
            PlayerPrefs.SetInt("HS",highScore);//yeni highscore sisteme kaydedilir.

        }
    }
}

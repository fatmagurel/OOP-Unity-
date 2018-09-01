using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Racket : MonoBehaviour {

    protected Rigidbody2D rb;//protected ile alt classlar erişebilir racket artık erişebilir.
    public float moveSpeed = 10.0f;
    protected int score;
    public Text ScoreText;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    public virtual void SkorYap()
    {
        score++;
        ScoreText.text = score.ToString();//ekrana skoru yazdırır.
    }
}

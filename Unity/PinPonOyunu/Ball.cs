using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{


    Rigidbody2D rb;
    public float moveSpeed = 10;
    public Racket solRaket;
    public Racket sagRaket;
    AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(1, 0) * moveSpeed;
        audioSource = GetComponent<AudioSource>();

    }

    private void OnCollisionEnter2D(Collision2D other)
    {

        audioSource.Play();

        if (other.transform.name == "SolDuvar")
            sagRaket.SkorYap();

        if (other.transform.name == "SagDuvar")
            solRaket.SkorYap();

        if (other.transform.name == "SolRaket")
            DonusYonuHesapla(1, other);

        if (other.transform.name == "SagRaket")
            DonusYonuHesapla(-1, other);

    }

    private void DonusYonuHesapla(int x, Collision2D other)
    {
        float pay = (transform.position.y - other.transform.position.y);
        float y = pay / other.collider.bounds.size.y;

        rb.velocity = new Vector2(x, y) * moveSpeed;
    }
}

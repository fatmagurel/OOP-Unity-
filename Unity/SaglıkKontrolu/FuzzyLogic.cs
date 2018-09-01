using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//arayüz kütüphanesi

public class FuzzyLogic : MonoBehaviour {

    public Text healthyTxt, hurtTxt, criticalTxt;//unity de value değerleri atanır.

    public InputField inputField;//unityde ınputfield atanır.
    float healthy, critical, hurt;
    float health;//makineye verilecek değer fuzzy logice.

    public AnimationCurve healthyCurve, hurtCurve, criticalCurve;//grafiği girebileceğimiz bir ortsm lazım.
    //animationcurve ın içi boş untiy de içi doldurulur grafik oluşturulur.

    public void Evaluate()
    {
        if (string.IsNullOrEmpty(inputField.text)) return;

        float health = float.Parse(inputField.text);//parse analiz eder text string değeri floata çevirir.
        healthy = healthyCurve.Evaluate(health);//health verilen değerine göre karşımıza çıkan değer healthy
        critical = criticalCurve.Evaluate(health);
        hurt = hurtCurve.Evaluate(health);
        DisplayResults();//ekrana yazdırmak için fonksiyon oluşturuldu.
    }

    private void DisplayResults()
    {
        healthyTxt.text = healthy.ToString();
        criticalTxt.text = critical.ToString();
        hurtTxt.text = hurt.ToString();
    }
}
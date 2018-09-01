using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AracKontrol : MonoBehaviour {

    public float mass;

    Vector3 velocity;//hız
    float currentSpeed;//mevcut hızı
    public float moveSpeed, rotSpeed;//dönme hızı rotspeed
    public Path path;
    public bool isLooping=false;

    Vector3 currentPoint;//mevcut point
    int currentIndex;//mevcut index 12 index lazım bize

	// Use this for initialization
	void Start () {
        currentIndex = 0;
        currentPoint = path.GetPoint(currentIndex);//o anki hedef nokta alınması lazım
        velocity = transform.forward;//başlangıç hızı ileri yön
	}
	
	// Update is called once per frame
	void Update () {
        currentSpeed = moveSpeed * Time.deltaTime;//başlangıç hızı
        currentPoint = path.GetPoint(currentIndex);//o anki hedef nokta alınması lazım.sürekli değişeceği için update de son hali alınmalı.

        //mesafe belli bi noktaya geldiğinde diğer index hesaplanır.
        Vector3 dir = currentPoint - transform.position;//bi sonraki nokta ile şuanki nokta arasındaki fark.
        float distance = dir.magnitude;//vektörün büyüklüğünü verir,farkı verir.
        dir = dir.normalized;//dir.Normalize();
        //dir /= dir.magnitude;//kendi büyüklüğüne bölersek birim vektörü almış oluruz bu rotasyonda kullanılacak.

        if(distance <= path.minFark)
        {
            if (currentIndex < path.Length - 1)
                currentIndex++;
            else if (isLooping)
                currentIndex = 0;

        }
        //sınavda sormaz...
        if (currentIndex == path.Length - 1 && !isLooping)//son indexe geldiyse ve looping yoksa
        {
            velocity = IvmeHesapla(currentPoint, true);
        }

        else
            velocity = IvmeHesapla(currentPoint, false);


        transform.position += velocity;//ileri doğru gitmesini sağlar.
        Quaternion rot = Quaternion.LookRotation(dir);
        transform.rotation = Quaternion.Lerp(transform.rotation, rot, rotSpeed*Time.deltaTime);//daha yavaş dönüşler yapar lerp.


	}
    //sınavda sormaz...
    private Vector3 IvmeHesapla(Vector3 currentPoint, bool isFinalPoint)
    {
        Vector3 v = currentPoint - transform.position;
        float distance = v.magnitude;
        v = v.normalized;

        if (distance < 10 && isFinalPoint)
        {
            v *= (currentSpeed * (distance / 10));
        }
        else
            v *= currentSpeed;

        //f=m.a => a=f/m;
        Vector3 a = v / mass;
        return a;
    }
}

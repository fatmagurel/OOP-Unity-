using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMaker : MonoBehaviour {

    public GameObject wallPrefab;
    Vector3 lastPos;//son duvarın pozisyonu
    float offset = 0.707f;
    int counter;

    public Transform player;//playerın pozisyonu
	// Use this for initialization
	void Start () {
        lastPos = wallPrefab.transform.position;//en son esas alınacak duvarın pozisyonu
	}
    public void CreateWall()
    {
        InvokeRepeating("CreateWallParts", 0.5f, Time.deltaTime);
        //sürekli fonksiyon çağırarak duvar oluşumu sağlanır.
    }
	
	// Update is called once per frame
	private void CreateWallParts() {

        //GameObject.Find("Player");//yukarda player çağırmadan da gameobje oluşturulup çağırılabilir.
        float distance = Vector3.Distance(lastPos, player.position);
        float screenSize = Camera.main.orthographicSize*2;
        //screenSize ekranın yarı yüksekliği olacaktır. 2 ile çarpılırsa tam yükseklik olur.
       
        if (distance > screenSize+2) return;

        int chance = Random.Range(0, 100);//rasgele yönlerde duvar oluşturulur.
        Vector3 newPos = Vector3.zero;

        if (chance > 50)//duvarları saga diz,degilse sola diz.
        {
            newPos = new Vector3(lastPos.x + offset, lastPos.y, lastPos.z + offset);
        }
        else
            newPos = new Vector3(lastPos.x - offset, lastPos.y, lastPos.z + offset);

        GameObject newWall = Instantiate(wallPrefab, newPos, Quaternion.Euler(0, 45, 0));
        lastPos = newWall.transform.position;
        //son pozisyona yeni son pozisyon değeri atanarak güncellenir.

        counter++; // kristallerin duvarlar oluştukça gelmesi için
        if(counter%Random.Range(3,10)==0)//counterın 3 ile 10 arasındaki sayıya bölümünden kalan 2 ise kristal oluşsun.
        {
            newWall.transform.GetChild(0).gameObject.SetActive(true);//nesnenin çocuğu varsa
        }
    }
}

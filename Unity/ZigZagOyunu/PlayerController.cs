using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public GameObject effectPrefab;
    public Transform rayOrigin;
    public GameManager gameManager;
    bool lookingRight = true;
    Animator anim;
    Rigidbody rb;
    float moveSpeed = 1.5f;
    float elapsedTime = 2;//geçen süre 2 saniye olsun.

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();//playerın animator componenti lazım.
    }

    private void Update()
    {
        elapsedTime -= Time.deltaTime;//geçen süreden 2 saniye çıkarılır. bir süre sonra sıfıra inecek.
        if(elapsedTime < 0)
        {
            moveSpeed *= 1.1f;//hız 1.2 artacak.
            elapsedTime = 2;
        }

        //ya da şu şekilde de olur.

        //if(Time.time > elapsedTime)
        //{
        //    moveSpeed *= 1.1f;
        //    elapsedTime = Time.time + 1;
        //}

        if(transform.position.y <-3)
        {
            gameManager.RestartGame();
        }
    }

    void FixedUpdate()
    {
        if (!gameManager.isGameStarted) return;
        anim.SetTrigger("isGameStarted");//unity deki isgamestarted parametresi alınır. trigger, tetikleyicidir bi kere çağırılır.

        rb.position += transform.forward * moveSpeed * Time.deltaTime;

        //if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) 
        if (Input.GetKeyDown(KeyCode.Space))//mobil için dokunmatiğe göre ayalandı.TouchPhase.Ended parmak ekrandan kalktıysa moved hareket  ediyorsa stationary parmak dokunuyo ama oynamıyosa
            TurnPlayer();

        
        if (!Physics.Raycast(rayOrigin.position, Vector3.down))//Aşağıda bir şey yoksa
        {
            anim.SetTrigger("isFalling");//unityde triggerin amacı state ten state e geçiş.
            //anim.SetFloat("distance", distance);//belli bi mesafeye ulaştıysa distance ı yapsın.distance de mesafe hesaplatıesın.
        }
    }

    private void TurnPlayer()
    {
        lookingRight = !lookingRight;//true ise false, false ise true olsun.

        if (lookingRight)
        {
            rb.rotation = Quaternion.Euler(new Vector3(0, 45, 0));//0,45,0 sağa bakar. Quaternion.Euler(0,45,0); da yazılabilir.y ekseni etrafında döner oyuncu.
        }

        else
        {
            rb.rotation = Quaternion.Euler(0, -45, 0);
        }
    }
        private void OnTriggerEnter(Collider other)//other elmas oluyo.
        {
            if (other.tag == "crystal")//unityde bütün kristallere crystal tagı verildi. çarpılan şeyin yani otherın tagı crystal ise;
            {
                 GameObject effect = Instantiate(effectPrefab, transform);//çarptığım nesne kristalse effect oluştursun.
                 Destroy(effect, 1);//efect 1 saniye sonra yok olur.
                 gameManager.MakeScore();//skor
                 Destroy(other.gameObject);//other ın gameObjectini yoket.collidera bağlı olan gameobject yokedilir.
            }
        }
}

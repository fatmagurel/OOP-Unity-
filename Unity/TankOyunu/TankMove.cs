
using UnityEngine;
using UnityEngine.AI; //yapay zeka kütüphanesi
public class TankMove : MonoBehaviour {
    public Transform player;
    float maxCheckDistance = 20;
    float rotSpeed = 5f;
    public Transform RayOrigin;
    public float moveSpeed, turnSpeed;
    Vector3 randomTargetPoint= Vector3.zero;
    NavMeshAgent agent; //yapay zeka kütüphanesi lazım.Navigasyon özelliği var, ajan. nav mesh nesnesine ulaşır.
    float minX, maxX, minZ, maxZ;
    float value = 15;
    Animator fsmAI;

    // Use this for initialization
    void Start () {
        fsmAI = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();//nesne alınır.
        minX = -value;
        maxX = value;
        minZ = -value;
        maxZ = value;
    }
	
	// Update is called once per frame
	void Update () {
        if (Vector3.Distance(transform.position, randomTargetPoint) <1f)
            FindNewRandomPoint();
        MoveToTarget();
        Vector3 dir = (player.position - RayOrigin.position).normalized;
        Debug.DrawRay(RayOrigin.position, dir * maxCheckDistance, Color.red);//ışın çizilir,görsel.
        RaycastHit hitInfo;//ateş edildiğinde canı azalacak o yüzden hitınfo lazım

        Ray ray = new Ray(transform.position, dir);



        if (Physics.Raycast(RayOrigin.position, dir, out hitInfo, maxCheckDistance))//tankın merkezinden dire doğru 20 birimlik ışın.
        {
            if (hitInfo.transform.tag == "Player")//çarptığı nesne tagı playersa
            {
                fsmAI.SetBool("isVisible", true);
                transform.GetComponent<TankMove>().Chase();
            }
            else
                fsmAI.SetBool("isVisible", false);
        }
        else
            fsmAI.SetBool("isVisible", false);
        if (!player) return;
    }

    public void FindNewRandomPoint()
    {
        float xRandom = Random.Range(minX, maxX);
        float zRandom = Random.Range(minZ, maxZ);
        randomTargetPoint = new Vector3(xRandom, transform.position.y, zRandom);
    }

    private void MoveToTarget()
    {
        Vector3 dir = (randomTargetPoint - transform.position).normalized;
        //transform.position += transform.forward * moveSpeed * Time.deltaTime;

        Quaternion lookRotation = Quaternion.LookRotation(dir);
        transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, turnSpeed * Time.deltaTime);
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        //transform.Rotate()
    }
    public void Chase()
    {
        if (!player) return;
        agent.SetDestination(player.position);
    }
    public void Patrol()
    {
        Debug.Log("Patrolling");
    }
    public void Shoot()
    {
        if (!player) return;
        Quaternion rot = new Quaternion();
        Vector3 dir = (player.position - transform.position).normalized;
        rot.SetLookRotation(dir);
        transform.rotation = Quaternion.Slerp(transform.rotation, rot, rotSpeed * Time.deltaTime);

        gameObject.GetComponent<Shooting>().Shoot();
        if (!player) return;
    }
}

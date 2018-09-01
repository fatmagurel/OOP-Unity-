using UnityEngine;
using UnityEngine.UI;

public class AI : Racket
{
    
    public Transform top;
    public float refVal = 2.0f;


    private void FixedUpdate()
    {
        float RaketTopFark = Mathf.Abs(top.position.y - transform.position.y);
        if(RaketTopFark > refVal)
        {
            if(top.position.y > transform.position.y)
            {
                rb.velocity = new Vector2(0, 1) * moveSpeed;
                //rb.velocity=Vector2.up;
            }

            if(top.position.y < transform.position.y)
            {
                rb.velocity = new Vector2(0, -1) * moveSpeed;
                //rb.velocity=Vector2.down;
            }
        }
    }
}

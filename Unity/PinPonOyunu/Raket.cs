using UnityEngine;

public class Raket : Racket {

    public string axisName;
    float moveAxis;
    
	// Update is called once per frame
	void Update () {
        moveAxis = Input.GetAxisRaw(axisName);
        rb.velocity = new Vector2(0, moveAxis) *moveSpeed;
	}

    public override void SkorYap()
    {
        //base.SkorYap();
        score += 2;
        ScoreText.text = score.ToString();
    }
}

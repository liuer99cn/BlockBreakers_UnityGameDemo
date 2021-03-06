using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
    public bool autoPlay = false;

    private Ball ball;

	// Use this for initialization
	void Start () {
        ball = GameObject.FindObjectOfType<Ball>();
        print(ball);
	}
	
	// Update is called once per frame
	void Update () {
        if (!autoPlay)
        {
            MoveWithMouse();
        }else
        {
            AutoPlay();
        }
	
	}

    void MoveWithMouse()
    {
        Vector3 paddlePos = new Vector3(0.5f, 0.22f, 0f);
        float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
        //print(mousePosInBlocks);
        paddlePos.x = Mathf.Clamp(mousePosInBlocks, 0.5f, 15.5f);
        this.transform.position = paddlePos;
    }

    void AutoPlay()
    {
        Vector3 paddlePos = new Vector3(0.5f, 0.22f, 0f);
        Vector3 ballPos = ball.transform.position;
        //print(mousePosInBlocks)thing;
        paddlePos.x = Mathf.Clamp(ballPos.x, 0.5f, 15.5f);
        this.transform.position = paddlePos;

    }
}

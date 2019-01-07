using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {
    // params
    [SerializeField] PaddleController paddle;

    // game state
    Vector2 paddleToBallVector;

	// Use this for initialization
	void Start () {
        paddleToBallVector = transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        var paddlePos = new Vector2(paddle.transform.position.x, paddle.transform.position.y);
        var ballPos = new Vector2(paddlePos.x + paddleToBallVector.x, paddlePos.y + paddleToBallVector.y);
        transform.position = ballPos;
	}
}

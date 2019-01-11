using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    // params
    [SerializeField]
    PaddleController paddle;
    [SerializeField]
    AudioClip[] ballSounds;

    // game state
    Vector2 paddleToBallVector;
    bool isStart = false;
    AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        paddleToBallVector = transform.position - paddle.transform.position;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isStart)
        {
            //LockBallToPaddle();
            LauchBallOnMouseClick();
        }
    }

    private void LockBallToPaddle()
    {
        var paddlePos = new Vector2(paddle.transform.position.x, paddle.transform.position.y);
        var ballPos = new Vector2(paddlePos.x + paddleToBallVector.x, paddlePos.y + paddleToBallVector.y);
        transform.position = ballPos;
    }

    private void LauchBallOnMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isStart = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 15f);
        }
    }

    private void OnCollisionEnter2D()
    {
        if (isStart)
        {
            AudioClip clip = ballSounds[UnityEngine.Random.Range(0, ballSounds.Length)];
            audioSource.PlayOneShot(clip);
        }
    }
}

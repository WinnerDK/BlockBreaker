using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour {

    [SerializeField] float sceneWithInUnits = 16f;
    [SerializeField] float maxX = 15f;
    [SerializeField] float minX = 1f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float mousePosInUnits = Input.mousePosition.x / Screen.width * sceneWithInUnits;
        Vector2 paddlePos = new Vector2(mousePosInUnits, transform.position.y);
        paddlePos.x = Mathf.Clamp(mousePosInUnits, minX, maxX); 
        transform.position = paddlePos;
    }
}

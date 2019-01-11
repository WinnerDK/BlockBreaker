using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public float horizontalSpeed = 2.0F;
    public float verticalSpeed = 2.0F;
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var currentPositionX = Input.mousePosition.x; //.position.x;
        var currentPositionY = Input.mousePosition.y; // transform.position.y;

        if (Input.GetMouseButtonDown(0))
        {
            transform.Rotate(currentPositionX, currentPositionY, 0);
        }
    }
}

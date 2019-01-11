using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineBorderController : MonoBehaviour
{
    // param
    private bool isStart = false;
    private float angleRotation = 25f;

    private float max = 65f;
    private float min = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isStart = true;
        }
        RotateScene();
    }

    private void RotateScene()
    {
        if (isStart)
        {
            //Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
            //Vector3 dir = Input.mousePosition - pos;
            //float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            //transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            difference.Normalize();
            float rotation_z = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
            var currentAxisZ = transform.position.z;
            transform.rotation = Quaternion.Euler(0f, 0f, currentAxisZ + angleRotation);
        }

        for (int i = 0; i < 6; i++)
        {
            float value = Mathf.Clamp(1, min, max);
            Debug.Log(value.ToString());
        }
    }
}

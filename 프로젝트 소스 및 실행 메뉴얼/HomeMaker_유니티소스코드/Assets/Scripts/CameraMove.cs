using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    int speed = 200;

    void Start()
    {

    }

    void Update()
    {
        moveCamera();
    }

    void moveCamera()
    {
        float keyHorizontal = Input.GetAxis("Horizontal");
        float keyVertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.left * speed * Time.smoothDeltaTime * keyHorizontal, Space.World);
        transform.Translate(Vector3.back * speed * Time.smoothDeltaTime * keyVertical, Space.World);
        //transform.Translate(Vector3.up * speed * Time.smoothDeltaTime * keyVertical, Space.World);
    }
}

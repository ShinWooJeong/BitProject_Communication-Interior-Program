using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{

    float speed = 20.0f;
    float rotSpeed = 1.0f;
    public float yRotation = 5.0F;
    public float xRotation = 5.0F;

    void Update()
    {
        Vector3 rot = transform.rotation.eulerAngles;
        //yRotation += Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.D))
        {
            yRotation += 1;
            //transform.eulerAngles = new Vector3(10, yRotation, 50);
            rot.y = yRotation;
            transform.eulerAngles = rot;
        }
        if (Input.GetKey(KeyCode.A))
        {
            yRotation -= 1;
            //transform.eulerAngles = new Vector3(10, yRotation, 50);
            rot.y = yRotation;
            transform.eulerAngles = rot;
        }
        if (Input.GetKey(KeyCode.S)&&xRotation<90)
        {
            xRotation += 1;
            //transform.eulerAngles = new Vector3(10, yRotation, 50);
            rot.x = xRotation;
            transform.eulerAngles = rot;
        }
        if (Input.GetKey(KeyCode.W) && xRotation > -90)
        {
            xRotation -= 1;
            //transform.eulerAngles = new Vector3(10, yRotation, 50);
            rot.x = xRotation;
            transform.eulerAngles = rot;
        }
        if (Input.GetKey(KeyCode.R))
        {
            
            //transform.position
        }
        if (Input.GetKey(KeyCode.F))
        {
        }
    }
}


//public class rotate : MonoBehaviour
//{

//    float speed = 20.0f;
//    float rotSpeed = 1.0f;

//    void Update()
//    {

//        float h = Input.GetAxisRaw("Horizontal");

//        if (Input.GetKey(KeyCode.E))
//        {

//            //transform.Rotate(Vector3.up * (-rotSpeed));
//            Vector3 rot = transform.rotation.eulerAngles;//회전값을 받음
//                                                         //캐릭터 이동과는 다르게 카메라는 x축과 y축을 회전시키고 z축을 회전시키지 않는다.
//            rot.z = 0;
//            rot.x += 0;
//            rot.y += h;
//            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(rot), 2f);
//        }
//        if (Input.GetKey(KeyCode.Q))
//        {
//            //transform.Rotate(Vector3.up * rotSpeed);
//            Vector3 rot = transform.rotation.eulerAngles;//회전값을 받음

//            rot.z = 0;
//            rot.x += 0;
//            rot.y -= h;
//            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(rot), 2f);
//        }
//    }

//}




//public class rotate : MonoBehaviour {

//    public float rot_speed = 1f;

//    void Update()
//    {
//        RotLeft();
//        RotRight();
//    }
//    public void RotRight()
//    {
//        if (Input.GetKey(KeyCode.E))
//        {
//            float Key = rot_speed * Time.deltaTime;
//            //transform.rotation *= Quaternion.AngleAxis(Key, Vector3.up);
//            //transform.rotation;
//            Camera.main.transform.
//        }
//    }
//    public void RotLeft()
//    {
//        if (Input.GetKey(KeyCode.Q))
//        {
//            float Key = rot_speed * Time.deltaTime;
//            transform.rotation *= Quaternion.AngleAxis(Key, Vector3.down);
//        }
//    }
//}

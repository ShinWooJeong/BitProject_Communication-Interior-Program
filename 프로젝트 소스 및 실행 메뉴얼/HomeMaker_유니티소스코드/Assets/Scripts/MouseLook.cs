using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public Quaternion TargetRotation;
    //public Transform CameraVector;
    public float RotationSpeed;
    public Vector3 Gap;
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CameraRotation();
    }
    void CameraRotation()
    {
        if (transform.rotation != TargetRotation)
            transform.rotation = Quaternion.Slerp(transform.rotation, TargetRotation, RotationSpeed * Time.deltaTime);

        if (Input.GetMouseButton(1))
        {
            Gap.x += Input.GetAxis("Mouse Y") * RotationSpeed * -1;
            Gap.y += Input.GetAxis("Mouse X") * RotationSpeed;

            Gap.x = Mathf.Clamp(Gap.x, -5f, 85f);
            TargetRotation = Quaternion.Euler(Gap);
            Quaternion q = TargetRotation;
            q.x = q.z = 0;
            //CameraVector.transform.rotation = q;
        }
    }
}

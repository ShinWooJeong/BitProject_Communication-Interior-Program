using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CDrag : MonoBehaviour
{

    Transform tf;
    Vector3 screenPosition;
    Vector3 relative;
    bool clicked;
    
    private Camera mainCamera;
    private RaycastHit rayHit;
    private Ray ray;
    public float MAX_RAY_DISTANCE = 1000000.0f;

    private void Awake()
    {
        tf = transform;
    }
    private void OnMouseDown()
    {
        mainCamera = Camera.main;
        gameObject.layer = 2;
        
    }
    private void OnMouseDrag()
    {
        ray = mainCamera.ScreenPointToRay(Input.mousePosition);

        Physics.Raycast(ray, out rayHit, MAX_RAY_DISTANCE);
        tf.position = rayHit.point;
    }
    private void OnMouseUp()
    {
        gameObject.layer = 0;
        clicked = false;
        Debug.Log("마우스 클릭업");
    }
    
}


//public class CDrag : MonoBehaviour
//{

//    Transform tf;
//    Vector3 screenPosition;
//    Vector3 relative;
//    bool clicked;

//    private void Awake()
//    {
//        tf = transform;
//    }
//    private void OnMouseDown()
//    {
//        screenPosition = Camera.main.WorldToScreenPoint(transform.position);
//        relative = screenPosition - Input.mousePosition;
//        clicked = true;
//        Debug.Log("마우스 클릭다운");
//    }
//    private void OnMouseDrag()
//    {
//        if (clicked)
//        {
//            tf.position = Camera.main.ScreenToWorldPoint(Input.mousePosition + relative);
//            if (Input.GetKeyDown(KeyCode.Escape))
//            {
//                tf.position = Camera.main.ScreenToWorldPoint(screenPosition);
//                clicked = false;
//                Debug.Log("ESC 버튼다운");
//            }
//        }
//    }
//    private void OnMouseUp()
//    {
//        clicked = false;
//        Debug.Log("마우스 클릭업");
//    }

//}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePosition : MonoBehaviour {

    private RaycastHit hit;

    public LayerMask maskValue = -1;


    void FixedUpdate()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Ray ray = new Ray();

            //스크린 상에서의 좌표를 월드 스페이스상 좌표로 변환
            //시작점 오리진을 설정하고 디렉션을 카메라가 비추는 방향으로 설정된 레이객체 반환
            //ray.origin = Camera.main.ScreenPointToWorld(Input.mousePosition);
            //ray.direction = 
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //rayCasting(ray);

            if(Physics.Raycast(ray, out hit, 10.0f, this.maskValue))
            {
                print(hit.collider.gameObject.name + "와 충돌");
            }
        }
    }
 
    //void rayCasting(Ray ray)
    //{
    //    RaycastHit hitObj;
    //
    //    if(Physics.Raycast(ray, out hitObj, Mathf.Infinity))
    //    {
    //        if(hitObj.transform.tag.Equals("Furniture"))
    //        {
    //            hitObj.transform.position = new Vector3(0, 0, 0);
    //        }
    //    }
    //}
	
}

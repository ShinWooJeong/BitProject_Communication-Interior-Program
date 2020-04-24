using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureFollow : MonoBehaviour {

    public GameObject furniture = null;

    void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x,
                                            Input.mousePosition.y, 0);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        furniture.transform.position = objPosition;


    }

}

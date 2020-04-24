using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDrag : MonoBehaviour
{

    public GameObject funitureObj = null;
    public Transform funitureTrans = null;
    public GameObject button = null;

    private Camera mainCamera;
    private RaycastHit rayHit;
    private Ray ray;
    public float MAX_RAY_DISTANCE = 1000000.0f;

    public string furnitureName = null;
    public string furnitureType = null;
    public string furnitureCompany = null;
    public int furniturePrice = 0;

    public void Down()
    {
        mainCamera = Camera.main;
        //button.SetActive
    }
    public void Drag()
    {
        ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        
        Physics.Raycast(ray, out rayHit, MAX_RAY_DISTANCE);
        Debug.DrawLine(ray.origin, rayHit.point, Color.green);
        Debug.Log("위치는 ->" + rayHit.point);
        funitureTrans.position = rayHit.point;
    }
    public void Up()
    {
        Instantiate(funitureObj, funitureTrans.position, Quaternion.identity);
        FurnitureManager.FurnitureListInstance.AddFurniture(furnitureName, furnitureType, furnitureCompany, furniturePrice, funitureTrans);
        FurnitureManager.FurnitureListInstance.Binding();
    }
}

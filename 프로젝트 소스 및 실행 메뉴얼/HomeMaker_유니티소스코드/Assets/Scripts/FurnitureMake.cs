using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureMake : MonoBehaviour {



    public GameObject funitureObj = null;
    public Transform funitureTrans = null;

    public string furnitureName = null;
    public string furnitureType = null;
    public string furnitureCompany = null;
    public int furniturePrice = 0;


    public void newFurniture()
    {



        Instantiate(funitureObj, funitureTrans.position, Quaternion.identity);
        FurnitureManager.FurnitureListInstance.AddFurniture(furnitureName, furnitureType, furnitureCompany, furniturePrice, funitureTrans);
        FurnitureManager.FurnitureListInstance.Binding();
    }



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

public class FurnitureManager : MonoBehaviour {

    // 모든 씬에서 설치된 가구를 관리해주는 싱글톤 매니저
    // [자신의 타입]은 프라이빗이고 그걸 접근 할 수 있는 게터를 선언
    private static FurnitureManager _furnitureListInstance = null;
    //private List<Furniture> furnitureList;
    private Stack<Furniture> furnitureList = new Stack<Furniture>();
   

    public static FurnitureManager FurnitureListInstance
    {
        get
        {
            if(_furnitureListInstance == null)
            {
                //파인드 오브젝트 오브 타입은 비용이 큰 함수지만 딱 한번만 실행
                _furnitureListInstance = FindObjectOfType(typeof(FurnitureManager)) as FurnitureManager;

                if(_furnitureListInstance == null)
                {
                    Debug.LogError("실행중인 퍼니처매니저 오브젝트가 없습니다.");
                }
            }
            return _furnitureListInstance;
        }

     
    }

    //가구를 저장
    public void AddFurniture(string name, string furnitureType, string company, int price, Transform locatedTransform)
    {
        furnitureList.Push(new Furniture(name, furnitureType, company, price, locatedTransform));
        Debug.Log("가구 잘 저장됨");
        Debug.Log(name + furnitureType + company + price.ToString() + locatedTransform.position.ToString());

    }

    //저장된 가구들을 모두 화면에 세팅
    public void SetAllFurniture()
    {
        foreach (Furniture furniture in furnitureList)
        {
            // 저장된 가구 이름
            Debug.Log(furniture.Name);

        }
        
    }

    public GameObject itemObject;
    public Transform content;

    

    public void Binding()
    {
        GameObject txtItemTemp;
        ItemObject itemobjectTemp;

        
            txtItemTemp = Instantiate(this.itemObject) as GameObject;
            itemobjectTemp = txtItemTemp.GetComponent<ItemObject>();
            itemobjectTemp.name.text = furnitureList.Pop().Name;

            txtItemTemp.transform.SetParent(this.content);
       
     
    }

}

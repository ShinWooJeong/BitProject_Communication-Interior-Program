using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;


public class LoginTest : MonoBehaviour
{
    InputField _id;
    InputField _pass;

    public void SetId(InputField id)
    {
        this._id = id;
    }

    public void SetPass(InputField pass)
    {
        this._pass = pass;
    }

    public void LogTest()
    {
        StartCoroutine(TestLogin());
    }

    IEnumerator TestLogin()
    {
        Text myLogin = GameObject.Find("logText").GetComponent<Text>();
        myLogin.text = "Testing";
        //로그인 php Url
        string url = "https://unity3dphp.azurewebsites.net/practice2.php";

        WWWForm loginData = new WWWForm();
        //php의 id_data로 대입
        loginData.AddField("id_data", _id.text);
        loginData.AddField("pass_data", _pass.text);

        //폼 데이터 전송
        WWW login = new WWW(url, loginData);
       
        yield return login;
        myLogin.text = login.text;

    }
}

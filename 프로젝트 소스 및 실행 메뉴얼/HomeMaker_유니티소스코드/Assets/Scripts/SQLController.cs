using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//mySql용 전처리기
using System.Data;   // C#의 데이터 테이블 때문에 사용
using MySql.Data;    // MySql 함수들을 불러오기 위해서 사용
using MySql.Data.MySqlClient;   // 클라이언트 기능을 사용하기 위해 사용

public class SQLController : MonoBehaviour{


    public void SqlConnection()
    {
        MySqlCreate mysql = new MySqlCreate();
        mysql.SQLConnection();
    }

    //MySqlConnection sqlconn = null;
    ////private string sqlDBip = "unity-daniel-db.mysql.database.azure.com";
    ////private string sqlDBname = "unity3d_db";
    ////private string sqlDBid = "unity3d@unity-daniel-db";
    ////private string sqlDBpw = "Gustmdrnldyal!";
    ////server=unity-daniel-db.mysql.database.azure.com;user id=unity3d@unity-daniel-db;database=unity3d_db
    //public void sqlConnect()
    //{
    //    //DB접속정보 입력
    //    //string sqlDatabase; = "Server=unity-daniel-db.mysql.database.azure.com;User Id=unity3d@unity-daniel-db;Password=Gustmdrnldyal!;Database=unity3d_db;SSLMode=none,SslMode=Preferred";

    //    try
    //    {
            
    //        sqlconn = new MySqlConnection("Server=unity-daniel-db.mysql.database.azure.com;User Id=unity3d@unity-daniel-db;Password=Gustmdrnldyal!;Database=unity3d_db;SSLMode=none,SslMode=MySqlSslMode.Required");
    //        //Debug.Log("접속은됨");
    //        sqlconn.Open();
           

    //        Debug.Log("SQL의 접속 상태 : " + sqlconn.State);
    //    }
    //    catch(Exception msg)
    //    {
    //        Debug.Log("에러");
    //        Debug.Log(msg);
    //    }
    //}

    //private void sqldisConnect()
    //{
    //    sqlconn.Close();
    //    Debug.Log("SQL의 접속상태 : " + sqlconn.State);
    //}

    ////함수를 불러올때 명령어에 대한 문자열을 인자로 받아옴
    //public void sqlcmdall(string allcmd)
    //{
    //    sqlConnect();

    //    //명령어를 커맨드에 입력
    //    //명령어를 SQL에 보냄
    //    //예를들어 같은 클래스에 해당 함수를 선언하면 인서트와 업데이트 구문은 해당 함수로 사용가능
    //    // 단, 셀렉트는 찾아오는 것이므로 리턴값이 있어야함
    //    MySqlCommand dbcmd = new MySqlCommand(allcmd, sqlconn);
    //    dbcmd.ExecuteNonQuery();

    //    //접속 해제
    //    sqldisConnect();

    //}

    //////리턴형식을 DataTable로 선언 - 셀렉트 구문용
    //////SELECT는 커맨드가 아닌 어댑터를 이용해 접속하고 데이터를 가져옴
    ////// DataTable로 반환하므로 객체선언 후 DataTable 변수에 대입
    ////public DataTable selsql(string sqlcmd)
    ////{
    ////    DataTable dt = new DataTable();

    ////    sqlConnect();
    ////    MySqlDataAdapter adapter = new MySqlDataAdapter(sqlcmd, sqlconn);
    ////    adapter.Fill(dt);
    ////    sqldisConnect();

    ////    return dt;
    ////}




}

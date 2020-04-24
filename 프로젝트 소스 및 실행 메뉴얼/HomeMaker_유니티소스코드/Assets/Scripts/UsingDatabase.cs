using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UsingDatabase : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void UseDatabase()
    {
        SQLController mysqlDB = new SQLController();

        
        string query = string.Format(
               @"INSERT INTO tb_stage_result
                (user_id, point, record_time)
                VALUES ('{0}','{1}', now())", 100, 1000);

        //mysqlDB.sqlcmdall(query);
        //mysqlDB.sqlcmdall("INSERT INTO "tb_user" VALUES('U");
        //DataTable dt = mysqlDB.selsql("");
    }
}

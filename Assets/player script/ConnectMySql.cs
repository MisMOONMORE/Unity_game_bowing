using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MySql.Data.MySqlClient;
using System.Data;
using UnityEngine;

public class ConnectMySql : MonoBehaviour
{
    void Start()
    {

        //���ݿ��ַ���˿ڡ��û��������ݿ���������
        string sqlSer = "server = 127.0.0.1;port = 3306;user = root;database = database;password = 2726;charset=utf8";
        //��������
        MySqlConnection conn = new MySqlConnection(sqlSer);
        try
        {
            conn.Open();
            Debug.Log("------���ӳɹ�------");
            //sql���
            string sqlQuary = "SELECT * FROM test;";

            Debug.Log(sqlQuary);

            MySqlCommand comd = new MySqlCommand(sqlQuary, conn);

            MySqlDataReader reader = comd.ExecuteReader();

            while (reader.Read())
            {
                //ͨ��reader������ݿ���Ϣ
                Debug.Log(reader.GetString("username"));
                Debug.Log(reader.GetString("password"));
            }
        }
        catch (System.Exception e)
        {
            Debug.Log("Error:" + e.Message);
        }
        finally
        {
            conn.Close();
        }
    }
    void Update()
    {

    }
}

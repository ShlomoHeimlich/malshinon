using System;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

public class DAL
{
    public MySqlConnection conn;
    string connStr = "server=localhost;user=root;password=;database=malshinon;";
    public DAL()
    {
        conn = new MySqlConnection(connStr);
        conn.Open();
        Console.WriteLine("connection success");
    }
}

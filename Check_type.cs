using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Xml.Linq;

public class Check_type
{
    public void Check(string name_malshin)
    {
        DAL dal = new DAL();
        string query_check = "SELECT type FROM people WHERE Name=@name_malshin;";
        MySqlCommand cmd = new MySqlCommand(query_check, dal.conn);
        cmd.Parameters.AddWithValue("@name_malshin", name_malshin);
        object result = cmd.ExecuteScalar();
        string a = result.ToString();
        
        if (a == "target")
        {
            string query_update = "UPDATE people SET type='molshan_and_malshin' WHERE Name=@name_malshin";
            MySqlCommand Cmd = new MySqlCommand(query_update, dal.conn);
            Cmd.Parameters.AddWithValue("@name_malshin", name_malshin);
            int rowsAffected = Cmd.ExecuteNonQuery();
            
        }
        dal.conn.Close();
    }
}
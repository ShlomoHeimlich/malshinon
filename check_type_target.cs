using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Xml.Linq;

public class Check_type_target
{
    public void Check(string name_molshan)
    {
        DAL dal = new DAL();
        string query_check = "SELECT type FROM people WHERE Name=@name_malshin;";
        MySqlCommand cmd = new MySqlCommand(query_check, dal.conn);
        cmd.Parameters.AddWithValue("@name_malshin", name_molshan);
        object result = cmd.ExecuteScalar();
        string a = result.ToString();
        if (a =="malshin")
        {
            string query_update = "UPDATE people SET type='molshan_and_malshin' WHERE Name=@name_molshan";
            MySqlCommand Cmd = new MySqlCommand(query_update, dal.conn);
            Cmd.Parameters.AddWithValue("@name_molshan", name_molshan);
            int rowsAffected = Cmd.ExecuteNonQuery();
        }

    }
}
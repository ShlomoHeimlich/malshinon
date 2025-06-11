using MySql.Data.MySqlClient;
using System;

public class check_Potential_threat
{
   public check_Potential_threat(string name_molshan)
    {
        DAL dal = new DAL();
        string query = "SELECT num_mentions FROM people WHERE NAME =@name_molshan";
        MySqlCommand cmd = new MySqlCommand(query, dal.conn);
        cmd.Parameters.AddWithValue("@name_molshan", name_molshan);
        object result = cmd.ExecuteScalar();
        int num_msg = Convert.ToInt32(result);
        if (num_msg > 20)
        {
                string query_update = "UPDATE people SET type='Potential threat' WHERE Name=@name_molshan";
                MySqlCommand Cmdd = new MySqlCommand(query_update, dal.conn);
                Cmdd.Parameters.AddWithValue("@name_molshan", name_molshan);
                int rowsAffected = Cmdd.ExecuteNonQuery();

        }
    }
}
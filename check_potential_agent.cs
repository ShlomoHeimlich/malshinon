using MySql.Data.MySqlClient;
using System;
using System.Xml.Linq;

class check_potential_agent
{
    public  void check(string malshin_name)
    {
        DAL dal = new DAL();
        string query = "SELECT num_reports FROM people WHERE NAME =@malshin_name";
        MySqlCommand cmd = new MySqlCommand(query, dal.conn);
        cmd.Parameters.AddWithValue("@malshin_name", malshin_name);
        object result = cmd.ExecuteScalar();
        int num_msg = Convert.ToInt32(result);
        if (num_msg > 10)
        {
            string query_id_malshin = "SELECT id FROM people WHERE name =@malshin_name";
            MySqlCommand Cmd = new MySqlCommand(query_id_malshin, dal.conn);
            Cmd.Parameters.AddWithValue("@malshin_name",malshin_name);
            object id_malshin = Cmd.ExecuteScalar();
            string num_id = Convert.ToString(id_malshin);
            string query_len_msg = "SELECT  text_MSG FROM msg WHERE REPORTED_ID=@num_id";
            MySqlCommand cmdd = new MySqlCommand(query_len_msg, dal.conn);
            cmdd.Parameters.AddWithValue("@num_id", num_id);
            int len=0;
            using (MySqlDataReader reader = cmdd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string textMsg = reader["text_MSG"].ToString();
                    len += textMsg.Length;
                }
            }
            if (len / num_msg > 100)
            {
                string query_update = "UPDATE people SET type='potential_agent' WHERE Name=@malshin_name";
                MySqlCommand Cmdd = new MySqlCommand(query_update, dal.conn);
                Cmdd.Parameters.AddWithValue("@malshin_name", malshin_name);
                int rowsAffected = Cmdd.ExecuteNonQuery();
            }

        }
    }
}


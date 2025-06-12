using MySql.Data.MySqlClient;

public class update_num
{
    public void update_num_reports(string name_malshin)
    {
        DAL dal = new DAL();
        string query = "UPDATE people SET num_reports=num_reports+1 WHERE Name=@name_malshin";
        MySqlCommand cmd = new MySqlCommand(query, dal.conn);
        cmd.Parameters.AddWithValue("@name_malshin", name_malshin);
        int rowsAffected = cmd.ExecuteNonQuery();
        dal.conn.Close();
    }
    public void update_num_mentions(string name_molshan)
    {
        DAL dal = new DAL();
        string query = "UPDATE people SET num_mentions=num_mentions+1 WHERE Name=@name_molshan";
        MySqlCommand cmd = new MySqlCommand(query, dal.conn);
        cmd.Parameters.AddWithValue("@name_molshan",name_molshan);
        int rowsAffected = cmd.ExecuteNonQuery();
        dal.conn.Close();
    }

}
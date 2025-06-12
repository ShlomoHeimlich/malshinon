using MySql.Data.MySqlClient;

public class update_MSG
{
    public update_MSG(string malshin, string target)
    {
        DAL dal = new DAL();
        string text_MSG = CreatMsg.Msg;
        string query_REPORTED_ID = "SELECT id FROM people WHERE NAME=@malshin";
        string query_target_id = "SELECT id FROM people WHERE NAME=@target";
        MySqlCommand cmd = new MySqlCommand(query_REPORTED_ID, dal.conn);
        cmd.Parameters.AddWithValue("@malshin", malshin);
        MySqlCommand Cmd = new MySqlCommand(query_target_id, dal.conn);
        Cmd.Parameters.AddWithValue("@target", target);
        string REPORTED_ID = cmd.ExecuteScalar()?.ToString();    
        string target_id = Cmd.ExecuteScalar()?.ToString();      
        string query = "INSERT INTO msg(REPORTED_ID,target_id,text_MSG) " +
        "VALUES(@REPORTED_ID,@target_id,@text_MSG)";
        MySqlCommand cmdd = new MySqlCommand(query, dal.conn);
        cmdd.Parameters.AddWithValue("@target_id", target_id);
        cmdd.Parameters.AddWithValue("@REPORTED_ID", REPORTED_ID);
        cmdd.Parameters.AddWithValue("@text_MSG", text_MSG);
        int rowsAffected = cmdd.ExecuteNonQuery();
        dal.conn.Close();


    }
}
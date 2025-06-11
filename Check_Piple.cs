using MySql.Data.MySqlClient;
using System;

public class Check_Piple
{
    public bool is_in;

    public  Check_Piple(string name)
    {
        this.is_in = Piple(name);
    }

    public bool Piple(string name)
    {
        try
        {
            DAL dal = new DAL();
            string query = $"SELECT * FROM people WHERE Name = @name";
            MySqlCommand cmd = new MySqlCommand(query, dal.conn);
            cmd.Parameters.AddWithValue("@name", name);

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    
                    return true;
                }
                else
                {
                   
                    return false;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception occurred:");
            Console.WriteLine(e.Message);
            return false;
        }
    }
}

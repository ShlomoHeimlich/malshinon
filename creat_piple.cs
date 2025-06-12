using MySql.Data.MySqlClient;
using System;

public class Creat_piple
{
    string name;
    int cod;
    string tipy;
    int num_reports;
    int num_mentions;
    int rating;
    public Creat_piple(string name,int cod, string tipy, int num_reports, int num_mentions, int rating )
    {
        this.cod = cod;
        this.tipy = tipy;
        this.num_reports = num_reports;
        this.num_mentions = num_mentions;
        this.rating = rating;
        this.name = name;
        DAL dal = new DAL();
        string query = "INSERT INTO people(Name, secret_code, type, num_reports, num_mentions, Rating) " +
        "VALUES(@name, @secret_code, @type, @num_reports, @num_mentions, @rating)";
        MySqlCommand cmd = new MySqlCommand(query, dal.conn);
        cmd.Parameters.AddWithValue("@name", this.name);
        cmd.Parameters.AddWithValue("@secret_code", this.cod);
        cmd.Parameters.AddWithValue("@type", this.tipy);
        cmd.Parameters.AddWithValue("@num_reports", this.num_reports);
        cmd.Parameters.AddWithValue("@num_mentions", this.num_mentions);
        cmd.Parameters.AddWithValue("@rating", this.rating);
        cmd.ExecuteNonQuery();
        dal.conn.Close();






    }
}

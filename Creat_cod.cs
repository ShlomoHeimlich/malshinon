using System;

public class Creat_cod 
{ 
    public int number_cod { get; }
 public   Creat_cod()
    {
        Random rnd = new Random();
        number_cod = rnd.Next(1, 1_000_001);   
    }
}
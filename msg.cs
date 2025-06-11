using System;

public class CreatMsg
{
    public static string Msg { get; private set; }
    public string MolshanName { get; private set; }

    public void Create()
    {
        Console.WriteLine("Enter your message:");
        Msg = Console.ReadLine();
        MolshanName = "";
        

        foreach (char c in Msg)
        {
            if (char.IsUpper(c))
            {
                MolshanName += c;
            }
        }
        MolshanName = MolshanName.ToLower();


    }
}

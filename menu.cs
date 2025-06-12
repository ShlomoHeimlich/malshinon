using System;
using ZstdSharp.Unsafe;

class menu
{
    public menu()
    {
        bool work = true;
        while (work)
        {
            Console.WriteLine( 
            "If you are a user press 1 \n" +
            "If you want to close the program press 2 \n");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Check_Maniger Check_Maniger = new Check_Maniger();
                    break;
                case "2":
                    Console.WriteLine("The program is stops.");
                    work = false;
                    break;
            }


        }
    }
}
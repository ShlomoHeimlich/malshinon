using System;
using ZstdSharp.Unsafe;

class menu
{
    public menu()
    {
        bool work = true;
        while (work)
        {
            Console.WriteLine("If you are an administrator press 1 \n" +
            "If you are a user press 2 \n" +
            "If you want to close the program press 3 \n");
            string choice= Console.ReadLine();
            switch (choice)
            {
                case "1":
                    system_administrator system_administrator = new system_administrator();
                    break;

                case "2":
                    Check_Maniger Check_Maniger = new Check_Maniger();
                    break;
                case "3":
                    Console.WriteLine("The program is stops.");
                    work = false;
                    break;
            }


        }
    }
}
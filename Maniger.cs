using Mysqlx.Crud;
using Org.BouncyCastle.Asn1.X509;
using System;

public class Check_Maniger
{
    public Check_Maniger()
    {
        bool piple_malshin = false;
        Console.WriteLine("Please enter your name_malshin.");
        string name_malshin = Console.ReadLine();
        var Check_Piple = new Check_Piple(name_malshin);
        piple_malshin = Check_Piple.is_in;
        if (piple_malshin == false)
        {
            var Creat_cod = new Creat_cod();
            int cod = Creat_cod.number_cod;
            Creat_piple creat_Piple = new Creat_piple(name_malshin,cod,"malshin", 1, 0, 0);
            piple_malshin = true;
        }
        else if (piple_malshin == true)
        {
            Check_type check_Type = new Check_type();
            check_Type.Check(name_malshin);
            update_num update_reports = new update_num();
            update_reports.update_num_reports(name_malshin);
            check_potential_agent check_potential_agent = new check_potential_agent();
            check_potential_agent.check(name_malshin);
        }
        CreatMsg creat_Msg = new CreatMsg();
        creat_Msg.Create();
        string name_molshan = creat_Msg.MolshanName;
        Check_Piple = new Check_Piple(name_molshan);
        bool piple_molshan = Check_Piple.is_in;
        if (piple_molshan == false)
        {
            var Creat_cod = new Creat_cod();
            int cod = Creat_cod.number_cod;
            Creat_piple creat_Piple = new Creat_piple(name_molshan, cod, "target", 0,1, 0);
        }
        else
        {
            Check_type_target Check_type_target = new Check_type_target();
            Check_type_target.Check(name_molshan);
            update_num update_mentions = new update_num();
            update_mentions.update_num_mentions(name_molshan);
            check_Potential_threat check_Potential_threat = new check_Potential_threat(name_molshan);

        }
        update_MSG update_MSG = new update_MSG(name_malshin,name_molshan);
        
    }
}

                
        
       
           
    

   


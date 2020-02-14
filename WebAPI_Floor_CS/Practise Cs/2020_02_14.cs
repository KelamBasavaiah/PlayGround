using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_Cs
{
    public class _2020_02_14
    {
        List<Role> Roles = new List<Role>();
       
        public void searchRole()
        {
            int u_id;
            Console.WriteLine("Enter id to get role");
            while (!int.TryParse(Console.ReadLine(), out u_id) || (u_id <= 0))
            {
                Console.WriteLine("Invalid id");
            }
            var erole = from Srole in Roles
                        where Srole.id == u_id
                        select Srole.name;
            foreach (var item in erole)
            {
                Console.WriteLine(item);
            }

        }
        public void oldRoles()
        {
            Roles.Add(new Role { id = 1, name = "Admin" });
            Roles.Add(new Role { id = 2, name = "General" });
            Roles.Add(new Role { id = 3, name = "ReadOnly" });
            Console.WriteLine("Old Data");
            Console.WriteLine("");
            foreach (var item in Roles)
            {
                Console.WriteLine(item.id +"    "+item.name);
            }

        }
        public void newRoles_Update( )
        {
            int u_id;
            Console.WriteLine("Enter id to udate role");
            while (!int.TryParse(Console.ReadLine(), out u_id) || (u_id <= 0))
            {
                Console.WriteLine("Invalid id");
            }
            Console.WriteLine("enter Updated role");
            string u_role = Console.ReadLine();


            for (int i = 0; i < Roles.Count; i++)
            {
                if (Roles[i].id == u_id)
                {
                    Roles[i].name =u_role ;
                }
                
            }

            Console.WriteLine("");
            Console.WriteLine("After updating Admin");
            foreach (var item in Roles)
            {
                Console.WriteLine(item.id + "    " + item.name);
            }

        }

        public void newRoles_Delete()
        {
            int u_id;
            Console.WriteLine("Enter id to delete element");
            while (!int.TryParse(Console.ReadLine(), out u_id) || (u_id <= 0))
            {
                Console.WriteLine("Invalid id");
            }
            


            for (int i = 0; i < Roles.Count; i++)
            {
                if (Roles[i].id == u_id)
                {
                    Roles.RemoveAt(i);
                }

            }

            Console.WriteLine("");
            Console.WriteLine("After Deleting");
            foreach (var item in Roles)
            {
                Console.WriteLine(item.id + "    " + item.name);
            }

        }
        public void newRoles_Insert()
        {
            int u_id;
            Console.WriteLine("Enter id to Insert");
            while (!int.TryParse(Console.ReadLine(), out u_id) || (u_id <= 0))
            {
                Console.WriteLine("Invalid id");
            }
            Console.WriteLine("enter role");
            string u_role = Console.ReadLine();

            Roles.Add(new Role() {id=u_id,name=u_role});

            Console.WriteLine("");
            Console.WriteLine("After insertg user");
            foreach (var item in Roles)
            {
                Console.WriteLine(item.id + "    " + item.name);
            }
            

        }
        static void Main(string[] args)
        {
            _2020_02_14 obj = new _2020_02_14();

            obj.oldRoles();
        //obj.newRoles_Update();
        // obj.newRoles_Delete();
        // obj.newRoles_Insert();
        // Console.WriteLine(obj.Roles.Count());
        CHOOSE:
            Console.WriteLine("\n Chose one option to \n  update      1 \n  delete      2 \n  insert      3 \n search Role  4  \n exit         5\n");
            int U_choise;

            while (!int.TryParse(Console.ReadLine(), out U_choise) || (U_choise < 0))
            {
                Console.WriteLine("Invalid id");
            }
          
            switch (U_choise)
            {
                case 1:
                    obj.newRoles_Update();
                    goto CHOOSE;
              
                case 2:
                    obj.newRoles_Delete();
                    goto CHOOSE;
                 
                case 3:
                    obj.newRoles_Insert();
                    goto CHOOSE;
                case 4:
                    obj.searchRole();
                    goto CHOOSE;
                case 5:
                  
                    break;

                default:
                    goto CHOOSE;
                   
            }

            Console.ReadKey();

      
        }
    }
    public class Role
    {
        private int E_id;
        private string E_name;

        public int id
        {
            get { return E_id; }
            set { E_id = value; }
        }

        public string name { get => E_name; set => E_name = value; }
    }

}

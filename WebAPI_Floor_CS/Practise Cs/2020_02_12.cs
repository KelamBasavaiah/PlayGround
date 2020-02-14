using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_Cs
{
   public class Program
    {
     

        string trim_String(string t_string  , int s_Length )
        {
            try
            {
                t_string = t_string.Remove(s_Length);
                return t_string;
            }
            catch (Exception e)
            {

                return "Select in the strig length range";

            }

        }
        String result()
        {
            Program  p = new Program();

            Console.WriteLine("Enter String");
            string t_string = Console.ReadLine();
            Console.WriteLine("Enter length u want");
            int s_Length;
            while (!int.TryParse(Console.ReadLine(), out s_Length) || (s_Length <= 0))
            {
                Console.WriteLine("Invalid length");
            }
            return p.trim_String(t_string, s_Length);
           
        }


        //static void Main(string[] args)
        //{
        //    Program p = new Program();
        //    Console.WriteLine(p.result());
        //    Console.Read();

        //}
    }
}

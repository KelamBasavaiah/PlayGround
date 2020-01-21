using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public void test()
        {
            //Program p = new Program();
            //p.test();
            Console.WriteLine("k");
        }
        public void test1()
        {
            int[] k;
            k = new int[4];
            int[] b = new int[4];
            int[] a = new int[2] { 1, 2 };
            var array3 = new[] { 1, 2 };
            Console.WriteLine("k");
        }
      public  static void Main(string[] args)
        {
            Program p = new Program();
            p.test();
            //p.test1();
            Console.WriteLine("k");
           
            var tc = new testClass();
            tc.kb();
           // tc.test();
            //Program.Main(args);
            string x;
            x = Console.ReadLine();

        }
    }
}

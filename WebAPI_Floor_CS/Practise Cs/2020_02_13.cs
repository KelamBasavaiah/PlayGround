using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_Cs
{
   
    public class _2020_02_13
    {
      

        public void printNotNUll()
        {
            string name = null;
            int? age = null;
            if (age.HasValue && (name.Length > 0))
            {
                Console.WriteLine(name+"is at age of"+age);
            }

        }
        public void Cond_statement()
        {
            int? name = 5;
            int? N_L = (name != null) ? name : null;
            Console.WriteLine($"The result of conditional statement is \"{N_L}\"");
        }
        public void getByValue(Student student)
        {
            //student = new Student();
            Console.WriteLine(student.id + " id is " + student.name);
            student.id += 100;
            student.name += "basuu";
            Console.WriteLine(student.id+" id is "+student.name);
        }
        public void getByRef(ref Student student)
        {
            //student = new Student();
            Console.WriteLine(student.id + " id is " + student.name);
            student.id += 100;
            student.name += "basuu";
            Console.WriteLine(student.id + " id is " + student.name);
        }



        //static void Main(string[] args)
        //{
        //    _2020_02_13 i = new _2020_02_13();

        //    //cond ? , ()? t : f

        //    i.Cond_statement();

        //    // with out ref pass a object
        //    Console.WriteLine("pass by value exaple");

        //    Student student = new Student() { id = 101, name = "basi" };
        //    Console.WriteLine(student.id+" id is "+student.name);
        //    i.getByValue(student);
        //    Console.WriteLine(student.id + " id is " + student.name);
        //    Console.WriteLine("");

        //    // with ref pass a object
        //    Console.WriteLine("pass by REf exaple");
        //    student = new Student() { id = 101, name = "basii" };
        //    Console.WriteLine(student.id + " id is " + student.name);
        //    i.getByRef(ref student);
        //    Console.WriteLine(student.id + " id is " + student.name);

        //    Console.WriteLine("");
        //    //out parameter
        //    Console.WriteLine("enter any integer");
        //    bool ip_integer = int.TryParse(Console.ReadLine(), out int age);
        //    string mess = ip_integer ? $"you enterd age is {age}" : "you did't enterd correct age";
        //    Console.WriteLine(mess);

        //    Console.Read();
        //}
    }
    public class Student
    {
        private int s_id;

        public int id
        {
            get { return s_id; }
            set { s_id = value; }
        }

        private string s_name;

        public string name
        {
            get { return s_name; }
            set { s_name = value; }
        }

    }
}

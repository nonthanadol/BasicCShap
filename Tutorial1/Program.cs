using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial.Interface;


namespace Tutorial
{
    class MainProgram
    {
        
        static void Main(string[] args)
        {
            //VarShare varShare = new VarShare();
            Person p1 = new Person();

            p1.FirstName = "John";
            p1.LastName = "Doe";
            p1.Age = 25;

            

            VarShare varShare1 = new VarShare();


            Console.WriteLine(p1.GetFullName());
            Console.WriteLine(varShare1._varShare);
            Console.WriteLine(varShare1.GetValue(1));

           // Console.WriteLine(Person.teststatic);
           // Console.WriteLine(Person.FirstName);
           



        }
    }
}

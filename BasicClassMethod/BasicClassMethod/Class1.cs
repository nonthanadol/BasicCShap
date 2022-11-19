using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClassMethod
{
    class Human //class "Human" has attributes, such as name and color, and methods such as jump and run.
    {
        string color;// variable is declared directly in a class, it is often referred to as a "attribute" .
        public string name; // "Access Modifiers" public is The code is accessible for all classes
        string sex;  
        int age;
        public void jump()
        {
            Console.WriteLine("method jump");
        }
        public void walk()
        {
            Console.WriteLine("method walk");

        }
        void run()
        {
            Console.WriteLine("method run");
        }

    }

}

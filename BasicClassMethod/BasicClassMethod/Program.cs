using System;

namespace BasicClassMethod
{
    class Program
    {
        static void Main(string[] args) // "static" means that the method belongs to the Program class and not an object of the Program class.
                                        // "void" means that this method does not have a return value
        {
            //........Array..............
            // Declare an array
            string[] cars;

            // Add values, using new
            cars = new string[] { "Volvo", "BMW", "Ford" };
            /* Add values without using new (this will cause an error)
            cars = { "Volvo", "BMW", "Ford"}; */

            Console.WriteLine("## Array ## ");
            for (int i = 0; i < cars.Length; i++) // ".Length" is To find out how many elements an array has
            {
                Console.WriteLine(cars[i]);
            }
            //...........

            //.........Method ..............
            Console.WriteLine(" ");
            Console.WriteLine("## Method ## ");
            Console.Write("enter Wide :: ");
            int W;
            int.TryParse(Console.ReadLine(),out W);//Convert String to int
            Console.Write("enter High :: ");
            int H;
            int.TryParse(Console.ReadLine(), out H);
            double AreaTriangle = CalArea(W,H); // Call method "CalArea" and send 2 arguments 
            Console.WriteLine("area is :: {0}",AreaTriangle);

            MyMethod(child3: "John", child1: "Liam", child2: "Liam"); // send arguments with the key: value syntax.
            //.............
        
            //..........Classs........
            Human p1 = new Human(); // Create Opject
                                    //Class "Program" and "Human" are same namespace
            p1.name = "nonthanadol"; // accessed attribute in class "Human"

            Console.WriteLine(" ");
            Console.WriteLine("## Class ## ");
            Console.WriteLine("p1.name :: {0}",p1.name);
            p1.jump(); // Call method "jump" in class "Human"
            // p1.run(); -> can't find method due to the method isn't " public "  accessed



        }

        static double CalArea(int w , int h)   // Method "CalArea" have 2 parameter
                                               // "double" means that this method return value type double
        {
            double area = 0.5*w*h;
            
            return area;
        }

        static void MyMethod(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is: " + child3);
        }


    }
}
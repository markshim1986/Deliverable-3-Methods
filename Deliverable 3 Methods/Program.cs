// Author: Mark Shim    
// Date: 9/18/2019
// Comments: C# Console application that demonstrates a Method

using System;

namespace Deliverable_3_Methods
{
    class Program
    {
        // Declaring my method
        public void Get_Name(string name)
        {
            Console.WriteLine("\n Hello " + name + "!");
            Console.WriteLine("\n Press any key to exit the program");
            Console.ReadKey(true);
        }
        // Calling my method by passing the arguments when the method is called
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            p.Get_Name(name);
        }
           

    }
}

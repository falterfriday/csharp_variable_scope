using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variable_scope
{
    class Program
    {
        //this is how you make a varable available to all methods of a class
        //called a "FIELD"
        static int localField = 15;

        //this is how you make a variable available to the entire application
        //add "PUBLIC" in front of the type declaration
        static public int localField2 = 20;
        
        static void Main(string[] args)
        {
            //local variable only available in this method
            int localVar = 1;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("The value of i: " + i);
                Console.WriteLine("The value of localVar: " + localVar);
                localVar++;
                localField++;
            }
            CustomMethod2();
        }

        static void CustomMethod()
        {
            //this wont work bc the variable is out of scope
            // Console.WriteLine("value of localVar: " + localVar);
        }

        static void CustomMethod2() 
        {
            Console.WriteLine("value of localField: " + localField);
        }
    }
}

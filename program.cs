// Demo 7.12.22 - Using the Console.WriteLine() method
//-----------------------------------------------------------------------------
// Demo hello world program to ensure development environment is working.
//-----------------------------------------------------------------------------


//system imports for the program
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace for the program
namespace HelloWorld
{

    // This program writes Hello World to the console.
    //create a program class
    class Program
    {
        //create a main method
        static void Main()
        {
            //write Hello World to the console using the WriteLine method
            Console.WriteLine("Hello World!");
            //pause the program until the user presses a key
            Console.ReadLine();
            //print the environment version to the console
            Console.WriteLine(Environment.Version);
            //write the full path of the executable to the console
            Console.WriteLine(Environment.GetCommandLineArgs()[0]);
            //end the program
            Environment.Exit(0);
            

        }
    }

}
using PersonModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Person bob = new Person();
            bob.FirstName = "Bob";
            bob.LastName = "Smith";
            bob.MiddleInitial = "Z.";

            Console.WriteLine(bob.FullName);

            Console.ReadLine();
        }
    }
}



//Homework: Create a class library that holds a person class.  Use that class in a console application.
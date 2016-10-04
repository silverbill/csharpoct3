using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            string howdy = "Hello World";
            Console.WriteLine(howdy);
            Console.Write("When did Columbus sail?");
            var columbus = Console.ReadLine();
            Console.WriteLine("Columbus sailed the world in: " + columbus + ".");
            Console.Write("Does Bryan have a dog? You must answer 'True or False'.");
            var myDog = Console.ReadLine();
            if  (myDog == "false")
                {
                    Console.WriteLine("It is " + myDog + " that I have a dog at home.");
                }
            else
                {
                     Console.WriteLine("It is " + myDog + " that I have a dog at home.");    
                }
            // bool myDog = false;
            Console.Write("What is today's date?");
            var userDate = Console.ReadLine();
            string date = DateTime.Today.ToShortDateString();
            Console.WriteLine("WRONG, Segundo! Today is " + date );
            float myMoney = 5.45f;
            char myChar = 'X';

            
            Console.ReadLine();
            Console.WriteLine("Columbus sailed the world in: " + columbus + ".");
            
            Console.WriteLine("Today is " + date + ".");
            Console.WriteLine("I spent $" + myMoney + " on a cheeseburger today.");
            Console.WriteLine(myChar + " marks the spot!");

            Console.ReadLine();
        }
    }
    
    internal class money
    {
    }
}

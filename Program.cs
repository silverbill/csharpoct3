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
            int columbus = 1492;
            //float myFloat = 5.45F;//
            bool myDog = false;
            string date = DateTime.Today.ToShortDateString();
            float myMoney = 5.45f;
            char myChar = 'X';

            Console.WriteLine(howdy);
            Console.ReadLine();
            Console.WriteLine("Columbus sailed the world in: " + columbus + ".");
            Console.WriteLine("It is " + myDog + " that I have a dog at home.");
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

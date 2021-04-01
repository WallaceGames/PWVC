using System;

namespace PlayingWithVariablesConsole
{
    class Program
    {
        static void Main(string[] args)
        {// Variable Decleration
            int age;
            string name;
            bool isAlive;

            //Variable Initialization
            age = 28;
            name = "Wallace";
            isAlive = true;


            Console.WriteLine($"{name} {age} is he alive: {isAlive}");
        }
    }
}

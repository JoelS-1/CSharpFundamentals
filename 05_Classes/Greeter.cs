using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    class Greeter
    {
        //1 access modifier
        //2 return type
        //3 method signature - includes method name and any parameters
        //4 body of the method - code that gets executed when the method is called

        //you can call this method, it will take in a string type variable and run the code in the body using the string type that you give the method when you call it

        public void SayHello(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }

        public void SaySomething(string speech)
        {
            Console.WriteLine(speech);
        }

        public string GetRandomGreeting()
        {
            Random randy = new Random();
            string[] greetings = new string[] { "hello", "hi", "sup", "yo", "hey" };
            int randomNumber = randy.Next(0, greetings.Length);
            string greeting = greetings[randomNumber];
            return greeting;
        }
    }
}

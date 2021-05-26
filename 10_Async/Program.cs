using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Async
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to make a meal");
            Console.ReadKey();

            Potato potato = new Potato();

            Kitchen kitchen = new Kitchen();
            potato.Peel();

            Console.WriteLine("Test");

            var fries = kitchen.FryPotatosAsync(potato);

            Console.WriteLine("Doing other stuff");

            var hamburger = kitchen.AssembleBurger();

            kitchen.ServeMeal(fries.Result, hamburger);

            Console.ReadKey();
        }
    }
}

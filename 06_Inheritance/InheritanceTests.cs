using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _06_Inheritance
{
    [TestClass]
    public class InheritanceTests
    {
        [TestMethod]
        public void PersonTests()
        {
            Person larry = new Person();
            
            larry.FirstName = "Larry";
            larry.LastName = "Bird";
            Console.WriteLine(larry.FullName);

            Customer sal = new Customer();
            sal.FirstName = "Sal";
            sal.LastName = "Vulcano";
            sal.IsPremium = true;
            Console.WriteLine(sal.FullName);
            Console.WriteLine(sal.IsPremium);

            sal.WhoAmI();

            Employee joe = new Employee(2, new DateTime(2021, 01, 01), "Joe", "Smith", "1234567890", "joeyG@gmail.com");
            Console.WriteLine(joe.Email);

            joe.WhoAmI();

            SalaryEmployee brain = new SalaryEmployee(3, 500000);
            brain.FirstName = "Brain";
            brain.LastName = "Quinn";
            Console.WriteLine(brain.FullName);

            List<Person> people = new List<Person>();
            people.Add(joe);
            people.Add(brain);
            people.Add(sal);
            people.Add(larry);

            foreach(Person person in people)
            {
                Console.WriteLine(person.FullName);
            }
        }
        
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _05_Classes
{
    [TestClass]
    public class ClassesTests
    {
        [TestMethod]
        public void VehiclePropertiesTests()
        {
            Vehicle firstVehicle = new Vehicle();
            firstVehicle.Make = "Honda";
            Console.WriteLine(firstVehicle.Make);

            firstVehicle.Model = "Accord";
            firstVehicle.Miles = 125321.4;
            firstVehicle.TypeOfVehicle = VehicleType.Car;

            Console.WriteLine(firstVehicle.Model);
            Console.WriteLine(firstVehicle.Miles);
            Console.WriteLine(firstVehicle.TypeOfVehicle);


        
        }

        [TestMethod]
        public void VehicleMethodsTests()
        {
            Vehicle secondVehicle = new Vehicle();
            secondVehicle.TurnOn();
            Console.WriteLine(secondVehicle.IsRunning);

            secondVehicle.TurnOff();
            Console.WriteLine(secondVehicle.IsRunning);


            secondVehicle.IndicateRight();
            Console.WriteLine(secondVehicle.RightIndicator);
            Console.WriteLine(secondVehicle.LeftIndicator);


            secondVehicle.TurnOnHazards();
            Console.WriteLine(secondVehicle.RightIndicator);
            Console.WriteLine(secondVehicle.LeftIndicator);

            secondVehicle.IndicateLeft();
            Console.WriteLine(secondVehicle.RightIndicator);
            Console.WriteLine(secondVehicle.LeftIndicator);

            //challenge for classes
            Indicator indicator = new Indicator();
            {
                indicator.TurnOn();
                Console.WriteLine(indicator.isFlashing);
            }

        }

        [TestMethod]
        public void GreeterMethodsTests()
        {
            Greeter greeterInstance = new Greeter();

            greeterInstance.SayHello("joel");

            List<string> students = new List<string>();
            students.Add("Hannah");
            students.Add("Joel");
            students.Add("Jay");
            students.Add("Lauren");
            students.Add("Luis");

            foreach(string student in students)
            {
                string greeting = greeterInstance.GetRandomGreeting();
                greeterInstance.SaySomething(greeting + " " + student);
            } //only grabs one single random greeting the first time, does not go through random greeting more than once each time it is run

            
            string greeting2 = greeterInstance.GetRandomGreeting();
            greeterInstance.SaySomething(greeting2); 
        }

        [TestMethod]
        public void CalculatorTests()
        {
            Calculator calculatorInstance = new Calculator();

            double sum = calculatorInstance.GetSum(3.5, 100.9);

            Console.WriteLine(sum);

            int age = calculatorInstance.CalculateAge(new DateTime(1988, 04, 11));
            Console.WriteLine(age);
        }

        //challenge for classes
        public class Indicator
        {


            public bool isFlashing { get; private set; }

            public void TurnOn()
            {
                isFlashing = true;
            }

            public void TurnOff()
            {
                isFlashing = false;
            }
        }

        [TestMethod]
        public void VehicleConstuctorTests()
        {
            Vehicle car = new Vehicle();
            car.Make = "Nissan";
            car.Model = "Skyline";
            car.Miles = 5000;
            car.TypeOfVehicle = VehicleType.Car;

            Vehicle rocket = new Vehicle("Enterprise", "Galaxy", 100000, VehicleType.Plane);
            Console.WriteLine($"I rode on a spaceship, it was the {rocket.Make}");

            rocket.Model = "Constellation";
        }

        //person class
        [TestMethod]
        public void PersonTests()
        {
            Person person = new Person("Michael", "Pabody", new DateTime(2000, 01, 31));
            Console.WriteLine(person.FullName);

            Console.WriteLine(person.Age);

            Person jake = new Person();
            jake.FirstName = "Jacob";
            jake.DateOfBirth = new DateTime(1991, 05, 04);

            Console.WriteLine(jake.FullName);
            Console.WriteLine(jake.Age);

            //
            Person andrew = new Person()
            {
                FirstName = "Andrew", LastName = "Torr", DateOfBirth = new DateTime(1950, 12, 25)
            };

            //asserting a test that these two are equal
            Assert.AreEqual("Jacob", jake.FirstName);
            //Asserting that these are not equal
            //Assert.AreNotEqual("Jacob", jake.FirstName);
        }
        
   

        Person _person = new Person("Luke", "Skywalker", new DateTime(2000, 01, 31));

        [TestMethod]
        public void PersonTransportTest()
        {
            _person.Transport = new Vehicle("X-Wing", "Starship", 1000, VehicleType.Plane);
            Console.WriteLine($"{_person.FullName} drives a {_person.Transport.Make}");

            _person.Transport.Make = "T16 Skyhopper";

            Console.WriteLine(_person.Transport.Make);

            Person blank = new Person();
            Console.WriteLine($"Unset class: {blank.Transport}");
            Console.WriteLine($"Unset struct: {blank.DateOfBirth}");
            Console.WriteLine($"Age: { blank.Age}");

            
        }

    }
}

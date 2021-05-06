using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public enum VehicleType { Car, Truck, Van, Motorcycle, Plane, Boat, Scooter}
    public class Vehicle
    {
        public Vehicle(string make, string model, double miles, VehicleType typeOfVehicle)
        {
            Make = make;
            Model = model;
            Miles = miles;
            TypeOfVehicle = typeOfVehicle;
        }

        public Vehicle() { }
 

        //1 access Modifier
        //type - type the property holds
        //3 name
        //4 getters and setters

        //1     2       3       4
        public string Make { get; set; }
        public string Model { get; set; }
        public double Miles { get; set; }
        public VehicleType TypeOfVehicle { get; set; }

        public bool IsRunning { get; private set; }

        public void TurnOn()
        {
            IsRunning = true;
            Console.WriteLine("You've turned on the vehicle");
        }

        public void TurnOff()
        {
            IsRunning = false;
            Console.WriteLine("You've turned off the vehicle");
        }

        public bool RightIndicator { get; private set; }
        public bool LeftIndicator { get; private set; }

        public void IndicateRight()
        {
            RightIndicator = true;
            LeftIndicator = false;
        }

        public void IndicateLeft()
        {
            LeftIndicator = true;
            RightIndicator = false;
        }

        public void TurnOnHazards()
        {
            LeftIndicator = true;
            RightIndicator = true;
        }

        public void TurnOffHazards()
        {
            LeftIndicator = false;
            RightIndicator = false;
        }

        //challenge - make indicator its own custom class
        //properties including IsFlashing
        //method for TurnOn() and TurnOff()

        //when you call it would look like LeftIndicator.TurnOn

        
    }
}

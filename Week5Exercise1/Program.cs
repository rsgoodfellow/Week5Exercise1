using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Week5Exercise1
{
    internal class Program
    {
        class Vehicle // Vehicle class (Parent class)
        {
            public string Make = "default make"; //declares and initializes a public string
            public string Model = "default model"; //declares and initializes a public string
            public int Year = 2000; //declares and initializes a public int
            public int MaxSpeed = 120; //declares and initializes a public int
            public void DisplayInfo() //method to display information about the vehicle
            {
                Console.WriteLine("Make: " + Make); //displays Make string
                Console.WriteLine("Model: " + Model); //displays Model string
                Console.WriteLine("Year: " + Year); //displays year int
                Console.WriteLine("Max Speed: " + MaxSpeed); //displays the max speed
            }
        }

        class Car : Vehicle //Car class that inherits from the Vehicle class (child of parent class)
        {
            int NumberOfDoors = 4; //declares and initializes door int
            public new void DisplayInfo() //method to display information about the car
            {
                Console.WriteLine("Make: " + Make); //displays Make string
                Console.WriteLine("Model: " + Model); //displays Model string
                Console.WriteLine("Year: " + Year); //displays year int
                Console.WriteLine("Max Speed: " + MaxSpeed); //displays the max speed
                Console.WriteLine("Number of Doors: " + NumberOfDoors); //displays the number of doors
            }
        }

        class Motorcycle : Vehicle
        {
            bool HasSidecar = false; //declares and initalizes boolean variable
            public new void DisplayInfo() //method to display information about the motorcycle
            {
                Console.WriteLine("Make: " + Make); //displays Make string
                Console.WriteLine("Model: " + Model); //displays Model string
                Console.WriteLine("Year: " + Year); //displays year int
                Console.WriteLine("Max Speed: " + MaxSpeed); //displays the max speed
                Console.WriteLine("has sidecar: " + HasSidecar); //displays if the motorcycle has a sidecar or not
            }
        }
        static void Main(string[] args) //main method
        {
            Car car = new Car(); //creates new car object
            Motorcycle motorcycle = new Motorcycle(); //creates new motorcycle object
            car.DisplayInfo(); //calls method to display info about the car
            Console.WriteLine(); //prints a blank line
            motorcycle.DisplayInfo(); //calls method to display info about the motorcycle

            Console.Read(); //lets the user read the program
        }
    }
}

using System;

namespace InheritanceTestApp
{

    class Vehicle  // Base class(Parent Class)
    {
        public string brand = "Ford";  // Vehicle field
        public void honk()             // Vehicle method 
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }
    class Car : Vehicle  // Derived class(Child class)
    {
        public string modelName = "Mustang";  // Car field
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Create a myCar object
            Car myCar = new Car();

            // Call the honk() method (From the Vehicle class) on the myCar object
            myCar.honk();

            // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
            Console.WriteLine(myCar.brand + " " + myCar.modelName);
            Console.ReadLine();
        }
    }
}


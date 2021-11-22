using System;
using CarInspectionApp.Component;
using CarInspectionApp.ConcreteComponent;
using CarInspectionApp.ConcreteDecorator;

namespace CarInspectionApp
{
    class Program
    {
        static void Main()
        {
            ICarService car = new OilChange(new TyreRotation(new CarInspection()));

            Console.WriteLine(car.GetDetails());
            Console.WriteLine("Total Cost : "+car.GetCost());
            Console.ReadKey();
        }
    }
}

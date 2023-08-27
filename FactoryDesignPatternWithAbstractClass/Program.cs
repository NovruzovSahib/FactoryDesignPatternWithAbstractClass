using FactoryDesignPatternWithAbstractClass.AbstractClasses;
using FactoryDesignPatternWithAbstractClass.Classes;
using FactoryDesignPatternWithAbstractClass.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPatternWithAbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory carfactory = new CarFactory();
            IVehicle car = carfactory.CreateVehicle();
            car.Move();
            car.Stop();


            VehicleFactory motorcyclefactory = new MotorcycleFactory();
            IVehicle motorcycle = motorcyclefactory.CreateVehicle();
            motorcycle.Move();
            motorcycle.Stop();


            Console.ReadLine();
        }
    }
}

using FactoryDesignPatternWithAbstractClass.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPatternWithAbstractClass.Classes
{
    internal class Car : IVehicle
    {
        public void Move()
        {
            Console.WriteLine("Car is moved");
        }
        public void Stop()
        {
            Console.WriteLine("Car is stopped");
        }
    }
}

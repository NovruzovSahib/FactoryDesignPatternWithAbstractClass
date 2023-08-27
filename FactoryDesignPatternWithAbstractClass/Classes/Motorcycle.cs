using FactoryDesignPatternWithAbstractClass.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPatternWithAbstractClass.Classes
{
    internal class Motorcycle : IVehicle
    {
        public void Move()
        {
            Console.WriteLine("Motorcycle is moved");
        }
        public void Stop()
        {
            Console.WriteLine("Motorcycle is stopped");
        }
    }
}

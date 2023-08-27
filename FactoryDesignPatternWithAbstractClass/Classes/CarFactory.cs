using FactoryDesignPatternWithAbstractClass.AbstractClasses;
using FactoryDesignPatternWithAbstractClass.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPatternWithAbstractClass.Classes
{
    internal class CarFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
            return new Car();
        }
    }
}

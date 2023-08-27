using FactoryDesignPatternWithAbstractClass.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPatternWithAbstractClass.AbstractClasses
{
    abstract class VehicleFactory
    {
        public abstract IVehicle CreateVehicle();
    }
}

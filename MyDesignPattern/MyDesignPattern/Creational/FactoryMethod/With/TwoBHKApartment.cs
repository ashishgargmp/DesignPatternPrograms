using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDesignPattern.Creational.FactoryMethod.With
{
    public class TwoBHKApartment: ApartmentWithFactMthd
    {
        protected override string PrintApartment()
        {
            return "You've selected 2BHK apartment!";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDesignPattern.Creational.SimpleFactory.With
{
    public class TwoBHKApartment: ApartmentWithSimpleFact
    {
        protected override string PrintApartment()
        {
            return "You've selected 2BHK apartment!";
        }
    }
}

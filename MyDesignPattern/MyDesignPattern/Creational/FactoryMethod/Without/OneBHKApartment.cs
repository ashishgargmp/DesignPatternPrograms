using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDesignPattern.Creational.FactoryMethod.Without
{
    public class OneBHKApartment: ApartmentWithoutFactMthd
    {
        protected override string PrintApartment()
        {
            return "You've selected 1BHK apartment!";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDesignPattern.Creational.FactoryMethod.Enums;

namespace MyDesignPattern.Creational.FactoryMethod.Without
{
    public class ClientWithoutFactMthd
    {
        private ApartmentWithoutFactMthd aprtmntObj;

        public ClientWithoutFactMthd(ApartmentType type)
        {
            if (type == ApartmentType.OneBHK)
            {
                aprtmntObj = new OneBHKApartment();
            }
            else if (type == ApartmentType.TwoBHK)
            {
                aprtmntObj = new TwoBHKApartment();
            }
            else
                aprtmntObj = null;
        }
    }
}

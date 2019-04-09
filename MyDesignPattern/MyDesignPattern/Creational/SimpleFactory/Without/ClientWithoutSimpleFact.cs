using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDesignPattern.Creational.SimpleFactory.Enums;

namespace MyDesignPattern.Creational.SimpleFactory.Without
{
    public class ClientWithoutSimpleFact
    {
        private ApartmentWithoutSimpleFact aprtmntObj;

        public ClientWithoutSimpleFact(ApartmentType type)
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

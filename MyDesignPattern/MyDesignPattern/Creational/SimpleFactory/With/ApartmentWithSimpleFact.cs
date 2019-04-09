using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDesignPattern.Creational.SimpleFactory.Enums;

namespace MyDesignPattern.Creational.SimpleFactory.With
{
    public abstract class ApartmentWithSimpleFact
    {
        protected abstract string PrintApartment();

        public ApartmentWithSimpleFact Create(ApartmentType type)
        {
            ApartmentWithSimpleFact aprtmntObj;

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

            return aprtmntObj;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDesignPattern.Creational.FactoryMethod.Enums;

namespace MyDesignPattern.Creational.FactoryMethod.With
{
    public abstract class ApartmentWithFactMthd
    {
        protected abstract string PrintApartment();

        public ApartmentWithFactMthd Create(ApartmentType type)
        {
            ApartmentWithFactMthd aprtmntObj;

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDesignPattern.Creational.FactoryMethod.Enums;

namespace MyDesignPattern.Creational.FactoryMethod.With
{
    public class ClientWithFactMthd
    {
        private ApartmentWithFactMthd aprtmntObj;

        public ClientWithFactMthd(ApartmentType type)
        {
            aprtmntObj.Create(type);
        }
    }
}

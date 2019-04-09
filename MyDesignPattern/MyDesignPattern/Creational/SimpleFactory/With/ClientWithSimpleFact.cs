using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDesignPattern.Creational.SimpleFactory.Enums;

namespace MyDesignPattern.Creational.SimpleFactory.With
{
    public class ClientWithSimpleFact
    {
        private ApartmentWithSimpleFact aprtmntObj;

        public ClientWithSimpleFact(ApartmentType type)
        {
            aprtmntObj.Create(type);
        }
    }
}

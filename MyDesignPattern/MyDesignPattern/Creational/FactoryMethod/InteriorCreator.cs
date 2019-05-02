using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDesignPattern.Creational.FactoryMethod.Enums;

namespace MyDesignPattern.Creational.FactoryMethod
{
    public abstract class InteriorCreator
    {
        public abstract IInteriorProduct CreateInterior();
    }

    public class ABCInteriorCreator : InteriorCreator
    {
        public override IInteriorProduct CreateInterior()
        {
            return new ABCInterior();
        }
    }

    public class XYZInteriorCreator: InteriorCreator
    {
        public override IInteriorProduct CreateInterior()
        {
            return new XYZInterior();
        }
    }
}

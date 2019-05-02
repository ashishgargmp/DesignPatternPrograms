using MyDesignPattern.Creational.AbstractFactory.WidgetFactory.CreatorClasses;
using MyDesignPattern.Creational.AbstractFactory.WidgetFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDesignPattern.Creational.AbstractFactory.WidgetFactory
{
    public class AbstractFactoryAgent
    {
        private IWidgetFactory factoryObj;

        public AbstractFactoryAgent(WidgetCreatorName creator)
        {
            switch (creator)
            {
                case WidgetCreatorName.Apple:
                    factoryObj = new AppleWidgetFactory();
                    break;
                case WidgetCreatorName.Google:
                    factoryObj = new GoogleWidgetFactory();
                    break;
                case WidgetCreatorName.Microsoft:
                    factoryObj = new MicrosoftWidgetFactory();
                    break;
                default:
                    factoryObj = new AppleWidgetFactory();
                    break;
            }
        }

        public IWidgetFactory GetFactoryObject()
        {
            return factoryObj;
        }
    }
}

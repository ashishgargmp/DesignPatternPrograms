using MyDesignPattern.Creational.AbstractFactory.WidgetFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDesignPattern.Creational.AbstractFactory.WidgetFactory.ProductClasses.Button
{
    public class MicrosoftButton : IButton
    {
        public string GetName()
        {
            return "This is Microsoft's button!";
        }
    }
}

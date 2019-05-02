using MyDesignPattern.Creational.AbstractFactory.WidgetFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDesignPattern.Creational.AbstractFactory.WidgetFactory.ProductClasses.Toolbar
{
    public class AppleToolbar : IToolbar
    {
        public string GetName()
        {
            return "This is Apple's Toolbar!";
        }
    }
}

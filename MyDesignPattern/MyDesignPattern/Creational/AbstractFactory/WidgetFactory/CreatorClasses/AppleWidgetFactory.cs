using MyDesignPattern.Creational.AbstractFactory.WidgetFactory.Interfaces;
using MyDesignPattern.Creational.AbstractFactory.WidgetFactory.ProductClasses.Button;
using MyDesignPattern.Creational.AbstractFactory.WidgetFactory.ProductClasses.Scrollbar;
using MyDesignPattern.Creational.AbstractFactory.WidgetFactory.ProductClasses.Toolbar;
using MyDesignPattern.Creational.AbstractFactory.WidgetFactory.ProductClasses.Window;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDesignPattern.Creational.AbstractFactory.WidgetFactory.CreatorClasses
{
    public class AppleWidgetFactory : IWidgetFactory
    {
        public IButton CreateButtons()
        {
            return new AppleButton();
        }

        public IScrollbar CreateScrollBar()
        {
            return new AppleScrollbar();
        }

        public IToolbar CreateToolBar()
        {
            return new AppleToolbar();
        }

        public IWindow CreateWindow()
        {
            return new AppleWindow();
        }
    }
}

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
    public class MicrosoftWidgetFactory: IWidgetFactory
    {
        public IButton CreateButtons()
        {
            return new MicrosoftButton();
        }

        public IScrollbar CreateScrollBar()
        {
            return new MicrosoftScrollbar();
        }

        public IToolbar CreateToolBar()
        {
            return new MicrosoftToolbar();
        }

        public IWindow CreateWindow()
        {
            return new MicrosoftWindow();
        }
    }
}

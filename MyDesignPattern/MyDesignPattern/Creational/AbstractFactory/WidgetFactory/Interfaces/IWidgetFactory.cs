using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDesignPattern.Creational.AbstractFactory.WidgetFactory.Interfaces
{
    public interface IWidgetFactory
    {
        IScrollbar CreateScrollBar();
        IWindow CreateWindow();
        IButton CreateButtons();
        IToolbar CreateToolBar();
    }
}

using MyDesignPattern.Creational.AbstractFactory.WidgetFactory;
using MyDesignPattern.Creational.AbstractFactory.WidgetFactory.Interfaces;
using MyDesignPattern.Creational.FactoryMethod;
using MyDesignPattern.Creational.FactoryMethod.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDesignPattern
{
    class Program
    {
        private static TestDifferentDesignPatterns objTestDesignPatterns;
        static void Main(string[] args)
        {
            // Test Factory method pattern
            //objTestDesignPatterns = new TestDifferentDesignPatterns();
            //objTestDesignPatterns.FactoryMethodClient();

            // Test Abstract factory design pattern
            WidgetClient widgetClientObj = new WidgetClient(WidgetCreatorName.Apple);
            Console.WriteLine("---------------APPLE Widgets-------------");
            Console.WriteLine(widgetClientObj.Button.GetName());
            Console.WriteLine(widgetClientObj.Scrollbar.GetName());
            Console.WriteLine(widgetClientObj.Toolbar.GetName());
            Console.WriteLine(widgetClientObj.Window.GetName());
            Console.WriteLine();

            Console.WriteLine("---------------Microsoft Widgets-------------");
            widgetClientObj = new WidgetClient(WidgetCreatorName.Microsoft);
            Console.WriteLine(widgetClientObj.Button.GetName());
            Console.WriteLine(widgetClientObj.Scrollbar.GetName());
            Console.WriteLine(widgetClientObj.Toolbar.GetName());
            Console.WriteLine(widgetClientObj.Window.GetName());
            Console.WriteLine();

            widgetClientObj = new WidgetClient(WidgetCreatorName.Google);
            Console.WriteLine("---------------Google Widgets-------------");
            Console.WriteLine(widgetClientObj.Button.GetName());
            Console.WriteLine(widgetClientObj.Scrollbar.GetName());
            Console.WriteLine(widgetClientObj.Toolbar.GetName());
            Console.WriteLine(widgetClientObj.Window.GetName());

            Console.ReadKey();
        }
    }

    public class WidgetClient
    {
        private IWidgetFactory widgetFactoryObj;  
        private IWindow windowObj;
        private IScrollbar scrollbarObj;
        private IToolbar toolbarObj;
        private IButton btnObj;

        public WidgetClient(WidgetCreatorName widgetCreaterName)
        {
            AbstractFactoryAgent objAbstractFactoryAgent = new AbstractFactoryAgent(widgetCreaterName);
            widgetFactoryObj = objAbstractFactoryAgent.GetFactoryObject();
            Window = widgetFactoryObj.CreateWindow();
            Scrollbar = widgetFactoryObj.CreateScrollBar();
            Toolbar = widgetFactoryObj.CreateToolBar();
            Button = widgetFactoryObj.CreateButtons();
        }

        public IWindow Window
        {
            get => windowObj;
            set => windowObj = value;
        }

        public IScrollbar Scrollbar
        {
            get => scrollbarObj;
            set => scrollbarObj = value;
        }

        public IToolbar Toolbar
        {
            get => toolbarObj;
            set => toolbarObj = value;
        }

        public IButton Button
        {
            get => btnObj;
            set => btnObj = value;
        }
    }
       

    public class TestDifferentDesignPatterns
    {
        public void FactoryMethodClient()
        {
            //Console.WriteLine("Below are the multiple factories available who creates Dining Halls:");
            //Console.WriteLine("S.No.    Factory Name    Factory Code");
            //Console.WriteLine("1        ABC             0");
            //Console.WriteLine("1        XYZ             1");
            //Console.WriteLine("Which Interior Factory you want to create Dinning Hall for you? -- Type the code here");

            //Console.WriteLine(Console.Read());

            //int factType = InteriorFactoryType.ABC.GetHashCode();
            //Console.WriteLine(factType.ToString());

            // Use ABCInteriorFactory
            InteriorCreator objInteriorCreator = new ABCInteriorCreator();
            IInteriorProduct interiorObj = objInteriorCreator.CreateInterior();
            Console.WriteLine(interiorObj.MakeDiningHall());
            Console.ReadKey();

            // Use XYZInteriorFactory
            objInteriorCreator = new XYZInteriorCreator();
            interiorObj = objInteriorCreator.CreateInterior();
            Console.WriteLine(interiorObj.MakeDiningHall());
            Console.ReadKey();
        }
    }
        

}
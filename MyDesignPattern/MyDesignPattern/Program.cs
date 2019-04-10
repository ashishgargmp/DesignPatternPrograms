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
            objTestDesignPatterns = new TestDifferentDesignPatterns();

            // Test Factory method pattern
            objTestDesignPatterns.FactoryMethodClient();
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
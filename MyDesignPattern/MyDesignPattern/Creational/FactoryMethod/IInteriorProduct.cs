using System;

namespace MyDesignPattern.Creational.FactoryMethod
{
    public interface IInteriorProduct
    {
        string MakeMasterBR();
        string MakeDiningHall();
        string MakeKitchen();
        string MakeStudyRoom();
    }

    public class ABCInterior : IInteriorProduct
    {
        public string MakeDiningHall()
        {
            return "Dining Hall made by ABC Interior";
        }

        public string MakeKitchen()
        {
            return "Kitchen made by ABC Interior";
        }

        public string MakeMasterBR()
        {
            return "Master BR made by ABC Interior";
        }

        public string MakeStudyRoom()
        {
            return "Study room made by ABC Interior";
        }
    }

    public class XYZInterior : IInteriorProduct
    {
        public string MakeDiningHall()
        {
            return "Dining Hall made by XYZ Interior";
        }

        public string MakeKitchen()
        {
            return "Kitchen made by XYZ Interior";
        }

        public string MakeMasterBR()
        {
            return "Master BR made by XYZ Interior";
        }

        public string MakeStudyRoom()
        {
            return "Study room made by XYZ Interior";
        }
    }
}
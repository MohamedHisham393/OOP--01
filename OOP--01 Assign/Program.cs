using System.Globalization;

namespace OOP__01_Assign_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part 01 : Theoretical Questions

            //Q1
            // a) nothing happens to the original value because they will be two blocks in stack 
            // b) changes in copied variable will appear in the original because they refer to the same addres in heap

            //============================================================

            //Q2
            // a) 1- No validation on weight so if the user make weight = -10 it willnot prevent this
            //    2- user can reach fields and modify on it using shipment.DeliveryFee
            //    3- 

            // b) using propeties --> (set) and make validation 

            //---------------------------------------------------------------------------------------------------

            //Part 02 : Practical

            DeliveryAddress DA = new DeliveryAddress("Maadi", "Elnasr", 44);

            //string address = DA.GetFullAddress();
            //Console.WriteLine(address);

            //DeliveryAddress DA02 = DA;
            //DA02.City = "Dokki";
            //DA02.Street = "kkk";
            //DA02.BuildingNumber = 50;

            //Console.WriteLine(DA.GetFullAddress());
            //Console.WriteLine(DA02.GetFullAddress());


            //Shipment ship01 = new Shipment("3322", "book", 50,1000, DA);

            //ship01.PrintShipment();

            //======================================================

            DeliveryCenter center = new DeliveryCenter();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter  Shipment {i + 1} Data");

                Console.Write("Enter Tracking Code: ");
                string trackingCode = Console.ReadLine();

                Console.Write("Enter Description: ");
                string description = Console.ReadLine();

                Console.Write("Enter Weight: ");
                double weight = double.Parse(Console.ReadLine());

                Console.Write("Enter Delivery Fee: ");
                double deliveryFee = double.Parse(Console.ReadLine());

                Console.Write("Enter City: ");
                string city = Console.ReadLine();

                Console.Write("Enter Street: ");
                string street = Console.ReadLine();

                Console.Write("Enter Building Number: ");
                int buildingNumber = int.Parse(Console.ReadLine());

                DeliveryAddress deliveryAddress = new DeliveryAddress(city, street, buildingNumber);
                Shipment shipment = new Shipment(trackingCode, description, weight, deliveryFee, deliveryAddress);

                center.AddShipment(shipment);

                Console.WriteLine("Shipment added successfully \n \n");
            }

            Console.WriteLine("------All Shipments-------");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"--- Shipment {i + 1} ---");
                center[i].PrintShipment();

                Console.WriteLine("\n");
            }


            Console.WriteLine("Enter a tracking code to search: ");
            string searchCode = Console.ReadLine();

            Shipment found = center[searchCode];

            if (found.TrackingCode == null)
            {
                Console.WriteLine("Shipment not found. ");
            }
            else
            {
                Console.WriteLine($"Shipment found: {found.TrackingCode} - {found.Description}");
            }


            DeliveryAddress newAddress = new DeliveryAddress("Maadi", "Elnasr", 44);

            DeliveryAddress copiedAdress = newAddress;

            Console.WriteLine("Before Changing ");
            Console.WriteLine(newAddress.GetFullAddress());
            Console.WriteLine(copiedAdress.GetFullAddress());

            copiedAdress.City = "Dokki";
            copiedAdress.Street = "Ahmed";
            copiedAdress.BuildingNumber = 50;


            Console.WriteLine("After Changing ");
            Console.WriteLine(newAddress.GetFullAddress());
            Console.WriteLine(copiedAdress.GetFullAddress());


        }
    }
}

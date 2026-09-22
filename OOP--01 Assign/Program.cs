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

            string address = DA.GetFullAddress();
            //Console.WriteLine(address);

            DeliveryAddress DA02 = DA;
            DA02.City = "Dokki";
            DA02.Street = "kkk";
            DA02.BuildingNumber = 50;

            Console.WriteLine(DA.GetFullAddress());
            Console.WriteLine(DA02.GetFullAddress());
        }
    }
}

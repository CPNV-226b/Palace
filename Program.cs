using Park;

namespace Palace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParkingLot parkingLot = new ParkingLot();
            Vehicle vehicle = new Vehicle();
            
            Console.WriteLine("Welcome to my Palace !");

            Console.WriteLine("Start of sequence : Regular Park");

            parkingLot.Park(vehicle);

            Console.WriteLine("End of sequence : Regular Park");
        }
    }
}
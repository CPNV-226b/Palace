using System.ComponentModel;

namespace Park
{
    public class ParkingLot
    {
        private List<Vehicle> _parkedVehicles = new List<Vehicle>();
        private List<Valet> _valets = new List<Valet>();
        public void Park(Vehicle vehicleToPark)
        {
            Console.WriteLine($"Step 1 : [{GetType().Name}] will park the vehicle");

            int size = vehicleToPark.Size;

            if (!IsAlreadyParked(vehicleToPark))
            {
                Valet valet = ChooseValet();
                valet.Drive(vehicleToPark);
                Console.WriteLine($"Step 1.5 : [{GetType().Name}] put vehicle into parkedVehicle");
            }
        }

        private bool IsAlreadyParked(Vehicle vehicleToFind)
        {
            Console.WriteLine($"Step 1.2 : [{GetType().Name}] vehicle already parked ?");
            foreach (Vehicle currentVehicle in _parkedVehicles) 
            {
                if(currentVehicle == vehicleToFind)
                {
                    return true;
                }
            }
            return false;
        }

        private Valet ChooseValet()
        {
            Console.WriteLine($"Step 1.3 : [{GetType().Name}] ChooseValet");
            return new Valet();
        }

        private void Add(Vehicle vehicleToPark)
        {
            this._parkedVehicles.Add(vehicleToPark);
        }
    }
}

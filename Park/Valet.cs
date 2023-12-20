namespace Park
{
    public class Valet
    {
        private bool _available = true;

        public void Drive(Vehicle vehicleToPark)
        {
            if(this.Available)
            {
                vehicleToPark.TurnOn();
                vehicleToPark.TurnOff();
            }
        }

        private bool Available
        {
            get
            {
                Console.WriteLine($"Step 1.4.1 : [{GetType().Name}] Available");
                return _available;
            }
        }
    }
}

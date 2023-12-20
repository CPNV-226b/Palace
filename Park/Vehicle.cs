namespace Park
{
    public class Vehicle
    {
        private int _size;
        public int Size
        {
            get
            {
                Console.WriteLine($"Step 1.1 : [{GetType().Name}] size");
                return _size;
            }
        }

        public void TurnOn()
        {
            Console.WriteLine($"Step 1.4.2 : [{GetType().Name}] TurnOn");
        }

        public void TurnOff()
        {
            Console.WriteLine($"Step 1.4.3 : [{GetType().Name}] TurnOff");
        }
    }
}

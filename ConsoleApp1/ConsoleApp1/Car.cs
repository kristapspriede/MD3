namespace ConsoleApp1
{
    public class Car
    {
        public string Brand { get; set; }
        public string PlateNumber { get; set; }
        public int MaxSpeed { get; set; }

        public string Start()
        {
            return "Start ride";
        }

        public string SpeedUp()
        {
            return "Increasing Speed";
        }

        public string Stop()
        {
            return "Stop ride";
        }

        public string Beep()
        {
            return "Beep-beep!";
        }
    }
}

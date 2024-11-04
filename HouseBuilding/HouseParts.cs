using HouseBuilding;
using Interfaces;

namespace HouseParts
{
    public class Wall : IPart
    {
        public string Name => "Wall"; 

        private static int counter = 0; 
        public int Counter 
        {
            get => counter;
            set => counter = value; 
        }
    }
    public class Basement : IPart
    {
        public string Name => "Basement";

        private static int counter = 0;
        public int Counter
        {
            get => counter;
            set => counter = value;
        }
    }

    public class Window : IPart
    {
        private static int counter = 0;
        public int Counter
        {
            get => counter;
            set => counter = value;
        }

        public string Name => "Window";
        
    }

    public class Door : IPart
    {
        private static int counter = 0;
        public int Counter
        {
            get => counter;
            set => counter = value;
        }
        public string Name => "Door";

    }

    public class Part : IPart
    {
        private static int counter = 0;
        public int Counter
        {
            get => counter;
            set => counter = value;
        }
        public string Name => "Part";
    }

    public class PartChecker
    {
        public IPart GetAvailablePart()
        {
            if (new Basement().Counter == 0)
                return new Basement();
            if (new Wall().Counter < 4)
                return new Wall();
            if (new Part().Counter == 0)
                return new Part();
            if (new Window().Counter <4)
                return new Window();
            if (new Door().Counter == 0)
                return new Door();

            return null; 
        }

        public double PercentReport()
        {
            double totalParts = 11;
            double completedParts = (new Basement().Counter + new Wall().Counter + new Part().Counter + new Window().Counter + new Door().Counter);
            double percent = (completedParts / totalParts) * 100;

            Console.WriteLine("Percent of work that's already done: {0:F2}%", percent);

            return percent;
        }
    }

}

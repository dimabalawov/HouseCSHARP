using HouseBuilding;
using HouseParts;
using Interfaces;

namespace WorkerClasses
{
    public class Worker : IWorker
    {
        private readonly PartChecker _partChecker;

        public Worker(PartChecker partChecker)
        {
            _partChecker = partChecker;
        }

        public virtual IPart Work(House house)
        {
            IPart part = _partChecker.GetAvailablePart();

            if (part == null)
            {
                Console.WriteLine("House-building is over");
                return null;
            }

            part.Counter++; 
            return part;
        }
    }

    public class TeamLeader
    {
        private readonly PartChecker _partChecker;

        public TeamLeader(PartChecker partChecker)
        {
            _partChecker = partChecker;
        }

        public void MakeReport(IPart part)
        {
            if (part == null)
            {
                Console.WriteLine("No part available to report.");
                return;
            }

            Console.WriteLine("{0} has been built for the house", part.Name);
            _partChecker.PercentReport();
        }

        public static void DrawHouse()
        {
            Console.WriteLine("    /\\   ");
            Console.WriteLine("   /__\\   ");
            Console.WriteLine("  /____\\  ");
            Console.WriteLine(" /______\\ ");
            Console.WriteLine("/________\\ ");
            Console.WriteLine("|________|");
            Console.WriteLine("|________|");
            Console.WriteLine("|________|");
            Console.WriteLine("|________|");
            Console.WriteLine("|________|");
        }
    }
}

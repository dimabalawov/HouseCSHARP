using HouseBuilding;
using HouseParts;
using Interfaces;

namespace WorkerClasses
{
    public class Team
    {
        private Worker[] arr;
        private TeamLeader tl;
        protected House house;
        public Team(Worker[] arr, TeamLeader tl,House house)
        {
            this.arr = arr;
            this.tl = tl;
            this.house = house;
        }

        public void Build()
        {
            Console.WriteLine("House-building has started");
            do
            {
                foreach (var worker in arr)
                {
                    IPart part = worker.Work(house);
                    tl.MakeReport(part);
                }

            } while (new PartChecker().PercentReport() < 100);

            Console.WriteLine("House-building has completed.");

            tl.DrawHouse();
        }
    }
}

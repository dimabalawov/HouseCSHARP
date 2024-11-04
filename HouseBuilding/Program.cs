using HouseBuilding;
using WorkerClasses;

House house = new House();

Worker worker = new Worker();
Worker worker2 = new Worker();
Worker worker3 = new Worker();

TeamLeader tl = new TeamLeader();

Team team = new Team(new[] { worker, worker2, worker3 }, tl,house);
team.Build();



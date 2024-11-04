namespace Interfaces
{
    public interface IWorker
    {
        IPart Work(object obj);
    }

    public interface IPart
    {
        string Name { get; }
        int Counter { get; set; } 
    }
}
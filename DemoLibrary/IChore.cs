namespace DemoLibrary
{
    public interface IChore
    {
        string ChoreName { get; set; }
        double HoursWorked { get; }
        bool IsComplete { get; }
        IPerson Owner { get; set; }

        void CompleteWork();
        void PerformedWork(double hours);
    }
}
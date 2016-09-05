namespace CommandPatternExample
{
    public interface ICommand
    {
        string Name { get; }
        void Execute();
    }
}
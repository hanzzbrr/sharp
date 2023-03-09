public class Program
{
    public static void Main()
    {
        Receiver receiver = new Receiver();
        ConcreteCommand command1 = new ConcreteCommand(receiver);
        Invoker invoker = new Invoker();
        invoker.SetCommand(command1);
        invoker.Run();
    }
}

abstract class Command
{
    public abstract void Execute();
    public abstract void Undo();
}

class ConcreteCommand : Command
{
    Receiver receiver;

    public ConcreteCommand(Receiver receiver)
    {
        this.receiver = receiver;
    }

    public override void Execute()
    {
        receiver.Operation();
    }

    public override void Undo()
    {
        // some undo operation here...
        throw new NotImplementedException();
    }
}

class Receiver
{
    public Receiver()
    {

    }
    public void Operation()
    {
        System.Console.WriteLine("Some receiver operation here!!!");
    }
}

class Invoker
{
    Command command;

    public Invoker()
    {

    }

    public void SetCommand(Command command)
    {
        this.command = command;
    }

    public void Run()
    {
        command.Execute();
    }

    public void Cancel()
    {
        command.Undo();
    }
}


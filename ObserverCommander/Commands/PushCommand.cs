using Hometask.Interfaces;

namespace Hometask.Commands;

public class PushCommand : INotificationCommand
{
    public void Execute(string message)
    {
        Console.WriteLine($"[PUSH] {message}");
    }
}
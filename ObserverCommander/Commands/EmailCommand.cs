using Hometask.Interfaces;

namespace Hometask.Commands;

public class EmailCommand : INotificationCommand
{
    public void Execute(string message)
    {
        Console.WriteLine($"[Email] {message}");
    }
}
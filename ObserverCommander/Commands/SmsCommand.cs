using Hometask.Interfaces;

namespace Hometask.Commands;

public class SmsCommand : INotificationCommand
{
    public void Execute(string message)
    {
        Console.WriteLine($"[SMS] {message}");
    }
}
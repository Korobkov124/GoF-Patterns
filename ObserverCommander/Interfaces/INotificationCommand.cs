namespace Hometask.Interfaces;

public interface INotificationCommand
{
    void Execute(string message);
}
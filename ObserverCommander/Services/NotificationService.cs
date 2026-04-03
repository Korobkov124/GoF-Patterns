using Hometask.Commands;
using Hometask.Interfaces;

namespace Hometask.Services;

public class  NotificationService : IOrderObserver
{
    private readonly List<INotificationCommand> _commands;
    
    public NotificationService()
    {
        _commands = new List<INotificationCommand>
        {
            new EmailCommand(),
            new SmsCommand(),
            new PushCommand()
        };
    }

    public void Update(string orderId, string newStatus)
    {
        var message = $"Заказ {orderId} сменил статус на {newStatus}";
        
        foreach (var command in _commands)
        {
            command.Execute(message);
        }
    }
}
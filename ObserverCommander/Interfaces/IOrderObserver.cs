namespace Hometask.Interfaces;

public interface IOrderObserver
{
    void Update(string orderId, string newStatus);
}
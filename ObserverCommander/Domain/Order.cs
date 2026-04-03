using Hometask.Interfaces;

namespace Hometask.Domain;

public class Order
{
    public string Id { get; set; }
    public string Status { get; set; }
    
    private readonly List<IOrderObserver> _observers = new List<IOrderObserver>();
    
    public Order()
    {
        Id = Guid.NewGuid().ToString();
        Status = "Created";
    }
    
    public void Attach(IOrderObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IOrderObserver observer)
    {
        _observers.Remove(observer);
    }

    public void SetStatus(string newStatus)
    {
        Status = newStatus;
        Notify();
    }
    
    private void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update(Id, Status);
        }
    }
}
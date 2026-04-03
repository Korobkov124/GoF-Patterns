using ChainOfResponsibility.Domain;

namespace ChainOfResponsibility.Handler;

public class EventProcessingHandler : Handler
{
    public override void Handle(RequestContext context)
    {
        Console.WriteLine($"[Success] processing complete");
    }
}
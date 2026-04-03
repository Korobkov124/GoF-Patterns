using ChainOfResponsibility.Domain;

namespace ChainOfResponsibility.Handler;

public class LoggingHandler : Handler
{
    public override void Handle(RequestContext context)
    {
        Console.WriteLine($"[Log] Request {context.Data}");
        base.Handle(context);
    }
}
using ChainOfResponsibility.Domain;

namespace ChainOfResponsibility.Handler;

public class ValidationHandler : Handler
{
    public override void Handle(RequestContext context)
    {
        if (string.IsNullOrEmpty(context.Data))
        {
            Console.WriteLine("[Error] Request is invalid");
            return;
        }
        
        context.IsValid = true;
        Console.WriteLine("[Success] Request is valid");
        base.Handle(context);
    }
}
using ChainOfResponsibility.Domain;

namespace ChainOfResponsibility.Handler;

public class AuthentificationHandler : Handler
{
    public override void Handle(RequestContext context)
    {
        if (string.IsNullOrEmpty(context.UserToken))
        {
            Console.WriteLine("[Error] UserToken is empty]");
            return;
        }
        context.IsAuthenticated = true;
        Console.WriteLine($"[Success] User: {context.UserToken}");
        base.Handle(context);
    }
}
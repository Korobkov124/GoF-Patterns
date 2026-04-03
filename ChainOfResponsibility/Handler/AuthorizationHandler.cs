using ChainOfResponsibility.Domain;

namespace ChainOfResponsibility.Handler;

public class AuthorizationHandler : Handler
{
    public override void Handle(RequestContext context)
    {
        if (context.Role != "Admin" && context.Role != "User")
        {
            Console.WriteLine("[Error] User is not authorized");
            return;
        }
        
        context.IsAuthorized = true;
        Console.WriteLine("[Success] User is authorized");
        base.Handle(context);
    }
}
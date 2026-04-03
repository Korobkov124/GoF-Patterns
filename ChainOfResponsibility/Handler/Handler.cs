using ChainOfResponsibility.Domain;

namespace ChainOfResponsibility.Handler;

public abstract class Handler
{
    protected Handler _nextHandler;

    public Handler SetNext(Handler handler)
    {
        _nextHandler = handler;
        return handler;
    }
    
    public virtual void Handle(RequestContext context)
    {
        if (_nextHandler != null)
        {
            _nextHandler.Handle(context);
        }
    }
}
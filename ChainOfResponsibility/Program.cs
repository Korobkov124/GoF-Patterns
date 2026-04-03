using ChainOfResponsibility.Domain;
using ChainOfResponsibility.Handler;

var auth = new AuthentificationHandler();
var authorization = new AuthorizationHandler();
var validation = new ValidationHandler();
var logging = new LoggingHandler();
var processing = new EventProcessingHandler();

auth.SetNext(authorization)
    .SetNext(validation)
    .SetNext(logging)
    .SetNext(processing);

var successContext = new RequestContext("valid_token", "Admin", "SomeData");
auth.Handle(successContext);

var failAuthContext = new RequestContext("", "Admin", "SomeData");
auth.Handle(failAuthContext);

var failValContext = new RequestContext("valid_token", "User", "");
auth.Handle(failValContext);
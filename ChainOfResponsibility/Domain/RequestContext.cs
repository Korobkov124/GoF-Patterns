namespace ChainOfResponsibility.Domain;

public class RequestContext
{
    public string UserToken { get; set; }
    public string Role { get; set; }
    public string Data { get; set; }
    public bool IsAuthenticated { get; set; }
    public bool IsAuthorized { get; set; }
    public bool IsValid { get; set; }

    public RequestContext(string token, string role, string data)
    {
        UserToken = token;
        Role = role;
        Data = data;
    }
}
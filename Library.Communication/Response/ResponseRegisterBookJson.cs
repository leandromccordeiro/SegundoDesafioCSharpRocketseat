using System.Security.Principal;

namespace Library.Communication.Response;
public class ResponseRegisterBookJson
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
}

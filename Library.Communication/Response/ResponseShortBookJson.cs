using Library.Communication.Enums;

namespace Library.Communication.Response;
public class ResponseShortBookJson
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public Gender Gender { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
}

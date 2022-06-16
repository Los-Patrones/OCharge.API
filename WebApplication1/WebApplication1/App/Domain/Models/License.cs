namespace WebApplication1.App.Domain.Models;

public class License
{
    public int Id { get; set; }
    public string Category { get; set; }
    public Courier Courier { get; set; }
    public int CourierId { get; set; }
}
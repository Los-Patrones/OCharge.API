namespace WebApplication1.App.Domain.Models;

public class Person
{
    public int Id { get; set; }
    public string Phone{ get; set; }
    public User User { get; set; }
    public int UserId { get; set; }
    public Courier Courier { get; set; }
    public int CourierId { get; set; }
}
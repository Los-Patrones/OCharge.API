namespace WebApplication1.App.Domain.Models;
public class User
{
    public int Id { get; set; }
    public string Phone{ get; set; }
    public List<UserRequest> UserRequests { get; set; } = new List<UserRequest>();
}
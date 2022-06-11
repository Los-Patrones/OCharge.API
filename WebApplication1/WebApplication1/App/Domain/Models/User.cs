namespace WebApplication1.App.Domain;

public class User
{
    public int Id { get; set; }
    public string Phone{ get; set; }
    public List<UserRequest> UserRequests { get; set; } = new List<UserRequest>();
}
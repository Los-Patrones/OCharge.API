namespace WebApplication1.App.Domain.Models;

public class PaymentMethod
{
    public int Id { get; set; }
    public int Type { get; set; }
    public List<PaymentService> PaymentServices { get; set; } = new List<PaymentService>();
}
namespace WebApplication1.App.Domain;

public class PaymentService
{
    public int Id { get; set; }
    public int CardUser { get; set; }
    public int CardCourier { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
    public int PaymentMethodId { get; set; }
    public Service Service { get; set; }
    public int ServiceId { get; set; }
}
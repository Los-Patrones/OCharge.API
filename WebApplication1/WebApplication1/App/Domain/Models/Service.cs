namespace WebApplication1.App.Domain;

public class Service
{
    public int Id { get; set; }
    public bool Finalized { get; set; }
    public PaymentService PaymentService { get; set; }
    public int PaymentServiceId { get; set; }
    public UserRequest UserRequest { get; set; }
    public int UserRequestId { get; set; }
    public Courier Courier { get; set; }
    public int CourierId { get; set; }
}
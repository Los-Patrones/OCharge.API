namespace WebApplication1.App.Resources;

public class ServiceResource
{
    public int Id { get; set; }
    public bool IsFinalized { get; set; }
    public int PaymentServiceId { get; set; }
    public int UserRequestId { get; set; }
    public int CourierId { get; set; }
}
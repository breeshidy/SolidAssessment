namespace Quiz.Models
{
    public class DeliveryDetails
    {
        public int Id { get; set; }
        public string? Address { get; set; }
        public DateTime DeliveryDateTime { get; set; }
        public DeliveryStatus DeliveryStatus { get; set; }
        public OrderDetails? OrderDetails { get; set; }
    }
}
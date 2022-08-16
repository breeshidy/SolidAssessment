namespace Quiz
{
    public class DeliveryDetails
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public DateTime DeliveryDateTime { get; set; }
        public DeliveryStatus DeliveryStatus { get; set; }
        public OrderDetails OrderDetails { get; set; }
    }

    public class OrderDetails
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string ContactNumber { get; set; }
    }

    public enum DeliveryStatus : byte
    {
       Delivered,
       InProgress,
       NotDelivered
    }
}

using Quiz.models;
using Quiz.Services;

namespace Quiz.Repositories
{
    public class DeliveryRepository
    {
        private readonly IDictionary<int, DeliveryDetails> _deliveries;

        public DeliveryRepository()
        {
            _deliveries = new Dictionary<int, DeliveryDetails>();
        }

        public void Add(DeliveryDetails deliveryDetails)
        {
            if (deliveryDetails == null)
            {
                return;
            }

            _deliveries.Add(deliveryDetails.Id, deliveryDetails);

            //send email to customer about delivery
            var emailToSend = new Email() { };
            //some logic here to send Email
        }

        public DeliveryDetails? Get(int deliveryId)
        {
            _deliveries.TryGetValue(deliveryId, out var deliveryDetails);

            if (deliveryDetails != null)
            {
                //send email to customer about delivery
                var emailToSend = new Email() { };
                //some logic here to send Email
            }

            return deliveryDetails;
        }

        public void Update(DeliveryDetails deliveryDetails)
        {
            if (deliveryDetails == null)
            {
                return;
            }

            _deliveries[deliveryDetails.Id] = deliveryDetails;

            //send email to customer about delivery
            var emailToSend = new Email() { };
            //some logic here to send Email
        }

        public void Delete(int deliveryId)
        {
            _deliveries.Remove(deliveryId);

            //send email to customer about delivery
            var emailToSend = new Email() { };
            //some logic here to send Email
        }
    }
}
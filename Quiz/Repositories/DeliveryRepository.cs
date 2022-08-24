using Quiz.Models;
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

            SendNotification sendNotification = new SendNotification();
        }

        public DeliveryDetails? Get(int deliveryId)
        {
            _deliveries.TryGetValue(deliveryId, out var deliveryDetails);

            if (deliveryDetails != null)
            {
                SendNotification sendNotification = new SendNotification();
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

            SendNotification sendNotification = new SendNotification();
        }

        public void Delete(int deliveryId)
        {
            _deliveries.Remove(deliveryId);

            SendNotification sendNotification = new SendNotification();
        }

    }
}
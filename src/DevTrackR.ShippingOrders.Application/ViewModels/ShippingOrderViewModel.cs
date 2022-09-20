using DevTrackR.ShippingOrders.Core.Entities;

namespace DevTrackR.ShippingOrders.Application.ViewModels
{
    public class ShippingOrderViewModel
    {
        public ShippingOrderViewModel(string trackingCode, string description, DateTime postedAt, decimal weightInKg, string fullAddress)
        {
            TrackingCode = trackingCode;
            Description = description;
            PostedAt = postedAt;
            WeightInKg = weightInKg;
            FullAddress = fullAddress;
        }

        public string TrackingCode { get; private set; }
        public string Description { get; private set; }
        public DateTime PostedAt { get; private set; }
        public decimal WeightInKg { get; private set; }
        public string FullAddress { get; private set; }
    }
}
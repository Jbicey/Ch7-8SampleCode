using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Abstract
{
    public interface IOrderProcessor
    {
        void ProcessOrder(Cart cart, SportStore.Domain.Entities.ShippingDetails shippingDetails);
    }
}
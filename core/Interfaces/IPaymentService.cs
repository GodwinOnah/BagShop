using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Entities.Oders;

namespace core.Entities.Interfaces
{
    public interface IPaymentService
    {
        Task<Basket> CreateOrUpdateIntent(string basketId);

        Task<Order> UpdateOrderPaymentSucceeded(string paymentIntentId);

        Task<Order> UpdateOrderPaymentFailed(string paymentIntentId);
    }
}
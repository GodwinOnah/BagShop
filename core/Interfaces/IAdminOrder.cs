using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Entities.Oders;

namespace core.Interfaces
{
    public interface IAdminOrder
    {
        Task<IReadOnlyList<AdminOrder>> GetAdminOrderhsAsync (OrderStatus orederStatus);
        Task<AdminOrder> GetAdminOrdersByIdAsync(int id);
        Task<bool> UpdateAdminOrdersByIdAsync(OrderConfirmDetails details);
        Task DeletAdminOrder(int id);
    }
}
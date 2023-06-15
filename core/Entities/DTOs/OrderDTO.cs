using API.DTOs;
using core.Entities.Oders;

namespace API.Controllers
{
    public class OrderDTO
    {
        public string basketId {get; set;}
        public int deliveryId {get; set;}
        public AddressDTO shippingAddress {get; set;}
    }
}
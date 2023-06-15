using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Entities.Oders;
using API.DTOs;

namespace core.Entities.DTOs
{
    public class AdminOrderDTO
    {
         public int  id {get; set;}
         public string  Email {get; set;}
        public ShippingAddress shippingAddress {get; set;}
        public IReadOnlyList<ItemOrderedDTO> itemOrdered {get; set;}
        public string  orderStatus {get; set;}
        public DateTime  orderDate {get; set;}
        public  Delivery  delivery {get; set;}
        public string confirmation {get; set;}
        
        
    }
}
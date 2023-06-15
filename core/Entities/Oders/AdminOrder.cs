using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Entities.Oders
{
    public class AdminOrder : ProductEntities
    {
       public  AdminOrder() 
        {

        }

       public AdminOrder(IReadOnlyList<ItemOrdered> itemOrdered,
         string email, ShippingAddress address, Delivery delivery
         ) 
        {

           this.Email = email;
            this.address = address;
            this.itemOrdered = itemOrdered;
            this.delivery = delivery;
            
            
                   
    }

        public string  Email {get; set;}
        public ShippingAddress address {get; set;}
        public IReadOnlyList<ItemOrdered > itemOrdered {get; set;}
        public OrderStatus  orderStatus {get; set;} = OrderStatus.PaymentReceived;
        public DateTime  orderDate {get; set;} = DateTime.UtcNow;
        public Delivery  delivery {get; set;}
         public string confirmation {get; set;} = "Awaits your confirmation";
       
       
    }
}
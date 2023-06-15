using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Entities.Adverts
{
    public class Adverts : ProductEntities
    {
         public string advert {get; set;}
         public decimal time {get; set;}
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Entities.Oders
{
    public class Delivery : ProductEntities
    {
            public string delName {get; set;}
            public string delTime {get; set;}
            public string delDescription {get; set;}
            public decimal delPrice{get; set;}
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class AddressDTO
    {
        [Required]
         public string firstName {get; set;}

           public string? middleName {get; set;}

            [Required]
            public string lastName {get; set;}

             [Required]
             public string street {get; set;}

              [Required]
              public string city {get; set;}

               [Required]
               public string country{get; set;}

                [Required]
                public string zipcode {get; set;}
                
                [Required]
                public string phone {get; set;}
        
    }
}
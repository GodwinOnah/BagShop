using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace core.Entities.Identity
{
    public class User : IdentityUser
    {
        public string NickName {get; set;}
         public Address address {get; set;}    
    }   
}
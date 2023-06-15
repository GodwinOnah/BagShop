using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Controllers;

namespace core.Interfaces
{
    public interface IProductType
    {
         Task UploadTypeAsync(ProductType brand);
        Task DeleteTypeAsync(int id);
    }
}
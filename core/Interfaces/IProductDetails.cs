using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Controllers;
using core.Entities.DTOs;

namespace core.Interfaces
{
    public interface IProductDetails
    {
        Task UploadProductAsync(ProductDetails productsDetails);
        Task DeleteProductAsync(int id);
    }
}
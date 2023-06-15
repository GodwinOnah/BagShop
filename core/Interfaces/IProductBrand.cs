using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Controllers;

namespace core.Interfaces
{
    public interface IProductBrand
    {
        Task UploadBrandAsync(ProductBrand brand);
        Task DeleteBrandAsync(int id);
    }
}
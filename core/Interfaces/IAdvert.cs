using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Entities.Adverts;
using core.Entities.DTOs;

namespace core.Interfaces
{
    public interface IAdvert
    {
        Task UploadProductsUrlToDb(Adverts advert);
        Task<Adverts> GetAdvertsById(int id);
        Task<IReadOnlyList<Adverts>> GetAdverts();
        Task<bool> DeleteAverts(int id);
    }
}
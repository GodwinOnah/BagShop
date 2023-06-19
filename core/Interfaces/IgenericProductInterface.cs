using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Entities;

namespace core.Interfaces
{
    public interface IgenericInterfaceRepository<T> where T : ProductEntities
    {
        Task<T> GetProductsByIdAdsync(int id);

        Task<T> GetProductsWithSpecification(ISpecificationProducts<T> specification);

        Task<IReadOnlyList<T>> ListAllAsync();

         Task<IReadOnlyList<T>> ListAllAsync(ISpecificationProducts<T> specification);

         Task<int> CountPage(ISpecificationProducts<T> specification);

         void Add(T entity);
          void Update(T entity);
           void Delete(T entity);
    }
}
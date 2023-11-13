using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAllByCategoryId();
        List<Product> GetByUnitPrice(int id);
        List<Product> GetByUnitPrice(decimal min, decimal max);
    }
}

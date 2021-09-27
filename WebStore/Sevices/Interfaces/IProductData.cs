using System.Collections.Generic;
using WebStore.Domain.Entities;

namespace WebStore.Sevices.Interfaces
{
    public interface IProductData
    {
        IEnumerable<Section> GetSections();

        IEnumerable<Brand> GetBrands();
    }
}

using nagikiShopSolution.Application.Catalog.Products.Dtos;
using nagikiShopSolution.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace nagikiShopSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        PagedViewModel<ProductViewModel> GetAllByCategoryId(int categoryId, int pageIndex, int pageSize);
    }
}

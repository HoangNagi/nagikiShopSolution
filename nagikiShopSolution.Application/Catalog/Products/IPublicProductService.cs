using NagikiShopSolution.ViewModels.Catalog.Products;
using NagikiShopSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace nagikiShopSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(string languageId,GetPublicProductPagingRequest request);
    }
}

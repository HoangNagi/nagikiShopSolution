using Microsoft.AspNetCore.Http;
using NagikiShopSolution.ViewModels.Catalog.Products;
using NagikiShopSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace nagikiShopSolution.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductUpdateRequest request);
        Task<int> Delete(int productId);
        Task<bool> UpdatePrice(int productId, decimal newPrice);
        Task<bool> UpdateStock(int productId, int addedQuantity);
        Task AddViewcount(int productId);
        Task<PagedResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);
        Task<int> AddImages(int productId, List<IFormFile> files);
        Task<int> UpdateImages(int imageId, string caption, bool isDefault);
        Task<int> RemoveImages(int imageId);
        Task<List<ProductImageViewModel>> GetListImage(int ProductId);
    }
}

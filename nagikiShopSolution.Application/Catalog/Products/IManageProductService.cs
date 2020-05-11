using Microsoft.AspNetCore.Http;
using NagikiShopSolution.ViewModels.Catalog.ProductImages;
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
        Task<int> AddImage(int productId,ProductImageCreateRequest request);
        Task<int> UpdateImage(int imageId, ProductImageUpdateRequest request);
        Task<int> RemoveImage(int imageId);
        Task<List<ProductImageViewModel>> GetListImages(int productId);
        Task<ProductImageViewModel> GetImageById(int imageId);
        Task<ProductViewModel> GetById(int productId, string languageId);
    }
}

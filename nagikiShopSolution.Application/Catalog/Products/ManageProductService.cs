using nagikiShopSolution.Application.Catalog.Products.Dtos;
using nagikiShopSolution.Application.Dtos;
using nagikiShopSolution.Data.EF;
using nagikiShopSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace nagikiShopSolution.Application.Catalog.Products
{
    public class ManageProductService : IManageProductService
    {
        private readonly NagikiShopDbContext _context;
        public ManageProductService(NagikiShopDbContext context) {
            _context = context;
        }
        public async Task<int> Create(ProductCreateRequest request)
        {
            var product = new Product()
            {
                Price = request.Price
            };
            _context.Products.Add(product);
         return  await _context.SaveChangesAsync();

        }

        public async Task<int> Delete(int productId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<PagedViewModel<ProductViewModel>> GetAllPaging(string keyWord, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Update(ProductEditRequest request)
        {
            throw new NotImplementedException();
        }
    }
}

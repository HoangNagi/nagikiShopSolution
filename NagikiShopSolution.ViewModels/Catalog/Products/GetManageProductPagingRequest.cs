using NagikiShopSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace NagikiShopSolution.ViewModels.Catalog.Products
{
    public class GetManageProductPagingRequest : PagingRequestBase
    {
        public string KeyWord { get; set; }
        public List<int> CategoryIds { get; set; }
    }

}

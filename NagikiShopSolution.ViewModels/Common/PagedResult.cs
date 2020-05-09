using System;
using System.Collections.Generic;
using System.Text;

namespace NagikiShopSolution.ViewModels.Common
{
    public class PagedResult<T>
    {
        public List<T> items { set; get; }
        public int TotalRecord { set; get; }
    }
}

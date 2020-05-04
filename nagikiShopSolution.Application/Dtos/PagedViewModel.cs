using System;
using System.Collections.Generic;
using System.Text;

namespace nagikiShopSolution.Application.Dtos
{
    public class PagedViewModel<T>
    {
        public List<T> items { set; get; }
        public int TotalRecord { set; get; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace nagikiShopSolution.Utilities.Exceptions
{
   public class NagikiShopException : Exception 
    {
        public NagikiShopException()
        {
        }

        public NagikiShopException(string message)
            : base(message)
        {
        }

        public NagikiShopException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }

}

using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Services
{
    interface ICartService
    {
        IList<Product> Cart { get; }
        int Total { get; set; }

        event Action OnChange;

        void AddProduct(Product product);
        void DeleteProduct(Product product);
    }
}

using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Services
{
    public class CartService : ICartService
    {
        public IList<Product> Cart { get; private set; }
        public int Total { get; set; }

        public event Action OnChange;

        public CartService() { Cart = new List<Product>(); }

        private void NotifyStateChanged() => OnChange?.Invoke();
        public void AddProduct(Product product)
        {
            Cart.Add(product);
            Total += product.Price;
            NotifyStateChanged();
        }
        public void DeleteProduct(Product product)
        {
            Cart.Remove(product);
            Total -= product.Price;
            NotifyStateChanged();
        }
    }
}

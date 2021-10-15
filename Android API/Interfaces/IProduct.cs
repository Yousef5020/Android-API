using System.Collections.Generic;
using Android_API.Models;

namespace Android_API.Interfaces
{
    public interface IProduct
    {
        public Product GetProduct(int id);

        public IEnumerable<Product> GetProducts();

        public Product AddProduct(Product product);

        public Product EditProduct(int id, Product product);
    }
}

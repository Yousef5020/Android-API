using System.Collections.Generic;
using System.Linq;
using Android_API.Interfaces;
using Android_API.Models;

namespace Android_API.Services
{
    public class ProductServices : IProduct
    {
        private List<Product> _products = new();

        public ProductServices()
        {
                _products.Add(new Product
                {
                    Id = 1,
                    Name = "منتج 1",
                    Barcode = "1"
                });

                _products.Add(new Product
                {
                    Id = 2,
                    Name = "منتج 2",
                    Barcode = "2"
                });

                _products.Add(new Product
                {
                    Id = 3,
                    Name = "منتج 3",
                    Barcode = "3"
                });
        }

        public Product GetProduct(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _products;
        }

        public Product AddProduct(Product product)
        {
            _products.Add(product);

            return _products.FirstOrDefault(p => p.Id == product.Id);
        }

        public Product EditProduct(int id, Product product)
        {
            var productEdit = _products.FirstOrDefault(p => p.Id == id);

            if (productEdit == null) return new Product();

            productEdit.Barcode = product.Barcode;
            productEdit.Name = product.Name;

            return productEdit;

        }
    }
}

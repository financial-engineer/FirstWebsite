using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstApp.Interfaces;

namespace FirstApp.Classes
{
    public class ProductRepository : IProductRepository
    {
        private List<ProductDto> products = new List<ProductDto>();
        private List<ProductDto> premiumProducts = new List<ProductDto>();

        public ProductRepository()
        {
            products.Add(new ProductDto(Id: 0, Name: "Product 0", Price: 0.1m));
            products.Add(new ProductDto(Id: 1, Name: "Product 1", Price: 1.0m));

            premiumProducts.Add(new ProductDto(Id: 2, Name: "Premium Product 2", Price: 2.0m));
        }

        public IEnumerable<Product> GetProducts()
        {
            return products.Select(p => new Product(p, AccountType.Basic)).ToList();
        }

        public IEnumerable<Product> GetPremiumProducts()
        {
            return premiumProducts.Select(p => new Product(p, AccountType.Premium)).ToList();
        }
    }
}
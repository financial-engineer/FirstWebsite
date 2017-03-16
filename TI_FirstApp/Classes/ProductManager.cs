using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstApp.Interfaces;

namespace FirstApp.Classes
{
    public class ProductManager : IProductManager
    {
        private readonly IAccountRepository accountRepository;
        private readonly IProductRepository productRepository;

        public ProductManager(IAccountRepository ar, IProductRepository pr)
        {
            this.accountRepository = ar;
            this.productRepository = pr;
        }

        public IEnumerable<Product> GetProductsByType(int userId)
        {
            var account = accountRepository.GetById(userId);

            if (account == null) { return null; };

            var products = new List<Product>();
            var basicProducts = productRepository.GetProducts();

            if (basicProducts != null)
            {
                products.AddRange(basicProducts);
            };

            if (account.accountType == AccountType.Premium)
            {
                var premiumProducts = productRepository.GetPremiumProducts();
                if (premiumProducts != null)
                {
                    products.AddRange(premiumProducts);
                }
            }
            return products;
        }
    }
}
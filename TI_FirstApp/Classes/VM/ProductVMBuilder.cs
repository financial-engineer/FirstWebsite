using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstApp.Interfaces;

namespace FirstApp.Classes.VM
{
    public class ProductVMBuilder: IProductVMBuilder
    {
        public ProductVM GetVM(Product product)
        {
            return new ProductVM { product = product };
        }
        
        public ProductListVM GetVMList(List<Product> products)
        {
            return new ProductListVM
            {
                products = products.Select(p => GetVM(p)).ToList()
            };
        }
    }
}

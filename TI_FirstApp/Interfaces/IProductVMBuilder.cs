using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstApp.Classes;
using FirstApp.Classes.VM;

namespace FirstApp.Interfaces
{
    public interface IProductVMBuilder
    {
        ProductVM GetVM(Product product);

        ProductListVM GetVMList(List<Product> products);
    }
}

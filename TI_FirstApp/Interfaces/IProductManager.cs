using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstApp.Classes;

namespace FirstApp.Interfaces
{
    public interface IProductManager
    {
        IEnumerable<Product> GetProductsByType(int userId);
    }
}

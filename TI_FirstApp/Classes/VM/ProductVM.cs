using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Classes.VM
{
    public class ProductVM
    {
        public Product product { get; set; }
        public string AccountTypeLabel { get { return product.IsPremium ? "[Premium]" : "[Usual]"; } }
    }
}

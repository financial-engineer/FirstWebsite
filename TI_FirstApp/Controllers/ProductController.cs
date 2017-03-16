using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstApp.Interfaces;
using FirstApp.Classes;
using System.Web;
using System.Web.Mvc;
using FirstApp.Classes.VM;

namespace FirstApp.Controllers
{
    class ProductController
    { 
        private IProductManager pm;
        private ProductVM vm;

        public ProductController(IProductManager pm) //, IProductVMViewer vm)
        {
            this.pm = pm;
            // this.vm = vm;
        }

        //public ActionResult Index()
        // {
        //    var products = pm.GetProductsByType(2);
        //    var productListVM = vm.GetVM(products);
        //    return new View(productListVM)
        //}
    }
}

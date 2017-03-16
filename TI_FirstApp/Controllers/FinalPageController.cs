using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstApp.Classes;

namespace FirstApp.Controllers
{
    public class FinalPageController
    {
        private FinalPage page;

        public FinalPageController(FinalPage page)
        {
            this.page = page;
        }

        public void Index()
        {
            Console.WriteLine(page.Name);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstApp.Classes;

namespace FirstApp.Controllers
{
    public class BasketPageController: BasketWizardPageController<BasketPage>
    {
        private BasketPage page;

        public BasketPageController(BasketPage page)
            :base(page)
        {
            this.page = page;
        }
        
    }
}

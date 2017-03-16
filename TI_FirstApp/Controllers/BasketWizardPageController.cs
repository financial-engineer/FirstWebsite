using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstApp.Classes;
using FirstApp.Interfaces;

namespace FirstApp.Controllers
{
    public abstract class BasketWizardPageController<TPage> where TPage:Page, IWizardPage
    {
        private TPage page;
        private Engine engine = new Engine();

        public BasketWizardPageController(TPage page)
        {
            this.page = page;
        }

        public void Index()
        {
            Console.WriteLine(page.WizardPageName);

            GoToNextPage();
        }

        public void GoToNextPage()
        {
            var nextPage = engine.Go(page);
            if (nextPage is FinalPage)
            {
                var controller = new FinalPageController(nextPage as FinalPage);
                controller.Index();
                return;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Classes
{
    public sealed class PageStore
    {
        private static readonly PageStore instance = new PageStore();
        private IEnumerable<Page> pages;

        static PageStore()
        {

        }

        private PageStore()
        {
            pages = new List<Page>
            {
                new StartPage { Name = "StartPage" },
                new BasketPage { Name = "BasketPage", WizardPageName = "Basket" },
                new RegisterPage { Name = "RegisterPage", WizardPageName = "Register" },
                new FinalPage { Name = "Success", WizardPageName="Basket"}, new FinalPage { Name = "Fail", WizardPageName="Basket"},
                new FinalPage { Name = "Success", WizardPageName="Register"}, new FinalPage { Name = "Fail", WizardPageName="Register"}
            };
        }

        public static IEnumerable<Page> Pages
        {
            get
            {
                return instance.pages;
            }
        }
    }
}

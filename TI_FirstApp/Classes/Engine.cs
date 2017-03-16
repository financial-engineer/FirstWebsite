using System;
using System.Linq;
using System.Collections.Generic;
using FirstApp.Interfaces;

namespace FirstApp.Classes
{
    public class Engine: IEngine 
    {

        private static IDictionary<string, Page> BasketFlow = new Dictionary<string, Page>();
        private static IDictionary<string, Page> RegisterFlow = new Dictionary<string, Page>();

        private static Random random = new Random();

        static Engine()
        {
            BasketFlow.Add("Basket", GetPage(typeof(BasketPage), "Basket"));
            BasketFlow.Add("Success", GetPage(typeof(FinalPage), "Basket"));
            BasketFlow.Add("Fail", GetPage(typeof(FinalPage), "Basket"));

            RegisterFlow.Add("Register", GetPage(typeof(RegisterPage), "Register"));
            RegisterFlow.Add("Success", GetPage(typeof(FinalPage), "Register"));
            RegisterFlow.Add("Fail", GetPage(typeof(FinalPage), "Register"));
        }

        private static Page GetPage(Type pageType, string wizardPageName)
        {
            foreach (var page in PageStore.Pages)
            {
                var wizardPage = page as IWizardPage;
                if (wizardPage != null && page.GetType() == pageType && wizardPage.WizardPageName == wizardPageName)
                {
                    return page;
                }
                  
            }
            return null;
        }

        public Page Go<TPage>(TPage page) where TPage:Page, IWizardPage
        {
            var startPage = PageStore.Pages.OfType<StartPage>().SingleOrDefault();
            if (BasketFlow.ContainsKey(page.WizardPageName))
            {
                if (page.WizardPageName == "Basket")
                {
                    return (random.Next(2) % 2 == 0 ? BasketFlow["Success"] : BasketFlow["Fail"]);
                }
            }
            if (RegisterFlow.ContainsKey(page.WizardPageName))
            {
                if (page.WizardPageName == "Register")
                {
                    return (random.Next(2) % 2 == 0 ? RegisterFlow["Success"] : RegisterFlow["Fail"]);
                }
            }
            return startPage;
        }
    }
}
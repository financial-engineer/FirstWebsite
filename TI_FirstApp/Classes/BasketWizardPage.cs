using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstApp.Interfaces;

namespace FirstApp.Classes
{
    public abstract class BasketWizardPage: Page, IWizardPage
    {
        public string WizardPageName { get; set; }
    }
}

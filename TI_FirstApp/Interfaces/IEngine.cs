using System;
using System.Linq;
using System.Collections.Generic;
using FirstApp.Interfaces;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Classes
{
    public interface IEngine
    {
        Page Go<TPage>(TPage page) where TPage : Page, IWizardPage;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstApp.Classes;

namespace FirstApp.Controllers
{
    public class RegisterPageController: RegisterWizardPageController<RegisterPage>
    {
        private RegisterPage page;

        public RegisterPageController(RegisterPage page)
            :base(page)
        {
            this.page = page;
        }

       
    }
}

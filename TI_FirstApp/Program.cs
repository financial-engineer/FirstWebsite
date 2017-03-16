using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstApp.Classes;
using FirstApp.Controllers;

namespace FirstApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                body();
            }
            Console.ReadKey();
        }

        static void body()
        { 
            var basketPage = PageStore.Pages.OfType<BasketPage>().FirstOrDefault();
            //var registerPage = PageStore.Pages.OfType<RegisterPage>().FirstOrDefault();

            var basketController = new BasketPageController(basketPage);
            //var registerController = new RegisterPageController(registerPage);

            basketController.Index();        
        }
    }
}

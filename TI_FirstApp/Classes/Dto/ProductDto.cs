using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Classes
{
    public class ProductDto
    {
        public int Id { get; }
        public string Name { get; }
        public decimal Price { get; }

        public ProductDto(int Id, string Name, decimal Price)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
        }
    }
}

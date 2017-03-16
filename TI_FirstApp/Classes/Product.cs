using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Classes
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsPremium { get; set; }

        public Product(ProductDto dto, AccountType type)
        {
            Id = dto.Id;
            Name = dto.Name;
            Price = dto.Price;
            IsPremium = (type == AccountType.Premium);
        }
    }
}

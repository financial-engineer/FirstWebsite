using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Classes
{
    public class AccountDto
    {
        public int userId { get; }
        public int accountType { get; }

        public AccountDto(int userId, int accountType)
        {
            this.userId = userId;
            this.accountType = accountType;
        }
    }
}

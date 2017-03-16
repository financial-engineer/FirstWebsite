using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Classes
{
    public class Account
    {
        public int userId { get; }
        public AccountType accountType { get; }
        public Account(AccountDto dto)
        {
            userId = dto.userId;
            accountType = (AccountType)dto.accountType;
        }
    }
}

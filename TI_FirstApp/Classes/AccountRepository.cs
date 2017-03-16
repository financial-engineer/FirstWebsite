using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstApp.Classes;

namespace FirstApp.Interfaces
{
    public class AccountRepository: IAccountRepository
    {
        private List<AccountDto> account;

        public AccountRepository()
        {
            this.account = new List<AccountDto>();
            var dto = new AccountDto(userId: 1, accountType: 0);
            this.account.Add(dto);
            var dto2 = new AccountDto(userId: 2, accountType: 1);
            this.account.Add(dto2);
        }            
            
        public Account GetById(int userId)
        {
            var dto = account.SingleOrDefault(x => x.userId == userId);
            return dto != null ? new Account(dto): null;
        }
    }
    
}

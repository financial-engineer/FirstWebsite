﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstApp.Classes;

namespace FirstApp.Interfaces
{
    public interface IAccountRepository
    {
        Account GetById(int userId);
    }
}

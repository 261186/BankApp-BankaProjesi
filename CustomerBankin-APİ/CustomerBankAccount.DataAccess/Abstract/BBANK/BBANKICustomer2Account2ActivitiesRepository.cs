﻿using CustomerBankAccount.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccount.DataAccess.Abstract.BBANK
{
    public interface BBANKICustomer2Account2ActivitiesRepository
    {
        List<BBANKCustomer2Account2Activities> GetAllCustomer2Account2Activities();
        BBANKCustomer2Account2Activities Customer2Account2ActivitiesById(int id);
    }
}

﻿using CustomerBankAccount.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccount.DataAccess.Abstract.ABANK
{
    public interface ABANKICustomer1Account1DetailsRepository
    {
        List<ABANKCustomer1Account1Details> GetAllCustomer1AccountDetails();
        ABANKCustomer1Account1Details GetCustomer1Account1DetailsById(int id);
        ABANKCustomer1Account1Details PostCustomer1Account1Details(ABANKCustomer1Account1Details aBANKCustomer1Account1Details);
        ABANKCustomer1Account1Details PutCustomer1Account1Details(ABANKCustomer1Account1Details aBANKCustomer1Account1Details);
        void DeleteCustomer1Account1Details(int id);
    }
}

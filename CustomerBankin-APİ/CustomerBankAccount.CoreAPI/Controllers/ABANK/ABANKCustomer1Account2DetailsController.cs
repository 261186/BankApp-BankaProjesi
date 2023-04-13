﻿using CustomerBankAccount.Business.Abstract.ABANK;
using CustomerBankAccount.Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CustomerBankAccount.CoreAPI.Controllers.ABANK
{

    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class ABANKCustomer1Account2DetailsController : ControllerBase
    {
        ABANKCustomer1Account customer1 = new ABANKCustomer1Account();
        private ABANKICustomer1Account2DetailsService customer1Account2DetailsSAervice;
        private readonly IDataProtector dataProtector;
        public ABANKCustomer1Account2DetailsController(ABANKICustomer1Account2DetailsService customer1Account2DetailsSAervice, IDataProtectionProvider provider)
        {
            this.customer1Account2DetailsSAervice = customer1Account2DetailsSAervice;
            dataProtector = provider.CreateProtector("musasekeroglu2005");
        }

        [HttpGet("Protect")]
        public IActionResult GetCustomer1Account2Details()
        {
            var customer1Account2Details = Customer1Account2Details();
            var outPut = customer1Account2Details.Select(x => new
            {
                Id = dataProtector.Protect(x.Id.ToString()),
                HesapNo = dataProtector.Protect(x.HesapNo.ToString()),
                HesapAdi = dataProtector.Protect(x.HesapAdi.ToString()),
                IbanNo = dataProtector.Protect(x.IbanNo.ToString()),
                SubeAdi = dataProtector.Protect(x.SubeAdi.ToString()),
                HesapBakiye = dataProtector.Protect(x.HesapBakiye.ToString()),
                HesapAktifMi = dataProtector.Protect(x.HesapAktifMi.ToString()),
                SubeKodu = dataProtector.Protect(x.SubeKodu.ToString()),
                GünlükTransferLimiti = dataProtector.Protect(x.GünlükTransferLimiti.ToString()),
                MusteriNo = dataProtector.Protect(x.MusteriNo.ToString()),

            });
            return Ok(outPut);

        }
        [HttpGet("HesapNo")]
        public IActionResult GetUnprotectCustomer1Account2Details(string HesapNo)
        {
            var OriginalMN = dataProtector.Unprotect(HesapNo);
            var customer1Account2Details = Customer1Account2Details();
            var ca1 = customer1Account2Details.Where(x => x.HesapNo == OriginalMN).First();
            return Ok(customer1Account2Details);
        }
        private List<ABANKCustomer1Account2Details> Customer1Account2Details()
        {
            var customer1Account = new List<ABANKCustomer1Account2Details>();
            customer1Account.Add(new ABANKCustomer1Account2Details()
            {
                Id = 2,
                HesapAdi = "DenizbankVadesizTL",
                HesapNo = "1101166820",
                IbanNo = "TR670001200190031101166820",
                HesapBakiye = 10000,
                SubeAdi = "DENİZBANK",
                MusteriNo = "10203040",
                HesapAktifMi = true,
                SubeKodu = 1010,
                GünlükTransferLimiti = 2500,
            });
            return customer1Account;
        }
        [HttpGet("GetAllCustomer1Account2Details")]
        public List<ABANKCustomer1Account2Details> GetAllCustomer1Account2Details()
        {
            return customer1Account2DetailsSAervice.GetAllCustomer1Account2Details().ToList(); ;
        }
        [HttpGet("{id}")]
        public ABANKCustomer1Account2Details GetCustomer1Account2DetailsById(int id)
        {
            return customer1Account2DetailsSAervice.GetCustomer1Account2DetailsById(id);
        }
        [HttpPost]
        public ABANKCustomer1Account2Details PostCustomer1Account2Details(ABANKCustomer1Account2Details aBANKCustomer1Account2Details)
        {
            return customer1Account2DetailsSAervice.PostCustomer1Account2Details(aBANKCustomer1Account2Details);
        }
        [HttpPut]
        public ABANKCustomer1Account2Details PutCustomer1Account2Details(ABANKCustomer1Account2Details aBANKCustomer1Account2Details)
        {
            return customer1Account2DetailsSAervice.PutCustomer1Account2Details(aBANKCustomer1Account2Details);
        }
        [HttpDelete("{id}")]
        public void DeleteCustomer1Account2Details(int id)
        {
            customer1Account2DetailsSAervice.DeleteCustomer1Account2Details(id);
        }
    }
}

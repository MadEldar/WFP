using Bank.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Bank.Controllers
{
    public class BankController : ApiController
    {
        private readonly DB_BankEntities _db = new DB_BankEntities();

        [HttpPost]
        [Authorize]
        [Route("api/Bank/Create")]
        public IHttpActionResult Create(BankModel bankModel)
        {
            var bank = new Table_DB_Bank()
            {
                BankName = bankModel.BankName,
                IFSC = bankModel.IFSC
            };
            _db.Table_DB_Bank.Add(bank);
            _db.SaveChanges();
            return Ok("Success");
        }

        [HttpPost]
        [Authorize]
        [Route("api/Bank/GetAll")]
        public IHttpActionResult GetAll()
        {
            var bank = _db.Table_DB_Bank.ToList();
            return Ok(bank);
        }

        [HttpPost]
        [Authorize]
        [Route("api/Bank/Modify")]
        public IHttpActionResult Modify(BankModel bankModel)
        {
            var bank = new Table_DB_Bank()
            {
                BankName = bankModel.BankName,
                IFSC = bankModel.IFSC,
                Id = bankModel.Id
            };
            _db.Entry(bank).State = EntityState.Modified;
            _db.SaveChanges();
            return Ok("Success");
        }

        [HttpPost]
        [Authorize]
        [Route("api/Bank/Delete/{id}")]
        public IHttpActionResult Delete(int id)
        {
            var bank = _db.Table_DB_Bank.SingleOrDefault(b => b.Id == id);
            _db.Table_DB_Bank.Remove(bank);
            _db.SaveChanges();
            return Ok("Success");
        }
    }
}

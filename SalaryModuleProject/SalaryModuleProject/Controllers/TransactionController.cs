using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SalaryModuleProject.Models;
using static SalaryModuleProject.Enums.TransactionEnums;

namespace SalaryModuleProject.Controllers
{
    public class TransactionController : Controller
    {
        public List<TransactionModel> defaultList = new List<TransactionModel>()
        {
            new TransactionModel() { TransactionId = 1, TransactionName = "Zakupy", TransactionType = eTransactionType.Withdraw, Amount = 150 },
            new TransactionModel() { TransactionId = 2, TransactionName = "Wpłata pierwsza", TransactionType = eTransactionType.Deposit, Amount = 200 }
        };

        // GET: Transaction
        public ActionResult Index()
        {
            var data = defaultList;
            return View(defaultList);
        }

        // GET: Transaction/Details/5
        public ActionResult Details(int id)
        {
            var data = defaultList.Where(x => x.TransactionId == id).FirstOrDefault();
            return View(data);
        }

        // GET: Transaction/Create
        public ActionResult Create()
        {
            return View(new TransactionModel());
        }

        // POST: Transaction/Create
        [HttpPost]
        public ActionResult Create(TransactionModel transactionModel)
        {
            defaultList.Add(transactionModel);
            return RedirectToAction("Index");
        }

        // GET: Transaction/Edit/5
        public ActionResult Edit(int id)
        {
            var data = defaultList.Where(x => x.TransactionId == id).FirstOrDefault();
            return View();
        }

        // POST: Transaction/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Transaction/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Transaction/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SalaryModuleProject.Models;
using SalaryModuleProject.Repositories;
using static SalaryModuleProject.Enums.TransactionEnums;

namespace SalaryModuleProject.Controllers
{
    public class TransactionController : Controller
    {
        private readonly ITransactionRepository _transactionRepository;

        //public TransactionController() { }

        public TransactionController(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        // GET: Transaction
        public ActionResult Index()
        {
            var data = _transactionRepository.GetAll();
            return View(data);
        }

        // GET: Transaction/Details/5
        public ActionResult Details(int id)
        {
            var data = _transactionRepository.Get(id);
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
            _transactionRepository.Add(transactionModel);
            return RedirectToAction("Index");
        }

        // GET: Transaction/Edit/5
        public ActionResult Edit(int id)
        {
            var data = _transactionRepository.Get(id);
            return View();
        }

        // POST: Transaction/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, TransactionModel transactionModel)
        {
            _transactionRepository.Update(id, transactionModel);
            return RedirectToAction("Index");
        }

        // GET: Transaction/Delete/5
        public ActionResult Delete(int id)
        {
            var data = _transactionRepository.Get(id);
            return View(data);
        }

        // POST: Transaction/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, TransactionModel transactionModel)
        {
            _transactionRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}

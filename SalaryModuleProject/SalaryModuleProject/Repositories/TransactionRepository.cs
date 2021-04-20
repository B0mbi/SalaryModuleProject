using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SalaryModuleProject.Models;

namespace SalaryModuleProject.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly TransactionContext _context;
        public TransactionRepository(TransactionContext context)
        {
            _context = context;
        }

        public TransactionModel Get(int id)
        {
            return _context.Transactions.SingleOrDefault(x => x.TransactionId == id);
        }

        public IQueryable<TransactionModel> GetAll()
        {
            return _context.Transactions;
        }

        public void Add(TransactionModel transaction)
        {
            _context.Transactions.Add(transaction);
            _context.SaveChanges();
        }

        public void Update(int transactionId, TransactionModel transaction)
        {
            var result = _context.Transactions.SingleOrDefault(x => x.TransactionId == transactionId);
            if (result != null)
            {
                result.TransactionName = transaction.TransactionName;
                result.Amount = transaction.Amount;

                _context.SaveChanges();
            }
        }

        public void Delete(int transactionId)
        {
            var result = _context.Transactions.SingleOrDefault(x => x.TransactionId == transactionId);
            if (result != null)
            {
                _context.Transactions.Remove(result);
                _context.SaveChanges();
            }
        }
    }
}
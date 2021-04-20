using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalaryModuleProject.Models;

namespace SalaryModuleProject.Repositories
{
    public interface ITransactionRepository
    {
        TransactionModel Get(int id);
        IQueryable<TransactionModel> GetAll();
        void Add(TransactionModel transaction);
        void Update(int transactionId, TransactionModel transaction);
        void Delete(int transactionId);
    }
}

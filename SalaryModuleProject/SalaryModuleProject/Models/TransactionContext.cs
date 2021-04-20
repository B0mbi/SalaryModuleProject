using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SalaryModuleProject.Models
{
    public class TransactionContext : DbContext
    {
        public TransactionContext() : base("TransactionDB")
        {

        }

        public DbSet<TransactionModel> Transactions { get; set; }
    }
}
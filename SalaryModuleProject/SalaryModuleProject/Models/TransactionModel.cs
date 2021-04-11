using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static SalaryModuleProject.Enums.TransactionEnums;

namespace SalaryModuleProject.Models
{
    public class TransactionModel
    {
        public int TransactionId { get; set; }
        public string TransactionName { get; set; }
        public decimal Amount { get; set; }
        public eTransactionType TransactionType { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using static SalaryModuleProject.Enums.TransactionEnums;

namespace SalaryModuleProject.Models
{
    [Table("Transaction")]
    public class TransactionModel
    {
        [Key]
        public int TransactionId { get; set; }
        public string TransactionName { get; set; }
        public decimal Amount { get; set; }
        public eTransactionType TransactionType { get; set; }
    }
}
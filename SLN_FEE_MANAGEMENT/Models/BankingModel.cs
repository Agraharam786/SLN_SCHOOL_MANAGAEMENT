using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLN_FEE_MANAGEMENT.Models
{
    public class BankingModel
    {
        public int? TransactionId { get; set; }  // Use nullable int for optional values
        public string? TransactionFrom { get; set; }
        public string? TransactionTo { get; set; }
        public decimal TransactionAmount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string? Description { get; set; }
        public bool IsDeleted { get; set; } = false;
        public string? DepositedBy { get; set; }
    }
}

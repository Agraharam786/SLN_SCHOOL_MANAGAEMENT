using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLN_FEE_MANAGEMENT.Models
{
    public class ExpenseModel
    {
        public int ExpenseId { get; set; }
        public string? ExpenseType { get; set; }
        public string? ExpenseFrom { get; set; }
        public string? Description { get; set; }
        public int ExpenseAmount { get; set; }
        public DateTime EntryDate { get; set; }
        public bool IsDeleted { get; set; }
        public int ExpCorrectedAmount { get; set; }
    }
}

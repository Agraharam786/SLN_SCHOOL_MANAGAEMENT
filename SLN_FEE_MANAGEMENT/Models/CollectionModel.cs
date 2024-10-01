using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLN_FEE_MANAGEMENT.Models
{
    public class CollectionModel
    {
        public int CollectionId { get; set; }
        public string? CollectionType { get; set; }
        public string? Description { get; set; }
        public int CollectionAmount { get; set; }
        public int BankDepositAmount { get; set; }
        public int Incash { get; set; }
        public DateTime EntryDate { get; set; }
        public bool IsDeleted { get; set; }
        public int CorrectedAmount { get; set; }
    }
}

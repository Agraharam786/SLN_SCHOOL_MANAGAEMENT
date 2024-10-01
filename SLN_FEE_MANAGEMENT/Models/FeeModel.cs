using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLN_FEE_MANAGEMENT.Models
{
    public class FeeModel
    {

        public int FEE_ID { get; set; }
        public string? FEE_TYPE { get; set; }
        public string? STUDENT_NAME { get; set; }
        public string? FATHER_NAME { get; set; }
        public string? CLASS { get; set; }
        public int PAID_AMOUNT { get; set; }
        public string? VILLAGE_NAME { get; set; }
        public DateTime PAID_DATE { get; set; }
        public string? ACADEMIC_YEAR { get; set; }
        public string? MOBILE_NUM { get; set; }
        public string? GENDER { get; set; }
        public bool IS_DELETED { get; set; }
        public string? DESCRIPTION { get; set; }
        public string? SECTION { get; set; }
        public string? BILL_NUMBER { get; set; }
        public int? CORRECTED_AMOUNT { get; set; }
        public int ADMISSION_ID { get; set; }
        public DateTime LST_UPDATED_TMSP { get; set; }
        public string? LST_UPATED_ID { get; set; }
    }
}

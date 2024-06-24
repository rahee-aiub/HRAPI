using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Domain.Models.Setup
{
    public class Department
    {
        public int DID { get; set; }
        public string? DEP_NAME { get; set; }
        public string? CREATE_BY { get; set; }
        public DateTime? CREATE_DATE { get; set; }
        public string? UPDATE_BY { get; set; }
        public DateTime? UPDATE_DATE { get; set; }
        public bool? IS_SHOP { get; set; }
        public int? CompanyId { get; set; }
        public int? OrderNo { get; set; }
    }
}

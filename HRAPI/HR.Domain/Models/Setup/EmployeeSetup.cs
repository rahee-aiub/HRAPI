using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Domain.Models.Setup
{
    public class EmployeeSetup
    {
        public int EID { get; set; }
        public string? CARD_NO { get; set; }
        public int? JTID { get; set; }
        public string? PAYTYPE { get; set; }
        public int? GID { get; set; }
        public int? BID { get; set; }
        public int? DID { get; set; }
        public string? NATIONAL_ID { get; set; }
        public string? EMP_NAME { get; set; }
        public string? FATHER_NAME { get; set; }
        public string? MOTHER_NAME { get; set; }
        public string? SPOUSE_NAME { get; set; }
        public string? PHONE_MOBILE { get; set; }
        public string? EMAIL { get; set; }
        public DateTime? JOIN_DATE { get; set; }
        public string? EMP_ADDRES { get; set; }
        public string? COUNTRY { get; set; }
        public string? DISTRICT { get; set; }
        public bool IS_ACTIVE { get; set; }
        public DateTime? DE_ACTIVE_DATE { get; set; }
        public string? ACC_CODE { get; set; }
        public int? BANK_ID { get; set; }
        public decimal? GRADE_AMOUNT { get; set; }
        public decimal? PER_HOUR_RATE { get; set; }
        public string? CREATE_BY { get; set; }
        public DateTime? CREATE_DATE { get; set; }
        public string? UPDATE_BY { get; set; }
        public DateTime? UPDATE_DATE { get; set; }
        public bool? IS_OT { get; set; }
        public decimal? OT_RATE { get; set; }
        public DateTime? DOB { get; set; }
        public string? BLOOD_GROUP { get; set; }
        public int? CompanyId { get; set; }
        public decimal? DesignationId { get; set; }
        public decimal? TAX_AMOUNT { get; set; }
        public decimal? CP_AMOUNT { get; set; }
        public decimal? STAMP_AMOUNT { get; set; }
        public int? FloorId { get; set; }
        public int? LineId { get; set; }
        public bool? AttendanceCheck { get; set; }
        public string? Gender { get; set; }
        public string? Education { get; set; }
        public string? Grade { get; set; }
        public string? Section { get; set; }
        public decimal? MarketingAllowance { get; set; }
        public string? EID2 { get; set; }
        public bool? IsRosterWiseAttendance { get; set; }
        public string? EMP_ADDRES_PRESENT { get; set; }
    }
}

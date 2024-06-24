using Microsoft.EntityFrameworkCore;
using HR.Domain.Interface;
using HR.ApplicationLayer;
using HR.Domain.Models.Setup;
using MathNet.Numerics.LinearAlgebra;

namespace HR.Infastructure.Repository
{
    public class EmployeeSetupRepository : IEmployeeSetupRepository
    {
        private readonly IAppDbContext _connection;

        public EmployeeSetupRepository(IAppDbContext connection)
        {
            _connection = connection;
        }

        public async Task<EmployeeSetup> CreateAsync(EmployeeSetup employee)
        {
            await _connection.EmployeeSetups.AddAsync(employee);
            await _connection.SaveChangesAsync();
            return employee;
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<EmployeeSetup>> GetAllAsync()
        {
            var list = await _connection.EmployeeSetups.ToListAsync();
            return list;
        }

        public async Task<EmployeeSetup> GetByIdAsync(int id)
        {
            return await _connection.EmployeeSetups.FindAsync(id) ?? new EmployeeSetup();
        }

        public async Task<int> UpDateAsync(int id, EmployeeSetup model)
        {
          var existingData = await _connection.EmployeeSetups.FindAsync(id);
            if (existingData == null) { return 0; }

            existingData.EID = model.EID;
            existingData.CARD_NO = model.CARD_NO;
            existingData.JTID = model.JTID;
            existingData.PAYTYPE = model.PAYTYPE;
            existingData.GID = model.GID;
            existingData.BID = model.BID;
            existingData.DID = model.DID;
            existingData.NATIONAL_ID = model.NATIONAL_ID;
            existingData.EMP_NAME = model.EMP_NAME;
            existingData.FATHER_NAME = model.FATHER_NAME;
            existingData.MOTHER_NAME = model.MOTHER_NAME;
            existingData.SPOUSE_NAME = model.SPOUSE_NAME;
            existingData.PHONE_MOBILE = model.PHONE_MOBILE;
            existingData.EMAIL = model.EMAIL;
            existingData.JOIN_DATE = model.JOIN_DATE;
            existingData.EMP_ADDRES = model.EMP_ADDRES;
            existingData.COUNTRY = model.COUNTRY;
            existingData.DISTRICT = model.DISTRICT;
            existingData.IS_ACTIVE = model.IS_ACTIVE;
            existingData.DE_ACTIVE_DATE = model.DE_ACTIVE_DATE;
            existingData.ACC_CODE = model.ACC_CODE;
            existingData.BANK_ID = model.BANK_ID;
            existingData.GRADE_AMOUNT = model.GRADE_AMOUNT;
            existingData.PER_HOUR_RATE = model.PER_HOUR_RATE;
            existingData.CREATE_BY = model.CREATE_BY;
            existingData.CREATE_DATE = model.CREATE_DATE;
            existingData.UPDATE_BY = model.UPDATE_BY;
            existingData.UPDATE_DATE = model.UPDATE_DATE;
            existingData.IS_OT = model.IS_OT;
            existingData.OT_RATE = model.OT_RATE;
            existingData.DOB = model.DOB;
            existingData.BLOOD_GROUP = model.BLOOD_GROUP;
            existingData.CompanyId = model.CompanyId;
            existingData.DesignationId = model.DesignationId;
            existingData.TAX_AMOUNT = model.TAX_AMOUNT;
            existingData.CP_AMOUNT = model.CP_AMOUNT;
            existingData.STAMP_AMOUNT = model.STAMP_AMOUNT;
            existingData.FloorId = model.FloorId;
            existingData.LineId = model.LineId;
            existingData.AttendanceCheck = model.AttendanceCheck;
            existingData.Gender = model.Gender;
            existingData.Education = model.Education;
            existingData.Grade = model.Grade;
            existingData.Section = model.Section;
            existingData.MarketingAllowance = model.MarketingAllowance;
            existingData.EID2 = model.EID2;
            existingData.IsRosterWiseAttendance = model.IsRosterWiseAttendance;
            existingData.EMP_ADDRES_PRESENT = model.EMP_ADDRES_PRESENT;



            return 1;

        }
    }
}

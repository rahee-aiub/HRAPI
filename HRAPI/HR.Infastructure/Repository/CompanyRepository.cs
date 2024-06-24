using HR.ApplicationLayer;
using HR.Domain.Interface;
using HR.Domain.Models.Setup;
using HR.Infastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HR.Infastructure.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly IAppDbContext _connection;

        public CompanyRepository(IAppDbContext connection)
        {
            _connection = connection;
        }

        public async Task<Company> CreateAsync(Company model)
        {
            await _connection.Companys.AddAsync(model);
            await _connection.SaveChangesAsync();
            return model;
        }

        public async Task<int> DeleteAsync(int id)
        {
            var data = await _connection.Companys.FindAsync(id);
            if (data == null)
            {
                return 0; 
            }

            _connection.Companys.Remove(data);
            return await _connection.SaveChangesAsync();

       
        }

        public async Task<List<Company>> GetAllAsync()
        {
            var list = await _connection.Companys.ToListAsync();
            return list;
        }

        public async Task<Company> GetByIdAsync(int id)
        {
            var result =await _connection.Companys.FindAsync(id);
            return result?? new Company();
        }

        public async Task<int> UpDateAsync(int id, Company model)
        {
            var existingData = await _connection.Companys.FindAsync(id);
            if (existingData == null)
            {
                return 0;
            }
            existingData.CompanyName = model.CompanyName;
            existingData.CompanyAddress = model.CompanyAddress;
            existingData.CompanyPhone = model.CompanyPhone;
            existingData.LateDayCountForDeduction = model.LateDayCountForDeduction;
            existingData.LateDeductionOnGross = model.LateDeductionOnGross;
            existingData.CompanyAddress = model.CompanyAddress;
            existingData.UPDATE_BY = model.UPDATE_BY;
            existingData.UPDATE_DATE = model.UPDATE_DATE;


            _connection.Companys.Update(existingData);
            return await _connection.SaveChangesAsync();
        }
    }
}

using HR.ApplicationLayer;
using HR.Domain.Interface;
using HR.Domain.Models.Setup;
using HR.Infastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HR.Infastructure.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly IAppDbContext _connection;

        public DepartmentRepository(IAppDbContext connection)
        {
            _connection = connection;
        }

        public async Task<Department> CreateAsync(Department model)
        {
            await _connection.Departments.AddAsync(model);
            await _connection.SaveChangesAsync();
            return model;
        }

        public async Task<int> DeleteAsync(int id)
        {
            var data = await _connection.Departments.FindAsync(id);
            if (data == null)
            {
                return 0;
            }

             _connection.Departments.Remove(data);
            return await _connection.SaveChangesAsync();
        }

        public async Task<List<Department>> GetAllAsync()
        {
            var list = await _connection.Departments.ToListAsync();
            return list;
        }

        public async Task<Department> GetByIdAsync(int id)
        {
            return await _connection.Departments.FindAsync(id);
        }

        public async Task<int> UpDateAsync(int id, Department model)
        {
            var existingData = await _connection.Departments.FindAsync(id);

            if (existingData == null)
            {
                return 0;
            }          
            existingData.DEP_NAME = model.DEP_NAME;
            existingData.UPDATE_BY = model.UPDATE_BY;
            existingData.UPDATE_DATE = model.UPDATE_DATE;
            existingData.CompanyId = model.CompanyId;
            existingData.OrderNo = model.OrderNo;
            existingData.IS_SHOP = model.IS_SHOP;

            _connection.Departments.Update(existingData);
            return await _connection.SaveChangesAsync();
        }
    }
}

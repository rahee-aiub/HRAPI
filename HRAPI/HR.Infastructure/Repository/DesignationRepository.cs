using HR.ApplicationLayer;
using HR.Domain.Interface;
using HR.Domain.Models.Setup;
using Microsoft.EntityFrameworkCore;

namespace HR.Infastructure.Repository
{
    public class DesignationRepository : IDesignationRepository
    {
        private readonly IAppDbContext _connection;

        public DesignationRepository(IAppDbContext connection)
        {
            _connection = connection;
        }

        public async Task<Designation> CreateAsync(Designation model)
        {
            await _connection.Designations.AddAsync(model);
            await _connection.SaveChangesAsync();
            return model;
        }

        public async Task<int> DeleteAsync(int id)
        {
            var data = await _connection.Designations.FindAsync(id);
            if (data == null)
            {
                return 0;
            }

            _connection.Designations.Remove(data);
            return await _connection.SaveChangesAsync();
        }

        public async Task<List<Designation>> GetAllAsync()
        {
            var list = await _connection.Designations.ToListAsync();
            return list;
        }

        public async Task<Designation> GetByIdAsync(int id)
        {
            return await _connection.Designations.FindAsync(id) ?? new Designation();
        }

        public async Task<int> UpDateAsync(int id, Designation model)
        {
            var existingData = await _connection.Designations.FindAsync(id);
            if (existingData == null)
            {
                return 0; 
            }

            existingData.Rank = model.Rank;
            existingData.DesignationName = model.DesignationName;
            existingData.UPDATE_BY = model.UPDATE_BY;
            existingData.UPDATE_DATE = model.UPDATE_DATE;
          
            _connection.Designations.Update(existingData);
            return await _connection.SaveChangesAsync();
        }
    }
}

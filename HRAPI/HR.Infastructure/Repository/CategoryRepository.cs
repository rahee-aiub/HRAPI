using HR.ApplicationLayer;
using HR.Domain.Interface;
using HR.Domain.Models.Setup;
using HR.Infastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HR.Infastructure.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IAppDbContext _connection;

        public CategoryRepository(IAppDbContext connection)
        {
            _connection = connection;
        }

        public async Task<Category> CreateAsync(Category category)
        {
            await _connection.Categorys.AddAsync(category);
            await _connection.SaveChangesAsync();
            return category;
        }

        public async Task<int> DeleteAsync(int id)
        {
            var result = await _connection.Categorys.FirstOrDefaultAsync(e => e.CategoryId == id);

            if (result != null)
            {
                _connection.Categorys.Remove(result);
                await _connection.SaveChangesAsync();
                return 1;
            }

            return 0;

        }

        public async Task<List<Category>> GetAllAsync()
        {
            var list = await _connection.Categorys.ToListAsync();
            return list;
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            return await _connection.Categorys.FirstOrDefaultAsync(k=>k.CategoryId == id) ?? new Category() { };           
        }

        public async Task<int> UpDateAsync(int id, Category category)
        {
            var result = await _connection.Categorys.FirstOrDefaultAsync(e => e.CategoryId == category.CategoryId);

            if (result != null)
            {
                result.CategoryName = category.CategoryName;
              
                await _connection.SaveChangesAsync();

                return 1;
            }

            return 0;
        }
    }
}

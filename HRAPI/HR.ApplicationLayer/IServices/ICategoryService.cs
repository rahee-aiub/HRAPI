using HR.ApplicationLayer.Dtos;
using HR.Domain.Models;

namespace HR.ApplicationLayer.IServices
{
    public interface ICategoryService
    {
        Task<List<CategoryRequest>> GetAllAsync();
        Task<CategoryRequest> GetByIdAsync(int id);
        Task<CategoryRequest> CreateAsync(CategoryRequest category);
        Task<int> UpDateAsync(int id, CategoryRequest category);
        Task<int> DeleteAsync(int id);
    }
}

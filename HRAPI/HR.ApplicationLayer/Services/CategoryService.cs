using AutoMapper;
using HR.ApplicationLayer.Dtos;
using HR.ApplicationLayer.IServices;
using HR.Domain.Interface;
using HR.Domain.Models.Setup;

namespace HR.ApplicationLayer.Services
{
    public class CategoryService :ICategoryService
    {

        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<CategoryRequest> CreateAsync(CategoryRequest category)
        {
            return _mapper.Map<CategoryRequest>(await _repository.CreateAsync(_mapper.Map<Category>(category)));
        }
        public async Task<int> DeleteAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }
        public async Task<List<CategoryRequest>> GetAllAsync()
        {
            var result= await _repository.GetAllAsync();
            return _mapper.Map<List<CategoryRequest>>(result);
        }

        public async Task<CategoryRequest> GetByIdAsync(int id)
        {
            return _mapper.Map<CategoryRequest>(await _repository.GetByIdAsync(id));
        }

        public async Task<int> UpDateAsync(int id, CategoryRequest category)
        {
            return  await _repository.UpDateAsync(id, _mapper.Map<Category>(category));
        }
    }
}

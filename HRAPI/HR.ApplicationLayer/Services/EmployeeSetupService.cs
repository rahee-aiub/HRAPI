using AutoMapper;
using HR.ApplicationLayer.Dtos.Recruitment;
using HR.ApplicationLayer.Dtos.Setup;
using HR.ApplicationLayer.IServices;
using HR.Domain.Interface;
using HR.Domain.Models.Setup;

namespace HR.ApplicationLayer.Services
{
    public class EmployeeSetupService : IEmployeeService
    {

        private readonly IEmployeeSetupRepository _repository;
        private readonly IMapper _mapper;

        public EmployeeSetupService(IEmployeeSetupRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<EmployeeRequest> CreateAsync(EmployeeRequest employee)
        {
            return _mapper.Map<EmployeeRequest>(await _repository.CreateAsync(_mapper.Map<EmployeeSetup>(employee)));
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<List<EmployeeRequest>> GetAllAsync()
        {
            return _mapper.Map<List<EmployeeRequest>>( await _repository.GetAllAsync());
        }

        public async Task<EmployeeRequest> GetByIdAsync(int id)
        {
            return _mapper.Map<EmployeeRequest> (await _repository.GetByIdAsync(id));
        }

        public async Task<int> UpDateAsync(int id, EmployeeRequest employee)
        {
            return await _repository.UpDateAsync(id, _mapper.Map<EmployeeSetup>(employee));
        }
    }
}

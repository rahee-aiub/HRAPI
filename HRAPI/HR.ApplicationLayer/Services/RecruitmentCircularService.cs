using AutoMapper;
using HR.ApplicationLayer.Dtos;
using HR.ApplicationLayer.Dtos.Recruitment;
using HR.ApplicationLayer.IServices;
using HR.Domain.Interface;
using HR.Domain.Models.Recruitment;

namespace HR.ApplicationLayer.Services
{
    public class RecruitmentCircularService : IRecruitmentCircularService
    {

        private readonly IRecruitmentCircularRepository _repository;
        private readonly IMapper _mapper;
        public RecruitmentCircularService(IRecruitmentCircularRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<RecruitmentCircularRequest> CreateAsync(RecruitmentCircularRequest recruitmentcircular)
        {
            return _mapper.Map<RecruitmentCircularRequest>(await _repository.CreateAsync(_mapper.Map<RecruitmentCircular>(recruitmentcircular)));

        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<List<RecruitmentCircularRequest>> GetAllAsync()
        {
           
            var result = await _repository.GetAllAsync();
            return _mapper.Map<List<RecruitmentCircularRequest>>(result);
        }

        public async Task<RecruitmentCircularRequest> GetByIdAsync(int id)
        {
            return _mapper.Map<RecruitmentCircularRequest>(await _repository.GetByIdAsync(id));
        }

        public async Task<int> UpDateAsync(int id, RecruitmentCircularRequest recruitmentcircular)
        {
            return await _repository.UpDateAsync(id, _mapper.Map<RecruitmentCircular>(recruitmentcircular));
        }
    }
}

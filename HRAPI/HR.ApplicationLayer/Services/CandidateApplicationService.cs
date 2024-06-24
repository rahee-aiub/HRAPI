using AutoMapper;
using HR.ApplicationLayer.Dtos.Recruitment;
using HR.ApplicationLayer.IServices;
using HR.Domain.Interface;
using HR.Domain.Models.Recruitment;
using HR.Domain.Models.Setup;

namespace HR.ApplicationLayer.Services
{
    public class CandidateApplicationService : ICandidateApplicationService
    {

        private readonly ICandidateApplicationRepository _repository;
        private readonly IMapper _mapper;
        private readonly IRecruitmentCircularRepository _recruitmentCircularRepository;

        public CandidateApplicationService(ICandidateApplicationRepository repository, IMapper mapper , IRecruitmentCircularRepository RecruitmentCircular)
        {
            _repository = repository;
            _mapper = mapper;
            _recruitmentCircularRepository = RecruitmentCircular;
        }

        public async Task<CandidateApplicationRequest> CreateAsync(CandidateApplicationRequest CandidateApplication)
        {

            var recruitment = await _recruitmentCircularRepository.GetByIdAsync(CandidateApplication.RecruitmentCircularId);

            if (recruitment != null || recruitment.isActive.Value == 0)
            {
                throw new Exception("The Recruitment is not found or is not Active");
            
            }
                 
            return _mapper.Map<CandidateApplicationRequest>(await _repository.CreateAsync(_mapper.Map<CandidateApplication>(CandidateApplication)));
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<List<CandidateApplicationRequest>> GetAllAsync()
        {
           
            var result = await _repository.GetAllAsync();
            return _mapper.Map<List<CandidateApplicationRequest>>(result);
        }

        public async Task<CandidateApplicationRequest> GetByIdAsync(int id)
        {
            return _mapper.Map<CandidateApplicationRequest>(await _repository.GetByIdAsync(id));
        }

        public async Task<int> UpDateAsync(int id, CandidateApplicationRequest CandidateApplication)
        {
            return await _repository.UpDateAsync(id, _mapper.Map<CandidateApplication>(CandidateApplication));

        }
    }
}

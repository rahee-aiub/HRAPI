using AutoMapper;
using HR.ApplicationLayer.Dtos.Recruitment;
using HR.ApplicationLayer.IServices;
using HR.Domain.Interface;
using HR.Domain.Models.Recruitment;
using HR.Domain.Models.Setup;

namespace HR.ApplicationLayer.Services
{
    public class ShortlistedCandidateService : IShortlistedCandidateService
    {

        private readonly IShortlistedCandidateRepository _repository;
        private readonly IMapper _mapper;
        private readonly IRecruitmentCircularRepository _recruitmentCircularRepository;

        public ShortlistedCandidateService(IShortlistedCandidateRepository repository, IMapper mapper , IRecruitmentCircularRepository RecruitmentCircular)
        {
            _repository = repository;
            _mapper = mapper;
            _recruitmentCircularRepository = RecruitmentCircular;
        }

        public async Task<ShortlistedCandidateRequest> CreateAsync(ShortlistedCandidateRequest shortlistedCandidate)
        {

            var recruitment = await _recruitmentCircularRepository.GetByIdAsync(shortlistedCandidate.ApplicationId);

            if (recruitment != null || recruitment.isActive.Value == 0)
            {
                throw new Exception("The Application is not found or is not Active");
            
            }
                 
            return _mapper.Map<ShortlistedCandidateRequest>(await _repository.CreateAsync(_mapper.Map<ShortlistedCandidate>(shortlistedCandidate)));
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<List<ShortlistedCandidateRequest>> GetAllAsync()
        {
           
            var result = await _repository.GetAllAsync();
            return _mapper.Map<List<ShortlistedCandidateRequest>>(result);
        }

        public async Task<ShortlistedCandidateRequest> GetByIdAsync(int id)
        {
            return _mapper.Map<ShortlistedCandidateRequest>(await _repository.GetByIdAsync(id));
        }

        public async Task<int> UpDateAsync(int id, ShortlistedCandidateRequest shortListedCandidate)
        {
            return await _repository.UpDateAsync(id, _mapper.Map<ShortlistedCandidate>(shortListedCandidate));

        }
    }
}

using EmployeePerformanceTracker.Models;
using EmployeePerformanceTracker.Repository;

namespace EmployeePerformanceTracker.Services
{
    public class MentorService
    {
        IMentorRepository<Mentor> _repository;
        public MentorService(IMentorRepository<Mentor> repository)
        {
            _repository = repository;
        }

        #region getallmentors
        public async Task<IEnumerable<Mentor>> GetAll()
        {
            return await _repository.GetAll();
        }
        #endregion

        #region mentordetailsbyid
        public async Task<Mentor> GetMentorDetailsById(int id)
        {
            return await _repository.GetMentorDetailsById(id);
        }
        #endregion

        #region updatementordetails
        public async Task UpdateMentorDetails(Mentor entity)
        {
            await _repository.UpdateMentorDetails(entity);
        }
        #endregion

        #region Save

        public async Task Save()
        {
            await _repository.Save();
            //throw new NotImplementedException();
        }
        #endregion
    }
}

using EmployeePerformanceTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeePerformanceTracker.Repository
{
    public class MentorRepository:IMentorRepository<Mentor>
    {
        private readonly EPTDBContext _dbcontext;
        public MentorRepository(EPTDBContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        #region GetAllMentors
        public async Task<IEnumerable<Mentor>> GetAll()
        {
            try
            {
                return await _dbcontext.Mentors.ToListAsync();
            }
            catch
            {
                return Enumerable.Empty<Mentor>();
            }
        }
        #endregion

        #region GetMentorDetailsById

        public async Task<Mentor> GetMentorDetailsById(int id)
        {
            try
            {
                var mentor = await _dbcontext.Mentors.Where(m => m.Id == id).Select(m=> new Mentor()
                {
                    Id = m.Id,
                    MentorId=m.MentorId,
                    MentorName=m.MentorName,
                    EmailId=m.EmailId,
                    PhoneNo=m.PhoneNo,
                    Location=m.Location,
                    Password=m.Password

                }
                ).FirstOrDefaultAsync();
                return mentor;
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region UpdateMentorDetails
        public async Task<Mentor> UpdateMentorDetails(Mentor mentor)
        {
            try
            {
                var mentor1 = await _dbcontext.Mentors.FirstOrDefaultAsync(m => m.Id == mentor.Id);
                if (mentor != null)
                {
                    mentor1.Id=mentor.Id;
                    mentor1.MentorId=mentor.MentorId;
                    mentor1.MentorName = mentor.MentorName;
                    mentor1.EmailId=mentor.EmailId;
                    mentor1.PhoneNo=mentor.PhoneNo;
                    mentor1.Location=mentor.Location;
                    mentor1.Password=mentor.Password;
                }
                return mentor1;
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region save
        public async Task Save()
        {
            await _dbcontext.SaveChangesAsync();
        }
        #endregion
    }
}

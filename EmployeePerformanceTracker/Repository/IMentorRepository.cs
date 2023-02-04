namespace EmployeePerformanceTracker.Repository
{
    public interface IMentorRepository<T1> where T1 : class
    {
        #region Abstract Methods Declaration

        Task<IEnumerable<T1>> GetAll();
        Task<T1> GetMentorDetailsById(int id);
        Task<T1> UpdateMentorDetails(T1 entity);
         Task Save();
        #endregion

    }
}

using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class JobApplicationRepository : RepositoryBase<JobApplication>, IJobApplicationRepository
    {
        public void ApplyJob(JobApplication jobApp)
        {
            Create(jobApp);
        }

        //public void DeleteJobApp(JobApplication jobApp)
        //{
        //    Delete
        //}

        //public void EditJobApp(JobApplication jobApp)
        //{
        //    throw new NotImplementedException();
        //}

        public JobApplication GetJob(int id)
        {
            return GetAll().Where(p => p.JobId == id).FirstOrDefault();
        }

        public List<JobApplication> GetJobs()
        {
            return GetAll().ToList();
        }
    }
}

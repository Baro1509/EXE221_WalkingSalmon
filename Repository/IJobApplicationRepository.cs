using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IJobApplicationRepository
    {
        public List<JobApplication> GetJobs();
        public JobApplication GetJob(int id);
        public void ApplyJob(JobApplication jobApp);
       

    }
}

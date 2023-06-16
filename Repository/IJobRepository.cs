using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository {
    public interface IJobRepository {
        public List<Job> GetJobs();
        public Job GetJobById(int jobId);
        public void CreateJob(Job job);
        public void UpdateJob(Job job);
        public void DeleteJob(int jobId);
    }
}

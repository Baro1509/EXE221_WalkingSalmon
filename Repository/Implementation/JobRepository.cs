using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation {
    public class JobRepository : RepositoryBase<Job>, IJobRepository {
        public void CreateJob(Job job) {
            job.DateCreated = DateTime.Now;
            job.DateUpdated = DateTime.Now;
            job.JobStatus = 1;
            Create(job);
        }

        public void DeleteJob(int jobId) {
            Job db = GetJobById(jobId);
            if (db == null) {
                throw new Exception("Job not exist");
            }
            db.JobStatus = 0;
            db.DateUpdated = DateTime.Now;
            Update(db);
        }

        public Job GetJobById(int jobId) {
            return GetAll().Where(p => p.JobId == jobId && p.JobStatus != 0).Include(p => p.Category).Include(p => p.Employer).FirstOrDefault();
        }

        public List<Job> GetJobs() {
            return GetAll().Where(p => p.JobStatus != 0).Include(p => p.Category).Include(p => p.Employer).ToList();
        }
        
        public List<Job> GetJobsByEmployer(int id) {
            return GetAll().Where(p =>p.EmployerId == id && p.JobStatus != 0).Include(p => p.Category).Include(p => p.Employer).ToList();
        }

        public void UpdateJob(Job job) {
            Job db = GetJobById(job.JobId);
            if (db == null) {
                throw new Exception("Job not exist");
            }
            db.Title = job.Title;
            db.Description = job.Description;
            db.DateUpdated = DateTime.Now;
            db.WorkLocation = job.WorkLocation;
            db.WorkType = job.WorkType;
            db.SalaryRate = job.SalaryRate;
            db.SalaryType = job.SalaryType;
            db.CategoryId = job.CategoryId;
            db.JobStatus = job.JobStatus;
            Update(db);
        }
    }
}

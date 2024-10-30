using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Candidate_BusinessObjects;
using Candidate_Repository;

namespace Candidate_Services
{
    public class JobPostingService : IJobPostingService
    {
        private readonly IJobPostingRepo jobPostingRepo;

        public JobPostingService()
        {
            jobPostingRepo = new JobPostingRepo();
        }

        public JobPosting GetJobPostingById(string jobId)
        {
            return jobPostingRepo.GetJobPostingById(jobId);
        }

        public List<JobPosting> GetJobPostings()
        {
            return jobPostingRepo.GetJobPostings();
        }

        public bool AddJobPosting(JobPosting jobPosting)
        {
            return jobPostingRepo.AddJobPosting(jobPosting);
        }

        public bool DeleteJobPosting(JobPosting jobPosting)
        {
            return jobPostingRepo.DeleteJobPosting(jobPosting);
        }

        public bool UpdateJobPosting(JobPosting jobPosting)
        {
            return jobPostingRepo.UpdateJobPosting(jobPosting);
        }
    }
}

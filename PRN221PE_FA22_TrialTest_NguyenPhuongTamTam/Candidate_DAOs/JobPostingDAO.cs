using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Candidate_BusinessObjects;
using Candidate_DAO;
using Microsoft.EntityFrameworkCore;

namespace Candidate_DAOs
{
    public class JobPostingDAO
    {
        private CandidateManagementContext context;
        private static JobPostingDAO instance;

        public static JobPostingDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new JobPostingDAO();
                }
                return instance;
            }
        }

        public JobPostingDAO() 
        { 
            context = new CandidateManagementContext();
        }

        public JobPosting GetJobPostingByID(string jobID)
        {
            return context.JobPostings.SingleOrDefault(m => m.PostingId.Equals(jobID));
        }

        public List<JobPosting> GetJobPostings()
        {
            return context.JobPostings.ToList();
        }

        public bool AddJobPosting(JobPosting jobPosting)
        {
            bool isSuccess = false;
            JobPosting jobposting = this.GetJobPostingByID(jobPosting.PostingId);
            try
            {
                if (jobposting == null)
                {
                    context.JobPostings.Add(jobPosting);
                    context.SaveChanges();
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return isSuccess;
        }

        public bool DeleteJobPosting(JobPosting jobPosting)
        {
            bool isSuccess = false;
            JobPosting jobposting = this.GetJobPostingByID(jobPosting.PostingId);
            try
            {
                if (jobposting != null)
                {
                    context.JobPostings.Remove(jobPosting);
                    context.SaveChanges();
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return isSuccess;
        }

        public bool UpdateJobPosting(JobPosting jobPosting)
        {
            bool isSuccess = false;
            JobPosting jobposting = this.GetJobPostingByID(jobPosting.PostingId);
            try
            {
                if (jobposting != null)
                {
                    jobposting.JobPostingTitle = jobPosting.JobPostingTitle;
                    jobposting.Description = jobPosting?.Description;
                    jobposting.PostedDate = jobPosting?.PostedDate;

                    context.Entry<JobPosting>(jobposting).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return isSuccess;
        }
    }
}

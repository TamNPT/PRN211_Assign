using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Candidate_BusinessObjects;
using Candidate_Repository;

namespace Candidate_Services
{
    public class CandidateProfileService : ICandidateProfileService
    {
        private ICandidateProfileRepo candidateProfileRepo;

        public CandidateProfileService()
        {
            candidateProfileRepo = new CandidateProfileRepo();
        }
        public bool AddCandidateProfile(CandidateProfile candidateProfile)
        {
            return candidateProfileRepo.AddCandidateProfile(candidateProfile);
        }

        public bool DeleteCandidateProfile(CandidateProfile candidateProfile)
        {
            return candidateProfileRepo.DeleteCandidateProfile(candidateProfile);
        }

        public CandidateProfile GetCandidateProfileById(string id)
        {
            return candidateProfileRepo.GetCandidateProfileById(id);
        }

        public List<CandidateProfile> GetCandidateProfiles()
        {
            return candidateProfileRepo.GetCandidateProfiles();
        }

        public bool UpdateCandidateProfile(CandidateProfile candidateProfile)
        {
            return candidateProfileRepo.UpdateCandidateProfile(candidateProfile);
        }

        public List<CandidateProfile> SearchCandidateByName(string name)
        {
            return candidateProfileRepo.SearchCandidateByName(name);
        }
    }
}

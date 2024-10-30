﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Candidate_BusinessObjects;
using Candidate_DAOs;
using Candidate_Repository;

namespace Candidate_Services
{
    public class HRAccountService : IHRAccountService
    {
        private IHRAccountRepo iAccountRepo;
        public HRAccountService()
        {
            iAccountRepo = new HRAccountRepo();
        }
        public Hraccount GetHraccountByEmail(string email)
        {
            return iAccountRepo.GetHraccountByEmail(email);
        }

        public List<Hraccount> GetHraccounts()
        {
            return iAccountRepo.GetHraccounts();
        }
    }
}

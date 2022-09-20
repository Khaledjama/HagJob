using AutoMapper;
using Microsoft.Extensions.Logging;
using FirstApplication.DAL.GenaricRepo;
using FirstApplication.DB;
using FirstApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApplication.DAL.NonGenaric
{
    public class ApplyJobReprositry : GenericRepository<ApplyJobs>, IApplyJobReprositry
    {
        public ApplyJobReprositry(JobsContext context) : base(context)
        {
        }

        public IEnumerable<ApplyJobs> GetMyApplyJob(string UserId)
        {
            return _context.ApplyJobs.Where(s => s.UserId == UserId).ToList();
        }

        public bool StatuesApplyingJob(int idJob, string UserId)
        {
            if (_context.ApplyJobs.Where(s => s.jobsId == idJob && s.UserId == UserId).Count() != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

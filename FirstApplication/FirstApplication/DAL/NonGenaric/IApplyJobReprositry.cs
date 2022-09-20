using FirstApplication.DAL.GenaricRepo;
using FirstApplication.DB;
using FirstApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApplication.DAL.NonGenaric
{
    public interface IApplyJobReprositry : IGenericRepository<ApplyJobs>
    {
        IEnumerable<ApplyJobs> GetMyApplyJob(string UserId);
        bool StatuesApplyingJob(int idJob, string UserId);
    }
}

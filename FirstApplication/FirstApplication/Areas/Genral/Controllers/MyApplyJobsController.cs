using AutoMapper;
using FirstApplication.DAL.UniteOfWork;
using FirstApplication.DB;
using FirstApplication.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApplication.Areas.Genral.Controllers
{
    [Area("Genral")]
    public class MyApplyJobsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly JobsContext db;
        private readonly UserManager<ApplicationUser> _UserManager;
        private readonly ILogger<MyApplyJobsController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public MyApplyJobsController(
            ILogger<MyApplyJobsController> logger,
            IMapper map,
            JobsContext j,
            IUnitOfWork unitOfWork,
            UserManager<ApplicationUser> user)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
            this._mapper = map;
            this.db = j;
            this._UserManager = user;
        }
        public IActionResult MyJobApply()
        {
            var UserId = _UserManager.GetUserId(User);
            IEnumerable<ApplyJobs> MyApplyJobs = _unitOfWork.ApplyJobReprositryMethods.GetMyApplyJob(UserId);
            var Data = _mapper.Map<IEnumerable<ApplyJobs>, IEnumerable<ApplyJobVm>>(MyApplyJobs);
            return View(Data);
        }
        public IActionResult Cancel(int Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            var CurrentJob = _unitOfWork.ApplyJobReprositry.GetById(Id);
            if (CurrentJob == null)
            {
                return NotFound();
            }
            else
            {
                _unitOfWork.ApplyJobReprositry.Delete(Id);
                _unitOfWork.SaveChanges();
                return RedirectToAction("MyJobApply");
            }

        }
    }
}

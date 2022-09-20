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
    public class ApplyJobsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly JobsContext db;
        private readonly UserManager<ApplicationUser> _UserManager;
        private readonly ILogger<ApplyJobsController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public ApplyJobsController(
            ILogger<ApplyJobsController> logger,
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
        public IActionResult ViewJob()
        {
            return View();
        }
        public IActionResult Apply(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewBag.mm = _unitOfWork.QUestionsJobReprositry.GetById(id);
            var UserId = _UserManager.GetUserId(User);
            ViewBag.UserInfo = _unitOfWork.UserInformationReprositry.GetById(UserId);
            ViewBag.UserAdress = _unitOfWork.AdreesReprositry.GetById(UserId);
            return View();
        }
        public IActionResult ApplyToJob(ApplyJobVm applyJobVm, string idjob)
        {
            var userId = _UserManager.GetUserId(User);
            applyJobVm.UserId = userId;
            applyJobVm.jobsId = Convert.ToInt32(idjob);
            if (ModelState.IsValid)
            {
                var data = _mapper.Map<ApplyJobs>(applyJobVm);
                _unitOfWork.ApplyJobReprositry.Insert(data);
                _unitOfWork.SaveChanges();
                return RedirectToAction("Index", "Jobs", new { area = "Admin" });
            }
            return RedirectToAction("Apply", new { id = applyJobVm.jobsId });

        }
    }
}

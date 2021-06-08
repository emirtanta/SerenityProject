
using FluentValidation.Results;
using SerenityProject.BusinessLayer.Concrete;
using SerenityProject.BusinessLayer.ValidationRules;
using SerenityProject.DataAccessLayer.Concrete.EntityFramework;
using SerenityProject.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SerenityProje.WebUI.Controllers
{
    public class HomeController : Controller
    {
        MemberManager _memberManager = new MemberManager(new EfMemberDal());
        MemberValidator _memberValidator = new MemberValidator();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MemberList()
        {
            var memberValues = _memberManager.GetList();

            return View(memberValues);
        }

        [HttpGet]
        public ActionResult MemberCreate()
        {
            

            return View();
        }

        [HttpPost]
        public ActionResult MemberCreate(Member _member)
        {
            ValidationResult _results = _memberValidator.Validate(_member);

            if (_results.IsValid)
            {
                _memberManager.MemberInsert(_member);

                return RedirectToAction("MemberList");
            }

            else
            {
                foreach (var item in _results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }

        [HttpGet]
        public ActionResult MemberEdit(int id)
        {
            var _memberValue = _memberManager.GetByID(id);

            return View(_memberValue);
        }

        [HttpPost]
        public ActionResult MemberEdit(Member _member)
        {
            ValidationResult _results = _memberValidator.Validate(_member);

            if (_results.IsValid)
            {
                _memberManager.MemberUpdate(_member);

                return RedirectToAction("MemberList");
            }

            else
            {
                foreach (var item in _results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }

        public ActionResult MemberDelete(int id)
        {
            var _memberValue = _memberManager.GetByID(id);

            _memberManager.MemberDelete(_memberValue);

            return RedirectToAction("MemberList");
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
namespace MvcCv.Controllers
{
    public class DefaultController : Controller
    {
        DbCvEntities context = new DbCvEntities();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialExperience()
        {
            var values = context.TblExperıence.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialEducation()
        {
            var values = context.TblEducation.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialSkills()
        {
            var values = context.TblSkills.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialInteresets()
        {
            var values = context.TblInterests.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialAwards()
        {
            var values = context.TblCertificates.ToList();

            return PartialView(values);
        }
        public PartialViewResult PartialAbout()
        {
            var values = context.TblAbout.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        [HttpGet]
        public PartialViewResult PartialContact()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialContact(TblContact contact)
        {
            contact.Date = DateTime.Parse(DateTime.Now.ToShortTimeString());
            context.TblContact.Add(contact);
            context.SaveChanges();
            return PartialView();
        }
    }
}
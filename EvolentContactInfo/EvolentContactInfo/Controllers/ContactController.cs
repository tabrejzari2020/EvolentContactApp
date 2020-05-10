using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EvolentContactInfo.Models;
using EvolentContactInfo.Services;

namespace EvolentContactInfo.Controllers
{
    public class ContactController : Controller
    {
        private IContactService _iContactService;

        public ContactController(IContactService iContactService)   
        {
            _iContactService = iContactService;  
        }  

        public ActionResult Index()
        {            
            ViewBag.ContactData = _iContactService.GetAllContact();
            return View();
        }

        [HttpPost]
        public ActionResult AddContact(Contact con)
        {
            if (ModelState.IsValid)
            {
                ModelState.Clear();
                _iContactService.AddContact(con);                
            }

            return RedirectToAction("Index");
        }
        
        public PartialViewResult EditContact(int Id)
        {
            Contact con =  new Contact();
            con = _iContactService.GetContactById(Id);
            return PartialView("EditContact", con);
        }

        public ActionResult UpdateContact(Contact con)
        {
            if (ModelState.IsValid)
            {
                ModelState.Clear();
                _iContactService.UpdateContact(con);
            }

            return RedirectToAction("Index");
        }

        public ActionResult DeleteContact(int Id)
        {
            _iContactService.DeleteContact(Id);
            return RedirectToAction("Index");
        }
    }
}
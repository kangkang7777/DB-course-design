using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DBcoursedesign.Controllers
{
    public class SearchInfoController : Controller
    {
        private static List<Contact> contacts = new List<Contact>
    {
    };

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Find(string clientLocation = "", int distance=999999 )
        {
            var result = from contact in contacts
                         where (  string.IsNullOrEmpty(clientLocation) || contact.ClientLocation.ToLower().Contains( clientLocation.ToLower() ))
                             && ( distance == 999999 || contact.Distance<distance  )
                         orderby contact.Id
                         select contact;
            return View("ContactListPartial", result.ToArray());
        }

        public ActionResult Find2(/**/)
        {
            /*var result = from contact in contacts
                         where (string.IsNullOrEmpty(clientLocation) || contact.ClientLocation.ToLower().Contains(clientLocation.ToLower()))
                             && (distance == 999999 || contact.Distance < distance)
                         orderby contact.Id
                         select contact;*/
            return View("ContactListPartial2"/*, result.ToArray()*/);
        }

        [HttpGet]
        public ActionResult Update(string contactId)
        {
            Contact contact = contacts.First(c => c.Id == contactId);
            return View("ContactPartial", contact);
        }

        [HttpPost]
        public string Update(Contact contact)
        {
            contacts.Remove(contacts.First(c => c.Id == contact.Id));
            contacts.Add(contact);
            return "OK";
        }

        [HttpGet]
        public ActionResult Update2(string contactId)
        {
            Contact contact = contacts.First(c => c.Id == contactId);
            return View("ContactPartial2", contact);
        }

        [HttpPost]
        public string Update2(Contact contact)
        {
            contacts.Remove(contacts.First(c => c.Id == contact.Id));
            contacts.Add(contact);
            return "OK";
        }
    }
}

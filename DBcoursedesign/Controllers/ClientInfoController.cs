using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DBcoursedesign.Controllers
{
    public class ClientInfoController : Controller
    {
        // GET: ClientInfo
        public ActionResult PersonInformation()
        {
            return View();
        }

        public ActionResult SaveInfo(InfoContact et)
        {
            if (ModelState.IsValid)
            {
                ClientInfoController empbal = new ClientInfoController();
                empbal.SaveInfo(et);
                return RedirectToAction("PersonInformation");
            }
            else
            {
                return View("PersonInformation");
            }
        }
        public ActionResult SaveInfo()
        {
            InfoContact ev = new InfoContact();
            ev.ClientName = Request.Form["ClientName"];
            ev.sex = Request.Form["sex"];
            ev.age = Request.Form["age"];
            ev.IDNum = Request.Form["IDNum"];
            ev.ClientTel = Request.Form["ClientTel"];
            ev.ClientAddress = Request.Form["ClientAddress"];
            return RedirectToAction("PersonInformation");
        }
    }
}
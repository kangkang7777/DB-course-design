using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DBcoursedesign.Controllers
{
    public class HomeController : Controller
    {
 
        public ActionResult Index()
        {
            string user_name = Request["username"];
            Console.WriteLine(user_name);

            return View();
        }

        public ActionResult About()
        {
            //下面是数据传递的方法测试

            //////viewbag方法//////
            //后端到前端
            ViewBag.Message = "这里是viewbag方法的测试";


            //////viewbag方法//////

            //////viewdata方法//////
            //后端到前端
            ViewData["viewdata"] = "这里是viewdata方法的测试";

            //////viewdata方法//////
            
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Change()
        {
            ViewBag.name = Request["username"];
            return View("about");
        }
    }
}
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ServiceModel;
using WebApplication1.ServiceReference1;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        HelloServiceClient client = new HelloServiceClient();
        public ActionResult Index()
        {
            ViewBag.Message = client.getMessage();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
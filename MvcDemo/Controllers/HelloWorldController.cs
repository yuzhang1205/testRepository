using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/
        public ActionResult Index()
        {
            return View();
        }
        //public string Index()
        //{
        //    return "This is my <b>default</b> action...";
        //}
        public ActionResult Welcome(string name,int numTimes=1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;
            return View();
        }
        public string getbyid(int id)
        {
            if (id==1)
            {
                return "{\"result\":\"ok\"}";
            }
            else
            {
                return "{\"result\":\"No\"}";
            }
        }
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _60321_2_Severina.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["MyText"]= "Лабораторная работа";
            
            SelectList Colors = new SelectList(Enum.GetValues(typeof(System.Drawing.KnownColor)));
            ViewBag.Colors = Colors;
            ViewBag.MyText =Request.QueryString["Colors"]?? "Лабораторная работа";
            return View();
        }
    }
}
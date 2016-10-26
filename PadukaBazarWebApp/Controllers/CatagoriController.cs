using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PadukaBazarWebApp.Core.Manager;
using PadukaBazarWebApp.Models;

namespace PadukaBazarWebApp.Controllers
{
    public class CatagoriController : Controller
    {
        CatagoryManager catagoryManager= new CatagoryManager();
        [HttpGet]
        public ActionResult Save()
        {
             ViewBag.CatagoryList = catagoryManager.GetCatagoryList();
            return View();
        }
        [HttpPost]
        public ActionResult Save(Catagory catagory)
        {
            ViewBag.Message = catagoryManager.InsertCatagory(catagory);
            ViewBag.CatagoryList = catagoryManager.GetCatagoryList();
            return View();
        }
	}
}
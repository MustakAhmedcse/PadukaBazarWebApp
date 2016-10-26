using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PadukaBazarWebApp.Core.Manager;
using PadukaBazarWebApp.Models;

namespace PadukaBazarWebApp.Controllers
{
    public class SubCatagoriController : Controller
    {
        SubCatagoryManager subCatagoryManager= new SubCatagoryManager();
        CatagoryManager catagoryManager= new CatagoryManager();

        [HttpGet]
        public ActionResult Save()
        {
            ViewBag.SubCatagoryList = subCatagoryManager.GetSubCatagoryList();
            ViewBag.ListOfCatagori = catagoryManager.GetCatagoryList();
            return View();
        }
        [HttpPost]
        public ActionResult Save(SubCatagory subCatagory)
        {
            ViewBag.SubCatagoryList = subCatagoryManager.GetSubCatagoryList();
            ViewBag.ListOfCatagori = catagoryManager.GetCatagoryList();
            ViewBag.Message = subCatagoryManager.InsertSubCatagory(subCatagory);
            return View();
        }
	}
}
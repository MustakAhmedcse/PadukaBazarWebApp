using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PadukaBazarWebApp.Core.Manager;
using PadukaBazarWebApp.Models;

namespace PadukaBazarWebApp.Controllers
{
    public class ItemController : Controller
    {
        ItemManager itemManager= new ItemManager();
        CatagoryManager catagoryManager= new CatagoryManager();
        SubCatagoryManager subCatagoryManager= new SubCatagoryManager();
        [HttpGet]
        public ActionResult SaveItem()
        {
            ViewBag.ListOfCatagori = catagoryManager.GetCatagoryList();
            ViewBag.ListOfSubCatagori = subCatagoryManager.GetSubCatagoryList();
            return View();
        }
        [HttpPost]
        public ActionResult SaveItem(Item item)
        {
            ViewBag.Message= itemManager.InsertItem(item);
            ViewBag.ListOfCatagori = catagoryManager.GetCatagoryList();
            ViewBag.ListOfSubCatagori = subCatagoryManager.GetSubCatagoryList();
            return View();
        }

	}
}
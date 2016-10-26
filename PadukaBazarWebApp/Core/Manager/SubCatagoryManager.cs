using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PadukaBazarWebApp.Core.Gateway;
using PadukaBazarWebApp.Models;

namespace PadukaBazarWebApp.Core.Manager
{
    public class SubCatagoryManager
    {
        SubCatagoryGateway subCatagoryGateway=new SubCatagoryGateway();
        public string InsertSubCatagory(SubCatagory subCatagory)
        {
            int rowAffected = subCatagoryGateway.InsertSubCatagory(subCatagory);
            if (rowAffected != 0)
            {
                return "Save Successfull,";
            }
            else
            {
                return "Sory! Save Fail.";
            }

        }

        public List<SubCatagory> GetSubCatagoryList()
        {
            return subCatagoryGateway.GetSubCatagoryList();
        }
    }
}
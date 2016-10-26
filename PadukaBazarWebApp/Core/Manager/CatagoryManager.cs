using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PadukaBazarWebApp.Core.Gateway;
using PadukaBazarWebApp.Models;

namespace PadukaBazarWebApp.Core.Manager
{
    public class CatagoryManager
    {
        CatagoryGateway catagoryGateway = new CatagoryGateway();

        public string InsertCatagory(Catagory catagory)
        {
            int rowAffected = catagoryGateway.InsertCatagory(catagory);
            if (rowAffected != 0)
            {
                return "Save Successfull,";
            }
            else
            {
                return "Sory! Save Fail.";
            }

        }

        public List<Catagory> GetCatagoryList()
        {
            return catagoryGateway.GetCatagoryList();
        }
    }
}
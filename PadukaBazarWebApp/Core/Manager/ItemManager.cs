using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PadukaBazarWebApp.Core.Gateway;
using PadukaBazarWebApp.Models;

namespace PadukaBazarWebApp.Core.Manager
{
    public class ItemManager
    {
        ItemGateway itemGateway= new ItemGateway();
        public string InsertItem(Item item)
        {
            int rowAffaced = itemGateway.InsertItem(item);
            if (rowAffaced!=0)
            {
                return "Save Successfull.";
            }
            else
            {
                return "Sory! Save Fail.";
            }

        }

        public List<Item> GetItemList()
        {
            return itemGateway.GetItemList();
        }
    }
}
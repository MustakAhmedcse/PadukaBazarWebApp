using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace PadukaBazarWebApp.Models
{
    public class Item
    {
        public int Id { get; set; }
        public int CatagoryId  { get; set; }
        public int SubCatagoryId  { get; set; }
        public string ItemName  { get; set; }
        public string ItemDiscrption  { get; set; }
        public string ItemColour  { get; set; }
        public string ItemBrand  { get; set; }
        public int BuyPrice { get; set; }
        public int SellPrice { get; set; }
       // public DateTime DateTime { get; set; }
        
        
    }
}
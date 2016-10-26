using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PadukaBazarWebApp.Models
{
    public class Item
    {
        public int Id { get; set; }
        public int CatagoriId  { get; set; }
        public int SubCatagoriId  { get; set; }
        public int ItemName  { get; set; }
        public int ItemDiscrption  { get; set; }
        public int ItemColour  { get; set; }
        public int ItemBrand  { get; set; }
        public int ByePrice { get; set; }
        public int SellPrice { get; set; }
        
        
    }
}
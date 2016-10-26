using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PadukaBazarWebApp.Models
{
    public class SubCatagory
    {
        public int Id { get; set; }
        public string SubCatagoryName { get; set; }
        public int CatagoryId { get; set; }
        
    }
}
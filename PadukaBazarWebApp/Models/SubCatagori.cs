using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PadukaBazarWebApp.Models
{
    public class SubCatagori
    {
        public int Id { get; set; }
        public string SubCatagoriName { get; set; }
        public int CatagoriId { get; set; }
        
    }
}
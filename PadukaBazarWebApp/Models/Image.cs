using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PadukaBazarWebApp.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public int IemId { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PadukaBazarWebApp.Core.Gateway;
using PadukaBazarWebApp.Models;

namespace PadukaBazarWebApp.Core.Manager
{
    public class ImageManager
    {
        ImageGateway imageGateway = new ImageGateway();

        public string InsertItem(Image image)
        {
            int rowAffaced = imageGateway.InsertImage(image);
            if (rowAffaced != 0)
            {
                return "Save Successfull.";
            }
            else
            {
                return "Sory! Save Fail.";
            }

        }
        
    }
}
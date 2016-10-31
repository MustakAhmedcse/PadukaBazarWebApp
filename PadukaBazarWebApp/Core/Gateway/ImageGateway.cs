using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PadukaBazarWebApp.Models;

namespace PadukaBazarWebApp.Core.Gateway
{
    public class ImageGateway : Gateway
    {
        public int InsertImage(Image image)
        {
            Query = "NSERT INTO Image VALUES('" + image.ImagePath + "'," + image.IemId + ")";
            Command.CommandText = Query;
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public List<Image> GetImageList()
        {
            List<Image> images = new List<Image>();
            Query = "SELECT * FROM Image";
            Command.CommandText = Query;
            Connection.Open();
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                Image image = new Image();
                image.Id = Convert.ToInt32(Reader["Id"]);
                image.ImagePath = Reader["ImagePath"].ToString();
                image.IemId = Convert.ToInt32(Reader["ItemId"]);

                images.Add(image);
            }
            Reader.Close();
            Connection.Close();
            return images;
        }
    }
}
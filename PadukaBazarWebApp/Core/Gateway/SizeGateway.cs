using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PadukaBazarWebApp.Models;
namespace PadukaBazarWebApp.Core.Gateway
{
    public class SizeGateway:Gateway
    {

        public int  InsertSize(Size size)
        {
            Query = "insert into Size values('"+size.ItemId+"','"+size.ItemSize+"','"+size.Quentity+"')";
            Command.CommandText = Query;
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }
        public List<Size> GetSizeList()
        {
            List<Size> sizes = new List<Size>();
            while (Reader.Read())
            {
                Size size = new Size();
                size.Id = Convert.ToInt32(Reader["Id"]);
                size.ItemSize = Convert.ToInt32(Reader["ItemSize"]);
                size.Quentity = Convert.ToInt32(Reader["Quentity"]);
                size.ItemId = Convert.ToInt32(Reader["ItemId"]);
                size.Add(size);
            }
            Reader.Close();
            Connection.Close();
            return sizes;
        }
    }
}

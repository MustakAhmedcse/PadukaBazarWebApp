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



        public List<Size> GetAllSize()
        {

            List<Size> sizes = new List<Size>();






            return sizes;
        }


    }
}
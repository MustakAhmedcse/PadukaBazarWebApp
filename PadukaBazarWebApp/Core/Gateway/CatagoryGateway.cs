using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PadukaBazarWebApp.Models;

namespace PadukaBazarWebApp.Core.Gateway
{
    public class CatagoryGateway:Gateway
    {
        public int InsertCatagory(Catagory catagory)
        {
            Query = "INSERT INTO Catagory VALUES('"+catagory.CatagoryName+"') ";
            Command.CommandText = Query;
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public List<Catagory> GetCatagoryList()
        {
            List<Catagory> catagories = new List<Catagory>();
            Query = "SELECT * FROM Catagory";
            Command.CommandText = Query;
            Connection.Open();
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                Catagory catagory=new Catagory();
                catagory.Id = Convert.ToInt32(Reader["Id"]);
                catagory.CatagoryName = Reader["CatagoryName"].ToString();
               catagories.Add(catagory);
            }

            Reader.Close();
            Connection.Close();
            return catagories;
        }

    }
}
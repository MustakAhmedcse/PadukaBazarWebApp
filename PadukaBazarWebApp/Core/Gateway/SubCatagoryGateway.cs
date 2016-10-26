using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PadukaBazarWebApp.Models;

namespace PadukaBazarWebApp.Core.Gateway
{
    public class SubCatagoryGateway:Gateway
    {
        public int InsertSubCatagory(SubCatagory subCatagory)
        {
            Query = "INSERT INTO SubCatagory VALUES('" + subCatagory.SubCatagoryName + "',"+subCatagory.CatagoryId+") ";
            Command.CommandText = Query;
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public List<SubCatagory> GetSubCatagoryList()
        {
            List<SubCatagory> subCatagories = new List<SubCatagory>();
            Query = "SELECT * FROM SubCatagory";
            Command.CommandText = Query;
            Connection.Open();
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                SubCatagory subCatagory = new SubCatagory();
                subCatagory.Id = Convert.ToInt32(Reader["Id"]);
                subCatagory.SubCatagoryName = Reader["SubCatagoryName"].ToString();
                subCatagory.CatagoryId = Convert.ToInt32(Reader["CatagoryId"]);
                subCatagories.Add(subCatagory);
            }

            Reader.Close();
            Connection.Close();
            return subCatagories;
        }

    }
}
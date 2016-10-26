using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PadukaBazarWebApp.Models;

namespace PadukaBazarWebApp.Core.Gateway
{
    public class ItemGateway:Gateway
    {
        public int InsertItem(Item item)
        {
            Query = "INSERT INTO Item VALUES(" + item.CatagoryId + "," + item.SubCatagoryId + ",'"+item.ItemName+"'," +
                    "'"+item.ItemDiscrption+"','"+item.ItemColour+"','"+item.ItemBrand+"',"+item.BuyPrice+","+item.SellPrice+") ";
            Command.CommandText = Query;
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }
        public List<Item> GetItemList()
        {
            List<Item> items = new List<Item>();
            Query = "SELECT * FROM Item";
            Command.CommandText = Query;
            Connection.Open();
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                Item item = new Item();
                item.Id = Convert.ToInt32(Reader["Id"]);
                item.CatagoryId = Convert.ToInt32(Reader["CatagoryId"]);
                item.SubCatagoryId = Convert.ToInt32(Reader["SubCatagoryId"]);
                item.ItemName = Reader["ItemName"].ToString();
                item.ItemDiscrption = Reader["ItemName"].ToString();
                item.ItemColour = Reader["ItemName"].ToString();
                item.ItemBrand = Reader["ItemName"].ToString();
                item.BuyPrice = Convert.ToInt32(Reader["ItemName"]);
                item.SellPrice = Convert.ToInt32(Reader["ItemName"]);

                items.Add(item);
            }

            Reader.Close();
            Connection.Close();
            return items;
        }
    }
}
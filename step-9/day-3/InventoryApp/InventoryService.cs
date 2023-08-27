using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using InventoryApp.Models;
using System.Data;

namespace InventoryApp
{
    public class InventoryService
    {
        private SQLiteConnection dbConnection;

        public InventoryService()
        {
            dbConnection = new SQLiteConnection("Data Source=inventory.db;Version=3;");
        }

        public DataSet GetInventoryItems()
        {
            dbConnection.Open();
            
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM inventory", dbConnection);
            DataSet ds = new DataSet();
            da.Fill(ds, "inventory");

            dbConnection.Close();

            return ds;
        }

        public int SaveItem(SaveItemRequest requestModel)
        {
            var query = "";
            if(requestModel.Id != null)
            {
                query = "UPDATE inventory SET product_id=@productId, insert_date=@insertDate, product_name=@productName, price=@price, quantity=@quantity WHERE product_id=@productId";
            }
            else
            {
                query = "INSERT INTO inventory(insert_date, product_name, price, quantity) VALUES(@insertDate, @productName, @price, @quantity)";
            }

            int res = -1;

            try
            {
                dbConnection.Open();

                using (SQLiteCommand cmd = new SQLiteCommand(query, dbConnection))
                {
                    cmd.Parameters.AddWithValue("@productId", requestModel.Id);
                    
                    cmd.Parameters.AddWithValue("@insertDate", requestModel.InsertDate);
                    cmd.Parameters.AddWithValue("@productName", requestModel.ProductName);
                    cmd.Parameters.AddWithValue("@price", requestModel.Price);
                    cmd.Parameters.AddWithValue("@quantity", requestModel.Quantity);

                    res = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                res = -1;
            }
            finally
            {
                dbConnection.Close();
            }

            return res;
        }

        public int DeleteItem(int id)
        {
            int res = -1;
            var query = "DELETE FROM inventory WHERE product_id=@productId";

            try
            {
                dbConnection.Open();

                using (SQLiteCommand cmd = new SQLiteCommand(query, dbConnection))
                {
                    cmd.Parameters.AddWithValue("@productId", id);

                    res = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                res = -1;
            }
            finally
            {
                dbConnection.Close();
            }

            return res;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using InventoryApp.Models;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class EasyInventory : Form
    {
        private InventoryService _inventoryService = new InventoryService(); 
        public EasyInventory()
        {
            InitializeComponent();
        }

        private void EasyInventory_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            var ds = _inventoryService.GetInventoryItems();
            inventoryDataGrid.DataSource = ds.Tables["inventory"];
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveItemRequest requestModel = new SaveItemRequest()
            {
                Id = string.IsNullOrWhiteSpace(idTxtBox.Text) ? null : int.Parse(idTxtBox.Text),
                InsertDate = insertDatePicker.Value.ToString(),
                ProductName = productNameTxtBox.Text,
                Price = Convert.ToDecimal(priceTxtBox.Text),
                Quantity = int.Parse(quantityTxtBox.Text),
            };

            var res = _inventoryService.SaveItem(requestModel);

            if(res > 0)
            {
                ClearInputs();
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("ERROR!");
            }
        }
        private void ClearInputs()
        {
            idTxtBox.Text = "";
            insertDatePicker.Value = DateTime.Now;
            productNameTxtBox.Text = "";
            priceTxtBox.Text = "";
            quantityTxtBox.Text = "";
        }

        private void inventoryDataGrid_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected || inventoryDataGrid.SelectedRows.Count < 1)
            {
                ClearInputs();
                saveBtn.Text = "ADD";
                deleteBtn.Visible = false;
                return;
            }

            saveBtn.Text = "UPDATE";
            deleteBtn.Visible = true;

            DataGridViewRow selectedRow = inventoryDataGrid.SelectedRows[0];
            idTxtBox.Text = selectedRow.Cells["product_id"].Value.ToString();
            insertDatePicker.Value = Convert.ToDateTime(selectedRow.Cells["insert_date"].Value);
            productNameTxtBox.Text = selectedRow.Cells["product_name"].Value.ToString();
            priceTxtBox.Text = selectedRow.Cells["price"].Value.ToString();
            quantityTxtBox.Text = selectedRow.Cells["quantity"].Value.ToString();
        }

        private void inventoryDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < inventoryDataGrid.Rows.Count)
            {
                inventoryDataGrid.Rows[e.RowIndex].Selected = false;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var res = _inventoryService.DeleteItem(int.Parse(idTxtBox.Text));

            if (res > 0)
            {
                ClearInputs();
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("ERROR!");
            }
        }
    }
}

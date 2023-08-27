using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeForm
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeView employeeView = new EmployeeView();
            employeeView.Show();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            EmployeeInfo employee = new EmployeeInfo()
            {
                Name = nameTxtBox.Text,
                DateOfEmployment = doePicker.Text,
                Department = departmentCombo.SelectedItem.ToString(),
                Role = roleCombo.SelectedItem.ToString(),
            };

            int res = employee.CreateEmployee(employee);

            if(res > 0)
            {
                MessageBox.Show("Saved Successfully!");
            }
            else
            {
                MessageBox.Show("Error Occured");
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            EmployeeInfo employee = new EmployeeInfo()
            {
                Id = int.Parse(idTxtBox.Text),
                Name = nameTxtBox.Text,
                DateOfEmployment = doePicker.Text,
                Department = departmentCombo.SelectedItem.ToString(),
                Role = roleCombo.SelectedItem.ToString(),
            };

            int res = employee.UpdateEmployee(employee);

            if (res > 0)
            {
                MessageBox.Show("Updated Successfully!");
            }
            else
            {
                MessageBox.Show("Error Occured");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            EmployeeInfo employee = new EmployeeInfo();
            int res = employee.DeleteEmployee(int.Parse(this.deleteIdTxtBox.Text));

            if (res > 0)
            {
                MessageBox.Show("Deleted Successfully!");
            }
            else
            {
                MessageBox.Show("Error Occured");
            }
        }
    }
}

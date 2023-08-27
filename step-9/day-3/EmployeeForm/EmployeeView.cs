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
    public partial class EmployeeView : Form
    {
        public EmployeeView()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();
        EmployeeInfo employeeService = new EmployeeInfo();

        private void EmployeeView_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            ds = employeeService.GetEmployees();
            dataGridView1.DataSource = ds.Tables["employees"];
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            GetData();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;

namespace EntityFrameworkApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee()
                {
                    Name = "Robert",
                    DateOfEmployment = DateTime.Now.ToString(),
                    Department = "Mechanical",
                    Role = "HOD"
                };

                using (DatabaseContext context = new DatabaseContext())
                {
                    context.Employees.Add(employee);
                    context.SaveChangesAsync();

                    LoadGridView();
                    MessageBox.Show("Created successfully!");
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            LoadGridView();
        }

        private void LoadGridView()
        {
            List<Employee> employees = new List<Employee>();

            using (DatabaseContext context = new DatabaseContext())
            {
                employees = context.Employees.ToList();
            }

            dbGridView.DataSource = employees;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (dbGridView.SelectedRows.Count > 0)
            {
                var id = (int)dbGridView.SelectedRows[0].Cells[0].Value;

                try
                {
                    using (DatabaseContext context = new DatabaseContext())
                    {
                        var employee = context.Employees.Where(x => x.Id == id).FirstOrDefault();

                        employee.Name = (string)dbGridView.SelectedRows[0].Cells[1].Value;
                        employee.Department = (string)dbGridView.SelectedRows[0].Cells[3].Value;
                        employee.Role = (string)dbGridView.SelectedRows[0].Cells[4].Value;

                        if (employee != null)
                        {
                            context.Entry(employee).State = EntityState.Modified;
                            context.SaveChanges();
                            MessageBox.Show("Record updated successfully!");
                            LoadGridView();
                        }
                        else
                        {
                            MessageBox.Show("Couldn't find the record in db!");
                        }
                    }
                }
                catch (Exception exp)
                {

                }
            }
            else
            {
                MessageBox.Show("Any record selected!");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if(dbGridView.SelectedRows.Count > 0)
            {
                var id = (int)dbGridView.SelectedRows[0].Cells[0].Value;

                try
                {
                    using (DatabaseContext context = new DatabaseContext())
                    {
                        var employee = context.Employees.Where(x => x.Id == id).FirstOrDefault();
                        if (employee != null)
                        {
                            context.Employees.Remove(employee);
                            context.SaveChanges();

                            LoadGridView();
                        }
                        else
                        {
                            MessageBox.Show("Couldn't find the record in db!");
                        }
                    }
                }
                catch (Exception exp)
                {

                }
            }
            else
            {
                MessageBox.Show("Any record selected!");
            }
        }

        private void readExcelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = "C:\\Users\\icgili\\Documents\\ctrl+future\\elev8-course\\step-9\\day-5\\sources\\employeeSource.xlsx";
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                
            }
            catch (Exception ex)
            {

            }
        }
    }
}

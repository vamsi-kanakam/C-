using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week13Tutorials
{
    public partial class EmployeeForm : Form
    {
        private List<Employee> employees;
        public EmployeeForm()
        {
            InitializeComponent();
            employees = new List<Employee>();
        }

        /*
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            DateTime birthday = new DateTime(1999, 5, 1);
            Employee spongebob = new Employee("Spongbob",birthday,10.5m,"Burgerflipper");
            lblEmployee.Text = spongebob.ToString();
        }
        */
        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            DateTime birthday = dtpBirthday.Value;
            string title = txtJobTitle.Text;
            decimal hourlyRate = Decimal.Parse(txtHourlyPay.Text);
            Employee employee;
            if (lstEmployee.SelectedIndex >= 0)
            {
                employee = (Employee)lstEmployee.SelectedItem;
                employee.Name = name;
                employee.Birthday = birthday;
                employee.JobTitle = title;
                employee.HourlySalary = hourlyRate;
            }
            else
            {
                employee = new Employee(name, birthday, hourlyRate, title);
                employees.Add(employee);
            }
            lstEmployee.Items.Clear();
            lstEmployee.Items.AddRange(employees.ToArray());
        }
    }
}

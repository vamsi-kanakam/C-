using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week13Tutorials
{
    internal class Employee
    {
        //private string name;
        public string Name { get; set; }
        //private DateTime birthday;
        public DateTime Birthday { get; set; }
        //private decimal hourlySalary;
        public decimal HourlySalary { get; set; }
        //private string jobTitle;
        public string JobTitle { get; set; }
        private decimal taxRate;
        public decimal TaxRate { get { return taxRate; } }
        public Employee(string name,DateTime birthday,decimal hourlySalary,string jobTitle)
        {
            this.Name = name;
            this.Birthday = birthday;
            this.HourlySalary = hourlySalary;
            this.JobTitle = jobTitle;
            taxRate = 0.25m;
        }

        public override string ToString()
        {
            return string.Format("Name:{0},Birthday:{1:d}, Hourly Salary: {2:c},Job Title: {3}", Name, Birthday, HourlySalary, JobTitle);
        }
    }
}

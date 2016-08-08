using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;


namespace ASPMVCdemo.Models
{
    public class Employee
    {
        [Key]
        public int E_id { get; set; }
        public string E_name { get; set; }
        public string E_code { get; set; }
        public double E_salary { get; set; }

    }

    public class Employee_context:DbContext
    {
        public DbSet<Employee> Employee_set { get; set; }
    }
}
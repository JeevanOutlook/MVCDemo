using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;
using System.Web.DynamicData;

namespace MVCDemo.Models
{
    [Table("tblDepartment")]
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
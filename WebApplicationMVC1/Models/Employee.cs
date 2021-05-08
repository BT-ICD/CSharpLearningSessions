using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMVC1.Models
{
    public class Employee
    {
        [DisplayName("Employee Id")]
        public int Id { get; set; }
        [DisplayName("Name")]
        public string Name { get; set; }
        [DisplayName("Gender")]
        public string Gender { get; set; }

        [DisplayName("Is Active")]
        public bool IsActive { get; set; }

        public bool IsNew { get; set; }
        //public DepartmentEnum Department { get; set; }
        public int Department { get; set; }

        public string Designation { get; set; }

        public string Suffix { get; set; }
        public string[] Roles { get; set; }

        public static List<SelectListItem> GetRoles()
        {
            List<SelectListItem> items = new List<SelectListItem>() {
            new SelectListItem("Admin","501"),
            new SelectListItem("Super Admin","601"),
            new SelectListItem("Network Admin","701"),
        };
            return items;
        }
    }
   
}

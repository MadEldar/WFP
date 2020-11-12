using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResourcesManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DOB { get; set; }
        public string Department { get; set; }
        public string Address { get; set; }
    }
}

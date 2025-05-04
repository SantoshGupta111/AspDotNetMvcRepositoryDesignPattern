using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Users
{
    public class EmployeeDTO:DTOBase
    {
       // [Range(1, int.MaxValue, ErrorMessage = "Please select a valid ID")]
        public int Id { get; set; } = Int_NullValue;

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }=String_NullValue;

        [Required(ErrorMessage = "Gender is required")]
        public string Gender { get; set; } = String_NullValue;

        [Required(ErrorMessage = "Department is required")]
        public string Department { get; set; } = String_NullValue;
    }
}

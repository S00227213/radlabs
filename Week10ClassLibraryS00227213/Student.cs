using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Student
    {
        [Key]
        public string? StudentID { get; set; }
        public string? FirstName { get; set; }

        public string? SecondName { get; set; }

        [Column(TypeName = "date")]
        [DataType(DataType.Date)] //Implements HTML5 Date picker
        public DateTime? RegistrationDate { get; set; }
    }
}

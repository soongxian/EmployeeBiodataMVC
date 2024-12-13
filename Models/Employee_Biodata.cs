using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EmployeeBiodataMVC.Models
{
    public class Employee_Biodata
    {
        [Key]
        [Column(TypeName = "VARCHAR(10)")]
        public string employee_no { get; set; }
        [Column(TypeName = "VARCHAR(60)")]
        public string employee_name { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime birth_date { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace ptmlql200.Models.Entities
{
    public class Employee : Person
    {
        [Key]
        public string EmployeeID { get; set; }
        public string CongTy { get; set; }
    }
}
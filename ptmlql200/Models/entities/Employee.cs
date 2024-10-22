using System.ComponentModel.DataAnnotations;

namespace ptpmql200.Models.entities
{
    public class Employee : Person
    {
    
        public string EmployeeID { get; set; } 
        public string CongTy { get; set; } 
    }
}

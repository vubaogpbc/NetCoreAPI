using System.Security.AccessControl;
using System.ComponentModel.DataAnnotations;
namespace ptpmql200.Models.entities
{
    public class Person
    {
        public int Id { get; set; }
        public string FullName { get; set; } 
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; } 
    }
}
using System.ComponentModel.DataAnnotations;
namespace ptpmql200.Models{
    public class Person {
        [Key]
        public string   PersonId  {get;set;}
        public string   FullName{get;set;}
    }
}
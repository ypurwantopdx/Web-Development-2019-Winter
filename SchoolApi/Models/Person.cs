using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolApi.Models
{
    [Table("Person")] public class Person
    {
        public int PersonId {get;set;}
        public string FirstName {get;set;}
        [Column("MiddelInitial")]
        public string MiddleInitial {get;set;}
        public string LastName {get;set;}
        public DateTime DateOfBirth {get;set;} 
    }
}
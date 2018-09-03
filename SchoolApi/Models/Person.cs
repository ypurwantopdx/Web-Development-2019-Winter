using System;
using System.ComponentModel.DataAnnotations.Schema;
using SchoolApi.Models;

namespace SchoolApi.Models
{
    [Table("Person")] public class Person
    {
        [ForeignKey("Person")]
        public int PersonId {get;set;}

        public string FirstName {get;set;}

        [Column("MiddelInitial")]
        public string MiddleInitial {get;set;}

        public string LastName {get;set;}

        public DateTime DateOfBirth {get;set;}

        public virtual Student Student { get ; set;}
    }
}
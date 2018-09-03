using System.ComponentModel.DataAnnotations.Schema;
using SchoolApi.Models;

public class Student
{

    [ForeignKey("Person")]
    public int StudentId { get; set; }
    public string Email { get; set; }
    public virtual Person Person { get ; set;}
}
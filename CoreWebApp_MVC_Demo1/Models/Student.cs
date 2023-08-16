

using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreWebApp_MVC_Demo1.Models
{
    [Table("Student")]
    public class Student
    {
        //private static List<Student> data = new List<Student>() {
        //        new Student(){Id=101,SName="Manan", Semester=1, Hobby="Music"},
        //        new Student(){Id=102,SName="Rajesh", Semester=3, Hobby="Sports"}
        //    };
        public decimal Id { get; set; }
        public string SName { get; set; }
        public decimal Semester { get; set; }
        public String Hobby { get; set; }

        public override string ToString()
        {
            return JsonConvert.ToString(this);
        }

        //public static List<Student> GetData()
        //{
        //    return data;
        //}
    }
}

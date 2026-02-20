using System.ComponentModel.DataAnnotations;

namespace HW1_SCD.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required(ErrorMessage ="Name is Required")]
        public string Name { get; set; }


        [Required(ErrorMessage ="Email is Required")]
        [EmailAddress(ErrorMessage ="Invalid Email Format")]
        public string Email { get; set; }



        [Required(ErrorMessage = "Department is Required")]

        public string Department { get; set; }



        [Range(0,4,ErrorMessage = "CGPA must be between 0 and 4")]
        public double cgpa { get; set; }



    }
}

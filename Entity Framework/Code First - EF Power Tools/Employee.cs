using System;
using System.ComponentModel.DataAnnotations;

namespace Code_First___EF_Power_Tools
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime  BirthDate { get; set; }

        public Department Department { get; set; }
        [Required]
        public int DepartmentId { get; set; }
    }
}
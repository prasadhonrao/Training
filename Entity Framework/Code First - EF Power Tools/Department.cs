using System.ComponentModel.DataAnnotations;

namespace Code_First___EF_Power_Tools
{
    public class Department
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
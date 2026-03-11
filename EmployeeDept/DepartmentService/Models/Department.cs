using System.ComponentModel.DataAnnotations;

namespace DepartmentService.Models
{
    public class Department
    {
        [Key]
        public int DeptNo { get; set; }
        public string DeptName { get; set; }
        public string Location { get; set; }

    }
}

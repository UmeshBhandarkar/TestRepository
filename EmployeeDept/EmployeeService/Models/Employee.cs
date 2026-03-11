using System.ComponentModel.DataAnnotations;

namespace EmployeeService.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string City { get; set; }
        public int  Salary { get; set; }
        public int DeptNo { get; set; }
    }
}

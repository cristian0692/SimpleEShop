namespace EShopSystem.Models
{
    public class Employee
    {

        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeMobile { get; set; }
        public string EmployeeEmail { get; set; }
        public int DepartamentId { get; set; }
        public virtual Departament Departament { get; set; }

    }
}
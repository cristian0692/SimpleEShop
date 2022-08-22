using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EShopSystem.Models
{
    public class Departament
    {

        public int DepartamentId { get; set; }
        public string DepartamentName { get; set; }
        public bool DepartamentIsActtive { get; set; }
        public  ICollection<Employee> Employees { get; set; }
    }
}
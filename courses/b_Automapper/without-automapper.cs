// The following example, copy the data from one object to another object in the traditional approach i.e. without using the C# automapper.

namespace AutoMapperDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Name = "James";
            emp.Salary = 20000;
            emp.Address = "London";
            emp.Department = "IT";

            EmployeeDTO empDTO = new EmployeeDTO();
            empDTO.Name = emp.Name;
            empDTO.Salary = emp.Salary;
            empDTO.Address = emp.Address;
            empDTO.Department = emp.Department;

            Console.WriteLine("Name:" + empDTO.Name + ", Salary:" + empDTO.Salary + ", Address:" + empDTO.Address + ", Department:"+ empDTO.Department);
            Console.ReadLine();
        }
    }
    
    public class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
    }
    
    public class EmployeeDTO
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
    }
}


using Linq2;

class Program
{
    static void Main(string[] args)
    {
        
        /*List<Employee> employeeList = Data.GetEmployees();

        var filteredEmployees = employeeList.Where(e => e.IsManager == true);

        foreach (var employee in filteredEmployees)
        {
            Console.WriteLine($"First Name: {employee.FirstName}");
            Console.WriteLine($"Last Name: {employee.LastName}");
            Console.WriteLine($"Annual Salary: {employee.AnnualSalary}");
            Console.WriteLine($"Manager: {employee.IsManager}");
            Console.WriteLine();
        }

        Console.ReadKey();*/

        List<Department> departmentList = Data.GetDepartments();

        var filterDepartments = departmentList.Where(dept => dept.Id > 1);

        foreach (var department in filterDepartments)
        {
            Console.WriteLine($"Id: {department.Id}");
            Console.WriteLine($"Short Name: {department.ShortName}");
            Console.WriteLine($"Long Name: {department.LongName}");
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}
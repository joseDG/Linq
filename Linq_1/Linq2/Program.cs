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

        Console.ReadKey();

        List<Department> departmentList = Data.GetDepartments();

        var filterDepartments = departmentList.Where(dept => dept.Id > 1);

        foreach (var department in filterDepartments)
        {
            Console.WriteLine($"Id: {department.Id}");
            Console.WriteLine($"Short Name: {department.ShortName}");
            Console.WriteLine($"Long Name: {department.LongName}");
            Console.WriteLine();
        }*/

        List<Employee> employeeList = Data.GetEmployees();
        List<Department> departmentList = Data.GetDepartments();

        var resultList = from emp in employeeList
                         join dept in departmentList
                         on emp.DepartmentId equals dept.Id
                         select new
                         {
                             FirstName = emp.FirstName,
                             LastName = emp.LastName,
                             AnnualSalary = emp.AnnualSalary,
                             Manager = emp.IsManager,
                             Department = dept.LongName,
                         };

        foreach (var employee in resultList)
        {
            Console.WriteLine($"First Name: {employee.FirstName}");
            Console.WriteLine($"Last Name: {employee.LastName}");
            Console.WriteLine($"Annual Salary: {employee.AnnualSalary}");
            Console.WriteLine($"Manager: {employee.Manager}");
            Console.WriteLine($"Department: {employee.Department}");
            Console.WriteLine();
        }

        var averageAnnualSalary = resultList.Average(a => a.AnnualSalary);
        var highestAnnualSalary = resultList.Max(a => a.AnnualSalary);
        var lowewtAnnualSalary = resultList.Min(a => a.AnnualSalary);

        Console.WriteLine($"Average Anual Salary: {averageAnnualSalary}");
        Console.WriteLine($"Highest Anual Salary: {highestAnnualSalary}");
        Console.WriteLine($"Lowest Annual Salary: {lowewtAnnualSalary}");


        Console.ReadKey();


    }
}
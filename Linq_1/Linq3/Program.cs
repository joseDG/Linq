using Linq3;

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employeesList = Data.GetEmployees();
        List<Department> departmentsList = Data.GetDepartments();

        //Select and Where Operators - Method Syntaxis
        //var results = employeesList.Select(e => new
        //{
        //    FullName = e.FirstName + "" + e.LastName,
        //    AnnualSalary = e.AnnualSalary,
        //}).Where(e => e.AnnualSalary >= 50000);

        //foreach(var item in results)
        //{
        //    Console.WriteLine($"{item.FullName, -20} {item.AnnualSalary, 10}");
        //}

        //Select and Where Operators - Query Syntaxis
        //var results = from emp in employeesList
        //              where emp.AnnualSalary >= 50000
        //              select new
        //              {
        //                  FullName = emp.FirstName + " " + emp.LastName,
        //                  AnnualSalary = emp.AnnualSalary
        //              };

        //foreach (var item in results)
        //{
        //   Console.WriteLine($"{item.FullName, -20} {item.AnnualSalary, 10}");
        //}

        //Deferred(Carga Perezosa) Execution Example
        //var results = from emp in employeesList.GetHighSalariedEmployees()
        //              select new
        //              {
        //                  FullName = emp.FirstName + " " + emp.LastName,
        //                  AnnualSalary = emp.AnnualSalary
        //              };

        //employeesList.Add(new Employee
        //{
        //    Id = 5,
        //    FirstName = "Sam",
        //    LastName = "Davis",
        //    AnnualSalary = 100000.20m,
        //    IsManager = true,
        //    DepartmentId = 2

        //});

        //foreach (var item in results)
        //{
        //    Console.WriteLine($"{item.FullName,-20} {item.AnnualSalary,10}");
        //}

        ////Immediate Execution Example
        //var results = (from emp in employeesList.GetHighSalariedEmployees()
        //               select new
        //               {
        //                   FullName = emp.FirstName + " " + emp.LastName,
        //                   AnnualSalary = emp.AnnualSalary
        //               }).ToList();

        //employeesList.Add(new Employee
        //{
        //    Id = 5,
        //    FirstName = "Sam",
        //    LastName = "Davis",
        //    AnnualSalary = 100000.20m,
        //    IsManager = true,
        //    DepartmentId = 2

        //});

        //foreach (var item in results)
        //{
        //    Console.WriteLine($"{item.FullName,-20} {item.AnnualSalary,10}");
        //}

        Console.ReadKey();
    }

}

public static class EnumerableCollectionExtensionMethods
{
    public static IEnumerable<Employee> GetHighSalariedEmployees(this IEnumerable<Employee> employees)
    {
        foreach (Employee emp in employees)
        {

            Console.WriteLine($"Accessing employee: {emp.FirstName + " " + emp.LastName}");

            if (emp.AnnualSalary >= 50000)
                yield return emp;
        }
    }
}
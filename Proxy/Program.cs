using Proxy.Models;
using Proxy.Proxies;

var allPrivileges = (int[]) Enum.GetValues(typeof(Privileges));

var admin = new Employee("Elvis", "King", allPrivileges);
var employee1 = new Employee("Michael", "Yeeyee", (int) Privileges.Create, (int) Privileges.Read);
var employee2 = new Employee("Marshall", "Slimshadyson", (int) Privileges.Update);

var proxy = new SalaryManagerProxy(admin);

proxy.CreateSalary(admin.EmployeeId, 200_000);
proxy.CreateSalary(employee1.EmployeeId, 150_000);
proxy.CreateSalary(employee2.EmployeeId, 100_000);
proxy.UpdateSalary(employee2.EmployeeId, 120_000);
foreach (var salary in proxy.ReadSalaries()) Console.WriteLine(salary);

proxy.ChangeEmployee(employee1);

// this will throw an exception because the proxy
// pass the user from a validation before runs the method
proxy.DeleteSalary(admin.EmployeeId);
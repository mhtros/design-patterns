using Proxy.Models;
using Proxy.Services;

namespace Proxy.Proxies;

public class SalaryManagerProxy : ISalaryManager
{
    private readonly SalaryManager _salaryManager = new();
    private Employee _employee;

    public SalaryManagerProxy(Employee employee)
    {
        _employee = employee;
    }

    public void CreateSalary(Guid userGuid, decimal salary)
    {
        if (_employee.Privileges.Contains((int) Privileges.Create)) _salaryManager.CreateSalary(userGuid, salary);
        else throw new UnauthorizedAccessException("Not authorized to create salaries");
    }

    public IEnumerable<string> ReadSalaries()
    {
        if (_employee.Privileges.Contains((int) Privileges.ReadAll)) return _salaryManager.ReadSalaries();
        throw new UnauthorizedAccessException("Not authorized to view all salaries");
    }

    public string ReadSalary(Guid userGuid)
    {
        if (_employee.Privileges.Contains((int) Privileges.Read)) return _salaryManager.ReadSalary(userGuid);
        throw new UnauthorizedAccessException("Not authorized to view salaries");
    }

    public void UpdateSalary(Guid userGuid, decimal newSalary)
    {
        if (_employee.Privileges.Contains((int) Privileges.Update)) _salaryManager.UpdateSalary(userGuid, newSalary);
        else throw new UnauthorizedAccessException("Not authorized to update salaries");
    }

    public void DeleteSalary(Guid userGuid)
    {
        if (_employee.Privileges.Contains((int) Privileges.Delete)) _salaryManager.DeleteSalary(userGuid);
        else throw new UnauthorizedAccessException("Not authorized to delete salaries");
    }

    public void ChangeEmployee(Employee employee)
    {
        _employee = employee;
    }
}
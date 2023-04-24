namespace Proxy.Services;

public interface ISalaryManager
{
    void CreateSalary(Guid userGuid, decimal salary);
    IEnumerable<string> ReadSalaries();
    string ReadSalary(Guid userGuid);
    void UpdateSalary(Guid userGuid, decimal newSalary);
    void DeleteSalary(Guid userGuid);
}
namespace Proxy.Services;

public class SalaryManager : ISalaryManager
{
    private readonly Dictionary<Guid, decimal> _salaries = new();

    public void CreateSalary(Guid userGuid, decimal salary)
    {
        var exists = _salaries.ContainsKey(userGuid);
        if (exists) throw new ApplicationException("User already exists.");
        _salaries.Add(userGuid, salary);
    }

    public IEnumerable<string> ReadSalaries()
    {
        return _salaries.Select(keypair => $"{keypair.Key}: {keypair.Value:N}");
    }

    public string ReadSalary(Guid userGuid)
    {
        var exists = _salaries.ContainsKey(userGuid);
        if (exists is false) throw new ApplicationException("User not exists.");
        return $"{userGuid}: {_salaries[userGuid]:N}";
    }

    public void UpdateSalary(Guid userGuid, decimal newSalary)
    {
        var exists = _salaries.ContainsKey(userGuid);
        if (exists is false) throw new ApplicationException("User not exists.");
        _salaries[userGuid] = newSalary;
    }

    public void DeleteSalary(Guid userGuid)
    {
        var exists = _salaries.ContainsKey(userGuid);
        if (exists is false) throw new ApplicationException("User not exists.");
        _salaries.Remove(userGuid);
    }
}
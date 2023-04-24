namespace Proxy.Models;

public class Employee
{
    public Employee(string firstName, string lastName, params int[] privileges)
    {
        EmployeeId = Guid.NewGuid();
        FirstName = firstName;
        LastName = lastName;
        Privileges = privileges;
    }

    public Guid EmployeeId { get; }
    public string FirstName { get; }
    public string LastName { get; }
    public int[] Privileges { get; }
}
using System.Text.Json;

namespace Prototype.Prototypes;

public class Student : Person
{
    public Student()
    {
    }

    private Student(Student source) : base(source)
    {
        StudentCode = source.StudentCode;
    }

    public Guid StudentCode { get; set; }

    public override object Clone()
    {
        return new Student(this);
    }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}
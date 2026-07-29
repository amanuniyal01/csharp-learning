// Exercise 2.1 — Basic hierarchy
// Create an abstract base class Employee with Name, BaseSalary, and an abstract method CalculateSalary(). Create two subclasses:

// Manager — CalculateSalary() returns BaseSalary + 10000 bonus
// Developer — CalculateSalary() returns BaseSalary + (500 * ProjectsCompleted) (add a ProjectsCompleted property)


public abstract class Employee
{
    public string Name;
    public decimal BaseSalary;

    public Employee(
        string n,
        decimal s)
    {
        Name = n;
        BaseSalary = s;

    }
    public abstract decimal CalculateSalary();
}

public class Manager : Employee
{
    public Manager(string name, decimal baseSalary) : base(name, baseSalary)
    {
    }

    public override decimal CalculateSalary()
    {
        return BaseSalary + 10000;
    }
}

public class Developer : Employee
{
    public int ProjectsCompleted { get; set; }

    public Developer(string name, decimal baseSalary, int projectsCompleted) : base(name, baseSalary)
    {
        ProjectsCompleted = projectsCompleted;
    }

    public override decimal CalculateSalary()
    {
        return BaseSalary + (500 * ProjectsCompleted);
    }
}
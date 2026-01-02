partial class Program
{
    static void EmployeeExcercise()
    {
        List<Employee> employees =
        [
            new TeamLeader("Carlos", "Team Leader", 5000),
            new TeamLeader("Ana", "Developer", 4000),
            new TeamLeader("Laura", "Team Leader", 6000),
            new TeamLeader("Luis", "Developer", 3500),
        ];

        foreach (var employee in employees)
        {
            employee.ShowInfo();
            WriteLine();
        }
    }
}

class Employee
{
    protected string? Name;
    protected string? JobPosition;
    protected double Salary;

    public Employee(string name, string jobPosition, double salary)
    {
        Name = name;
        JobPosition = jobPosition;
        Salary = salary;
    }

    public virtual double CalculateBonus()
    {
        double bonus = Salary * 0.05;

        return bonus;
    }

    public void ShowInfo()
    {
        WriteLine($"- Nombre: {Name}\n- Cargo: {JobPosition}\n- Salario: {Salary}\n- Bono Calculado: {CalculateBonus()}");
    }
}

class TeamLeader : Employee
{
    public TeamLeader(string name, string jobPosition, double salary) : base(name, jobPosition, salary) { }

    public override double CalculateBonus()
    {
        double bonus = Salary * 0.1;

        return bonus;
    }
}

class Developer : Employee
{
    public Developer(string name, string jobPosition, double salary) : base(name, jobPosition, salary) { }

    public override double CalculateBonus()
    {
        double bonus = Salary * 0.07;

        return bonus;
    }
}
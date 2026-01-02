partial class Program
{
    static void EmployeeExcercise()
    {
        List<Employee> employees =
        [
            new TeamLeader("Carlos", "Team Leader", 5000),
            new Developer("Ana", "Developer", 4000),
            new TeamLeader("Laura", "Team Leader", 6000),
            new Developer("Luis", "Developer", 3500),
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
    protected string? Name { get; set; }
    protected string? Position { get; set; }
    protected double Salary { get; set; }

    public Employee(string name, string position, double salary)
    {
        Name = name;
        Position = position;
        Salary = salary;
    }

    public virtual double CalculateBonus()
    {
        return Salary * 0.05;
    }

    public void ShowInfo()
    {
        WriteLine($"- Nombre: {Name}\n- Cargo: {Position}\n- Salario: {Salary:C}\n- Bono Calculado: {CalculateBonus():C}");
    }
}

class TeamLeader : Employee
{
    public TeamLeader(string name, string position, double salary) : base(name, position, salary) { }

    public override double CalculateBonus()
    {
        return Salary * 0.1;
    }
}

class Developer : Employee
{
    public Developer(string name, string position, double salary) : base(name, position, salary) { }

    public override double CalculateBonus()
    {
        return Salary * 0.07;
    }
}
using ConsoleApp1;

Employee employee1 = new Employee("Mieszko", "Pierwszy", 33);
Employee employee2 = new Employee("Bolesław", "Drugi", 46);
Employee employee3 = new Employee("Jan", "Trzeci", 27);

employee1.AddScore(15);
employee1.AddScore(4);
employee1.AddScore(29);
employee1.AddScore(21);
employee1.AddScore(2);

employee2.AddScore(18);
employee2.AddScore(1);
employee2.AddScore(9);
employee2.AddScore(26);
employee2.AddScore(13);

employee3.AddScore(6);
employee3.AddScore(21);
employee3.AddScore(16);
employee3.AddScore(3);
employee3.AddScore(17);

Console.WriteLine(employee1.Name + " " + employee1.Surname + ": " + employee1.Result);
Console.WriteLine(employee2.Name + " " + employee2.Surname + ": " + employee2.Result);
Console.WriteLine(employee3.Name + " " + employee3.Surname + ": " + employee3.Result);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int theBestResult = -1;
Employee theBestEmployee = default;

foreach (Employee employee in employees)
{
    if (employee.Result > theBestResult)
    {
        theBestResult = employee.Result;
        theBestEmployee = employee;
    }
}
Console.WriteLine("...czyli najlepszy jest:\n" + theBestEmployee.Name + " " + theBestEmployee.Surname + " z wynikiem: " + theBestEmployee.Result);


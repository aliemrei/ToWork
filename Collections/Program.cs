// See https://aka.ms/new-console-template for more information
using Collections;
using Collections.CustomComparers;

Console.WriteLine("Hello, World!");

#region Create some employee instance
var emp1 = new Employee { Id = 5, Name = "John", Job = "Manager", Salary = 9000 };
var emp2 = new Employee { Id = 2, Name = "Mary", Job = "Accountant", Salary = 5500 };
var emp3 = new Employee { Id = 6, Name = "Joe", Job = "Team Leader", Salary = 6000 };
var emp4 = new Employee { Id = 3, Name = "Frank", Job = "Programmer", Salary = 5000 };
var emp5 = new Employee { Id = 9, Name = "Andre", Job = "CEO", Salary = 12000 };

#endregion

#region Custom Enumerator Sample
Organization organization = new Organization();

organization.Add(emp1);
organization.Add(emp2);
organization.Add(emp3);
organization.Add(emp4);
organization.Add(emp5);

foreach (Employee employee in organization)
{
    Console.WriteLine(employee.Id + " " + employee.Name + " " + employee.Job + " " + employee.Salary);
}

Console.WriteLine();

#endregion


#region List sorting routines samples
List<Employee> employees = new List<Employee>();
employees.Add(emp1);
employees.Add(emp2);
employees.Add(emp3);
employees.Add(emp4);
employees.Add(emp5);


Console.WriteLine("--- Sorted by default comparer of Employee class ---");
employees.Sort();

foreach (Employee employee in employees)
{
    Console.WriteLine(employee.Id + " " + employee.Name + " " + employee.Job + " " + employee.Salary);
}
Console.WriteLine();


Console.WriteLine("--- Sorted by lambda expression ---");
employees.Sort((a,b) => a.Name.CompareTo(b.Name));

foreach (Employee employee in employees)
{
    Console.WriteLine(employee.Id + " " + employee.Name + " " + employee.Job + " " + employee.Salary);
}
Console.WriteLine();

Console.WriteLine("--- Sorted by delegate function ---");
employees.Sort(delegate(Employee a, Employee b)
{
    if (a.Salary > b.Salary)
        return 1;
    else if (a.Salary < b.Salary)
        return -1;

    return 0;
});

foreach (Employee employee in employees)
{
    Console.WriteLine(employee.Id + " " + employee.Name + " " + employee.Job + " " + employee.Salary);
}
Console.WriteLine();


Console.WriteLine("--- Sorted by custom comparer ---");

var comparer = new EmployeeComparer();
employees.Sort(comparer);

foreach (Employee employee in employees)
{
    Console.WriteLine(employee.Id + " " + employee.Name + " " + employee.Job + " " + employee.Salary);
}
Console.WriteLine();

#endregion

Console.ReadLine();
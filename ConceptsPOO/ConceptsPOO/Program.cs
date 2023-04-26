using ConceptsPOO;

Console.WriteLine("POO CONCEPTS");
Console.WriteLine("============");

Employee employee1 = new SalaryEmployee()
{
    Id = 1010,
    FirstName = "Sergio",
    LastName = "Latorre",
    BirthDate = new Date(1987, 6, 12),
    HiringDate = new Date(2010, 5, 4),
    IsActive = true,
    Salary = 2290000.45M
};

//Console.WriteLine(employee1);

Employee employee2 = new CommissionEmployee()
{
    Id = 1020,
    FirstName = "David",
    LastName = "Latorre",
    BirthDate = new Date(1988, 5, 7),
    HiringDate = new Date(2020, 5, 4),
    IsActive = true,
    Sales = 320000000M,
    CommissionPercentaje = 0.03F
};

//Console.WriteLine(employee2);

Employee employee3 = new HourlyEmployee()
{
    Id = 1030,
    FirstName = "Jose",
    LastName = "Latorre",
    BirthDate = new Date(1988, 5, 7),
    HiringDate = new Date(2020, 5, 4),
    IsActive = true,
    HourValue = 15320.50M,
    Hours = 123.5F
};

//Console.WriteLine(employee3);

Employee employee4 = new BaseCommissionEmployee()
{
    Id = 1040,
    FirstName = "Jasmín",
    LastName = "Salazar",
    BirthDate = new Date(1989, 5, 7),
    HiringDate = new Date(2018, 12, 4),
    IsActive = true,
    Base = 1160000.50M,
    Sales = 58000000M,
    CommissionPercentaje = 0.015F
};

//Console.WriteLine(employee4);

//Creamos una lista de empleados, a través de una interfaz.

ICollection<Employee> employees = new List<Employee>()
{ 
    employee1, employee2, employee3, employee4 //Es similar a Employee.add(employee1)...
};

decimal payroll = 0;
foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();
}

Console.WriteLine("                                =================");
Console.WriteLine($"TOTAL                          {$"{payroll:C2}",18}");

Invoice invoice = new Invoice()
{
    Description = "Iphone 13",
    Id = 1,
    Price = 5300000M,
    Quantity = 6
};

Invoice invoice2 = new Invoice()
{
    Description = "Posta Premium",
    Id = 2,
    Price = 32000M,
    Quantity = 17.5F
};

Console.WriteLine(invoice);
Console.WriteLine(invoice2);
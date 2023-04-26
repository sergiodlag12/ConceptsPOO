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

Console.WriteLine(employee1);

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

Console.WriteLine(employee2);

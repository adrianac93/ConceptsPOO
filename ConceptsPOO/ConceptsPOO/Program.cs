using ConceptsPOO;

Console.WriteLine("POO Concepts");
Console.WriteLine("============");
Employee employee1 = new SalaryEmployee()
{
    Id = 1010, 
    FirstName = "Sandra", 
    LastName = "Morales",
    Birthdate = new Date(1990, 5, 23),
    Hiringdate = new Date(2021, 3, 10),
    IsActive = true,
    Salary = 1000.00M
};
Console.WriteLine(employee1);
Employee employee2 = new CommissionEmployee()
{     
    Id = 2020,
    FirstName = "Patricia",
    LastName = "Gutierrez",
    Birthdate = new Date(1995, 5, 23),
    Hiringdate = new Date(2021, 2, 5),
    IsActive = true,
    Sales = 20000M,
    CommissionPercentaje = 0.06F
};
Console.WriteLine(employee2);
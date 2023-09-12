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
//Console.WriteLine(employee1);

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
//Console.WriteLine(employee2);

Employee employee3 = new HourlyEmployee()
{
    Id = 3030,
    FirstName = "Gonzalo",
    LastName = "Cardona",
    Birthdate = new Date(1985, 5, 23),
    Hiringdate = new Date(2021, 2, 5),
    IsActive = true,
    HourValue = 5000.56M,
    Hours = 124.4F
};
//Console.WriteLine(employee3);

Employee employee4 = new BaseCommissionEmployee()
{
    Id = 4040,
    FirstName = "Jazmin",
    LastName = "Salazar",
    Birthdate = new Date(1988, 4, 23),
    Hiringdate = new Date(2020, 1, 6),
    IsActive = true,
    Base = 5500.88M,
    Sales = 10000M,
    CommissionPercentaje = 0.018F
};
//Console.WriteLine(employee4);

ICollection<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3, employee4
};

decimal payroll = 0;
foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();
}
Console.WriteLine("                     ==================");
Console.WriteLine($"TOTAL                 {$"{payroll:C2}",18}");

Invoice invoice1 = new Invoice()
{
    Description = "iPhone 13",
    Id = 1,
    Price = 2000M,
    Quantity = 6
};
Invoice invoice2 = new Invoice()
{
    Description = "Posta Premium",
    Id = 3,
    Price = 2500M,
    Quantity = 12F
};
Console.WriteLine(invoice1);
Console.WriteLine(invoice2);
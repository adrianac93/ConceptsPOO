

using ConceptsPOO;

Console.WriteLine("POO Concepts");
Console.WriteLine("============");
try
{
	Console.WriteLine(new Date(2024, 2, 29));
	Console.WriteLine(new Date(2009, 9, 23));
	Console.WriteLine(new Date(2008, 11, 31));

}
catch (Exception error)
{
    Console.WriteLine(error.Message);
}
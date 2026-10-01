using ConsoleApp1;

List<Persona> personas = new List<Persona>
{
    new Persona("Juan", 28, true),
    new Persona("Ana", 30, false),
    new Persona("Luis", 22, false),
    new Desarrollador("Kevin", 25, true, "C#"),
    new Desarrollador("Marta", 35, true, "JavaScript")
};

var personasEmpleadas = personas.Count(p => p.EstaEmpleado);

var nombresNoEmpleadosAsc = personas
    .Where(p => !p.EstaEmpleado)
    .OrderBy(p => p.Nombre)
    .Select(p => p.Nombre)
    .ToList();

Console.WriteLine($"Numero de personas empleadas: {personasEmpleadas}");

Console.WriteLine("Nombres de personas no empleadas por orden alfabetico:");
foreach (var nombreEmpleado in nombresNoEmpleadosAsc)
{
    Console.WriteLine($"{nombreEmpleado}");
}




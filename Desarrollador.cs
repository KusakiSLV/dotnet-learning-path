
namespace ConsoleApp1
{
    public class Desarrollador : Persona, IPresentable
    {
        public string LenguajePrincipal { get; set; }

        public Desarrollador(string nombre, int edad, bool estaEmpleado, string lenguajePrincipal)
            : base(nombre, edad, estaEmpleado)
        {
            LenguajePrincipal = lenguajePrincipal;
        }

        public override string Presentarse()
        {
            return base.Presentarse() + $" Programa principalmente en {LenguajePrincipal}.";
        }
    }
}


namespace R19_E01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Programador pepe = new Programador();
            pepe.Nombre = "Pepe";
            pepe.Apellidos = "Alcazar";
            pepe.Salario = 1500;

            ProgramadorJunior yo = new ProgramadorJunior();
            yo.Nombre = "Tontito";
            yo.Apellidos = "Master";
            yo.Salario = 600f;
            yo.Bonus = 1000; 


            Console.WriteLine(pepe.Nombre);
            Console.WriteLine(pepe.Apellidos);
            Console.WriteLine(pepe.Salario);

            Console.WriteLine("");

            Console.WriteLine(yo.Nombre);
            Console.WriteLine(yo.Apellidos);
            Console.WriteLine(yo.Salario);
            Console.WriteLine(yo.Bonus);
        }
    }
}
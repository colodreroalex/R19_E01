namespace R19_E01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //RECURSOS
            bool esCorrecto = true; 
            string mensajeError = "";
            string aux = "";
            Programador empleado;
            empleado = new Programador();



            //Console.WriteLine("PRUEBAS: CONSTRUCTOR POR DEFECTO");
            //Console.WriteLine(  "");
            //desarrollador = new Programador();
            //MostrarProgramador(desarrollador);

            //desarrolladorJunior = new ProgramadorJunior();
            //MostrarProgramadorJunior(desarrolladorJunior);


            //Inicializacion con parametros 

            //Console.WriteLine("PRUEBAS: CONSTRUCTOR CON PARAMETROS ");
            //Console.WriteLine(  "----------------------------------");
            //desarrollador = new Programador("pepe", "garcia", 2000);
            //MostrarProgramador(desarrollador);

            //desarrolladorJunior = new ProgramadorJunior("pepe", "garcia", 2000, 200);
            //MostrarProgramadorJunior(desarrolladorJunior);




            Console.WriteLine("PRUEBAS: ESTABLECIMIENTO DE DATOS - CONTROL DE ERRORES ");
            Console.WriteLine(  "|-----------------------------------------------------------|");
            //CONTROL DE ERRORES TRY/CATCH
            Programador desarrollador;
            desarrollador = new Programador();

            ProgramadorJunior desarrolladorJunior;
            desarrolladorJunior = new ProgramadorJunior();
            

            

            try
            {
                //desarrolladorJunior.Nombre = "";
                //desarrolladorJunior.Apellidos = "";
                desarrolladorJunior.Salario = 1500;
                desarrolladorJunior. =
                desarrolladorJunior.Bonus = 500; 
            }
            catch(ArgumentException ar)
            {
                mensajeError = ar.Message;
            }
            catch (FormatException f)
            {
                mensajeError = f.Message;
                esCorrecto = false; 
            }
            catch(Exception ex)
            {
                mensajeError = ex.Message;
                esCorrecto = false; 
            }
            finally
            {
                if (!esCorrecto) throw new Exception(mensajeError);
                
            }
            MostrarProgramador(desarrolladorJunior);



























            //COMPROBACIONES MIAS SIMPLES

            //Programador pepe = new Programador();
            //pepe.Nombre = "Pepe";
            //pepe.Apellidos = "Alcazar";
            //pepe.Salario = 1500;

            //ProgramadorJunior yo = new ProgramadorJunior("Alex", "colo", 600, 150);
            ////yo.Nombre = "ales";
            ////yo.Apellidos = "colo";
            ////yo.Salario = 600f;
            ////yo.Bonus = 1000;


            //Console.WriteLine(pepe.Nombre);
            //Console.WriteLine(pepe.Apellidos);
            //Console.WriteLine(pepe.Salario);

            //Console.WriteLine("");

            //Console.WriteLine(yo.Nombre);
            //Console.WriteLine(yo.Apellidos);
            //Console.WriteLine(yo.Salario);
            //Console.WriteLine(yo.Bonus);
        }

        private static void MostrarProgramador(Programador objeto)
        {
            Console.WriteLine(objeto.ToString());
        }

        private static void MostrarProgramadorJunior(Programador objeto)
        {
            Console.WriteLine(objeto.ToString());
        }
    }
}
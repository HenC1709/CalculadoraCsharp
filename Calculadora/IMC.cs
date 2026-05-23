using System;

namespace MiProyecto
{
    class IMC
    {
     
        public static void IMCEmepezar()
        {
            Console.Clear();

            Usuario usuario = CrearUsuario();

            MostrarBienvenidaIMC();

            double peso = PedirPeso();
            double altura = PedirAltura();

            double imc = CalcularIMC(peso, altura);
            string categoria = ObtenerCategoria(imc);

            MostrarResultado(imc, categoria);
        }

        static Usuario CrearUsuario()
        {
            Usuario usuario = new Usuario();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Dime tu nombre: ");
            usuario.Nombre = Console.ReadLine()!;

            Console.Write("Ingresa tu fecha de nacimiento (AAAA-MM-DD): ");

            if (!DateTime.TryParse(Console.ReadLine(), out DateTime fecha))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Fecha inválida.");
                Environment.Exit(0);
            }

            usuario.fechaNacimiento = fecha;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(
                $"{usuario.Nombre}, tienes {usuario.CalcularEdad()} años"
            );

            return usuario;
        }

        static void MostrarBienvenidaIMC()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine();
            Console.WriteLine("===================================");
            Console.WriteLine(" BIENVENIDO A LA CALCULADORA IMC ");
            Console.WriteLine("===================================");
        }

        static double PedirPeso()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Ingresa tu peso (kg): ");

            double.TryParse(Console.ReadLine(), out double peso);

            return peso;
        }

        static double PedirAltura()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Ingresa tu altura (m) Ej: 1.76 : ");

            double.TryParse(Console.ReadLine(), out double altura);

            return altura;
        }

        static double CalcularIMC(double peso, double altura)
        {
            return peso / (altura * altura);
        }

        static string ObtenerCategoria(double imc)
        {
            if (imc < 18.5)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                return "Bajo peso";
            }

            if (imc < 24.9)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                return "Peso normal";
            }

            if (imc < 29.9)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                return "Sobrepeso";
            }
            
            Console.ForegroundColor = ConsoleColor.Red;
            return "Obesidad";

        }

        static void MostrarResultado(double imc, string categoria)
        {
            Console.WriteLine();
            Console.WriteLine($"Tu IMC es: {imc:F2}");
            Console.WriteLine($"Estado: {categoria}");
        }
    }
}
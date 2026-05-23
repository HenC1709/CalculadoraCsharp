using System;
using MiProyecto;

public class Operaciones
{
    public static void Empezar()
    {
        CalculadoraBasica calc = new CalculadoraBasica();
        OperacionesAvanzadas adv = new OperacionesAvanzadas();

        bool salir = false;

        while(!salir)
        {
            Console.WriteLine("\n=== CALCULADORA ===");
            Console.WriteLine("1. Operaciones básicas (ej: 1+2-3*4)");
            Console.WriteLine("2. Potencia");
            Console.WriteLine("3. Raíz cuadrada");
            Console.WriteLine("4. IMC");
            Console.WriteLine("0. Salir.");
            Console.Write("Seleccione opción: ");

            string opcion = Console.ReadLine()!;

            try
            {
                switch (opcion)
                {
                    case "1":
                     Console.Write("Ingrese expresión: ");
                     string exp = Console.ReadLine()!;
                     double resultado = calc.EvaluarExpresion(exp);
                     Console.WriteLine($"Resultado: {resultado}");
                     break;

                      case "2":
                        Console.Write("Base: ");
                        double b = double.Parse(Console.ReadLine()!);

                        Console.Write("Exponente: ");
                        double e = double.Parse(Console.ReadLine()!);

                        Console.WriteLine($"Resultado: {adv.Potencia(b, e)}");
                        break;

                        case "3":
                        Console.Write("Número: ");
                        double n = double.Parse(Console.ReadLine()!);

                        Console.WriteLine($"Resultado: {adv.RaizCuadrada(n)}");
                        break;


                        case "4":
                        IMC.IMCEmepezar();
                        break;

                        case "0":
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción inválida");
                        break;

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
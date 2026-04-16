using System;
// titulos y colores, nota mental para futuras mejoras: agregar la opción de sumar o restar, y validar que el usuario ingrese números válidos.
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("------------------------------------");
Console.WriteLine(" LA CALCULADORA MAGICA ");
Console.WriteLine("------------------------------------");
Console.ForegroundColor = ConsoleColor.Green;
// pregunata al usuario qué operación desea realizar
Console.ForegroundColor = ConsoleColor.Yellow;
while (true)
{
Console.WriteLine("¿Qué operación desea realizar? \n1. + suma \n2. - resta \n3. * multiplicación \n4. / división");
string eleccion = Console.ReadLine();
// pedir los numeros al usuario: nota mental string es para texto, no para números, por lo que se debe convertir a double o int, y validar que la conversión sea exitosa.
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("Ingrese el primer número:");
// declaramos y aignamos el valor de num1 xd 
if (!double.TryParse(Console.ReadLine(), out double num1)) // nota mental double.Tryparse impide que uses letras o caracteres no numéricos, y asigna el valor a num1 si la conversión es exitosa, de lo contrario devuelve false.
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Syxtanx error. Migajero xd, ingrese un numero valido.");
    continue; // salir del programa si el número no es válido
}
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Ingrese el segundo número:");
if (!double.TryParse(Console.ReadLine(), out double num2))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Syxtanx error. Migajero xd, ingrese un numero valido.");
    continue; // salir del programa si el número no es válido
}
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Ingrese el tercer número (solo para multiplicación o división, si no desea usarlo, ingrese 0):");
if (!Double.TryParse(Console.ReadLine(), out double num3))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Syxtanx error. Migajero xd, ingrese un numero valido.");
    continue; // salir del programa si el número no es válido
}
// ahora viene el cerebro de la calculadora, que es el if/else para determinar qué operación realizar, y luego mostrar el resultado al usuario, por favor repasar xd
if (eleccion == "1")
{
    double resultado = num1 + num2 + num3; // nota mental: para sumar tres números, simplemente se suman los tres, y si el usuario no desea usar el tercer número, puede ingresar 0, lo que no afectará la suma.
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"\n[suma] El resultado de la suma es: {resultado}");
}
else if (eleccion == "2")
{
    double resultado = num1 - num2 - num3; // nota mental: para restar tres números, se resta el segundo número del primero, y luego se resta el tercer número del resultado, y si el usuario no desea usar el tercer número, puede ingresar 0, lo que no afectará la resta.    
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"\n[resta] El resultado de la resta es: {resultado}");
}
else if (eleccion == "3")
{
    double resultado = num1 * num2 * num3; // nota mental: para multiplicar tres números, simplemente se multiplican los tres, y si el usuario no desea usar el tercer número, puede ingresar 0, lo que hará que el resultado sea 0, pero es una forma de permitir al usuario no usar el tercer número sin afectar la lógica de la multiplicación.  
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine($"\n[multiplicación] El resultado de la multiplicación es: {resultado}");
}
else if (eleccion == "4")
{
    if (num2 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error: No se puede dividir por cero, migajero xd.");
    }
    else
    {
        double resultado = num1 / num2 / (num3 == 0 ? 1 : num3); // nota mental: para dividir tres números, se divide el primer número entre el segundo, y luego se divide el resultado entre el tercer número, pero si el usuario no desea usar el tercer número, puede ingresar 0, lo que hará que el resultado sea simplemente la división del primer número entre el segundo, ya que dividir entre 1 no afecta el resultado.    
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"\n[división] El resultado de la división es: {resultado}");
    }
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Opción no válida. Por favor, migajero xd.");

}
Console.WriteLine("\n¿Desea realizar otra operación? (s/n)");
if (Console.ReadLine().ToLower() == "n")
{
    break; // salir del bucle si el usuario no desea realizar otra operación
}
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Gracias por usar la calculadora, migajero xd.");
Console.ResetColor();
Console.WriteLine("Presione cualquier tecla para salir...");
Console.ReadKey();}

using System;

public class OperacionesAvanzadas
{
    public double Potencia(double baseNum, double exponente)
    {
        return Math.Pow(baseNum, exponente);
    }
    
    public double RaizCuadrada(double numero)
    {
        if (numero < 0)
        throw new Exception("No se puede raiz de numero negativo");

        return Math.Sqrt(numero);
    }
}
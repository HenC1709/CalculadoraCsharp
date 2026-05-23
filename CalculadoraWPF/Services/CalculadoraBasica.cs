using System;
using System.Data;

namespace CalculadoraWPF.Services
{
    public class CalculadoraBasica
    {
        public double EvaluarExpresion(string expresion)
        {
            try
            {
                var resultado = new DataTable().Compute(expresion, null);
                return Convert.ToDouble(resultado);
            }
            catch
            {
                throw new Exception("Expresión inválida");
            }
        }
    }
}
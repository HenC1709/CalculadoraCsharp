using System;

namespace CalculadoraWPF.Services
{
    public class IMCService
    {
        public double CalcularIMC(double peso, double altura)
        {
            return peso / (altura * altura);
        }

        public string ObtenerCategoria(double imc)
        {
            if (imc < 18.5)
                return "Bajo peso";

            if (imc < 24.9)
                return "Peso normal";

            if (imc < 29.9)
                return "Sobrepeso";

            return "Obesidad";
        }
    }
}
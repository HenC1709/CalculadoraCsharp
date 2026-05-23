using System;

namespace CalculadoraWPF.Models
{
    public class Usuario
    {
        public string Nombre = "";

        public DateTime FechaNacimiento;

        public int CalcularEdad()
        {
            var hoy = DateTime.Today;
            var edad = hoy.Year - FechaNacimiento.Year;

            if (FechaNacimiento.Date > hoy.AddYears(-edad))
                edad--;

            return edad;
        }
    }
}

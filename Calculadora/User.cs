using System;
using System.Data;

namespace MiProyecto
{
    class Usuario
{
    public string Nombre = "";
    public DateTime fechaNacimiento; // para fechas completas es mejor no usar static y que se pueda calcular todo en ese momento 

    // ahora vamos a calcular la edad
    public int CalcularEdad()
    {
        var hoy = DateTime.Today;
        var edad = hoy.Year-fechaNacimiento.Year;
         // pequeño ajuste xd
         if (fechaNacimiento.Date > hoy.AddYears(-edad)) edad--;

         return edad;
    }
     
 }
}

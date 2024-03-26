namespace Practico3Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /** Ejercicio 3 
                Un club deportivo permite el ingreso a la categoría de primera división de todas sus actividades 
                solo a los mayores de edad. Desea registrar a sus socios en un sistema, de los cuales guarda: 
                nombre, apellido (ambos distintos de vacío y nulo) y fecha de nacimiento (distinto de nulo).  
                Cada socio puede practicar hasta 2 deportes. De cada deporte se conoce el nombre (no vacío ni 
                nulo), si es grupal y cantidad de profesores (debe ser mayor a 0). 
            **/

            try
            {
                var deporte = new Deporte("Fútbol", true, 2);

                deporte.Validar();

                Console.WriteLine("Costo del deporte: $" + deporte.CalcularCosto());

                var fechaNacimientoSocio = new DateTime(1990, 5, 15);

                var socio = new Socio("Juan", "Pérez", fechaNacimientoSocio);

                socio.Validar();

                Console.WriteLine("¿Es mayor de edad? " + socio.EsMayorDeEdad());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            
        }
    }
}

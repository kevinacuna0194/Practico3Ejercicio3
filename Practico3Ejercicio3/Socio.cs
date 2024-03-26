using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practico3Ejercicio3.Interface;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Practico3Ejercicio3
{
    internal class Socio : IValidar
    {
        private static int _idSocio = 1;
        private int _id;
        private string _nombre;
        private string _apellido;
        private DateTime _fechaNacimiento;

        public Socio(string nombre, string apellido, DateTime fechaNacimiento)
        {
            _id = Socio._idSocio++;
            _nombre = nombre;
            _apellido = apellido;
            _fechaNacimiento = fechaNacimiento;
        }

        public bool EsMayorDeEdad()
        {
            // Calcular la edad comparando la fecha de nacimiento con la fecha actual
            int edad = DateTime.Today.Year - _fechaNacimiento.Year;
            /** 15/05/1990 0:00:00 > 25/03/1991 0:00:00 **/
            if (_fechaNacimiento.Date > DateTime.Today.AddYears(-edad)) edad--;

            return edad >= 18;
        }

        public void Validar()
        {
            ValidarNombreYApellido();
            ValidarFechaNacimiento();
        }

        internal void ValidarNombreYApellido()
        {
            if (string.IsNullOrWhiteSpace(_nombre) || string.IsNullOrWhiteSpace(_apellido))
                throw new ArgumentException("El nombre y el apellido no pueden estar vacíos.");
        }

        public void ValidarFechaNacimiento()
        {
            if (_fechaNacimiento == null)
                throw new ArgumentNullException("La fecha de nacimiento no puede ser nula.");
        }

        public override string ToString()
        {
            string mensaje = $"ID Socio: {_id} - ";
            mensaje += $"Nombre: {_nombre} - ";
            mensaje += $"Apellido: {_apellido} - ";
            mensaje += $"Fecha de Nacimiento: {_fechaNacimiento}";

            return mensaje;
        }
    }
}

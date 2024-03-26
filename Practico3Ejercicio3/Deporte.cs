using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practico3Ejercicio3.Interface;

namespace Practico3Ejercicio3
{
    internal class Deporte : IValidar
    {
        private static int _idDeporte = 1;
        private int _id;
        private string _nombre;
        private bool _esGrupal;
        private int _cantidadProfesores;

        public Deporte(string nombre, bool esGrupal, int cantidadProfesores)
        {
            _id = Deporte._idDeporte++;
            _nombre = nombre;
            _esGrupal = esGrupal;
            _cantidadProfesores = cantidadProfesores;
        }

        public decimal CalcularCosto()
        {
            return _cantidadProfesores * 1500;
        }

        public void Validar()
        {
            ValidarNombre();
            ValidarcantidadProfesores();
        }

        internal bool ValidarNombre()
        {
            return !string.IsNullOrEmpty(_nombre);
        }

        internal bool ValidarcantidadProfesores()
        {
            return _cantidadProfesores > 0;
        }

        public override string ToString()
        {
            string mensaje = $"ID Deporte: {_id} - ";
            mensaje += $"Nombre: {_nombre} - ";
            mensaje += $"¿Es Grupal?: {_esGrupal} - ";
            mensaje += $"Cantidad de Profesores: {_cantidadProfesores}";

            return mensaje;
        }
    }
}

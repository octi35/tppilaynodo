using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE1
{
    public class Paciente
    {
        public string dni;
        public string nombre;
        public string apellido;
        public bool vigente;
        public Paciente siguiente;

        public Paciente(string dni, string nombre, string apellido)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.siguiente = null;
        }
    }
}

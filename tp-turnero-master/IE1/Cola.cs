using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IE1
{
    internal class Cola
    {
        public Paciente inicio;
        public Paciente fin;

        public void Insertar(string dni, string nombre, string apellido)
        {
            Paciente nuevo = new Paciente(dni, nombre, apellido);

            if (inicio == null)
            {
                inicio = nuevo;
                fin = nuevo;
            }
            else
            {
                fin.siguiente = nuevo;
                fin = nuevo;
            }
        }
        public void Listar(ListBox lstEspera)
        {
            lstEspera.Items.Clear();

            if (inicio == null)
            {
                lstEspera.Items.Add("No hay pacientes");
            }
            else
            {
                Paciente aux = inicio;
                while (aux != null)
                {
                    lstEspera.Items.Add($"{aux.dni} - {aux.nombre} {aux.apellido}");
                    aux = aux.siguiente;
                }
            }
        }

        public List<string> devolverRegistros()
        {
            List<string> lista = new List<string>();
            Paciente aux = inicio;

            while (aux != null)
            {
                string registro = $"{aux.dni} - {aux.nombre} {aux.apellido}";
                lista.Add(registro);
                aux = aux.siguiente;
            }

            return lista;
        }


        public void Eliminar()
        {
            Paciente aux = inicio;
            inicio = inicio.siguiente;
            aux = null;
        }

    }
}

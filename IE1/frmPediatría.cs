using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IE1
{
    public partial class frmPediatría : Form
    {

        Cola esperaPediatria = new Cola();

        public frmPediatría()
        {
            InitializeComponent();
        }

        public void llamaPaciente(Paciente llamado)
        {
            lblPaciente.Text = llamado.apellido.ToUpper() + ", " + llamado.nombre;
            lblDNI.Text = llamado.dni;
        }

        public void mostrarProximos(List<string> listaPacientes)
        {
            lstProximos.Items.Clear();

            if (listaPacientes == null)
            {
                lstProximos.Items.Add("No hay pacientes");
            }
            else
            {
                Paciente aux = null;
                while (aux != null)
                {
                    lstProximos.Items.Add($"{aux.dni} - {aux.nombre} {aux.apellido}");
                    aux = aux.siguiente;
                }
            }

            for (int i = 1; i < listaPacientes.Count; i++)
            {
                lstProximos.Items.Add(listaPacientes[i]);
            }
        }


        public void mostrarConsultario()
        {
            Random rnd = new Random();
            lblConsultorio.Text = "PED" + rnd.Next(1, 5).ToString("000#");
        }
    }
}

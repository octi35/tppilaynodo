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
    public partial class frmGuardia : Form
    {
        public frmGuardia()
        {
            InitializeComponent();
        }

        public void llamaPaciente(Paciente llamado)
        {
            lblPaciente.Text = llamado.apellido.ToUpper() + ", " + llamado.nombre;
            lblDNI.Text = llamado.dni;
        }


        public void mostrarConsultario()
        {
            Random rnd = new Random();
            lblConsultorio.Text = "GUA" + rnd.Next(1, 5).ToString("000#");
        }
    }
}

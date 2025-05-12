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
    public partial class frmClinica : Form
    {
        public frmClinica()
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
            lblConsultorio.Text = "CLI" + rnd.Next(1, 5).ToString("000#");
        }

    }
}

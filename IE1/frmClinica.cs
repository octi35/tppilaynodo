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

        // Método que recibe un paciente y muestra sus datos en pantalla. ............ igual con los otros forms
        public void llamaPaciente(Paciente llamado)
        {
            // Muestra el nombre completo del paciente con el formato: APELLIDO, Nombre
            // Convierte el apellido a mayúsculas para destacarlo.
            lblPaciente.Text = llamado.apellido.ToUpper() + ", " + llamado.nombre;

            // Muestra el DNI del paciente en la etiqueta correspondiente.
            lblDNI.Text = llamado.dni;
        }

        public void mostrarConsultario()
        {
            Random rnd = new Random();
            lblConsultorio.Text = "CLI" + rnd.Next(1, 5).ToString("000#");
        }

        private void frmClinica_Load(object sender, EventArgs e)
        {

        }
    }
}

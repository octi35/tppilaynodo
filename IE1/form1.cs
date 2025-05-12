using System.Drawing;

namespace IE1
{
    public partial class form1 : Form
    {
        // Colas de espera por especialidad
        Cola esperaClinicaMedica = new Cola();
        Cola esperaPediatria = new Cola();
        Cola esperaGuardia = new Cola();

        // Formularios que muestran información del paciente llamado
        frmClinica visorClinica = new frmClinica();
        frmGuardia visorGuardia = new frmGuardia();
        frmPediatría visorPediatria = new frmPediatría();

        // Constructor del formulario principal
        public form1()
        {
            InitializeComponent();
            visorClinica.Show();    // Muestra el formulario de Clínica
            visorGuardia.Show();    // Muestra el formulario de Guardia
            visorPediatria.Show();  // Muestra el formulario de Pediatría
            restaurar();            // Restaura los datos desde los archivos de backup
        }

        // Botón para insertar un nuevo paciente en la cola correspondiente
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (!validarCamposPaciente()) return;

            if (cmbEspecialidad.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una especialidad.");
                return;
            }

            string especialidad = cmbEspecialidad.SelectedItem.ToString();
            Paciente nuevo = crearObjPaciente();  // Crea el objeto paciente

            // Inserta el paciente según la especialidad seleccionada
            switch (especialidad)
            {
                case "Clínica":
                    esperaClinicaMedica.Insertar(nuevo.dni, nuevo.nombre, nuevo.apellido);
                    esperaClinicaMedica.Listar(lstClinica);
                    break;
                case "Pediatría":
                    esperaPediatria.Insertar(nuevo.dni, nuevo.nombre, nuevo.apellido);
                    esperaPediatria.Listar(lstPediatria);
                    break;
                case "Guardia":
                    esperaGuardia.Insertar(nuevo.dni, nuevo.nombre, nuevo.apellido);
                    esperaGuardia.Listar(lstGuardia);
                    break;
                default:
                    MessageBox.Show("Especialidad no reconocida.");
                    return;
            }

            MessageBox.Show($"Paciente insertado en la cola de {especialidad}.");

            // Limpia los campos del formulario
            txtDNI.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
        }

        // Crea un objeto Paciente con los datos del formulario
        private Paciente crearObjPaciente()
        {
            return new Paciente(txtDNI.Text, txtNombre.Text, txtApellido.Text)
            {
                vigente = true
            };
        }

        // Verifica que todos los campos estén completos antes de insertar
        // se le añade adverten 
        private bool validarCamposPaciente()
        {
            if (string.IsNullOrWhiteSpace(txtDNI.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                cmbEspecialidad.SelectedItem == null)
            {
                MessageBox.Show("Complete todos los campos y seleccione una especialidad.");
                return false;
            }

            return true;
        }

        // Botón para llamar al siguiente paciente en la cola correspondiente
        private void btnLlamar_Click(object sender, EventArgs e)
        {
            if (optClinica.Checked)
            {
                // Llama y elimina al primer paciente en la cola de Clínica
                if (esperaClinicaMedica.inicio != null)
                {
                    visorClinica.llamaPaciente(esperaClinicaMedica.inicio);
                    esperaClinicaMedica.Eliminar();
                    esperaClinicaMedica.Listar(lstClinica);
                    backup();
                }
                else
                {
                    MessageBox.Show("No hay pacientes en Clínica Médica.");
                }
            }
            else if (optPediatria.Checked)
            {
                // Llama y elimina al primer paciente en la cola de Pediatría
                if (esperaPediatria.inicio != null)
                {
                    visorPediatria.llamaPaciente(esperaPediatria.inicio);
                    esperaPediatria.Eliminar();
                    esperaPediatria.Listar(lstPediatria);
                    backup();
                }
                else
                {
                    MessageBox.Show("No hay pacientes en Pediatría.");
                }
            }
            else if (optGuardia.Checked)
            {
                // Llama y elimina al primer paciente en la cola de Guardia
                if (esperaGuardia.inicio != null)
                {
                    visorGuardia.llamaPaciente(esperaGuardia.inicio);
                    esperaGuardia.Eliminar();
                    esperaGuardia.Listar(lstGuardia);
                    backup();
                }
                else
                {
                    MessageBox.Show("No hay pacientes en Guardia.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una especialidad.");
            }
        }

        // Guarda el estado actual de las colas en archivos de texto
        public void backup()
        {
            List<string> listaClinica = esperaClinicaMedica.devolverRegistros();
            using (StreamWriter escribir = File.CreateText("backup_clinica.txt"))
            {
                foreach (string registro in listaClinica)
                {
                    escribir.WriteLine(registro);
                }
            }

            List<string> listaPediatria = esperaPediatria.devolverRegistros();
            using (StreamWriter escribir = File.CreateText("backup_pediatria.txt"))
            {
                foreach (string registro in listaPediatria)
                {
                    escribir.WriteLine(registro);
                }
            }

            List<string> listaGuardia = esperaGuardia.devolverRegistros();
            using (StreamWriter escribir = File.CreateText("backup_guardia.txt"))
            {
                foreach (string registro in listaGuardia)
                {
                    escribir.WriteLine(registro);
                }
            }
        }

        // Restaura el contenido de las colas desde los archivos de backup (si existen)
        public void restaurar()
        {
            if (File.Exists("backup_clinica.txt"))
            {
                using (StreamReader leer = File.OpenText("backup_clinica.txt"))
                {
                    string registro = leer.ReadLine();
                    while (registro != null)
                    {
                        string[] campos = registro.Split(',');
                        esperaClinicaMedica.Insertar(campos[0], campos[1], campos[2]);
                        registro = leer.ReadLine();
                    }
                }
                esperaClinicaMedica.Listar(lstClinica);
            }

            if (File.Exists("backup_pediatria.txt"))
            {
                using (StreamReader leer = File.OpenText("backup_pediatria.txt"))
                {
                    string registro = leer.ReadLine();
                    while (registro != null)
                    {
                        string[] campos = registro.Split(',');
                        esperaPediatria.Insertar(campos[0], campos[1], campos[2]);
                        registro = leer.ReadLine();
                    }
                }
                esperaPediatria.Listar(lstPediatria);
            }

            if (File.Exists("backup_guardia.txt"))
            {
                using (StreamReader leer = File.OpenText("backup_guardia.txt"))
                {
                    string registro = leer.ReadLine();
                    while (registro != null)
                    {
                        string[] campos = registro.Split(',');
                        esperaGuardia.Insertar(campos[0], campos[1], campos[2]);
                        registro = leer.ReadLine();
                    }
                }
                esperaGuardia.Listar(lstGuardia);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

namespace IE1
{
    partial class form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtDNI = new TextBox();
            cmbEspecialidad = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lstClinica = new ListBox();
            lstPediatria = new ListBox();
            lstGuardia = new ListBox();
            groupBox1 = new GroupBox();
            btnLlamar = new Button();
            optGuardia = new RadioButton();
            optPediatria = new RadioButton();
            optClinica = new RadioButton();
            btnInsertar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 18);
            label1.Name = "label1";
            label1.Size = new Size(46, 28);
            label1.TabIndex = 0;
            label1.Text = "DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 18);
            label2.Name = "label2";
            label2.Size = new Size(86, 28);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(472, 18);
            label3.Name = "label3";
            label3.Size = new Size(85, 28);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(684, 18);
            label4.Name = "label4";
            label4.Size = new Size(120, 28);
            label4.TabIndex = 3;
            label4.Text = "Especialidad";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(235, 42);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(208, 34);
            txtApellido.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(472, 42);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(179, 34);
            txtNombre.TabIndex = 5;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(24, 42);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(179, 34);
            txtDNI.TabIndex = 6;
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.ImeMode = ImeMode.Katakana;
            cmbEspecialidad.Items.AddRange(new object[] { "Clínica", "Pediatría", "Guardia" });
            cmbEspecialidad.Location = new Point(684, 42);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new Size(211, 36);
            cmbEspecialidad.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 122);
            label5.Name = "label5";
            label5.Size = new Size(131, 28);
            label5.TabIndex = 8;
            label5.Text = "Espera Clínica";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(325, 122);
            label6.Name = "label6";
            label6.Size = new Size(140, 28);
            label6.TabIndex = 9;
            label6.Text = "Espera Peditría";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(620, 122);
            label7.Name = "label7";
            label7.Size = new Size(143, 28);
            label7.TabIndex = 10;
            label7.Text = "Espera Guardia";
            // 
            // lstClinica
            // 
            lstClinica.FormattingEnabled = true;
            lstClinica.ItemHeight = 28;
            lstClinica.Location = new Point(28, 153);
            lstClinica.Name = "lstClinica";
            lstClinica.Size = new Size(275, 312);
            lstClinica.TabIndex = 11;
            // 
            // lstPediatria
            // 
            lstPediatria.FormattingEnabled = true;
            lstPediatria.ItemHeight = 28;
            lstPediatria.Location = new Point(325, 153);
            lstPediatria.Name = "lstPediatria";
            lstPediatria.Size = new Size(275, 312);
            lstPediatria.TabIndex = 12;
            // 
            // lstGuardia
            // 
            lstGuardia.FormattingEnabled = true;
            lstGuardia.ItemHeight = 28;
            lstGuardia.Location = new Point(620, 153);
            lstGuardia.Name = "lstGuardia";
            lstGuardia.Size = new Size(275, 312);
            lstGuardia.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLlamar);
            groupBox1.Controls.Add(optGuardia);
            groupBox1.Controls.Add(optPediatria);
            groupBox1.Controls.Add(optClinica);
            groupBox1.Location = new Point(28, 471);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(864, 110);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Llamar a consultorio";
            // 
            // btnLlamar
            // 
            btnLlamar.BackColor = Color.LimeGreen;
            btnLlamar.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnLlamar.Location = new Point(589, 32);
            btnLlamar.Name = "btnLlamar";
            btnLlamar.Size = new Size(250, 52);
            btnLlamar.TabIndex = 3;
            btnLlamar.Text = "L L A M A R";
            btnLlamar.UseVisualStyleBackColor = false;
            btnLlamar.Click += btnLlamar_Click;
            // 
            // optGuardia
            // 
            optGuardia.AutoSize = true;
            optGuardia.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            optGuardia.Location = new Point(366, 42);
            optGuardia.Name = "optGuardia";
            optGuardia.Size = new Size(142, 45);
            optGuardia.TabIndex = 2;
            optGuardia.TabStop = true;
            optGuardia.Text = "Guardia";
            optGuardia.UseVisualStyleBackColor = true;
            // 
            // optPediatria
            // 
            optPediatria.AutoSize = true;
            optPediatria.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            optPediatria.Location = new Point(191, 42);
            optPediatria.Name = "optPediatria";
            optPediatria.Size = new Size(153, 45);
            optPediatria.TabIndex = 1;
            optPediatria.TabStop = true;
            optPediatria.Text = "Pediatría";
            optPediatria.UseVisualStyleBackColor = true;
            // 
            // optClinica
            // 
            optClinica.AutoSize = true;
            optClinica.Checked = true;
            optClinica.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            optClinica.Location = new Point(26, 42);
            optClinica.Name = "optClinica";
            optClinica.Size = new Size(125, 45);
            optClinica.TabIndex = 0;
            optClinica.TabStop = true;
            optClinica.Text = "Clínica";
            optClinica.UseVisualStyleBackColor = true;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.LimeGreen;
            btnInsertar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertar.Location = new Point(684, 81);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(211, 37);
            btnInsertar.TabIndex = 15;
            btnInsertar.Text = "I N S E R T A R";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.White;
            btnModificar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.Location = new Point(47, 587);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(132, 37);
            btnModificar.TabIndex = 16;
            btnModificar.Text = "modificar";
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.White;
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(744, 587);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(132, 37);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += this.btnEliminar_Click;
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrchid;
            ClientSize = new Size(926, 629);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnInsertar);
            Controls.Add(groupBox1);
            Controls.Add(lstGuardia);
            Controls.Add(lstPediatria);
            Controls.Add(lstClinica);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cmbEspecialidad);
            Controls.Add(txtDNI);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "form1";
            Text = "Carga de Pacientes";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtDNI;
        private ComboBox cmbEspecialidad;
        private Label label5;
        private Label label6;
        private Label label7;
        private ListBox lstClinica;
        private ListBox lstPediatria;
        private ListBox lstGuardia;
        private GroupBox groupBox1;
        private Button btnLlamar;
        private RadioButton optGuardia;
        private RadioButton optPediatria;
        private RadioButton optClinica;
        private Button btnInsertar;
        private Button btnModificar;
        private Button btnEliminar;
    }
}
namespace IE1
{
    partial class frmGuardia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblConsultorio = new Label();
            label5 = new Label();
            lblDNI = new Label();
            label2 = new Label();
            lblPaciente = new Label();
            label1 = new Label();
            lstProximos = new ListBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // lblConsultorio
            // 
            lblConsultorio.AutoSize = true;
            lblConsultorio.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point);
            lblConsultorio.Location = new Point(406, 203);
            lblConsultorio.Name = "lblConsultorio";
            lblConsultorio.Size = new Size(190, 51);
            lblConsultorio.TabIndex = 23;
            lblConsultorio.Text = "GUA0001";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(119, 203);
            label5.Name = "label5";
            label5.Size = new Size(305, 51);
            label5.TabIndex = 22;
            label5.Text = "CONSULTORIO: ";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(282, 117);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(194, 46);
            lblDNI.TabIndex = 19;
            lblDNI.Text = "XX.XXX.XXX";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(202, 117);
            label2.Name = "label2";
            label2.Size = new Size(85, 46);
            label2.TabIndex = 18;
            label2.Text = "DNI:";
            // 
            // lblPaciente
            // 
            lblPaciente.Font = new Font("Segoe UI", 35F, FontStyle.Bold, GraphicsUnit.Point);
            lblPaciente.Location = new Point(18, 55);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(679, 62);
            lblPaciente.TabIndex = 17;
            lblPaciente.Text = "APELLIDO, Nombre";
            lblPaciente.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(258, 9);
            label1.Name = "label1";
            label1.Size = new Size(165, 46);
            label1.TabIndex = 16;
            label1.Text = "PACIENTE";
            // 
            // lstProximos
            // 
            lstProximos.FormattingEnabled = true;
            lstProximos.ItemHeight = 45;
            lstProximos.Location = new Point(41, 337);
            lstProximos.Name = "lstProximos";
            lstProximos.Size = new Size(592, 229);
            lstProximos.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 279);
            label3.Name = "label3";
            label3.Size = new Size(309, 46);
            label3.TabIndex = 24;
            label3.Text = "Próximos pacientes";
            // 
            // frmGuardia
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(678, 582);
            Controls.Add(lstProximos);
            Controls.Add(label3);
            Controls.Add(lblConsultorio);
            Controls.Add(label5);
            Controls.Add(lblDNI);
            Controls.Add(label2);
            Controls.Add(lblPaciente);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(8, 9, 8, 9);
            Name = "frmGuardia";
            Text = "Consualtorio de Guardia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblConsultorio;
        private Label label5;
        private Label lblDNI;
        private Label label2;
        private Label lblPaciente;
        private Label label1;
        private ListBox lstProximos;
        private Label label3;
    }
}
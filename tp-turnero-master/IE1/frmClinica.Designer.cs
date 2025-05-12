namespace IE1
{
    partial class frmClinica
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
            label1 = new Label();
            lblPaciente = new Label();
            label2 = new Label();
            lblDNI = new Label();
            label3 = new Label();
            label5 = new Label();
            lblConsultorio = new Label();
            lstProximos = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(252, 18);
            label1.Name = "label1";
            label1.Size = new Size(165, 46);
            label1.TabIndex = 0;
            label1.Text = "PACIENTE";
            // 
            // lblPaciente
            // 
            lblPaciente.Font = new Font("Segoe UI", 35F, FontStyle.Bold, GraphicsUnit.Point);
            lblPaciente.Location = new Point(12, 64);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(679, 62);
            lblPaciente.TabIndex = 1;
            lblPaciente.Text = "APELLIDO, Nombre";
            lblPaciente.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 126);
            label2.Name = "label2";
            label2.Size = new Size(85, 46);
            label2.TabIndex = 2;
            label2.Text = "DNI:";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(276, 126);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(194, 46);
            lblDNI.TabIndex = 3;
            lblDNI.Text = "XX.XXX.XXX";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 284);
            label3.Name = "label3";
            label3.Size = new Size(309, 46);
            label3.TabIndex = 4;
            label3.Text = "Próximos pacientes";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(119, 212);
            label5.Name = "label5";
            label5.Size = new Size(305, 51);
            label5.TabIndex = 6;
            label5.Text = "CONSULTORIO: ";
            // 
            // lblConsultorio
            // 
            lblConsultorio.AutoSize = true;
            lblConsultorio.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point);
            lblConsultorio.Location = new Point(415, 212);
            lblConsultorio.Name = "lblConsultorio";
            lblConsultorio.Size = new Size(165, 51);
            lblConsultorio.TabIndex = 7;
            lblConsultorio.Text = "CLI0001";
            // 
            // lstProximos
            // 
            lstProximos.FormattingEnabled = true;
            lstProximos.ItemHeight = 45;
            lstProximos.Location = new Point(37, 342);
            lstProximos.Name = "lstProximos";
            lstProximos.Size = new Size(592, 229);
            lstProximos.TabIndex = 8;
            // 
            // frmClinica
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(672, 586);
            Controls.Add(lstProximos);
            Controls.Add(lblConsultorio);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(lblDNI);
            Controls.Add(label2);
            Controls.Add(lblPaciente);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(8, 9, 8, 9);
            Name = "frmClinica";
            Text = "Consultorio Clínico";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblPaciente;
        private Label label2;
        private Label lblDNI;
        private Label label3;
        private Label label5;
        private Label lblConsultorio;
        private ListBox lstProximos;
    }
}
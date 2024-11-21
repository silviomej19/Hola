namespace InterfazDentalidea2
{
    partial class AgendarCitaUsuario
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
            this.grpEntrada = new System.Windows.Forms.GroupBox();
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.mtxtFecha = new System.Windows.Forms.MaskedTextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.rtxtComentarios = new System.Windows.Forms.RichTextBox();
            this.rtxtMotivo = new System.Windows.Forms.RichTextBox();
            this.cmbConsultorio = new System.Windows.Forms.ComboBox();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.lblConsultorio = new System.Windows.Forms.Label();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.rtxtSalida = new System.Windows.Forms.RichTextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.grpEntrada.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEntrada
            // 
            this.grpEntrada.Controls.Add(this.btnBorrar);
            this.grpEntrada.Controls.Add(this.cmbHora);
            this.grpEntrada.Controls.Add(this.btnVer);
            this.grpEntrada.Controls.Add(this.mtxtFecha);
            this.grpEntrada.Controls.Add(this.lblFecha);
            this.grpEntrada.Controls.Add(this.btnClose);
            this.grpEntrada.Controls.Add(this.btnClear);
            this.grpEntrada.Controls.Add(this.btnLeer);
            this.grpEntrada.Controls.Add(this.btnSave);
            this.grpEntrada.Controls.Add(this.rtxtComentarios);
            this.grpEntrada.Controls.Add(this.rtxtMotivo);
            this.grpEntrada.Controls.Add(this.cmbConsultorio);
            this.grpEntrada.Controls.Add(this.cmbDoctor);
            this.grpEntrada.Controls.Add(this.lblComentarios);
            this.grpEntrada.Controls.Add(this.lblMotivo);
            this.grpEntrada.Controls.Add(this.lblConsultorio);
            this.grpEntrada.Controls.Add(this.lblDoctor);
            this.grpEntrada.Controls.Add(this.lblHora);
            this.grpEntrada.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEntrada.Location = new System.Drawing.Point(8, 15);
            this.grpEntrada.Name = "grpEntrada";
            this.grpEntrada.Size = new System.Drawing.Size(1108, 381);
            this.grpEntrada.TabIndex = 0;
            this.grpEntrada.TabStop = false;
            this.grpEntrada.Text = "Entrada Datos";
            // 
            // cmbHora
            // 
            this.cmbHora.FormattingEnabled = true;
            this.cmbHora.Items.AddRange(new object[] {
            "08:00 - 09:00",
            "10:00 - 11:00",
            "01:00 - 02:00",
            "03:00 - 04:00"});
            this.cmbHora.Location = new System.Drawing.Point(270, 39);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(151, 30);
            this.cmbHora.TabIndex = 17;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(800, 191);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(185, 46);
            this.btnVer.TabIndex = 16;
            this.btnVer.Text = "Ver disponible";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // mtxtFecha
            // 
            this.mtxtFecha.Location = new System.Drawing.Point(590, 44);
            this.mtxtFecha.Mask = "00/00/0000";
            this.mtxtFecha.Name = "mtxtFecha";
            this.mtxtFecha.Size = new System.Drawing.Size(86, 29);
            this.mtxtFecha.TabIndex = 15;
            this.mtxtFecha.ValidatingType = typeof(System.DateTime);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(435, 47);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(126, 22);
            this.lblFecha.TabIndex = 14;
            this.lblFecha.Text = "Ingrese fecha: ";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(959, 116);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(119, 45);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(799, 116);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 45);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(959, 33);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(119, 50);
            this.btnLeer.TabIndex = 11;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(799, 33);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 50);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // rtxtComentarios
            // 
            this.rtxtComentarios.Location = new System.Drawing.Point(238, 296);
            this.rtxtComentarios.Name = "rtxtComentarios";
            this.rtxtComentarios.Size = new System.Drawing.Size(396, 70);
            this.rtxtComentarios.TabIndex = 9;
            this.rtxtComentarios.Text = "";
            this.rtxtComentarios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtxtComentarios_KeyPress);
            // 
            // rtxtMotivo
            // 
            this.rtxtMotivo.Location = new System.Drawing.Point(270, 213);
            this.rtxtMotivo.Name = "rtxtMotivo";
            this.rtxtMotivo.Size = new System.Drawing.Size(364, 74);
            this.rtxtMotivo.TabIndex = 8;
            this.rtxtMotivo.Text = "";
            this.rtxtMotivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtxtMotivo_KeyPress);
            // 
            // cmbConsultorio
            // 
            this.cmbConsultorio.Enabled = false;
            this.cmbConsultorio.FormattingEnabled = true;
            this.cmbConsultorio.Items.AddRange(new object[] {
            "c-201",
            "b-202",
            "b-108",
            "f-483"});
            this.cmbConsultorio.Location = new System.Drawing.Point(270, 152);
            this.cmbConsultorio.Name = "cmbConsultorio";
            this.cmbConsultorio.Size = new System.Drawing.Size(241, 30);
            this.cmbConsultorio.TabIndex = 7;
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.Enabled = false;
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(238, 99);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(247, 30);
            this.cmbDoctor.TabIndex = 6;
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.Location = new System.Drawing.Point(37, 299);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(121, 22);
            this.lblComentarios.TabIndex = 4;
            this.lblComentarios.Text = "Comentarios: ";
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(37, 216);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(187, 22);
            this.lblMotivo.TabIndex = 3;
            this.lblMotivo.Text = "Motivo de la consulta:";
            // 
            // lblConsultorio
            // 
            this.lblConsultorio.AutoSize = true;
            this.lblConsultorio.Location = new System.Drawing.Point(37, 160);
            this.lblConsultorio.Name = "lblConsultorio";
            this.lblConsultorio.Size = new System.Drawing.Size(196, 22);
            this.lblConsultorio.TabIndex = 2;
            this.lblConsultorio.Text = "Consultorio disponible:";
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Location = new System.Drawing.Point(37, 107);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(164, 22);
            this.lblDoctor.TabIndex = 1;
            this.lblDoctor.Text = "Doctor disponible: ";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(37, 47);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(216, 22);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "Ingrese la hora de la cita: ";
            // 
            // rtxtSalida
            // 
            this.rtxtSalida.Location = new System.Drawing.Point(12, 421);
            this.rtxtSalida.Name = "rtxtSalida";
            this.rtxtSalida.Size = new System.Drawing.Size(1103, 215);
            this.rtxtSalida.TabIndex = 1;
            this.rtxtSalida.Text = "";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(799, 262);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(186, 44);
            this.btnBorrar.TabIndex = 18;
            this.btnBorrar.Text = "Borrar todo";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // AgendarCitaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1127, 655);
            this.Controls.Add(this.rtxtSalida);
            this.Controls.Add(this.grpEntrada);
            this.Name = "AgendarCitaUsuario";
            this.Text = "Agendar Cita Usuario | Dental clinic";
            this.Load += new System.EventHandler(this.AgendarCitaUsuario_Load);
            this.grpEntrada.ResumeLayout(false);
            this.grpEntrada.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEntrada;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.Label lblComentarios;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.Label lblConsultorio;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.RichTextBox rtxtComentarios;
        private System.Windows.Forms.RichTextBox rtxtMotivo;
        private System.Windows.Forms.ComboBox cmbConsultorio;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox rtxtSalida;
        private System.Windows.Forms.MaskedTextBox mtxtFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.ComboBox cmbHora;
        private System.Windows.Forms.Button btnBorrar;
    }
}
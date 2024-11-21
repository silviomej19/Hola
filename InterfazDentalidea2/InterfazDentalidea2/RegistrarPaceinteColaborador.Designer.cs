namespace InterfazDentalidea2
{
    partial class RegistrarPaceinteColaborador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarPaceinteColaborador));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblTipoSangre = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.grpdATOS = new System.Windows.Forms.GroupBox();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.txtTipoSangre = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grpdATOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 34);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(86, 22);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(21, 87);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(95, 22);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Direccion: ";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(21, 140);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(85, 22);
            this.lblNum.TabIndex = 2;
            this.lblNum.Text = "Numero: ";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(21, 192);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(60, 22);
            this.lblEdad.TabIndex = 3;
            this.lblEdad.Text = "Edad: ";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(21, 245);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(58, 22);
            this.lblSexo.TabIndex = 4;
            this.lblSexo.Text = "Sexo: ";
            // 
            // lblTipoSangre
            // 
            this.lblTipoSangre.AutoSize = true;
            this.lblTipoSangre.Location = new System.Drawing.Point(21, 295);
            this.lblTipoSangre.Name = "lblTipoSangre";
            this.lblTipoSangre.Size = new System.Drawing.Size(114, 22);
            this.lblTipoSangre.TabIndex = 5;
            this.lblTipoSangre.Text = "Tipo sangre: ";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(21, 350);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(38, 22);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "ID: ";
            // 
            // grpdATOS
            // 
            this.grpdATOS.Controls.Add(this.btnAgregar);
            this.grpdATOS.Controls.Add(this.btnLeer);
            this.grpdATOS.Controls.Add(this.btnClose);
            this.grpdATOS.Controls.Add(this.btnSave);
            this.grpdATOS.Controls.Add(this.cmbSexo);
            this.grpdATOS.Controls.Add(this.txtTipoSangre);
            this.grpdATOS.Controls.Add(this.txtID);
            this.grpdATOS.Controls.Add(this.txtEdad);
            this.grpdATOS.Controls.Add(this.txtNumero);
            this.grpdATOS.Controls.Add(this.txtDireccion);
            this.grpdATOS.Controls.Add(this.txtName);
            this.grpdATOS.Controls.Add(this.lblNombre);
            this.grpdATOS.Controls.Add(this.lblID);
            this.grpdATOS.Controls.Add(this.lblNum);
            this.grpdATOS.Controls.Add(this.lblTipoSangre);
            this.grpdATOS.Controls.Add(this.lblEdad);
            this.grpdATOS.Controls.Add(this.lblDireccion);
            this.grpdATOS.Controls.Add(this.lblSexo);
            this.grpdATOS.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpdATOS.Location = new System.Drawing.Point(21, 22);
            this.grpdATOS.Name = "grpdATOS";
            this.grpdATOS.Size = new System.Drawing.Size(1088, 412);
            this.grpdATOS.TabIndex = 7;
            this.grpdATOS.TabStop = false;
            this.grpdATOS.Text = "Ingreso Dato";
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(925, 55);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(126, 53);
            this.btnLeer.TabIndex = 17;
            this.btnLeer.Text = "Leer texto";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(925, 133);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 53);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Salir";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(674, 133);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(211, 54);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Guardar en un archivo";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.cmbSexo.Location = new System.Drawing.Point(125, 235);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(290, 30);
            this.cmbSexo.TabIndex = 13;
            // 
            // txtTipoSangre
            // 
            this.txtTipoSangre.Location = new System.Drawing.Point(157, 288);
            this.txtTipoSangre.Name = "txtTipoSangre";
            this.txtTipoSangre.Size = new System.Drawing.Size(273, 29);
            this.txtTipoSangre.TabIndex = 12;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(109, 343);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(292, 29);
            this.txtID.TabIndex = 11;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(124, 185);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(292, 29);
            this.txtEdad.TabIndex = 10;
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(138, 133);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(292, 29);
            this.txtNumero.TabIndex = 9;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(138, 80);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(292, 29);
            this.txtDireccion.TabIndex = 8;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(147, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(292, 29);
            this.txtName.TabIndex = 7;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Location = new System.Drawing.Point(21, 444);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.ReadOnly = true;
            this.dgvPacientes.RowHeadersWidth = 51;
            this.dgvPacientes.RowTemplate.Height = 24;
            this.dgvPacientes.Size = new System.Drawing.Size(1088, 197);
            this.dgvPacientes.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(759, 55);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(126, 54);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // RegistrarPaceinteColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1219, 650);
            this.Controls.Add(this.dgvPacientes);
            this.Controls.Add(this.grpdATOS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrarPaceinteColaborador";
            this.Text = "Registrar Paceinte Colaborador | Dental Clinic";
            this.Load += new System.EventHandler(this.RegistrarPaceinteColaborador_Load);
            this.grpdATOS.ResumeLayout(false);
            this.grpdATOS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblTipoSangre;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox grpdATOS;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.TextBox txtTipoSangre;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
namespace InterfazDentalidea2
{
    partial class MenuColaboradores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuColaboradores));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarHistorialMedicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRegistrarPaciente = new System.Windows.Forms.Button();
            this.btnRegistrarHistorialMed = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblRegistrarDeco = new System.Windows.Forms.Label();
            this.lblSalirColaDeco = new System.Windows.Forms.Label();
            this.lblRegisPacienteDeco = new System.Windows.Forms.Label();
            this.lblOptions = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.DimGray;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitulo.Location = new System.Drawing.Point(746, 49);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(414, 43);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Bienvenido a DentalClinic";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(564, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(747, 628);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarPacienteToolStripMenuItem,
            this.salirDelProgramaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1311, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrarPacienteToolStripMenuItem
            // 
            this.registrarPacienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarHistorialMedicoToolStripMenuItem});
            this.registrarPacienteToolStripMenuItem.Name = "registrarPacienteToolStripMenuItem";
            this.registrarPacienteToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.registrarPacienteToolStripMenuItem.Text = "Registrar Paciente";
            this.registrarPacienteToolStripMenuItem.Click += new System.EventHandler(this.registrarPacienteToolStripMenuItem_Click);
            // 
            // registrarHistorialMedicoToolStripMenuItem
            // 
            this.registrarHistorialMedicoToolStripMenuItem.Name = "registrarHistorialMedicoToolStripMenuItem";
            this.registrarHistorialMedicoToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.registrarHistorialMedicoToolStripMenuItem.Text = "Registrar Historial Medico";
            this.registrarHistorialMedicoToolStripMenuItem.Click += new System.EventHandler(this.registrarHistorialMedicoToolStripMenuItem_Click);
            // 
            // salirDelProgramaToolStripMenuItem
            // 
            this.salirDelProgramaToolStripMenuItem.Name = "salirDelProgramaToolStripMenuItem";
            this.salirDelProgramaToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.salirDelProgramaToolStripMenuItem.Text = "Salir del programa";
            this.salirDelProgramaToolStripMenuItem.Click += new System.EventHandler(this.salirDelProgramaToolStripMenuItem_Click);
            // 
            // btnRegistrarPaciente
            // 
            this.btnRegistrarPaciente.BackColor = System.Drawing.Color.DimGray;
            this.btnRegistrarPaciente.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPaciente.Location = new System.Drawing.Point(76, 228);
            this.btnRegistrarPaciente.Name = "btnRegistrarPaciente";
            this.btnRegistrarPaciente.Size = new System.Drawing.Size(446, 54);
            this.btnRegistrarPaciente.TabIndex = 7;
            this.btnRegistrarPaciente.Text = "Registrar Paciente";
            this.btnRegistrarPaciente.UseVisualStyleBackColor = false;
            this.btnRegistrarPaciente.Click += new System.EventHandler(this.btnRegistrarPaciente_Click);
            // 
            // btnRegistrarHistorialMed
            // 
            this.btnRegistrarHistorialMed.BackColor = System.Drawing.Color.DimGray;
            this.btnRegistrarHistorialMed.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarHistorialMed.Location = new System.Drawing.Point(76, 131);
            this.btnRegistrarHistorialMed.Name = "btnRegistrarHistorialMed";
            this.btnRegistrarHistorialMed.Size = new System.Drawing.Size(446, 58);
            this.btnRegistrarHistorialMed.TabIndex = 8;
            this.btnRegistrarHistorialMed.Text = "Registrar Historial Medico";
            this.btnRegistrarHistorialMed.UseVisualStyleBackColor = false;
            this.btnRegistrarHistorialMed.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DimGray;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(76, 318);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(446, 55);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Salir ";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 433);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(526, 198);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // lblRegistrarDeco
            // 
            this.lblRegistrarDeco.AutoSize = true;
            this.lblRegistrarDeco.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarDeco.Location = new System.Drawing.Point(5, 147);
            this.lblRegistrarDeco.Name = "lblRegistrarDeco";
            this.lblRegistrarDeco.Size = new System.Drawing.Size(39, 42);
            this.lblRegistrarDeco.TabIndex = 11;
            this.lblRegistrarDeco.Text = "»";
            // 
            // lblSalirColaDeco
            // 
            this.lblSalirColaDeco.AutoSize = true;
            this.lblSalirColaDeco.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalirColaDeco.Location = new System.Drawing.Point(5, 331);
            this.lblSalirColaDeco.Name = "lblSalirColaDeco";
            this.lblSalirColaDeco.Size = new System.Drawing.Size(39, 42);
            this.lblSalirColaDeco.TabIndex = 12;
            this.lblSalirColaDeco.Text = "»";
            // 
            // lblRegisPacienteDeco
            // 
            this.lblRegisPacienteDeco.AutoSize = true;
            this.lblRegisPacienteDeco.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisPacienteDeco.Location = new System.Drawing.Point(5, 240);
            this.lblRegisPacienteDeco.Name = "lblRegisPacienteDeco";
            this.lblRegisPacienteDeco.Size = new System.Drawing.Size(39, 42);
            this.lblRegisPacienteDeco.TabIndex = 13;
            this.lblRegisPacienteDeco.Text = "»";
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.BackColor = System.Drawing.Color.DimGray;
            this.lblOptions.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptions.Location = new System.Drawing.Point(151, 68);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(124, 33);
            this.lblOptions.TabIndex = 6;
            this.lblOptions.Text = "Opciones";
            // 
            // MenuColaboradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1311, 661);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblRegisPacienteDeco);
            this.Controls.Add(this.lblSalirColaDeco);
            this.Controls.Add(this.lblRegistrarDeco);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRegistrarHistorialMed);
            this.Controls.Add(this.btnRegistrarPaciente);
            this.Controls.Add(this.lblOptions);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuColaboradores";
            this.Text = "Menu Colaboradores | Dental clinic";
            this.Load += new System.EventHandler(this.MenuColaboradores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarHistorialMedicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDelProgramaToolStripMenuItem;
        private System.Windows.Forms.Button btnRegistrarPaciente;
        private System.Windows.Forms.Button btnRegistrarHistorialMed;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblRegistrarDeco;
        private System.Windows.Forms.Label lblSalirColaDeco;
        private System.Windows.Forms.Label lblRegisPacienteDeco;
        private System.Windows.Forms.Label lblOptions;
    }
}
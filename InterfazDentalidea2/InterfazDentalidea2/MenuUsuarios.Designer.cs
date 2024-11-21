namespace InterfazDentalidea2
{
    partial class MenuUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuUsuarios));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agendarCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEditarDeco = new System.Windows.Forms.Label();
            this.lblEliminarDeco = new System.Windows.Forms.Label();
            this.lblAgendarDeco = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.brnEliminar = new System.Windows.Forms.Button();
            this.btnAgendarCita = new System.Windows.Forms.Button();
            this.btnEditarCita = new System.Windows.Forms.Button();
            this.lblOptions = new System.Windows.Forms.Label();
            this.lblSalirDeco = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendarCitaToolStripMenuItem,
            this.salirDelProgramaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1311, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agendarCitaToolStripMenuItem
            // 
            this.agendarCitaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarCitaToolStripMenuItem,
            this.eliminarCitaToolStripMenuItem});
            this.agendarCitaToolStripMenuItem.Name = "agendarCitaToolStripMenuItem";
            this.agendarCitaToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.agendarCitaToolStripMenuItem.Text = "Agendar Cita";
            this.agendarCitaToolStripMenuItem.Click += new System.EventHandler(this.agendarCitaToolStripMenuItem_Click);
            // 
            // editarCitaToolStripMenuItem
            // 
            this.editarCitaToolStripMenuItem.Name = "editarCitaToolStripMenuItem";
            this.editarCitaToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.editarCitaToolStripMenuItem.Text = "Editar Cita";
            this.editarCitaToolStripMenuItem.Click += new System.EventHandler(this.editarCitaToolStripMenuItem_Click);
            // 
            // eliminarCitaToolStripMenuItem
            // 
            this.eliminarCitaToolStripMenuItem.Name = "eliminarCitaToolStripMenuItem";
            this.eliminarCitaToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.eliminarCitaToolStripMenuItem.Text = "Eliminar Cita";
            this.eliminarCitaToolStripMenuItem.Click += new System.EventHandler(this.eliminarCitaToolStripMenuItem_Click);
            // 
            // salirDelProgramaToolStripMenuItem
            // 
            this.salirDelProgramaToolStripMenuItem.Name = "salirDelProgramaToolStripMenuItem";
            this.salirDelProgramaToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.salirDelProgramaToolStripMenuItem.Text = "Salir del programa";
            this.salirDelProgramaToolStripMenuItem.Click += new System.EventHandler(this.salirDelProgramaToolStripMenuItem_Click);
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblEditarDeco
            // 
            this.lblEditarDeco.AutoSize = true;
            this.lblEditarDeco.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarDeco.Location = new System.Drawing.Point(8, 219);
            this.lblEditarDeco.Name = "lblEditarDeco";
            this.lblEditarDeco.Size = new System.Drawing.Size(39, 42);
            this.lblEditarDeco.TabIndex = 21;
            this.lblEditarDeco.Text = "»";
            // 
            // lblEliminarDeco
            // 
            this.lblEliminarDeco.AutoSize = true;
            this.lblEliminarDeco.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminarDeco.Location = new System.Drawing.Point(8, 283);
            this.lblEliminarDeco.Name = "lblEliminarDeco";
            this.lblEliminarDeco.Size = new System.Drawing.Size(39, 42);
            this.lblEliminarDeco.TabIndex = 20;
            this.lblEliminarDeco.Text = "»";
            // 
            // lblAgendarDeco
            // 
            this.lblAgendarDeco.AutoSize = true;
            this.lblAgendarDeco.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgendarDeco.Location = new System.Drawing.Point(8, 149);
            this.lblAgendarDeco.Name = "lblAgendarDeco";
            this.lblAgendarDeco.Size = new System.Drawing.Size(39, 42);
            this.lblAgendarDeco.TabIndex = 19;
            this.lblAgendarDeco.Text = "»";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(15, 435);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(526, 198);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // brnEliminar
            // 
            this.brnEliminar.BackColor = System.Drawing.Color.DimGray;
            this.brnEliminar.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnEliminar.Location = new System.Drawing.Point(79, 270);
            this.brnEliminar.Name = "brnEliminar";
            this.brnEliminar.Size = new System.Drawing.Size(446, 55);
            this.brnEliminar.TabIndex = 17;
            this.brnEliminar.Text = "Eliminar Cita";
            this.brnEliminar.UseVisualStyleBackColor = false;
            this.brnEliminar.Click += new System.EventHandler(this.brnEliminar_Click);
            // 
            // btnAgendarCita
            // 
            this.btnAgendarCita.BackColor = System.Drawing.Color.DimGray;
            this.btnAgendarCita.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendarCita.Location = new System.Drawing.Point(79, 133);
            this.btnAgendarCita.Name = "btnAgendarCita";
            this.btnAgendarCita.Size = new System.Drawing.Size(446, 58);
            this.btnAgendarCita.TabIndex = 16;
            this.btnAgendarCita.Text = "Agendar Cita";
            this.btnAgendarCita.UseVisualStyleBackColor = false;
            this.btnAgendarCita.Click += new System.EventHandler(this.btnAgendarCita_Click);
            // 
            // btnEditarCita
            // 
            this.btnEditarCita.BackColor = System.Drawing.Color.DimGray;
            this.btnEditarCita.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCita.Location = new System.Drawing.Point(79, 207);
            this.btnEditarCita.Name = "btnEditarCita";
            this.btnEditarCita.Size = new System.Drawing.Size(446, 54);
            this.btnEditarCita.TabIndex = 15;
            this.btnEditarCita.Text = "Editar Cita";
            this.btnEditarCita.UseVisualStyleBackColor = false;
            this.btnEditarCita.Click += new System.EventHandler(this.btnEditarCita_Click);
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.BackColor = System.Drawing.Color.DimGray;
            this.lblOptions.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptions.Location = new System.Drawing.Point(154, 70);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(124, 33);
            this.lblOptions.TabIndex = 14;
            this.lblOptions.Text = "Opciones";
            // 
            // lblSalirDeco
            // 
            this.lblSalirDeco.AutoSize = true;
            this.lblSalirDeco.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalirDeco.Location = new System.Drawing.Point(8, 343);
            this.lblSalirDeco.Name = "lblSalirDeco";
            this.lblSalirDeco.Size = new System.Drawing.Size(39, 42);
            this.lblSalirDeco.TabIndex = 23;
            this.lblSalirDeco.Text = "»";
            this.lblSalirDeco.Click += new System.EventHandler(this.lblSalirDeco_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DimGray;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(79, 343);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(446, 55);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Salir";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MenuUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1311, 661);
            this.Controls.Add(this.lblSalirDeco);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblEditarDeco);
            this.Controls.Add(this.lblEliminarDeco);
            this.Controls.Add(this.lblAgendarDeco);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.brnEliminar);
            this.Controls.Add(this.btnAgendarCita);
            this.Controls.Add(this.btnEditarCita);
            this.Controls.Add(this.lblOptions);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuUsuarios";
            this.Text = "Menu Usuarios | Dental clinic";
            this.Load += new System.EventHandler(this.MenuUsuarios_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agendarCitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarCitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarCitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDelProgramaToolStripMenuItem;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEditarDeco;
        private System.Windows.Forms.Label lblEliminarDeco;
        private System.Windows.Forms.Label lblAgendarDeco;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button brnEliminar;
        private System.Windows.Forms.Button btnAgendarCita;
        private System.Windows.Forms.Button btnEditarCita;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Label lblSalirDeco;
        private System.Windows.Forms.Button btnClose;
    }
}
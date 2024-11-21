using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazDentalidea2
{
    public partial class MenuUsuarios : Form
    {
        public MenuUsuarios()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void agendarCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgendarCitaUsuario agendarCitaUsuario = new AgendarCitaUsuario(); //Creamos instancia y llamamos al otro formulario
            agendarCitaUsuario.Show();
        }

        private void editarCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarCitaUsuario editarCitaUsuario = new EditarCitaUsuario(); //Creamos instancia y llamamos al otro formulario
            editarCitaUsuario.Show();
        }

        private void eliminarCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarCitaUsuario eliminarCitaUsuario = new EliminarCitaUsuario(); //Creamos instancia y llamamos al otro formulario
            eliminarCitaUsuario.Show();
        }

        private void salirDelProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Redirigiendo al inicio", "Redirigir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Close(); //Cerramos forms y despues creamos instancia y llamamos al otro formulario 
            FormInicioSesion formInicioSesion = new FormInicioSesion();
            formInicioSesion.Show();
        }

        private void btnAgendarCita_Click(object sender, EventArgs e)
        {
            lblSalirDeco.ForeColor = System.Drawing.Color.Black; //Esto es meramente estetico para que se pongan las binetas de color rojo cuando seleccionamos un button
            lblEliminarDeco.ForeColor = System.Drawing.Color.Black;
            lblEditarDeco.ForeColor = System.Drawing.Color.Black;
            lblAgendarDeco.ForeColor = System.Drawing.Color.Red;
            AgendarCitaUsuario agendarCitaUsuario = new AgendarCitaUsuario();
            agendarCitaUsuario.Show();
        }

        private void btnEditarCita_Click(object sender, EventArgs e)
        {
            lblSalirDeco.ForeColor = System.Drawing.Color.Black; //Esto es meramente estetico para que se pongan las binetas de color rojo cuando seleccionamos un button
            lblEliminarDeco.ForeColor = System.Drawing.Color.Black;
            lblEditarDeco.ForeColor = System.Drawing.Color.Red;
            lblAgendarDeco.ForeColor = System.Drawing.Color.Black;
            EditarCitaUsuario editarCitaUsuario = new EditarCitaUsuario();
            editarCitaUsuario.Show();
        }

        private void brnEliminar_Click(object sender, EventArgs e)
        {
            lblSalirDeco.ForeColor = System.Drawing.Color.Black; //Esto es meramente estetico para que se pongan las binetas de color rojo cuando seleccionamos un button
            lblEliminarDeco.ForeColor = System.Drawing.Color.Red;
            lblEditarDeco.ForeColor = System.Drawing.Color.Black;
            lblAgendarDeco.ForeColor = System.Drawing.Color.Black;
            EliminarCitaUsuario eliminarCitaUsuario = new EliminarCitaUsuario();
            eliminarCitaUsuario.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            lblSalirDeco.ForeColor = System.Drawing.Color.Red; //Esto es meramente estetico para que se pongan las binetas de color rojo cuando seleccionamos un button
            lblEliminarDeco.ForeColor = System.Drawing.Color.Black;
            lblEditarDeco.ForeColor = System.Drawing.Color.Black;
            lblAgendarDeco.ForeColor = System.Drawing.Color.Black;
            MessageBox.Show("Redirigiendo al inicio", "Redirigir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Close();
            FormInicioSesion formInicioSesion = new FormInicioSesion();
            formInicioSesion.Show();
        }

        private void lblSalirDeco_Click(object sender, EventArgs e)
        {

        }

        private void MenuUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}

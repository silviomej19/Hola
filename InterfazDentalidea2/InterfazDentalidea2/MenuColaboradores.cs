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
    public partial class MenuColaboradores : Form
    {
        public MenuColaboradores()
        {
            InitializeComponent();
        }

        private void agregarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirDelProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Redirigiendo al inicio","Redirigir",MessageBoxButtons.OK,MessageBoxIcon.Warning); //Cerramos el presente forms
            Close();
            FormInicioSesion formInicioSesion = new FormInicioSesion(); //Creamos instancia del formulario anterior y lo llamamos 
            formInicioSesion.Show();
        }

        private void registrarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarPaceinteColaborador registrarPaceinteColaborador = new RegistrarPaceinteColaborador(); //Creamos instancia del formulario y lo llamamos
            registrarPaceinteColaborador.Show();
        }

        private void registrarHistorialMedicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarHistorialMedico registrarHistorialMedico = new RegistrarHistorialMedico(); //Repetimos procesos de crear instancia y llamar
            registrarHistorialMedico.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblRegistrarDeco.ForeColor = System.Drawing.Color.Red; //Esto es meramente estetico para que se pongan las binetas de color rojo cuando seleccionamos un button
            lblRegisPacienteDeco.ForeColor = System.Drawing.Color.Black;
            lblSalirColaDeco.ForeColor = System.Drawing.Color.Black;
            RegistrarHistorialMedico registrarHistorialMedico = new RegistrarHistorialMedico();
            registrarHistorialMedico.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            lblSalirColaDeco.ForeColor = System.Drawing.Color.Red; //Esto es meramente estetico para que se pongan las binetas de color rojo cuando seleccionamos un button
            lblRegisPacienteDeco.ForeColor = System.Drawing.Color.Black;
            lblRegistrarDeco.ForeColor = System.Drawing.Color.Black;
            MessageBox.Show("Redirigiendo al inicio", "Redirigir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Close();
            FormInicioSesion formInicioSesion = new FormInicioSesion();
            formInicioSesion.Show();
        }

        private void btnRegistrarPaciente_Click(object sender, EventArgs e)
        {
            lblRegisPacienteDeco.ForeColor = System.Drawing.Color.Red; //Esto es meramente estetico para que se pongan las binetas de color rojo cuando seleccionamos un button
            lblSalirColaDeco.ForeColor = System.Drawing.Color.Black;
            lblRegistrarDeco.ForeColor = System.Drawing.Color.Black;
            RegistrarPaceinteColaborador registrarPaceinteColaborador = new RegistrarPaceinteColaborador();
            registrarPaceinteColaborador.Show();
        }

        private void MenuColaboradores_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

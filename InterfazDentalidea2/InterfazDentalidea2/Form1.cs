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
    public partial class FormInicioSesion : Form
    {
        public FormInicioSesion()
        {
            InitializeComponent();
        }

        public bool validarDatos() //Funcion para validar los datos de los campos del ID y la contrasenia 
        {
            if (string.IsNullOrWhiteSpace(txtID.Text)) //Para validar que los campos esten llenos 
            {
                MessageBox.Show("El ID es obligatorio", "Llenar por favor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtID.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text)) //Lo mismo quiere decir que si quedan en blanco o vacios va a mandar un MessageBox que diga que son obligatorios
            {
                MessageBox.Show("La contrasenia es obligatorio", "Llenar por favor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtID.Focus();
                return false;
            }

            return true; //Si todos los campos estan completos
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            //Lamamos funcion
            if (validarDatos())
            {
                txtPassword.Focus();
                string ID = txtID.Text;
                string password = txtPassword.Text; //Declaramos variables y les asignamos donde el usuario las digite
                if (ID == "Silvio" && password == "191106") //Aqui yo digo que ID para colaborador es Silvio y su contrasenia es mi cumple
                {
                    txtResult.Text = "Colaborador";
                    MessageBox.Show("Bienvenido Colaborador", "Colaborador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MenuColaboradores menuColaboradores = new MenuColaboradores(); //Creamos instacia del menu colaborador 
                    menuColaboradores.Show(); //Llamamos al menu de colaboradores 
                    this.Hide();
                }
                else if (ID == "User" && password == "10") //Aqui digo que para paciente es User y su contrasenia es 10 
                {
                    txtResult.Text = "Usuario";
                    MessageBox.Show("Bienvenido Usuario", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MenuUsuarios menuUsuarios = new MenuUsuarios(); //Creamos instacia del menu usuario 
                    menuUsuarios.Show(); //Llamamos al menu usuario
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("ID o Constrasenia incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("Desea salir del programa?", "Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (respuesta == DialogResult.Yes)
            {
                MessageBox.Show("Saliendo del programa", "Salida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e) //Evento keypress donde el usuario solo le permito digitar numeros sin letras ni espacios 
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo números por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite letras, números, espacios y retroceso (borrar)
            if (char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == 32 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Ingrese solo letras, números o espacios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void FormInicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }
    }
}

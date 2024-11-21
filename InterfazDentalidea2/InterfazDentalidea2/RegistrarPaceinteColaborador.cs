using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazDentalidea2
{
    public partial class RegistrarPaceinteColaborador : Form
    {
        private List<pacienteRegistroClase> pacientes;
        private pacienteRegistroClase pacienteRegistroClaseSel = new pacienteRegistroClase();
        private const string rutaDoc = "C:\\Users\\Silvio Mejia\\Documents\\AQUI SE GUARDA EL TXT\\datos.txt";
        private string cedulaVerificacionPattern = @"^\d{3}-\d{6}-\d{4}[A-Z]$";

        public RegistrarPaceinteColaborador()
        {
            InitializeComponent();
            pacientes = new List<pacienteRegistroClase>();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Filter = "Archivo DAT (*.dat)|*.dat";
                saveFileDialog1.Title = "Guardar archivo";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    archivoRegistroPacienteClase archivo = new archivoRegistroPacienteClase();

                    archivo.GuardarArchivo(pacientes, saveFileDialog1.FileName);
                    MessageBox.Show("Se ha guardado el archivo", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saliendo del programa", "Saliendo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Close();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Archivos DAT (*.dat)|*.dat| Todos los archivos (*.*)|*.";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string ruta = openFileDialog1.FileName;

                archivoRegistroPacienteClase archivo = new archivoRegistroPacienteClase();
                pacientes = archivo.CargarPacientes(ruta);

                MostrarDatos();
            }
            else
            {
                MessageBox.Show("No se selecciono ningun archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegistrarPaceinteColaborador_Load(object sender, EventArgs e)
        {
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 32 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Ingrese solo letras o espacios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 44) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo números por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == 32 || e.KeyChar == 8 || e.KeyChar == 46)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Ingrese solo letras, números o espacios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            int cursorPosition = txtID.SelectionStart;
            int lengthBefore = txtID.Text.Length;

            string text = txtID.Text.Replace("-", "");

            if (text.Length > 3)
            {
                text = text.Insert(3, "-");
            }
            if (text.Length > 10)
            {
                text = text.Insert(10, "-");
            }

            txtID.Text = text;

            int lengthAfter = txtID.Text.Length;
            cursorPosition += lengthAfter - lengthBefore;

            if (cursorPosition < 0) cursorPosition = 0;
            if (cursorPosition > txtID.Text.Length) cursorPosition = txtID.Text.Length;

            txtID.SelectionStart = cursorPosition;
        }

        public void MostrarDatos()
        {
            dgvPacientes.DataSource = null;
            dgvPacientes.DataSource = pacientes;
        }

        public void LimpiarCodigo()
        {
            txtID.Clear();
            txtEdad.Clear();
            txtDireccion.Clear();
            txtName.Clear();
            txtNumero.Clear();
            txtTipoSangre.Clear();
            cmbSexo.ResetText();
            txtName.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pacienteRegistroClase paciente = new pacienteRegistroClase();
            string id;
            string nombre = txtName.Text;
            string direccion = txtDireccion.Text;
            int numero = int.Parse(txtNumero.Text);
            int edad = int.Parse(txtEdad.Text);
            string sexo = cmbSexo.Text;
            string tipoSangre = txtTipoSangre.Text;
            bool isValidID = Regex.IsMatch(txtID.Text, cedulaVerificacionPattern);

            if (isValidID)
            {
                id = txtID.Text;
                paciente.ID = id;
                paciente.Name = nombre;
                paciente.Direccion = direccion;
                paciente.Numero = numero.ToString();
                paciente.Edad = edad;
                paciente.Sexo = sexo;
                paciente.Blood = tipoSangre;
            }
            else
            {
                MessageBox.Show("Cedula incorrecta");
                return;
            }

            int index = pacientes.FindIndex(p => p.ID == paciente.ID);
            if (index != -1)
            {
                pacientes[index] = paciente;
            }
            else
            {
                pacientes.Add(paciente);
            }

            MostrarDatos();
            LimpiarCodigo();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }
    }
}

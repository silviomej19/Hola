using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazDentalidea2
{
    public partial class RegistrarHistorialMedico : Form
    {
        public RegistrarHistorialMedico()
        {
            InitializeComponent();
        }
        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (rbtnSiAlergia.Checked == true)
            {
                rtxtAlergia.Enabled = true;
            }
            else
            {
                rtxtAlergia.Enabled = false;
            }
            if (rbtnSiEnfermedad.Checked == true)
            {
                rtxtEnfermedad.Enabled = true;
            }
            else
            {
                rtxtEnfermedad.Enabled = false;
            }
            if (rbtnSiOperacion.Checked == true)
            { 
                rtxtOperacion.Enabled = true;
            }
            else
            {
                rtxtOperacion.Enabled = false;
            }
            if (rbtnSiTratamiento.Checked == true)
            {
                rtxtTratamiento.Enabled = true;
            }
            else
            {
                rtxtTratamiento.Enabled = false;
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            rtxtMostrar.Clear();
            rtxtAlergia.Clear();
            rtxtEnfermedad.Clear();
            rtxtOperacion.Clear();
            rtxtTratamiento.Clear();
            rtxtEnfermedad.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtxtAlergia.Text) && !rbtnSiAlergia.Checked ||
                string.IsNullOrWhiteSpace(rtxtEnfermedad.Text) && !rbtnSiEnfermedad.Checked ||
                string.IsNullOrWhiteSpace(rtxtOperacion.Text) && !rbtnSiOperacion.Checked ||
                string.IsNullOrWhiteSpace(rtxtTratamiento.Text) && !rbtnSiTratamiento.Checked)
            {
                MessageBox.Show("Por favor complete todos los campos requeridos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detener el proceso de guardar si hay campos vacíos
            }

            try
            {
                // Guardar en el archivo
                using (TextWriter historialMedico = new StreamWriter("C:\\Users\\Silvio Mejia\\Documents\\AQUI SE GUARDA EL TXT\\historial.txt"))
                {
                    string Alergias = rtxtAlergia.Text;
                    string Operacion = rtxtOperacion.Text;
                    string Tratamiento = rtxtTratamiento.Text;
                    string Enfermedad = rtxtEnfermedad.Text;

                    historialMedico.WriteLine("Alergia cliente: " + Alergias);
                    historialMedico.WriteLine("Enfermedades cliente: " + Enfermedad);
                    historialMedico.WriteLine("Tratamiento cliente: " + Tratamiento);
                    historialMedico.WriteLine("Operacion cliente: " + Operacion);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el historial: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader leer = new StreamReader("C:\\Users\\Silvio Mejia\\Documents\\AQUI SE GUARDA EL TXT\\historial.txt"))
                {
                    string linea;
                    rtxtMostrar.Clear();
                    while ((linea = leer.ReadLine()) != null)
                    {
                        rtxtMostrar.AppendText(linea + Environment.NewLine);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("El archivo no existe. Por favor guarde un historial antes de intentar leer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rtxtEnfermedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo letras, espacios y retroceso (borrar)
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

        private void rtxtTratamiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo letras, espacios y retroceso (borrar)
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

        private void rtxtAlergia_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo letras, espacios y retroceso (borrar)
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

        private void rtxtOperacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo letras, espacios y retroceso (borrar)
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

        private void RegistrarHistorialMedico_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Volviendo al menu anterior", "Saliendo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();    
        }
    }
}

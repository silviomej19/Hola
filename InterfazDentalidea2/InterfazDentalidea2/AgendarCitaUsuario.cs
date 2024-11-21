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
    public partial class AgendarCitaUsuario : Form
    {
        public AgendarCitaUsuario()
        {
            InitializeComponent();
        }

        private bool validarInfo()
        {
            if (string.IsNullOrWhiteSpace(mtxtFecha.Text))
            {
                MessageBox.Show("El campo de fecha es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtxtFecha.Focus();
                return false; 
            }

            if (string.IsNullOrWhiteSpace(cmbHora.Text))
            {
                MessageBox.Show("El campo de la hora es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbHora.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbDoctor.Text))
            {
                MessageBox.Show("El campo doctor es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbDoctor.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbConsultorio.Text))
            {
                MessageBox.Show("El campo consultorio es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbConsultorio.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(rtxtComentarios.Text))
            {
                MessageBox.Show("El campo comentarios es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rtxtComentarios.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(rtxtMotivo.Text))
            {
                MessageBox.Show("El campo motivo es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rtxtMotivo.Focus();
                return false;
            }

            return true; //Si todos los campos estan llenos
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            if (validarInfo())
            {
                try
                {
                    TextWriter cita = new StreamWriter("C:\\Users\\Silvio Mejia\\Documents\\AQUI SE GUARDA EL TXT\\datos cita.txt",true);
                    string fecha = mtxtFecha.Text;
                    string hora = cmbHora.Text;
                    string doctor = cmbDoctor.Text;
                    string comentarios = rtxtComentarios.Text;
                    string motivo = rtxtMotivo.Text;
                    string consultorio = cmbConsultorio.Text;

                    cita.WriteLine("Fecha de la cita: " + fecha);
                    cita.WriteLine("Hora de la cita: " + hora);
                    cita.WriteLine("Doctor de la cita: " + doctor);
                    cita.WriteLine("Comentarios de la cita: " + comentarios);
                    cita.WriteLine("Motivo de la cita: " + motivo);
                    cita.WriteLine("Consultorio de la cita: " + consultorio);
                    cita.WriteLine(new string('-',50));
                    cita.Close();
                    MessageBox.Show("Cita agendada correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Datos inválidos, por favor ingrese datos correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void mtxtFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo números por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void rtxtMotivo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void rtxtComentarios_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnLeer_Click(object sender, EventArgs e)
        {
            StreamReader leer = new StreamReader("C:\\Users\\Silvio Mejia\\Documents\\AQUI SE GUARDA EL TXT\\datos cita.txt");
            string linea;
            try
            {
                linea = leer.ReadLine();
                while (linea != null)
                {
                    rtxtSalida.AppendText(linea + "\n");
                    linea = leer.ReadLine();
                }
            }
            catch
            {
                MessageBox.Show("Error Digite valores admitidos");
            }
            finally 
            {
                leer.Close();
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            cmbConsultorio.Enabled = true;
            cmbDoctor.Enabled = true;

            string fecha = mtxtFecha.Text;
            string hora = cmbHora.Text;

            if (hora == "08:00 - 09:00")
            {
                cmbDoctor.Items.Clear();
                cmbDoctor.Items.Add("Gabriel");
                cmbDoctor.Items.Add("Silvio");
            }
            if (hora == "10:00 - 11:00")
            {
                cmbDoctor.Items.Clear();
                cmbDoctor.Items.Add("Alex");
                cmbDoctor.Items.Add("Slles");
            }
            if (hora == "01:00 - 02:00")
            {
                cmbDoctor.Items.Clear();
                cmbDoctor.Items.Add("Juan");
                cmbDoctor.Items.Add("Anthony");
            }
            if (hora == "03:00 - 04:00")
            {
                cmbDoctor.Items.Clear();
                cmbDoctor.Items.Add("Jenora");
                cmbDoctor.Items.Add("Regina");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            mtxtFecha.Clear();
            cmbDoctor.SelectedIndex = -1;
            cmbHora.SelectedIndex = -1;
            cmbConsultorio.SelectedIndex = -1;
            rtxtComentarios.Clear();
            rtxtMotivo.Clear();
            rtxtSalida.Clear();

            cmbConsultorio.Enabled = false;
            cmbDoctor.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Volviendo al menu anterior", "Saliendo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void AgendarCitaUsuario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\Silvio Mejia\\Documents\\AQUI SE GUARDA EL TXT\\datos cita.txt";

            try
            {
                // Sobrescribe el archivo con contenido vacío
                File.WriteAllText(filePath, "");
                MessageBox.Show("El contenido del archivo ha sido eliminado correctamente.", "Archivo Limpiado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al intentar borrar el contenido del archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

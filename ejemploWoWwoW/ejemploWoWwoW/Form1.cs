using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemploWoWwoW
{
    public partial class Form1 : Form
    {
        private List<Ciudad> ciudades; //Declaramos la lista
        private Ciudad ciudadSel = new Ciudad(); //Declaramos la variable estructura
        public Form1()
        {
            InitializeComponent();
            ciudades = new List<Ciudad>(); //Creando objeto de tipo lista 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Ciudad ciudad = new Ciudad();
            ciudad.ID = int.Parse(txtCode.Text); //Obtenemos el ID de la ciudad a traves del text box de codigo ciudad
            ciudad.Nombre = txtNombre.Text; //Obtenemos el nombre de la ciudad mediante el text box nombre ciudad 

            //Buscar si ya existe una ciudad con el mismo ID en la lista 
            int index = ciudades.FindIndex(ItemActivation => ItemActivation.ID == ciudad.ID);

            if (index != -1) //Si ya existe, actualizar la ciudad en la lista 
            {
                ciudades[index] = ciudad;
            }
            else
            {

                ciudades.Add(ciudad);
            }
            MostrarDatos();
            LimpiarCodigo();
        }

        public void MostrarDatos()
        {
            dgvRegistros.DataSource = null; //Actualiza datos o limpiar el datagridview
            dgvRegistros.DataSource = ciudades; //Alimentamos el datagridview con la lista  
        }

        public void LimpiarCodigo()
        {
            txtCode.Clear();
            txtNombre.Clear();
            txtCode.Focus();

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Filter = "Archivo DAT (*.dat)|*.dat";
                saveFileDialog1.Title = "Guardar archivo";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    CiudadArchivo archivo = new CiudadArchivo();

                    archivo.GaurdarArchivo(ciudades, saveFileDialog1.FileName);
                    MessageBox.Show("Se ha guardado el archivo", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Archivos DAT (*.dat)|*.dat| Todos los archivos (*.*)|*.";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string ruta = openFileDialog1.FileName;

                CiudadArchivo archivo = new CiudadArchivo();
                ciudades = archivo.CargarCiudades(ruta);

                MostrarDatos();
            }
            else
            {
                MessageBox.Show("No se selecciono ningun archivo.");
            }
        }
        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ciudades.Remove(ciudadSel);
                MessageBox.Show("Ciudad eliminada...", "Ciudad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvRegistros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = dgvRegistros.CurrentRow;
            if (currentRow != null)
            {
                ciudadSel.ID = int.Parse(currentRow.Cells[0].Value.ToString());
                ciudadSel.Nombre = currentRow.Cells[1].Value.ToString();
                txtCode.Text = ciudadSel.ID.ToString();
                txtNombre.Text = ciudadSel.Nombre;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Filter = "Archivo DAT (*.dat)|*.dat";
                saveFileDialog1.Title = "Guardar archivo";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    CiudadArchivo archivo = new CiudadArchivo();

                    archivo.GaurdarArchivo(ciudades, saveFileDialog1.FileName);
                    MessageBox.Show("Se ha guardado el archivo", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Archivos DAT (*.dat)|*.dat| Todos los archivos (*.*)|*.";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string ruta = openFileDialog1.FileName;

                CiudadArchivo archivo = new CiudadArchivo();
                ciudades = archivo.CargarCiudades(ruta);

                MostrarDatos();
            }
            else
            {
                MessageBox.Show("No se selecciono ningun archivo.");
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                ciudades.Remove(ciudadSel);
                MessageBox.Show("Ciudad eliminada...", "Ciudad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

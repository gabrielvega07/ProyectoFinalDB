using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dev_Solutions.Llenar;
using Dev_Solutions.Model;

namespace Dev_Solutions
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            ListarDepartamento();

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image files (*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp)";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureFoto.Image = new Bitmap(open.FileName);
            }
        }

        private void btnFirma_Click(object sender, EventArgs e)
        {

        }

        private void pictureFoto_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image files (*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp)";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureFirma.Image = new Bitmap(open.FileName);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClsMunicipios oMunicipioSeleccionado = (ClsMunicipios)combMunicipios.SelectedItem;

        }

        private void ListarDepartamento()
        {
            combDepartamentos.DataSource = new CLsData().ObtenerDepartamentos();
            combDepartamentos.ValueMember = "Dpto_ID";
            combDepartamentos.DisplayMember = "Dpto_Nombre";

        }

        private void combDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClsDepartamentos oDepartamentoSeleccionado = (ClsDepartamentos)combDepartamentos.SelectedItem;

            combMunicipios.DataSource = new CLsData().ObtenerMunicipios(oDepartamentoSeleccionado.Dpto_ID);
            combMunicipios.ValueMember = "Mpio_ID";
            combMunicipios.DisplayMember = "Mpio_Nombre";
        }
    }
}

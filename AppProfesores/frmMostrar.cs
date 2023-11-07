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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppProfesores
{
    public partial class frmMostrar : Form
    {
        frmMenu menu;
        public frmMostrar()
        {
            InitializeComponent();
        }
        private void frmMostrar_Load(object sender, EventArgs e)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Profesores.txt");
            StreamReader archivoALeer = File.OpenText(path);
            string renglon = archivoALeer.ReadLine();

            do
            {
                lstProfesores.Items.Add(renglon);
                renglon = archivoALeer.ReadLine();

            } while (renglon != null);
            archivoALeer.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            menu = new frmMenu();
            menu.Show();
            this.Hide();
        }
    }
}

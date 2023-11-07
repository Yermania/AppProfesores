using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppProfesores
{
    public partial class frmMenu : Form
    {
        frmAgregar agregar;
        frmBuscar buscar;
        frmMostrar mostrar;
        public frmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            agregar = new frmAgregar();
            agregar.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mostrar = new frmMostrar();
            mostrar.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buscar = new frmBuscar();
            buscar.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppProfesores
{
    public partial class Login : Form
    {
        frmMenu Menu;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text=="admin" && txtPassword.Text=="admin2023")
            {
                Menu = new frmMenu();
                Menu.Show();
                this.Hide();
            }
            else
            {
                lblError.Text = "Usuario o Contraseña incorrectos";
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

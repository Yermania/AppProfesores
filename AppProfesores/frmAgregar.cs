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

namespace AppProfesores
{
    public partial class frmAgregar : Form
    {
        List<Profesor> listProfesores = new List<Profesor>();
        frmMenu menu;
        public frmAgregar()
        {
            InitializeComponent();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            menu = new frmMenu();
            menu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                int edad = int.Parse(txtEdad.Text);
                string dni = txtDni.Text;
                string genero = txtGenero.Text;
                string puesto = txtPuesto.Text;
                string antiguedad = txtAntiguedad.Text;
                string sueldo = txtSueldo.Text;
                int horasSemanales = int.Parse(txtHoras.Text);

                Profesor profesor = new Profesor(nombre, apellido, edad, dni, genero, puesto, antiguedad, sueldo, horasSemanales);
                listProfesores.Add(profesor);
                try
                {
                    string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Profesores.txt");
                    StreamWriter archivo;
                    if (File.Exists(path))
                    {
                        archivo = File.AppendText(path);
                    }
                    else
                    {
                        archivo = File.CreateText(path);
                    }
                    foreach (Profesor a in listProfesores)
                    {
                        archivo.WriteLine(a.Nombre);
                        archivo.WriteLine(a.Apellido);
                        archivo.WriteLine(a.Edad);
                        archivo.WriteLine(a.Dni);
                        archivo.WriteLine(a.Genero);
                        archivo.WriteLine(a.Puesto);
                        archivo.WriteLine(a.Antiguedad);
                        archivo.WriteLine(a.Sueldo);
                        archivo.WriteLine(a.HorasSemanales);
                        archivo.WriteLine("*");
                    }
                    archivo.Close();
                    MessageBox.Show("El archivo se guardó correctamente", "Confirmación");
                }

                catch (Exception ex)
                {
                    MessageBox.Show("La ruta especificada no existe", "Error");
                    MessageBox.Show(ex.Message, "Error");
                }
                
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Alguno de los datos ingresados no corresponde con el tipo de datos solicitados");
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                menu = new frmMenu();
                menu.Show();
                this.Close();
            }
        }
    }
}

using BL.Citas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.CitasMedicas
{
    public partial class Form1  : Form
    {
        SeguridadBL _seguridad;/*Variable global*/

        /*Deberia de ser FormLogin(Form1*/
        public Form1()
        {
            InitializeComponent();
            _seguridad = new SeguridadBL();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Usuario;
            string Contraseña;

            Usuario = textBox1.Text;
            Contraseña = textBox2.Text;

           var resultado = _seguridad.Autorizar(Usuario, Contraseña);

            if (resultado == true)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Verifique Su Usuario o Contraseña Incorrecta");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;

            }
            else
            {
                this.WindowState = FormWindowState.Normal;

            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

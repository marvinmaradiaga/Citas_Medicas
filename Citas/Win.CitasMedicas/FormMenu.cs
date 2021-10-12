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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        /* Este deberia de ser FormClientes*/
        private void medicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formClientes = new FormClientes();
            formClientes.MdiParent = this;
            formClientes.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            /*Esta variable viene Login (Deberia de ser FormLogin) */
            Login();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Esta variable viene Login (Deberia de ser FormLogin) */
            Login();
        }

        private void Login()
        {
            var form1 = new Form1();
            form1.ShowDialog();
        }

        private void agendarCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formAgendarCitas = new FormAgendarCitas();
            formAgendarCitas.MdiParent = this;
            formAgendarCitas.Show();
        }

        private void buscarMedicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formMedicamentos = new FormMedicamentos();
            formMedicamentos.MdiParent = this;
            formMedicamentos.Show();
        }

        private void calendarioDeCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCalendario = new FormCalendario();
            formCalendario.MdiParent = this;
            formCalendario.Show();
        }
    }
}

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
    public partial class FormMedicamentos : Form
    {
        MedicamentosBL _medicamentos;
        public FormMedicamentos()
        {
            InitializeComponent();
            _medicamentos = new MedicamentosBL();
            listaMedicamentosBindingSource.DataSource = _medicamentos.ObtenerMedicamentos();
        }

        private void FormMedicamentos_Load(object sender, EventArgs e)
        {

        }
        //Agregando el boton de guardar.
        private void listaMedicamentosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaMedicamentosBindingSource.EndEdit();
            var medicamentos = (Medicamento)listaMedicamentosBindingSource.Current;

            var resultado = _medicamentos.GardarMedicamentos(medicamentos);

            if (resultado.Exitoso == true)
            {
                listaMedicamentosBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Medicamento Guardado");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
            
        }

        //Agregando boton de agregar nuevo medicamento

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _medicamentos.AgregarMedicamento();
            listaMedicamentosBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }
        // Deshabilitando botones.
    
        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtonCancelar.Visible = !valor;
        }

        // Agregar boton de eliminar.
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
         

            if(idTextBox.Text != "")
            {
                    var resultado = MessageBox.Show("Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);

                    if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }
                        
            }
        }

        private void Eliminar(int id)
        {
            
            var resultado = _medicamentos.EliminarMedicamento(id);

            if (resultado == true)
            {
                listaMedicamentosBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error en eliminar Medicamento");
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarBotones(true);
            Eliminar(0);
        }
    }
}

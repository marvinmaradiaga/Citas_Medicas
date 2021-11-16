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
    public partial class FormReporteMedicamentos : Form
    {
        public FormReporteMedicamentos()
        {
            InitializeComponent();
            // para enlazar nuestro reporte Medicamentos 
            var _medicamentoBL = new MedicamentosBL();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = _medicamentoBL.ObtenerMedicamentos();

            var reporte = new ReporteMedicamentos();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
// esta linea de comando esta vinculada ah repormedian.Designer segun el video no sale
      /*  private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }*/
    }
}

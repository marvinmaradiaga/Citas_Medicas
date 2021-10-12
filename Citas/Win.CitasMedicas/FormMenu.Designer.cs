namespace Win.CitasMedicas
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programarCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendarCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarioDeCitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarMedicamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesDeCitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeCalendarioDeCitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeMedicamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programarCitaToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.seguridadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(383, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programarCitaToolStripMenuItem
            // 
            this.programarCitaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendarCitaToolStripMenuItem,
            this.medicamentosToolStripMenuItem,
            this.calendarioDeCitasToolStripMenuItem,
            this.buscarMedicamentosToolStripMenuItem});
            this.programarCitaToolStripMenuItem.Name = "programarCitaToolStripMenuItem";
            this.programarCitaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.programarCitaToolStripMenuItem.Text = "Consultas";
            // 
            // agendarCitaToolStripMenuItem
            // 
            this.agendarCitaToolStripMenuItem.Name = "agendarCitaToolStripMenuItem";
            this.agendarCitaToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.agendarCitaToolStripMenuItem.Text = "Agendar Cita";
            this.agendarCitaToolStripMenuItem.Click += new System.EventHandler(this.agendarCitaToolStripMenuItem_Click);
            // 
            // medicamentosToolStripMenuItem
            // 
            this.medicamentosToolStripMenuItem.Name = "medicamentosToolStripMenuItem";
            this.medicamentosToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.medicamentosToolStripMenuItem.Text = "Buscar Clientes";
            this.medicamentosToolStripMenuItem.Click += new System.EventHandler(this.medicamentosToolStripMenuItem_Click);
            // 
            // calendarioDeCitasToolStripMenuItem
            // 
            this.calendarioDeCitasToolStripMenuItem.Name = "calendarioDeCitasToolStripMenuItem";
            this.calendarioDeCitasToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.calendarioDeCitasToolStripMenuItem.Text = "Calendario de Citas";
            this.calendarioDeCitasToolStripMenuItem.Click += new System.EventHandler(this.calendarioDeCitasToolStripMenuItem_Click);
            // 
            // buscarMedicamentosToolStripMenuItem
            // 
            this.buscarMedicamentosToolStripMenuItem.Name = "buscarMedicamentosToolStripMenuItem";
            this.buscarMedicamentosToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.buscarMedicamentosToolStripMenuItem.Text = "Buscar Medicamentos";
            this.buscarMedicamentosToolStripMenuItem.Click += new System.EventHandler(this.buscarMedicamentosToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesDeCitasToolStripMenuItem,
            this.reporteDeClientesToolStripMenuItem,
            this.reporteDeCalendarioDeCitasToolStripMenuItem,
            this.reporteDeMedicamentosToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reportesDeCitasToolStripMenuItem
            // 
            this.reportesDeCitasToolStripMenuItem.Name = "reportesDeCitasToolStripMenuItem";
            this.reportesDeCitasToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.reportesDeCitasToolStripMenuItem.Text = "Reporte de Citas";
            // 
            // reporteDeClientesToolStripMenuItem
            // 
            this.reporteDeClientesToolStripMenuItem.Name = "reporteDeClientesToolStripMenuItem";
            this.reporteDeClientesToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.reporteDeClientesToolStripMenuItem.Text = "Reporte de Clientes";
            // 
            // reporteDeCalendarioDeCitasToolStripMenuItem
            // 
            this.reporteDeCalendarioDeCitasToolStripMenuItem.Name = "reporteDeCalendarioDeCitasToolStripMenuItem";
            this.reporteDeCalendarioDeCitasToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.reporteDeCalendarioDeCitasToolStripMenuItem.Text = "Reporte de Calendario de Citas";
            // 
            // reporteDeMedicamentosToolStripMenuItem
            // 
            this.reporteDeMedicamentosToolStripMenuItem.Name = "reporteDeMedicamentosToolStripMenuItem";
            this.reporteDeMedicamentosToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.reporteDeMedicamentosToolStripMenuItem.Text = "Reporte de Medicamentos";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 261);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "Menú Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programarCitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendarCitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarioDeCitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesDeCitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeCalendarioDeCitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarMedicamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeMedicamentosToolStripMenuItem;
    }
}
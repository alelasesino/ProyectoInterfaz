using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoInterfaz {
    public partial class FormPolizaFilter:Form {

        public DateTime dtFechaDesde, dtFechaHasta;
        private int[] id_clientes;

        public FormPolizaFilter(int[] id_clientes, DateTime fechaDesde,DateTime fechaHasta) {
            this.id_clientes = id_clientes;
            this.dtFechaDesde = fechaDesde;
            this.dtFechaHasta = fechaHasta;

            InitializeComponent();
            initializeDatepickers();

            comboEstado.SelectedIndex = 0;

        }

        private void initializeDatepickers() {
        
            if(dtFechaDesde != null)
                fechaDesde.Value = dtFechaDesde;

            if(dtFechaHasta != null)
                fechaHasta.Value = dtFechaHasta;

        }


        private void btAceptar_Click(object sender,EventArgs e) {

            string estado = comboEstado.Text;

            if(estado == "Todos")
                estado = "";

            dtFechaDesde = fechaDesde.Value;
            dtFechaHasta = fechaHasta.Value;

            FormReport form = new FormReport(id_clientes,fechaDesde.Value,fechaHasta.Value,estado);
            form.Show();

            Dispose();

        }

        private void btCancelar_Click(object sender,EventArgs e) {

            Close();

        }
    }
}

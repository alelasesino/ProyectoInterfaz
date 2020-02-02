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

        private int[] id_clientes;

        public FormPolizaFilter(int[] id_clientes) {
            this.id_clientes = id_clientes;
            InitializeComponent();
        }

        private void btAceptar_Click(object sender,EventArgs e) {

            FormReport form = new FormReport(id_clientes,fechaDesde.Value,fechaHasta.Value);
            form.Show();
            Close();

        }

        private void btCancelar_Click(object sender,EventArgs e) {
            Close();
        }
    }
}

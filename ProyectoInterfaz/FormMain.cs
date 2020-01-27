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
    public partial class FormMain:System.Windows.Forms.Form {
        public FormMain() {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender,EventArgs e) {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.segurosDataSet);

        }

        private void Form1_Load(object sender,EventArgs e) {
            // TODO: esta línea de código carga datos en la tabla 'segurosDataSet.poliza' Puede moverla o quitarla según sea necesario.
            this.polizaTableAdapter.Fill(this.segurosDataSet.poliza);
            // TODO: esta línea de código carga datos en la tabla 'segurosDataSet.cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.segurosDataSet.cliente);

        }

        private void bindingNavigatorAddNewItem_Click(object sender,EventArgs e) {

            //Form1 form = new Form1(this.clienteBindingSource);
            //form.Show();

        }
    }
}

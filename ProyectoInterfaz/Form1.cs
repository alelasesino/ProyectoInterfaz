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
    public partial class Form1:Form {

        private BindingSource clienteBindingSource;

        public Form1(BindingSource clienteBindingSource) {
            this.clienteBindingSource = clienteBindingSource;
            InitializeComponent();

            textNombre.DataBindings.Add(new Binding("Text",this.clienteBindingSource,"nombre",true));
            textApellido.DataBindings.Add(new Binding("Text",this.clienteBindingSource,"apellido",true));
            textTelefono.DataBindings.Add(new Binding("Text",this.clienteBindingSource,"telefono",true));
            textLocalidad.DataBindings.Add(new Binding("Text",this.clienteBindingSource,"localidad",true));
            textCodigoPostal.DataBindings.Add(new Binding("Text",this.clienteBindingSource,"codigo_postal",true));
            textPronvincia.DataBindings.Add(new Binding("Text",this.clienteBindingSource,"provincia",true));

        }

        private void btAceptar_Click(object sender,EventArgs e) {
            Hide();
        }

        private void polizaBindingNavigatorSaveItem_Click(object sender,EventArgs e) {
            this.Validate();
            this.polizaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.segurosDataSet);

        }

        private void Form1_Load(object sender,EventArgs e) {
            // TODO: esta línea de código carga datos en la tabla 'segurosDataSet.poliza' Puede moverla o quitarla según sea necesario.
            this.polizaTableAdapter.Fill(this.segurosDataSet.poliza);

        }
    }
}

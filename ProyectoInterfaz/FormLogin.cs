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
    public partial class FormLogin:Form {
        public FormLogin() {
            InitializeComponent();
        }

        private void btLogin_Click(object sender,EventArgs e) {

            if(acceptLogin()) {

                FormMain form = new FormMain();
                form.Show();
                Hide();

            } else {
                MessageBox.Show(this,"Usuario o contraseña incorrecta","Login erroreo");
                txtPassword.Text = "";
            }

        }

        private bool acceptLogin() {
                
            foreach(DataRow row in segurosDataSet.Tables["usuario"].Rows){
                
                Console.WriteLine();
                if(row["username"].ToString() == txtUsername.Text)
                    return row["password"].ToString() == txtPassword.Text;
                
            }

            return false;

        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender,EventArgs e) {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.segurosDataSet);

        }

        private void FormLogin_Load(object sender,EventArgs e) {
            // TODO: esta línea de código carga datos en la tabla 'segurosDataSet.usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.segurosDataSet.usuario);

        }
    }
}

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
    public partial class FormMain: Form {

        private DateTimePicker cellDateTimePicker = new DateTimePicker();

        public FormMain() {
            InitializeComponent();

            polizaDataGridView.Controls.Add(cellDateTimePicker);
            cellDateTimePicker.Visible = false;
            cellDateTimePicker.Format = DateTimePickerFormat.Custom;
            cellDateTimePicker.TextChanged += new EventHandler(cellDateTimePickerChanged);

        }

        private void clienteBindingNavigatorSaveItem_Click(object sender,EventArgs e) {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.segurosDataSet);

        }

        private void polizaBindingNavigatorSaveItem_Click(object sender,EventArgs e) {
            this.Validate();
            this.polizaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.segurosDataSet);

        }

        private void Form1_Load(object sender,EventArgs e) {
            // TODO: esta línea de código carga datos en la tabla 'segurosDataSet.poliza' Puede moverla o quitarla según sea necesario.
            this.polizaTableAdapter.Fill(this.segurosDataSet.poliza);
            //this.polizaDataGridView.Columns[0].Visible = false;
            // TODO: esta línea de código carga datos en la tabla 'segurosDataSet.cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.segurosDataSet.cliente);
        }

        private void bindingNavigatorAddNewItem_Click(object sender,EventArgs e) {

            //Form1 form = new Form1(this.clienteBindingSource);
            //form.Show();

        }

        private void polizaDataGridView_CellBeginEdit(object sender,DataGridViewCellCancelEventArgs e) {

            switch(polizaDataGridView.Columns[e.ColumnIndex].Name){
            case "fecha":
                var _Rectangle = polizaDataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                cellDateTimePicker.Size = new Size(_Rectangle.Width, _Rectangle.Height);
                cellDateTimePicker.Location = new Point(_Rectangle.X, _Rectangle.Y);
                cellDateTimePicker.Visible = true;
            break;
            }    

        }

        private void cellDateTimePickerChanged(object sender, EventArgs e) {
        
            polizaDataGridView.CurrentCell.Value = cellDateTimePicker.Text.ToString();
        
        }

        private void polizaDataGridView_CancelRowEdit(object sender,QuestionEventArgs e) {
            cellDateTimePicker.Visible = false;
        }

        private void polizaDataGridView_CellEndEdit(object sender,DataGridViewCellEventArgs e) {
            
            if(polizaDataGridView.Columns[e.ColumnIndex].Name == "fecha") {

                polizaDataGridView.CurrentCell.Value = cellDateTimePicker.Text.ToString();
                cellDateTimePicker.Visible = false;

            }
            
        }
    }

}

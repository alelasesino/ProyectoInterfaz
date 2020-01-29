using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoInterfaz {
    public partial class FormMain: Form {

        private DateTimePicker cellDateTimePicker = new DateTimePicker();
        private int idClientSelected;
        private int currentRowSelected;

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
            this.clienteTableAdapterManager.UpdateAll(this.segurosDataSet);
            this.clienteTableAdapter.Fill(this.segurosDataSet.cliente);
        }

        private void polizaBindingNavigatorSaveItem_Click(object sender,EventArgs e) {
            this.Validate();
            this.polizaBindingSource.EndEdit();
            this.polizaTableAdapterManager.UpdateAll(this.segurosDataSet);
            this.polizaTableAdapter.Fill(this.segurosDataSet.poliza);
        }

        private void Form1_Load(object sender,EventArgs e) {
            // TODO: esta línea de código carga datos en la tabla 'segurosDataSet.poliza' Puede moverla o quitarla según sea necesario.
            this.polizaTableAdapter.Fill(this.segurosDataSet.poliza);
            // TODO: esta línea de código carga datos en la tabla 'segurosDataSet.cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.segurosDataSet.cliente);
        }

        private void polizaDataGridView_CellBeginEdit(object sender,DataGridViewCellCancelEventArgs e) {

            if(polizaDataGridView.Columns[e.ColumnIndex].Name == "fecha") {

                var rectangle = polizaDataGridView.GetCellDisplayRectangle(e.ColumnIndex,e.RowIndex,true);
                cellDateTimePicker.Size = new Size(rectangle.Width,rectangle.Height);
                cellDateTimePicker.Location = new Point(rectangle.X,rectangle.Y);
                cellDateTimePicker.Visible = true;

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

        private void textBuscar_TextChanged(object sender,EventArgs e) {
            clienteBindingSource.Filter = "nombre LIKE '*" + textBuscar.Text + "*'";
        }

        private void clienteDataGridView_RowStateChanged(object sender,DataGridViewRowStateChangedEventArgs e) {
            
            if(clienteDataGridView != null && clienteDataGridView.SelectedRows.Count > 0) {

                DataGridViewRow row = getRowSelected(clienteDataGridView);
                Object value = row.Cells[0].Value;
                
                if(value != null)
                    idClientSelected = Int32.Parse(value.ToString());
                else
                    idClientSelected = -1;
                
                polizaBindingSource.Filter = "id_cliente = '" + idClientSelected + "'";

                if(idClientSelected == -1 && tabMain.TabPages.Contains(tabPolizas)) {

                    tabMain.TabPages.Remove(tabPolizas);

                } else {

                    if(!tabMain.TabPages.Contains(tabPolizas))
                        tabMain.TabPages.Add(tabPolizas);

                }

                currentRowSelected = clienteDataGridView.CurrentCell.RowIndex;

            }
        }

        private DataGridViewRow getRowSelected(DataGridView view) {

            int indexSelected = view.SelectedCells[0].RowIndex;
            return view.Rows[indexSelected];

        }

        private void clienteDataGridView_CellMouseDoubleClick(object sender,DataGridViewCellMouseEventArgs e) {

            if(idClientSelected != -1)
                tabMain.SelectedTab = tabPolizas;

        }

    }

}

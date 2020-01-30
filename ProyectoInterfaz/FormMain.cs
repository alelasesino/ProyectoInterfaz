using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoInterfaz {
    public partial class FormMain: Form {

        private DateTimePicker cellDateTimePicker = new DateTimePicker();
        private ComboBox stateCombox = new ComboBox();
        private Cliente currentClientSelected;
        private Poliza currentPolizaSelected;
        //private int currentClientRowSelected;

        public FormMain() {
            InitializeComponent();

            polizaDataGridView.Controls.Add(cellDateTimePicker);
            cellDateTimePicker.Visible = false;
            cellDateTimePicker.Format = DateTimePickerFormat.Custom;
            cellDateTimePicker.TextChanged += new EventHandler(cellDateTimePickerChanged);

            polizaDataGridView.Controls.Add(stateCombox);
            stateCombox.Visible = false;
            stateCombox.FormattingEnabled = true;
            stateCombox.Items.AddRange(new object[] {
            "Cobrada",
            "A cuenta",
            "Liquidada",
            "Pre Anulada",
            "Anulada"});
            stateCombox.Name = "State Combo";
            stateCombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

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
            // TODO: esta línea de código carga datos en la tabla 'segurosDataSet.pago' Puede moverla o quitarla según sea necesario.
            this.pagoTableAdapter.Fill(this.segurosDataSet.pago);
            // TODO: esta línea de código carga datos en la tabla 'segurosDataSet.poliza' Puede moverla o quitarla según sea necesario.
            this.polizaTableAdapter.Fill(this.segurosDataSet.poliza);
            // TODO: esta línea de código carga datos en la tabla 'segurosDataSet.cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.segurosDataSet.cliente);
        }

        private void polizaDataGridView_CellBeginEdit(object sender,DataGridViewCellCancelEventArgs e) {

            switch(polizaDataGridView.Columns[e.ColumnIndex].Name) {
            
                case "fecha":

                    var rectangleDate = polizaDataGridView.GetCellDisplayRectangle(e.ColumnIndex,e.RowIndex,true);
                    cellDateTimePicker.Size = new Size(rectangleDate.Width,rectangleDate.Height);
                    cellDateTimePicker.Location = new Point(rectangleDate.X,rectangleDate.Y);
                    cellDateTimePicker.Visible = true;

                    if(polizaDataGridView.CurrentCell.Value.ToString() != "")
                        cellDateTimePicker.Value = Convert.ToDateTime(polizaDataGridView.CurrentCell.Value.ToString());
                    else
                        cellDateTimePicker.Value = DateTime.Today;
                break;

                case "estado":

                    var rectangleState = polizaDataGridView.GetCellDisplayRectangle(e.ColumnIndex,e.RowIndex,true);
                    stateCombox.Size = new Size(rectangleState.Width,rectangleState.Height);
                    stateCombox.Location = new Point(rectangleState.X,rectangleState.Y);
                    stateCombox.Visible = true;

                    if(polizaDataGridView.CurrentCell.Value.ToString() != "")
                        stateCombox.SelectedItem = polizaDataGridView.CurrentCell.Value.ToString();
                     else
                        stateCombox.SelectedIndex = 0;

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

            switch(polizaDataGridView.Columns[e.ColumnIndex].Name) {

                case "fecha":
                    polizaDataGridView.CurrentCell.Value = cellDateTimePicker.Text.ToString();
                    cellDateTimePicker.Visible = false;
                break;

                case "estado":
                    polizaDataGridView.CurrentCell.Value = stateCombox.Text.ToString();
                    stateCombox.Visible = false;
                break;

            }

        }

        private void textBuscar_TextChanged(object sender,EventArgs e) {
            clienteBindingSource.Filter = "nombre LIKE '*" + textBuscar.Text + "*'";
        }

        private void clienteDataGridView_RowStateChanged(object sender,DataGridViewRowStateChangedEventArgs e) {
            
            if(clienteDataGridView != null && clienteDataGridView.SelectedRows.Count > 0) {

                currentClientSelected = getClientSelected();
                polizaBindingSource.Filter = "id_cliente = '" + currentClientSelected.id + "'";
                lblClientePolizas.Text = currentClientSelected.nombre.ToUpper();
                lblClientePagos.Text = lblClientePolizas.Text;

                if(currentClientSelected.id == -1 && tabMain.TabPages.Contains(tabPolizas)) {

                    tabMain.TabPages.Remove(tabPolizas);

                } else {

                    if(!tabMain.TabPages.Contains(tabPolizas))
                        tabMain.TabPages.Add(tabPolizas);

                }

                //currentClientRowSelected = clienteDataGridView.CurrentCell.RowIndex;

            }

        }

        private Cliente getClientSelected() {

            DataGridViewRow row = getRowSelected(clienteDataGridView);
            Cliente cliente = new Cliente();
            cliente.id = toInt(row.Cells[0].Value);
            cliente.nombre = toString(row.Cells[1].Value);
            cliente.apellido = toString(row.Cells[2].Value);
            cliente.telefono = toString(row.Cells[3].Value);
            cliente.localidad = toString(row.Cells[4].Value);
            cliente.codigoPostal = toInt(row.Cells[5].Value);
            cliente.provincia = toString(row.Cells[6].Value);
            cliente.empresa = toString(row.Cells[7].Value) == "True";
            
            return cliente;

        }

        private Poliza getPolizaSelected() {

            DataGridViewRow row = getRowSelected(polizaDataGridView);
            Poliza poliza = new Poliza();
            poliza.id = toInt(row.Cells[0].Value);
            poliza.idCliente = toInt(row.Cells[1].Value);
            poliza.importe = toFloat(row.Cells[2].Value);
            poliza.fecha = toString(row.Cells[3].Value);
            poliza.estado = toString(row.Cells[4].Value);
            poliza.observaciones = toString(row.Cells[5].Value);

            return poliza;

        }

        private string toString(object obj){
        
            if(obj != null)
                return obj.ToString();

            return "";

        }

        private int toInt(object obj) {
            
            if(obj != null && obj.ToString() != "")
                return Int32.Parse(obj.ToString());

            return -1;

        }

        private float toFloat(object obj) {

            if(obj != null && obj.ToString() != "")
                return float.Parse(obj.ToString());

            return -1;

        }

        private DataGridViewRow getRowSelected(DataGridView view) {

            int indexSelected = view.SelectedCells[0].RowIndex;
            return view.Rows[indexSelected];

        }

        private void clienteDataGridView_CellMouseDoubleClick(object sender,DataGridViewCellMouseEventArgs e) {

            if(currentClientSelected.id != -1)
                tabMain.SelectedTab = tabPolizas;

        }

        private void pagoBindingNavigatorSavePago_Click(object sender,EventArgs e) {
            this.Validate();
            this.pagoBindingSource.EndEdit();
            this.pagoTableAdapterManager.UpdateAll(this.segurosDataSet);
            this.pagoTableAdapter.Fill(this.segurosDataSet.pago);
        }

        private void bindingNavigatorAddNewPoliza_Click(object sender,EventArgs e) {
            
            //polizaDataGridView.CurrentRow.Cells[0].Value = 0;
            polizaDataGridView.CurrentRow.Cells[1].Value = currentClientSelected.id;
            polizaDataGridView.CurrentRow.Cells[3].Value = DateTime.Today;
            polizaDataGridView.CurrentRow.Cells[4].Value = "A cuenta";

        }

        private void polizaDataGridView_RowStateChanged(object sender,DataGridViewRowStateChangedEventArgs e) {

            if(polizaDataGridView != null && polizaDataGridView.SelectedRows.Count > 0) {

                currentPolizaSelected = getPolizaSelected();
                pagoBindingSource.Filter = "id_poliza = '" + currentPolizaSelected.id + "'";
                //lblCliente.Text = currentClientSelected.nombre.ToUpper();
                
                if(currentPolizaSelected.id == -1 && tabMain.TabPages.Contains(tabPagos)) {

                    tabMain.TabPages.Remove(tabPagos);

                } else {

                    if(!tabMain.TabPages.Contains(tabPagos))
                        tabMain.TabPages.Add(tabPagos);

                }

                //currentRowSelected = clienteDataGridView.CurrentCell.RowIndex;

            }

        }

        private void bindingNavigatorAddNewPago_Click(object sender,EventArgs e) {

            //pagoDataGridView.CurrentRow.Cells[0].Value = 0;
            pagoDataGridView.CurrentRow.Cells[1].Value = currentPolizaSelected.id;

        }

        private void polizaDataGridView_CellMouseDoubleClick(object sender,DataGridViewCellMouseEventArgs e) {

            if(currentPolizaSelected.id != -1)
                tabMain.SelectedTab = tabPagos;

        }

        private void polizaDataGridView_CellFormatting(object sender,DataGridViewCellFormattingEventArgs e) {
            
            /*IDictionary<string,Color> fontColor = new Dictionary<string,Color>();
            fontColor["A cuenta"] = ColorTranslator.FromHtml("#000000");
            fontColor["Cobrada"] = ColorTranslator.FromHtml("#000000");
            fontColor["Liquidada"] = ColorTranslator.FromHtml("#000000");
            fontColor["Pre Anulada"] = ColorTranslator.FromHtml("#000000");
            fontColor["Anulada"] = ColorTranslator.FromHtml("#000000");*/

            IDictionary<string,Color> bgColor = new Dictionary<string,Color>();
            bgColor["A cuenta"] = ColorTranslator.FromHtml("#FF8989");
            bgColor["Cobrada"] = ColorTranslator.FromHtml("#96FF99");
            bgColor["Liquidada"] = ColorTranslator.FromHtml("#A2FFF2");
            bgColor["Pre Anulada"] = ColorTranslator.FromHtml("#9DCEFF");
            bgColor["Anulada"] = ColorTranslator.FromHtml("#EEB0FF");

            foreach(DataGridViewRow row in polizaDataGridView.Rows) {
                
                string state = toString(row.Cells["estado"].Value);
                if(state != ""){
                    row.DefaultCellStyle.BackColor = bgColor[state];
                   //row.DefaultCellStyle.ForeColor = fontColor[state];
                }

            }

        }
    }

}

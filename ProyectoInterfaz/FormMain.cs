using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoInterfaz {
    public partial class FormMain: Form {

        private DateTimePicker cellDateTimePickerPolizas = new DateTimePicker();
        private DateTimePicker cellDateTimePickerPagos = new DateTimePicker();
        private ComboBox stateCombox = new ComboBox();
        private Cliente currentClientSelected;
        private Poliza currentPolizaSelected;
        //private int currentClientRowSelected;

        public FormMain() {
            InitializeComponent();

            polizaDataGridView.Controls.Add(cellDateTimePickerPolizas);
            cellDateTimePickerPolizas.Visible = false;
            cellDateTimePickerPolizas.Format = DateTimePickerFormat.Custom;
            cellDateTimePickerPolizas.TextChanged += new EventHandler(cellDateTimePickerChangedPolizas);

            polizaDataGridView.Controls.Add(stateCombox);
            stateCombox.Visible = false;
            stateCombox.FormattingEnabled = true;
            stateCombox.Items.AddRange(new object[] {
            "Cobrada",
            "A cuenta",
            "Liquidada",
            "Pre anulada",
            "Anulada"});
            stateCombox.Name = "State Combo";
            stateCombox.DropDownStyle = ComboBoxStyle.DropDownList;

            pagoDataGridView.Controls.Add(cellDateTimePickerPagos);
            cellDateTimePickerPagos.Visible = false;
            cellDateTimePickerPagos.Format = DateTimePickerFormat.Custom;
            cellDateTimePickerPagos.TextChanged += new EventHandler(cellDateTimePickerChangedPagos);

        }

        private void clienteBindingNavigatorSaveItem_Click(object sender,EventArgs e) {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.clienteTableAdapterManager.UpdateAll(this.segurosDataSet);
            this.clienteTableAdapter.Fill(this.segurosDataSet.cliente);

            if(editCliente.BackColor != Color.Transparent)
                changeEditMode(clienteDataGridView,editCliente);
        }

        private void polizaBindingNavigatorSaveItem_Click(object sender,EventArgs e) {
            this.Validate();
            this.polizaBindingSource.EndEdit();
            this.polizaTableAdapterManager.UpdateAll(this.segurosDataSet);
            this.polizaTableAdapter.Fill(this.segurosDataSet.poliza);

            if(editPoliza.BackColor != Color.Transparent)
                changeEditMode(polizaDataGridView,editPoliza);
        }

        private void pagoBindingNavigatorSavePago_Click(object sender,EventArgs e) {
            this.Validate();
            this.pagoBindingSource.EndEdit();
            this.pagoTableAdapterManager.UpdateAll(this.segurosDataSet);
            this.pagoTableAdapter.Fill(this.segurosDataSet.pago);

            if(editPago.BackColor != Color.Transparent)
                changeEditMode(pagoDataGridView,editPago);
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
            
                case "fecha_poliza":

                    var rectangleDate = polizaDataGridView.GetCellDisplayRectangle(e.ColumnIndex,e.RowIndex,true);
                    cellDateTimePickerPolizas.Size = new Size(rectangleDate.Width,rectangleDate.Height);
                    cellDateTimePickerPolizas.Location = new Point(rectangleDate.X,rectangleDate.Y);
                    cellDateTimePickerPolizas.Visible = true;

                    if(polizaDataGridView.CurrentCell.Value.ToString() != "")
                        cellDateTimePickerPolizas.Value = Convert.ToDateTime(polizaDataGridView.CurrentCell.Value.ToString());
                    else
                        cellDateTimePickerPolizas.Value = DateTime.Today;
                break;

                case "estado_poliza":

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

        private void cellDateTimePickerChangedPolizas(object sender, EventArgs e) {
            polizaDataGridView.CurrentCell.Value = cellDateTimePickerPolizas.Text.ToString();
        }

        private void cellDateTimePickerChangedPagos(object sender,EventArgs e) {
            pagoDataGridView.CurrentCell.Value = cellDateTimePickerPagos.Text.ToString();
        }

        private void polizaDataGridView_CancelRowEdit(object sender,QuestionEventArgs e) {
            cellDateTimePickerPolizas.Visible = false;
        }

        private void polizaDataGridView_CellEndEdit(object sender,DataGridViewCellEventArgs e) {

            switch(polizaDataGridView.Columns[e.ColumnIndex].Name) {

                case "fecha_poliza":
                    polizaDataGridView.CurrentCell.Value = cellDateTimePickerPolizas.Text.ToString();
                    cellDateTimePickerPolizas.Visible = false;
                break;

                case "estado_poliza":
                    polizaDataGridView.CurrentCell.Value = stateCombox.Text.ToString();
                    stateCombox.Visible = false;
                break;

            }

        }

        private void textBuscar_TextChanged(object sender,EventArgs e) {
            clienteBindingSource.Filter = "nombre LIKE '*" + textBuscarCliente.Text + "*'";
        }

        private void clienteDataGridView_RowStateChanged(object sender,DataGridViewRowStateChangedEventArgs e) {
            
            if(clienteDataGridView != null && clienteDataGridView.SelectedRows.Count > 0) {

                currentClientSelected = getClientSelected();
                polizaBindingSource.Filter = "id_cliente = '" + currentClientSelected.id + "'";
                lblClientePolizas.Text = currentClientSelected.nombre.ToUpper();
                lblClientePagos.Text = lblClientePolizas.Text;

                /*if(currentClientSelected.id == -1 && tabMain.TabPages.Contains(tabPolizas)) {

                    tabMain.TabPages.Remove(tabPolizas);

                } else {

                    if(!tabMain.TabPages.Contains(tabPolizas))
                        tabMain.TabPages.Add(tabPolizas);

                }*/

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

            if(currentClientSelected.id != -1 && editCliente.BackColor == Color.Transparent) {
                tabMain.SelectedTab = tabPolizas;
                polizaDataGridView.Sort(this.polizaDataGridView.Columns["fecha_poliza"],ListSortDirection.Descending);
            }

        }

        private void bindingNavigatorAddNewPoliza_Click(object sender,EventArgs e) {
            
            //polizaDataGridView.CurrentRow.Cells[0].Value = 0;
            polizaDataGridView.CurrentRow.Cells[1].Value = currentClientSelected.id;
            polizaDataGridView.CurrentRow.Cells[3].Value = DateTime.Today;
            polizaDataGridView.CurrentRow.Cells[4].Value = "A cuenta";

            changeEditMode(polizaDataGridView,editPoliza);

        }

        private void polizaDataGridView_RowStateChanged(object sender,DataGridViewRowStateChangedEventArgs e) {

            if(polizaDataGridView != null && polizaDataGridView.SelectedRows.Count > 0) {

                currentPolizaSelected = getPolizaSelected();
                pagoBindingSource.Filter = "id_poliza = '" + currentPolizaSelected.id + "'";
                //lblCliente.Text = currentClientSelected.nombre.ToUpper();
                
                /*if(currentPolizaSelected.id == -1 && tabMain.TabPages.Contains(tabPagos)) {

                    tabMain.TabPages.Remove(tabPagos);

                } else {

                    if(!tabMain.TabPages.Contains(tabPagos))
                        tabMain.TabPages.Add(tabPagos);

                }*/

                //currentRowSelected = clienteDataGridView.CurrentCell.RowIndex;

            }

        }

        private void bindingNavigatorAddNewPago_Click(object sender,EventArgs e) {

            //pagoDataGridView.CurrentRow.Cells[0].Value = 0;
            pagoDataGridView.CurrentRow.Cells[1].Value = currentPolizaSelected.id;
            pagoDataGridView.CurrentRow.Cells[3].Value = DateTime.Today;
            changeEditMode(pagoDataGridView,editPago);

        }

        private void polizaDataGridView_CellMouseDoubleClick(object sender,DataGridViewCellMouseEventArgs e) {

            if(currentPolizaSelected.id != -1 && editPoliza.BackColor == Color.Transparent)
                tabMain.SelectedTab = tabPagos;

        }

        private void polizaDataGridView_CellFormatting(object sender,DataGridViewCellFormattingEventArgs e) {

            IDictionary<string,Color> bgColor = new Dictionary<string,Color>();
            bgColor["A cuenta"] = ColorTranslator.FromHtml("#FF8989");
            bgColor["Cobrada"] = ColorTranslator.FromHtml("#96FF99");
            bgColor["Liquidada"] = ColorTranslator.FromHtml("#A2FFF2");
            bgColor["Pre anulada"] = ColorTranslator.FromHtml("#9DCEFF");
            bgColor["Anulada"] = ColorTranslator.FromHtml("#EEB0FF");

            foreach(DataGridViewRow row in polizaDataGridView.Rows) {
                
                string state = toString(row.Cells["estado_poliza"].Value);

                if(state != "")
                    row.DefaultCellStyle.BackColor = bgColor[state];

            }

        }

        private void informeCliente_Click(object sender,EventArgs e) {
            
            int[] id_clientes = new int[clienteDataGridView.SelectedRows.Count];

            int i = 0;
            foreach(DataGridViewRow row in clienteDataGridView.SelectedRows)
                id_clientes[i++] = toInt(row.Cells["id_cliente"].Value);
            
            FormPolizaFilter form = new FormPolizaFilter(id_clientes);
            form.Show();

        }

        private void editCliente_Click(object sender,EventArgs e) {

            changeEditMode(clienteDataGridView,editCliente);

        }

        private void editPoliza_Click(object sender,EventArgs e) {

            changeEditMode(polizaDataGridView,editPoliza);

        }

        private void editPago_Click(object sender,EventArgs e) {

            changeEditMode(pagoDataGridView, editPago);

        }

        private void changeEditMode(DataGridView datagrid,ToolStripButton editButton) {
            
            editButton.BackColor = (editButton.BackColor == Color.Transparent) ? ColorTranslator.FromHtml("#FF7D12") : Color.Transparent;
            datagrid.ReadOnly = (editButton.BackColor == Color.Transparent);
            
            if(datagrid.Columns.Contains("liquidado")){
                datagrid.Columns["liquidado"].ReadOnly = true;
                datagrid.Columns["restante"].ReadOnly = true;
            }

        }

        private void addNewCliente_Click(object sender,EventArgs e) {

            changeEditMode(clienteDataGridView,editCliente);

        }

        private void pagoDataGridView_CellBeginEdit(object sender,DataGridViewCellCancelEventArgs e) {

            switch(pagoDataGridView.Columns[e.ColumnIndex].Name) {

                case "fecha_pago":

                var rectangleDate = pagoDataGridView.GetCellDisplayRectangle(e.ColumnIndex,e.RowIndex,true);
                cellDateTimePickerPagos.Size = new Size(rectangleDate.Width,rectangleDate.Height);
                cellDateTimePickerPagos.Location = new Point(rectangleDate.X,rectangleDate.Y);
                cellDateTimePickerPagos.Visible = true;

                if(pagoDataGridView.CurrentCell.Value.ToString() != "")
                    cellDateTimePickerPagos.Value = Convert.ToDateTime(pagoDataGridView.CurrentCell.Value.ToString());
                else
                    cellDateTimePickerPagos.Value = DateTime.Today;
                break;

            }

        }

        private void pagoDataGridView_CellEndEdit(object sender,DataGridViewCellEventArgs e) {

            switch(pagoDataGridView.Columns[e.ColumnIndex].Name) {

                case "fecha_pago":
                pagoDataGridView.CurrentCell.Value = cellDateTimePickerPagos.Text.ToString();
                cellDateTimePickerPagos.Visible = false;
                break;

            }

        }

        private int getPagoTotal(int id) {

            int importeTotal = 0;
            pagoBindingSource.Filter = "id_poliza = '" + id + "'";
            
            foreach(DataGridViewRow row in pagoDataGridView.Rows) {

                int importe = toInt(row.Cells["importe_pago"].Value);

                if(importe != -1)
                    importeTotal += importe;

            }

            pagoBindingSource.Filter = "id_poliza = '" + currentPolizaSelected.id + "'";

            return importeTotal;

        }

        private void polizaDataGridView_CellPainting(object sender,DataGridViewCellPaintingEventArgs e) {

            if(e.RowIndex > -1) {
                DataGridViewRow row = polizaDataGridView.Rows[e.RowIndex];
                string importe_poliza = row.Cells["importe_poliza"].Value.ToString();

                int result;
                if(Int32.TryParse(importe_poliza,out result)) {
                    int total = getPagoTotal(toInt(row.Cells["id_poliza"].Value));
                    result = Int32.Parse(importe_poliza) - total;
                    row.Cells["restante"].Value = result;
                    row.Cells["liquidado"].Value = total;

                    if(result <= 0){
                    
                        row.Cells["estado_poliza"].Value = "Liquidada";
                        //this.polizaBindingNavigatorSaveItem_Click(null, null);
                    }

                }
            }

        }

    }

}

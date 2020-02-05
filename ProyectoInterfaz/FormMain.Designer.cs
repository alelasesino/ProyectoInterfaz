namespace ProyectoInterfaz {
    partial class FormMain {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabClientes = new System.Windows.Forms.TabPage();
            this.clienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.addNewCliente = new System.Windows.Forms.ToolStripButton();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.segurosDataSet = new ProyectoInterfaz.SegurosDataSet();
            this.countCliente = new System.Windows.Forms.ToolStripLabel();
            this.deleteCliente = new System.Windows.Forms.ToolStripButton();
            this.moveFirstCliente = new System.Windows.Forms.ToolStripButton();
            this.movePreviousCliente = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.positionCliente = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.moveNextCliente = new System.Windows.Forms.ToolStripButton();
            this.moveLastCliente = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveCliente = new System.Windows.Forms.ToolStripButton();
            this.editCliente = new System.Windows.Forms.ToolStripButton();
            this.informeCliente = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.lblBuscarCliente = new System.Windows.Forms.ToolStripLabel();
            this.textBuscarCliente = new System.Windows.Forms.ToolStripTextBox();
            this.clienteDataGridView = new System.Windows.Forms.DataGridView();
            this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo_postal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPolizas = new System.Windows.Forms.TabPage();
            this.lblClientePolizas = new System.Windows.Forms.Label();
            this.polizaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.addNewPoliza = new System.Windows.Forms.ToolStripButton();
            this.polizaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countPoliza = new System.Windows.Forms.ToolStripLabel();
            this.deletePoliza = new System.Windows.Forms.ToolStripButton();
            this.moveFirstPoliza = new System.Windows.Forms.ToolStripButton();
            this.movePreviousPoliza = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.positionPoliza = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.moveNextPoliza = new System.Windows.Forms.ToolStripButton();
            this.moveLastPoliza = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.savePoliza = new System.Windows.Forms.ToolStripButton();
            this.editPoliza = new System.Windows.Forms.ToolStripButton();
            this.polizaDataGridView = new System.Windows.Forms.DataGridView();
            this.id_poliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe_poliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_poliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_poliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liquidado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPagos = new System.Windows.Forms.TabPage();
            this.lblClientePagos = new System.Windows.Forms.Label();
            this.pagoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.addNewPago = new System.Windows.Forms.ToolStripButton();
            this.pagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countPago = new System.Windows.Forms.ToolStripLabel();
            this.deletePago = new System.Windows.Forms.ToolStripButton();
            this.moveFirstPago = new System.Windows.Forms.ToolStripButton();
            this.movePreviousPago = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.positionPago = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.moveNextPago = new System.Windows.Forms.ToolStripButton();
            this.moveLastPago = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.savePago = new System.Windows.Forms.ToolStripButton();
            this.editPago = new System.Windows.Forms.ToolStripButton();
            this.pagoDataGridView = new System.Windows.Forms.DataGridView();
            this.id_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_poliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteTableAdapter = new ProyectoInterfaz.SegurosDataSetTableAdapters.clienteTableAdapter();
            this.clienteTableAdapterManager = new ProyectoInterfaz.SegurosDataSetTableAdapters.TableAdapterManager();
            this.polizaTableAdapter = new ProyectoInterfaz.SegurosDataSetTableAdapters.polizaTableAdapter();
            this.polizaTableAdapterManager = new ProyectoInterfaz.SegurosDataSetTableAdapters.TableAdapterManager();
            this.pagoTableAdapter = new ProyectoInterfaz.SegurosDataSetTableAdapters.pagoTableAdapter();
            this.pagoTableAdapterManager = new ProyectoInterfaz.SegurosDataSetTableAdapters.TableAdapterManager();
            this.restante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabMain.SuspendLayout();
            this.tabClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).BeginInit();
            this.clienteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segurosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).BeginInit();
            this.tabPolizas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.polizaBindingNavigator)).BeginInit();
            this.polizaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.polizaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polizaDataGridView)).BeginInit();
            this.tabPagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pagoBindingNavigator)).BeginInit();
            this.pagoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabClientes);
            this.tabMain.Controls.Add(this.tabPolizas);
            this.tabMain.Controls.Add(this.tabPagos);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(852, 455);
            this.tabMain.TabIndex = 0;
            // 
            // tabClientes
            // 
            this.tabClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(150)))));
            this.tabClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabClientes.Controls.Add(this.clienteBindingNavigator);
            this.tabClientes.Controls.Add(this.clienteDataGridView);
            this.tabClientes.Location = new System.Drawing.Point(4, 22);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientes.Size = new System.Drawing.Size(844, 429);
            this.tabClientes.TabIndex = 0;
            this.tabClientes.Text = " Clientes";
            // 
            // clienteBindingNavigator
            // 
            this.clienteBindingNavigator.AddNewItem = this.addNewCliente;
            this.clienteBindingNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(150)))));
            this.clienteBindingNavigator.BindingSource = this.clienteBindingSource;
            this.clienteBindingNavigator.CountItem = this.countCliente;
            this.clienteBindingNavigator.DeleteItem = this.deleteCliente;
            this.clienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveFirstCliente,
            this.movePreviousCliente,
            this.bindingNavigatorSeparator,
            this.positionCliente,
            this.countCliente,
            this.bindingNavigatorSeparator1,
            this.moveNextCliente,
            this.moveLastCliente,
            this.bindingNavigatorSeparator2,
            this.addNewCliente,
            this.deleteCliente,
            this.saveCliente,
            this.editCliente,
            this.informeCliente,
            this.toolStripSeparator4,
            this.lblBuscarCliente,
            this.textBuscarCliente});
            this.clienteBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.clienteBindingNavigator.MoveFirstItem = this.moveFirstCliente;
            this.clienteBindingNavigator.MoveLastItem = this.moveLastCliente;
            this.clienteBindingNavigator.MoveNextItem = this.moveNextCliente;
            this.clienteBindingNavigator.MovePreviousItem = this.movePreviousCliente;
            this.clienteBindingNavigator.Name = "clienteBindingNavigator";
            this.clienteBindingNavigator.Padding = new System.Windows.Forms.Padding(0);
            this.clienteBindingNavigator.PositionItem = this.positionCliente;
            this.clienteBindingNavigator.Size = new System.Drawing.Size(836, 25);
            this.clienteBindingNavigator.TabIndex = 1;
            // 
            // addNewCliente
            // 
            this.addNewCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addNewCliente.Image = ((System.Drawing.Image)(resources.GetObject("addNewCliente.Image")));
            this.addNewCliente.Name = "addNewCliente";
            this.addNewCliente.RightToLeftAutoMirrorImage = true;
            this.addNewCliente.Size = new System.Drawing.Size(23, 22);
            this.addNewCliente.Text = "Agregar nuevo";
            this.addNewCliente.Click += new System.EventHandler(this.addNewCliente_Click);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.segurosDataSet;
            // 
            // segurosDataSet
            // 
            this.segurosDataSet.DataSetName = "SegurosDataSet";
            this.segurosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // countCliente
            // 
            this.countCliente.Name = "countCliente";
            this.countCliente.Size = new System.Drawing.Size(37, 22);
            this.countCliente.Text = "de {0}";
            this.countCliente.ToolTipText = "Número total de elementos";
            // 
            // deleteCliente
            // 
            this.deleteCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteCliente.Image = ((System.Drawing.Image)(resources.GetObject("deleteCliente.Image")));
            this.deleteCliente.Name = "deleteCliente";
            this.deleteCliente.RightToLeftAutoMirrorImage = true;
            this.deleteCliente.Size = new System.Drawing.Size(23, 22);
            this.deleteCliente.Text = "Eliminar";
            // 
            // moveFirstCliente
            // 
            this.moveFirstCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.moveFirstCliente.Image = ((System.Drawing.Image)(resources.GetObject("moveFirstCliente.Image")));
            this.moveFirstCliente.Name = "moveFirstCliente";
            this.moveFirstCliente.RightToLeftAutoMirrorImage = true;
            this.moveFirstCliente.Size = new System.Drawing.Size(23, 22);
            this.moveFirstCliente.Text = "Mover primero";
            // 
            // movePreviousCliente
            // 
            this.movePreviousCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.movePreviousCliente.Image = ((System.Drawing.Image)(resources.GetObject("movePreviousCliente.Image")));
            this.movePreviousCliente.Name = "movePreviousCliente";
            this.movePreviousCliente.RightToLeftAutoMirrorImage = true;
            this.movePreviousCliente.Size = new System.Drawing.Size(23, 22);
            this.movePreviousCliente.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // positionCliente
            // 
            this.positionCliente.AccessibleName = "Posición";
            this.positionCliente.AutoSize = false;
            this.positionCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.positionCliente.Name = "positionCliente";
            this.positionCliente.Size = new System.Drawing.Size(50, 23);
            this.positionCliente.Text = "0";
            this.positionCliente.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // moveNextCliente
            // 
            this.moveNextCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.moveNextCliente.Image = ((System.Drawing.Image)(resources.GetObject("moveNextCliente.Image")));
            this.moveNextCliente.Name = "moveNextCliente";
            this.moveNextCliente.RightToLeftAutoMirrorImage = true;
            this.moveNextCliente.Size = new System.Drawing.Size(23, 22);
            this.moveNextCliente.Text = "Mover siguiente";
            // 
            // moveLastCliente
            // 
            this.moveLastCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.moveLastCliente.Image = ((System.Drawing.Image)(resources.GetObject("moveLastCliente.Image")));
            this.moveLastCliente.Name = "moveLastCliente";
            this.moveLastCliente.RightToLeftAutoMirrorImage = true;
            this.moveLastCliente.Size = new System.Drawing.Size(23, 22);
            this.moveLastCliente.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // saveCliente
            // 
            this.saveCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveCliente.Image = ((System.Drawing.Image)(resources.GetObject("saveCliente.Image")));
            this.saveCliente.Name = "saveCliente";
            this.saveCliente.Size = new System.Drawing.Size(23, 22);
            this.saveCliente.Text = "Guardar datos";
            this.saveCliente.Click += new System.EventHandler(this.clienteBindingNavigatorSaveItem_Click);
            // 
            // editCliente
            // 
            this.editCliente.BackColor = System.Drawing.Color.Transparent;
            this.editCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editCliente.Image = ((System.Drawing.Image)(resources.GetObject("editCliente.Image")));
            this.editCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editCliente.Name = "editCliente";
            this.editCliente.Size = new System.Drawing.Size(23, 22);
            this.editCliente.Text = "Editar";
            this.editCliente.Click += new System.EventHandler(this.editCliente_Click);
            // 
            // informeCliente
            // 
            this.informeCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.informeCliente.Image = ((System.Drawing.Image)(resources.GetObject("informeCliente.Image")));
            this.informeCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.informeCliente.Name = "informeCliente";
            this.informeCliente.Size = new System.Drawing.Size(23, 22);
            this.informeCliente.Text = "Informe";
            this.informeCliente.Click += new System.EventHandler(this.informeCliente_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // lblBuscarCliente
            // 
            this.lblBuscarCliente.Name = "lblBuscarCliente";
            this.lblBuscarCliente.Size = new System.Drawing.Size(45, 22);
            this.lblBuscarCliente.Text = "Buscar:";
            // 
            // textBuscarCliente
            // 
            this.textBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBuscarCliente.Name = "textBuscarCliente";
            this.textBuscarCliente.Size = new System.Drawing.Size(170, 25);
            this.textBuscarCliente.TextChanged += new System.EventHandler(this.textBuscar_TextChanged);
            // 
            // clienteDataGridView
            // 
            this.clienteDataGridView.AllowUserToAddRows = false;
            this.clienteDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(181)))));
            this.clienteDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.clienteDataGridView.AutoGenerateColumns = false;
            this.clienteDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clienteDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(150)))));
            this.clienteDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clienteDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.clienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cliente,
            this.nombre,
            this.apellido,
            this.telefono,
            this.localidad,
            this.codigo_postal,
            this.provincia,
            this.empresa});
            this.clienteDataGridView.DataSource = this.clienteBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.clienteDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.clienteDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.clienteDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(150)))));
            this.clienteDataGridView.Location = new System.Drawing.Point(3, 29);
            this.clienteDataGridView.Name = "clienteDataGridView";
            this.clienteDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clienteDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.clienteDataGridView.RowHeadersVisible = false;
            this.clienteDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clienteDataGridView.Size = new System.Drawing.Size(836, 395);
            this.clienteDataGridView.TabIndex = 0;
            this.clienteDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.clienteDataGridView_CellMouseDoubleClick);
            this.clienteDataGridView.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.clienteDataGridView_RowStateChanged);
            // 
            // id_cliente
            // 
            this.id_cliente.DataPropertyName = "id";
            this.id_cliente.HeaderText = "id";
            this.id_cliente.Name = "id_cliente";
            this.id_cliente.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "apellido";
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // localidad
            // 
            this.localidad.DataPropertyName = "localidad";
            this.localidad.HeaderText = "Localidad";
            this.localidad.Name = "localidad";
            this.localidad.ReadOnly = true;
            // 
            // codigo_postal
            // 
            this.codigo_postal.DataPropertyName = "codigo_postal";
            this.codigo_postal.HeaderText = "Codigo Postal";
            this.codigo_postal.Name = "codigo_postal";
            this.codigo_postal.ReadOnly = true;
            // 
            // provincia
            // 
            this.provincia.DataPropertyName = "provincia";
            this.provincia.HeaderText = "Provincia";
            this.provincia.Name = "provincia";
            this.provincia.ReadOnly = true;
            // 
            // empresa
            // 
            this.empresa.DataPropertyName = "empresa";
            this.empresa.HeaderText = "Empresa";
            this.empresa.Name = "empresa";
            this.empresa.ReadOnly = true;
            // 
            // tabPolizas
            // 
            this.tabPolizas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(97)))));
            this.tabPolizas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPolizas.Controls.Add(this.lblClientePolizas);
            this.tabPolizas.Controls.Add(this.polizaBindingNavigator);
            this.tabPolizas.Controls.Add(this.polizaDataGridView);
            this.tabPolizas.Location = new System.Drawing.Point(4, 22);
            this.tabPolizas.Name = "tabPolizas";
            this.tabPolizas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPolizas.Size = new System.Drawing.Size(844, 429);
            this.tabPolizas.TabIndex = 1;
            this.tabPolizas.Text = " Polizas";
            // 
            // lblClientePolizas
            // 
            this.lblClientePolizas.AutoSize = true;
            this.lblClientePolizas.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientePolizas.ForeColor = System.Drawing.Color.White;
            this.lblClientePolizas.Location = new System.Drawing.Point(7, 40);
            this.lblClientePolizas.Name = "lblClientePolizas";
            this.lblClientePolizas.Size = new System.Drawing.Size(94, 32);
            this.lblClientePolizas.TabIndex = 19;
            this.lblClientePolizas.Text = "Cliente";
            // 
            // polizaBindingNavigator
            // 
            this.polizaBindingNavigator.AddNewItem = this.addNewPoliza;
            this.polizaBindingNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(150)))));
            this.polizaBindingNavigator.BindingSource = this.polizaBindingSource;
            this.polizaBindingNavigator.CountItem = this.countPoliza;
            this.polizaBindingNavigator.DeleteItem = this.deletePoliza;
            this.polizaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveFirstPoliza,
            this.movePreviousPoliza,
            this.toolStripSeparator1,
            this.positionPoliza,
            this.countPoliza,
            this.toolStripSeparator2,
            this.moveNextPoliza,
            this.moveLastPoliza,
            this.toolStripSeparator3,
            this.addNewPoliza,
            this.deletePoliza,
            this.savePoliza,
            this.editPoliza});
            this.polizaBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.polizaBindingNavigator.MoveFirstItem = this.moveFirstPoliza;
            this.polizaBindingNavigator.MoveLastItem = this.moveLastPoliza;
            this.polizaBindingNavigator.MoveNextItem = this.moveNextPoliza;
            this.polizaBindingNavigator.MovePreviousItem = this.movePreviousPoliza;
            this.polizaBindingNavigator.Name = "polizaBindingNavigator";
            this.polizaBindingNavigator.PositionItem = this.positionPoliza;
            this.polizaBindingNavigator.Size = new System.Drawing.Size(836, 25);
            this.polizaBindingNavigator.TabIndex = 17;
            this.polizaBindingNavigator.Text = "bindingNavigator1";
            // 
            // addNewPoliza
            // 
            this.addNewPoliza.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addNewPoliza.Image = ((System.Drawing.Image)(resources.GetObject("addNewPoliza.Image")));
            this.addNewPoliza.Name = "addNewPoliza";
            this.addNewPoliza.RightToLeftAutoMirrorImage = true;
            this.addNewPoliza.Size = new System.Drawing.Size(23, 22);
            this.addNewPoliza.Text = "Agregar nuevo";
            this.addNewPoliza.Click += new System.EventHandler(this.bindingNavigatorAddNewPoliza_Click);
            // 
            // polizaBindingSource
            // 
            this.polizaBindingSource.DataMember = "poliza";
            this.polizaBindingSource.DataSource = this.segurosDataSet;
            // 
            // countPoliza
            // 
            this.countPoliza.Name = "countPoliza";
            this.countPoliza.Size = new System.Drawing.Size(37, 22);
            this.countPoliza.Text = "de {0}";
            this.countPoliza.ToolTipText = "Número total de elementos";
            // 
            // deletePoliza
            // 
            this.deletePoliza.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deletePoliza.Image = ((System.Drawing.Image)(resources.GetObject("deletePoliza.Image")));
            this.deletePoliza.Name = "deletePoliza";
            this.deletePoliza.RightToLeftAutoMirrorImage = true;
            this.deletePoliza.Size = new System.Drawing.Size(23, 22);
            this.deletePoliza.Text = "Eliminar";
            // 
            // moveFirstPoliza
            // 
            this.moveFirstPoliza.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.moveFirstPoliza.Image = ((System.Drawing.Image)(resources.GetObject("moveFirstPoliza.Image")));
            this.moveFirstPoliza.Name = "moveFirstPoliza";
            this.moveFirstPoliza.RightToLeftAutoMirrorImage = true;
            this.moveFirstPoliza.Size = new System.Drawing.Size(23, 22);
            this.moveFirstPoliza.Text = "Mover primero";
            // 
            // movePreviousPoliza
            // 
            this.movePreviousPoliza.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.movePreviousPoliza.Image = ((System.Drawing.Image)(resources.GetObject("movePreviousPoliza.Image")));
            this.movePreviousPoliza.Name = "movePreviousPoliza";
            this.movePreviousPoliza.RightToLeftAutoMirrorImage = true;
            this.movePreviousPoliza.Size = new System.Drawing.Size(23, 22);
            this.movePreviousPoliza.Text = "Mover anterior";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // positionPoliza
            // 
            this.positionPoliza.AccessibleName = "Posición";
            this.positionPoliza.AutoSize = false;
            this.positionPoliza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.positionPoliza.Name = "positionPoliza";
            this.positionPoliza.Size = new System.Drawing.Size(50, 23);
            this.positionPoliza.Text = "0";
            this.positionPoliza.ToolTipText = "Posición actual";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // moveNextPoliza
            // 
            this.moveNextPoliza.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.moveNextPoliza.Image = ((System.Drawing.Image)(resources.GetObject("moveNextPoliza.Image")));
            this.moveNextPoliza.Name = "moveNextPoliza";
            this.moveNextPoliza.RightToLeftAutoMirrorImage = true;
            this.moveNextPoliza.Size = new System.Drawing.Size(23, 22);
            this.moveNextPoliza.Text = "Mover siguiente";
            // 
            // moveLastPoliza
            // 
            this.moveLastPoliza.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.moveLastPoliza.Image = ((System.Drawing.Image)(resources.GetObject("moveLastPoliza.Image")));
            this.moveLastPoliza.Name = "moveLastPoliza";
            this.moveLastPoliza.RightToLeftAutoMirrorImage = true;
            this.moveLastPoliza.Size = new System.Drawing.Size(23, 22);
            this.moveLastPoliza.Text = "Mover último";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // savePoliza
            // 
            this.savePoliza.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.savePoliza.Image = ((System.Drawing.Image)(resources.GetObject("savePoliza.Image")));
            this.savePoliza.Name = "savePoliza";
            this.savePoliza.Size = new System.Drawing.Size(23, 22);
            this.savePoliza.Text = "Guardar datos";
            this.savePoliza.Click += new System.EventHandler(this.polizaBindingNavigatorSaveItem_Click);
            // 
            // editPoliza
            // 
            this.editPoliza.BackColor = System.Drawing.Color.Transparent;
            this.editPoliza.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editPoliza.Image = ((System.Drawing.Image)(resources.GetObject("editPoliza.Image")));
            this.editPoliza.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editPoliza.Name = "editPoliza";
            this.editPoliza.Size = new System.Drawing.Size(23, 22);
            this.editPoliza.Text = "Editar";
            this.editPoliza.Click += new System.EventHandler(this.editPoliza_Click);
            // 
            // polizaDataGridView
            // 
            this.polizaDataGridView.AllowUserToAddRows = false;
            this.polizaDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(181)))));
            this.polizaDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.polizaDataGridView.AutoGenerateColumns = false;
            this.polizaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.polizaDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(150)))));
            this.polizaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.polizaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.polizaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.polizaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_poliza,
            this.fk_cliente,
            this.importe_poliza,
            this.fecha_poliza,
            this.estado_poliza,
            this.observaciones,
            this.liquidado,
            this.restante});
            this.polizaDataGridView.DataSource = this.polizaBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.polizaDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.polizaDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.polizaDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(150)))));
            this.polizaDataGridView.Location = new System.Drawing.Point(3, 78);
            this.polizaDataGridView.Name = "polizaDataGridView";
            this.polizaDataGridView.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.polizaDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.polizaDataGridView.RowHeadersVisible = false;
            this.polizaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.polizaDataGridView.Size = new System.Drawing.Size(836, 346);
            this.polizaDataGridView.TabIndex = 18;
            this.polizaDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.polizaDataGridView_CellBeginEdit);
            this.polizaDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.polizaDataGridView_CellEndEdit);
            this.polizaDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.polizaDataGridView_CellFormatting);
            this.polizaDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.polizaDataGridView_CellMouseDoubleClick);
            this.polizaDataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.polizaDataGridView_CellPainting);
            this.polizaDataGridView.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.polizaDataGridView_RowStateChanged);
            // 
            // id_poliza
            // 
            this.id_poliza.DataPropertyName = "id";
            this.id_poliza.HeaderText = "id";
            this.id_poliza.Name = "id_poliza";
            this.id_poliza.ReadOnly = true;
            // 
            // fk_cliente
            // 
            this.fk_cliente.DataPropertyName = "id_cliente";
            this.fk_cliente.HeaderText = "id_cliente";
            this.fk_cliente.Name = "fk_cliente";
            this.fk_cliente.ReadOnly = true;
            // 
            // importe_poliza
            // 
            this.importe_poliza.DataPropertyName = "importe";
            this.importe_poliza.HeaderText = "Importe (EUR)";
            this.importe_poliza.Name = "importe_poliza";
            this.importe_poliza.ReadOnly = true;
            // 
            // fecha_poliza
            // 
            this.fecha_poliza.DataPropertyName = "fecha";
            this.fecha_poliza.HeaderText = "Fecha";
            this.fecha_poliza.Name = "fecha_poliza";
            this.fecha_poliza.ReadOnly = true;
            // 
            // estado_poliza
            // 
            this.estado_poliza.DataPropertyName = "estado";
            this.estado_poliza.HeaderText = "Estado";
            this.estado_poliza.Name = "estado_poliza";
            this.estado_poliza.ReadOnly = true;
            // 
            // observaciones
            // 
            this.observaciones.DataPropertyName = "observaciones";
            this.observaciones.HeaderText = "Observaciones";
            this.observaciones.Name = "observaciones";
            this.observaciones.ReadOnly = true;
            // 
            // liquidado
            // 
            this.liquidado.HeaderText = "Liquidado";
            this.liquidado.Name = "liquidado";
            this.liquidado.ReadOnly = true;
            // 
            // tabPagos
            // 
            this.tabPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(97)))));
            this.tabPagos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPagos.Controls.Add(this.lblClientePagos);
            this.tabPagos.Controls.Add(this.pagoBindingNavigator);
            this.tabPagos.Controls.Add(this.pagoDataGridView);
            this.tabPagos.Location = new System.Drawing.Point(4, 22);
            this.tabPagos.Name = "tabPagos";
            this.tabPagos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagos.Size = new System.Drawing.Size(844, 429);
            this.tabPagos.TabIndex = 2;
            this.tabPagos.Text = "Pagos";
            // 
            // lblClientePagos
            // 
            this.lblClientePagos.AutoSize = true;
            this.lblClientePagos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblClientePagos.ForeColor = System.Drawing.Color.White;
            this.lblClientePagos.Location = new System.Drawing.Point(7, 40);
            this.lblClientePagos.Name = "lblClientePagos";
            this.lblClientePagos.Size = new System.Drawing.Size(94, 32);
            this.lblClientePagos.TabIndex = 20;
            this.lblClientePagos.Text = "Cliente";
            // 
            // pagoBindingNavigator
            // 
            this.pagoBindingNavigator.AddNewItem = this.addNewPago;
            this.pagoBindingNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(150)))));
            this.pagoBindingNavigator.BindingSource = this.pagoBindingSource;
            this.pagoBindingNavigator.CountItem = this.countPago;
            this.pagoBindingNavigator.DeleteItem = this.deletePago;
            this.pagoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveFirstPago,
            this.movePreviousPago,
            this.toolStripSeparator5,
            this.positionPago,
            this.countPago,
            this.toolStripSeparator6,
            this.moveNextPago,
            this.moveLastPago,
            this.toolStripSeparator7,
            this.addNewPago,
            this.deletePago,
            this.savePago,
            this.editPago});
            this.pagoBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.pagoBindingNavigator.MoveFirstItem = this.moveFirstPago;
            this.pagoBindingNavigator.MoveLastItem = this.moveLastPago;
            this.pagoBindingNavigator.MoveNextItem = this.moveNextPago;
            this.pagoBindingNavigator.MovePreviousItem = this.movePreviousPago;
            this.pagoBindingNavigator.Name = "pagoBindingNavigator";
            this.pagoBindingNavigator.Padding = new System.Windows.Forms.Padding(0);
            this.pagoBindingNavigator.PositionItem = this.positionPago;
            this.pagoBindingNavigator.Size = new System.Drawing.Size(836, 25);
            this.pagoBindingNavigator.TabIndex = 17;
            // 
            // addNewPago
            // 
            this.addNewPago.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addNewPago.Image = ((System.Drawing.Image)(resources.GetObject("addNewPago.Image")));
            this.addNewPago.Name = "addNewPago";
            this.addNewPago.RightToLeftAutoMirrorImage = true;
            this.addNewPago.Size = new System.Drawing.Size(23, 22);
            this.addNewPago.Text = "Agregar nuevo";
            this.addNewPago.Click += new System.EventHandler(this.bindingNavigatorAddNewPago_Click);
            // 
            // pagoBindingSource
            // 
            this.pagoBindingSource.DataMember = "pago";
            this.pagoBindingSource.DataSource = this.segurosDataSet;
            // 
            // countPago
            // 
            this.countPago.Name = "countPago";
            this.countPago.Size = new System.Drawing.Size(37, 22);
            this.countPago.Text = "de {0}";
            this.countPago.ToolTipText = "Número total de elementos";
            // 
            // deletePago
            // 
            this.deletePago.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deletePago.Image = ((System.Drawing.Image)(resources.GetObject("deletePago.Image")));
            this.deletePago.Name = "deletePago";
            this.deletePago.RightToLeftAutoMirrorImage = true;
            this.deletePago.Size = new System.Drawing.Size(23, 22);
            this.deletePago.Text = "Eliminar";
            // 
            // moveFirstPago
            // 
            this.moveFirstPago.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.moveFirstPago.Image = ((System.Drawing.Image)(resources.GetObject("moveFirstPago.Image")));
            this.moveFirstPago.Name = "moveFirstPago";
            this.moveFirstPago.RightToLeftAutoMirrorImage = true;
            this.moveFirstPago.Size = new System.Drawing.Size(23, 22);
            this.moveFirstPago.Text = "Mover primero";
            // 
            // movePreviousPago
            // 
            this.movePreviousPago.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.movePreviousPago.Image = ((System.Drawing.Image)(resources.GetObject("movePreviousPago.Image")));
            this.movePreviousPago.Name = "movePreviousPago";
            this.movePreviousPago.RightToLeftAutoMirrorImage = true;
            this.movePreviousPago.Size = new System.Drawing.Size(23, 22);
            this.movePreviousPago.Text = "Mover anterior";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // positionPago
            // 
            this.positionPago.AccessibleName = "Posición";
            this.positionPago.AutoSize = false;
            this.positionPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.positionPago.Name = "positionPago";
            this.positionPago.Size = new System.Drawing.Size(50, 23);
            this.positionPago.Text = "0";
            this.positionPago.ToolTipText = "Posición actual";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // moveNextPago
            // 
            this.moveNextPago.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.moveNextPago.Image = ((System.Drawing.Image)(resources.GetObject("moveNextPago.Image")));
            this.moveNextPago.Name = "moveNextPago";
            this.moveNextPago.RightToLeftAutoMirrorImage = true;
            this.moveNextPago.Size = new System.Drawing.Size(23, 22);
            this.moveNextPago.Text = "Mover siguiente";
            // 
            // moveLastPago
            // 
            this.moveLastPago.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.moveLastPago.Image = ((System.Drawing.Image)(resources.GetObject("moveLastPago.Image")));
            this.moveLastPago.Name = "moveLastPago";
            this.moveLastPago.RightToLeftAutoMirrorImage = true;
            this.moveLastPago.Size = new System.Drawing.Size(23, 22);
            this.moveLastPago.Text = "Mover último";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // savePago
            // 
            this.savePago.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.savePago.Image = ((System.Drawing.Image)(resources.GetObject("savePago.Image")));
            this.savePago.Name = "savePago";
            this.savePago.Size = new System.Drawing.Size(23, 22);
            this.savePago.Text = "Guardar datos";
            this.savePago.Click += new System.EventHandler(this.pagoBindingNavigatorSavePago_Click);
            // 
            // editPago
            // 
            this.editPago.BackColor = System.Drawing.Color.Transparent;
            this.editPago.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editPago.Image = ((System.Drawing.Image)(resources.GetObject("editPago.Image")));
            this.editPago.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editPago.Name = "editPago";
            this.editPago.Size = new System.Drawing.Size(23, 22);
            this.editPago.Text = "Editar";
            this.editPago.Click += new System.EventHandler(this.editPago_Click);
            // 
            // pagoDataGridView
            // 
            this.pagoDataGridView.AllowUserToAddRows = false;
            this.pagoDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(181)))));
            this.pagoDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.pagoDataGridView.AutoGenerateColumns = false;
            this.pagoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pagoDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(150)))));
            this.pagoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pagoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.pagoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pagoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_pago,
            this.fk_poliza,
            this.importe_pago,
            this.fecha_pago});
            this.pagoDataGridView.DataSource = this.pagoBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.pagoDataGridView.DefaultCellStyle = dataGridViewCellStyle11;
            this.pagoDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pagoDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(150)))));
            this.pagoDataGridView.Location = new System.Drawing.Point(3, 78);
            this.pagoDataGridView.Name = "pagoDataGridView";
            this.pagoDataGridView.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pagoDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.pagoDataGridView.RowHeadersVisible = false;
            this.pagoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pagoDataGridView.Size = new System.Drawing.Size(836, 346);
            this.pagoDataGridView.TabIndex = 17;
            this.pagoDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.pagoDataGridView_CellBeginEdit);
            this.pagoDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.pagoDataGridView_CellEndEdit);
            // 
            // id_pago
            // 
            this.id_pago.DataPropertyName = "id";
            this.id_pago.HeaderText = "id";
            this.id_pago.Name = "id_pago";
            this.id_pago.ReadOnly = true;
            // 
            // fk_poliza
            // 
            this.fk_poliza.DataPropertyName = "id_poliza";
            this.fk_poliza.HeaderText = "id_poliza";
            this.fk_poliza.Name = "fk_poliza";
            this.fk_poliza.ReadOnly = true;
            // 
            // importe_pago
            // 
            this.importe_pago.DataPropertyName = "importe";
            this.importe_pago.HeaderText = "Importe (EUR)";
            this.importe_pago.Name = "importe_pago";
            this.importe_pago.ReadOnly = true;
            // 
            // fecha_pago
            // 
            this.fecha_pago.DataPropertyName = "fecha";
            this.fecha_pago.HeaderText = "Fecha";
            this.fecha_pago.Name = "fecha_pago";
            this.fecha_pago.ReadOnly = true;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // clienteTableAdapterManager
            // 
            this.clienteTableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.clienteTableAdapterManager.clienteTableAdapter = this.clienteTableAdapter;
            this.clienteTableAdapterManager.pagoTableAdapter = null;
            this.clienteTableAdapterManager.polizaTableAdapter = null;
            this.clienteTableAdapterManager.UpdateOrder = ProyectoInterfaz.SegurosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.clienteTableAdapterManager.usuarioTableAdapter = null;
            // 
            // polizaTableAdapter
            // 
            this.polizaTableAdapter.ClearBeforeFill = true;
            // 
            // polizaTableAdapterManager
            // 
            this.polizaTableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.polizaTableAdapterManager.clienteTableAdapter = null;
            this.polizaTableAdapterManager.pagoTableAdapter = null;
            this.polizaTableAdapterManager.polizaTableAdapter = this.polizaTableAdapter;
            this.polizaTableAdapterManager.UpdateOrder = ProyectoInterfaz.SegurosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.polizaTableAdapterManager.usuarioTableAdapter = null;
            // 
            // pagoTableAdapter
            // 
            this.pagoTableAdapter.ClearBeforeFill = true;
            // 
            // pagoTableAdapterManager
            // 
            this.pagoTableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.pagoTableAdapterManager.clienteTableAdapter = null;
            this.pagoTableAdapterManager.pagoTableAdapter = this.pagoTableAdapter;
            this.pagoTableAdapterManager.polizaTableAdapter = null;
            this.pagoTableAdapterManager.UpdateOrder = ProyectoInterfaz.SegurosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.pagoTableAdapterManager.usuarioTableAdapter = null;
            // 
            // restante
            // 
            this.restante.HeaderText = "Restante";
            this.restante.Name = "restante";
            this.restante.ReadOnly = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(852, 455);
            this.Controls.Add(this.tabMain);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seguros";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabMain.ResumeLayout(false);
            this.tabClientes.ResumeLayout(false);
            this.tabClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).EndInit();
            this.clienteBindingNavigator.ResumeLayout(false);
            this.clienteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segurosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).EndInit();
            this.tabPolizas.ResumeLayout(false);
            this.tabPolizas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.polizaBindingNavigator)).EndInit();
            this.polizaBindingNavigator.ResumeLayout(false);
            this.polizaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.polizaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polizaDataGridView)).EndInit();
            this.tabPagos.ResumeLayout(false);
            this.tabPagos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pagoBindingNavigator)).EndInit();
            this.pagoBindingNavigator.ResumeLayout(false);
            this.pagoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagoDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabClientes;
        private System.Windows.Forms.TabPage tabPolizas;
        private SegurosDataSet segurosDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private SegurosDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private SegurosDataSetTableAdapters.TableAdapterManager clienteTableAdapterManager;
        private System.Windows.Forms.BindingNavigator clienteBindingNavigator;
        private System.Windows.Forms.ToolStripButton addNewCliente;
        private System.Windows.Forms.ToolStripLabel countCliente;
        private System.Windows.Forms.ToolStripButton deleteCliente;
        private System.Windows.Forms.ToolStripButton moveFirstCliente;
        private System.Windows.Forms.ToolStripButton movePreviousCliente;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox positionCliente;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton moveNextCliente;
        private System.Windows.Forms.ToolStripButton moveLastCliente;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton saveCliente;
        private System.Windows.Forms.DataGridView clienteDataGridView;
        private System.Windows.Forms.BindingSource polizaBindingSource;
        private SegurosDataSetTableAdapters.polizaTableAdapter polizaTableAdapter;
        private System.Windows.Forms.BindingNavigator polizaBindingNavigator;
        private System.Windows.Forms.ToolStripButton addNewPoliza;
        private System.Windows.Forms.ToolStripLabel countPoliza;
        private System.Windows.Forms.ToolStripButton deletePoliza;
        private System.Windows.Forms.ToolStripButton moveFirstPoliza;
        private System.Windows.Forms.ToolStripButton movePreviousPoliza;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox positionPoliza;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton moveNextPoliza;
        private System.Windows.Forms.ToolStripButton moveLastPoliza;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton savePoliza;
        private System.Windows.Forms.DataGridView polizaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_poliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe_poliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_poliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_poliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn observaciones;
        private SegurosDataSetTableAdapters.TableAdapterManager polizaTableAdapterManager;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel lblBuscarCliente;
        private System.Windows.Forms.ToolStripTextBox textBuscarCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_postal;
        private System.Windows.Forms.DataGridViewTextBoxColumn provincia;
        private System.Windows.Forms.DataGridViewCheckBoxColumn empresa;
        private System.Windows.Forms.TabPage tabPagos;
        private System.Windows.Forms.BindingNavigator pagoBindingNavigator;
        private System.Windows.Forms.ToolStripButton addNewPago;
        private System.Windows.Forms.ToolStripLabel countPago;
        private System.Windows.Forms.ToolStripButton deletePago;
        private System.Windows.Forms.ToolStripButton moveFirstPago;
        private System.Windows.Forms.ToolStripButton movePreviousPago;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripTextBox positionPago;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton moveNextPago;
        private System.Windows.Forms.ToolStripButton moveLastPago;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton savePago;
        private System.Windows.Forms.BindingSource pagoBindingSource;
        private SegurosDataSetTableAdapters.pagoTableAdapter pagoTableAdapter;
        private System.Windows.Forms.DataGridView pagoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_poliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe_pago;
        private SegurosDataSetTableAdapters.TableAdapterManager pagoTableAdapterManager;
        private System.Windows.Forms.Label lblClientePolizas;
        private System.Windows.Forms.Label lblClientePagos;
        private System.Windows.Forms.ToolStripButton informeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_pago;
        private System.Windows.Forms.ToolStripButton editCliente;
        private System.Windows.Forms.ToolStripButton editPoliza;
        private System.Windows.Forms.ToolStripButton editPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn liquidado;
        private System.Windows.Forms.DataGridViewTextBoxColumn restante;
    }
}


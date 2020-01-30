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
            this.bindingNavigatorAddNewCliente = new System.Windows.Forms.ToolStripButton();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.segurosDataSet = new ProyectoInterfaz.SegurosDataSet();
            this.bindingNavigatorCountCliente = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteCliente = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstCliente = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousCliente = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionCliente = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextCliente = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastCliente = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clienteBindingNavigatorSaveCliente = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.lblBuscar = new System.Windows.Forms.ToolStripLabel();
            this.textBuscar = new System.Windows.Forms.ToolStripTextBox();
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
            this.bindingNavigatorAddNewPoliza = new System.Windows.Forms.ToolStripButton();
            this.polizaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountPoliza = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeletePoliza = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstPoliza = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousPoliza = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionPoliza = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextPoliza = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastPoliza = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.polizaBindingNavigatorSavePoliza = new System.Windows.Forms.ToolStripButton();
            this.polizaDataGridView = new System.Windows.Forms.DataGridView();
            this.id_poliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe_poliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPagos = new System.Windows.Forms.TabPage();
            this.lblClientePagos = new System.Windows.Forms.Label();
            this.pagoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewPago = new System.Windows.Forms.ToolStripButton();
            this.pagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountPago = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeletePago = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstPago = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousPago = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionPago = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextPago = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastPago = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.pagoBindingNavigatorSavePago = new System.Windows.Forms.ToolStripButton();
            this.pagoDataGridView = new System.Windows.Forms.DataGridView();
            this.id_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_poliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteTableAdapter = new ProyectoInterfaz.SegurosDataSetTableAdapters.clienteTableAdapter();
            this.clienteTableAdapterManager = new ProyectoInterfaz.SegurosDataSetTableAdapters.TableAdapterManager();
            this.polizaTableAdapter = new ProyectoInterfaz.SegurosDataSetTableAdapters.polizaTableAdapter();
            this.polizaTableAdapterManager = new ProyectoInterfaz.SegurosDataSetTableAdapters.TableAdapterManager();
            this.pagoTableAdapter = new ProyectoInterfaz.SegurosDataSetTableAdapters.pagoTableAdapter();
            this.pagoTableAdapterManager = new ProyectoInterfaz.SegurosDataSetTableAdapters.TableAdapterManager();
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
            this.tabClientes.Controls.Add(this.clienteBindingNavigator);
            this.tabClientes.Controls.Add(this.clienteDataGridView);
            this.tabClientes.Location = new System.Drawing.Point(4, 22);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientes.Size = new System.Drawing.Size(844, 429);
            this.tabClientes.TabIndex = 0;
            this.tabClientes.Text = " Clientes";
            this.tabClientes.UseVisualStyleBackColor = true;
            // 
            // clienteBindingNavigator
            // 
            this.clienteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewCliente;
            this.clienteBindingNavigator.BindingSource = this.clienteBindingSource;
            this.clienteBindingNavigator.CountItem = this.bindingNavigatorCountCliente;
            this.clienteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteCliente;
            this.clienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstCliente,
            this.bindingNavigatorMovePreviousCliente,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionCliente,
            this.bindingNavigatorCountCliente,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextCliente,
            this.bindingNavigatorMoveLastCliente,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewCliente,
            this.bindingNavigatorDeleteCliente,
            this.clienteBindingNavigatorSaveCliente,
            this.toolStripSeparator4,
            this.lblBuscar,
            this.textBuscar});
            this.clienteBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.clienteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstCliente;
            this.clienteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastCliente;
            this.clienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextCliente;
            this.clienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousCliente;
            this.clienteBindingNavigator.Name = "clienteBindingNavigator";
            this.clienteBindingNavigator.PositionItem = this.bindingNavigatorPositionCliente;
            this.clienteBindingNavigator.Size = new System.Drawing.Size(838, 25);
            this.clienteBindingNavigator.TabIndex = 1;
            this.clienteBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewCliente
            // 
            this.bindingNavigatorAddNewCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewCliente.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewCliente.Image")));
            this.bindingNavigatorAddNewCliente.Name = "bindingNavigatorAddNewCliente";
            this.bindingNavigatorAddNewCliente.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewCliente.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewCliente.Text = "Agregar nuevo";
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
            // bindingNavigatorCountCliente
            // 
            this.bindingNavigatorCountCliente.Name = "bindingNavigatorCountCliente";
            this.bindingNavigatorCountCliente.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountCliente.Text = "de {0}";
            this.bindingNavigatorCountCliente.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteCliente
            // 
            this.bindingNavigatorDeleteCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteCliente.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteCliente.Image")));
            this.bindingNavigatorDeleteCliente.Name = "bindingNavigatorDeleteCliente";
            this.bindingNavigatorDeleteCliente.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteCliente.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteCliente.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstCliente
            // 
            this.bindingNavigatorMoveFirstCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstCliente.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstCliente.Image")));
            this.bindingNavigatorMoveFirstCliente.Name = "bindingNavigatorMoveFirstCliente";
            this.bindingNavigatorMoveFirstCliente.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstCliente.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstCliente.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousCliente
            // 
            this.bindingNavigatorMovePreviousCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousCliente.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousCliente.Image")));
            this.bindingNavigatorMovePreviousCliente.Name = "bindingNavigatorMovePreviousCliente";
            this.bindingNavigatorMovePreviousCliente.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousCliente.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousCliente.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionCliente
            // 
            this.bindingNavigatorPositionCliente.AccessibleName = "Posición";
            this.bindingNavigatorPositionCliente.AutoSize = false;
            this.bindingNavigatorPositionCliente.Name = "bindingNavigatorPositionCliente";
            this.bindingNavigatorPositionCliente.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionCliente.Text = "0";
            this.bindingNavigatorPositionCliente.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextCliente
            // 
            this.bindingNavigatorMoveNextCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextCliente.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextCliente.Image")));
            this.bindingNavigatorMoveNextCliente.Name = "bindingNavigatorMoveNextCliente";
            this.bindingNavigatorMoveNextCliente.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextCliente.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextCliente.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastCliente
            // 
            this.bindingNavigatorMoveLastCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastCliente.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastCliente.Image")));
            this.bindingNavigatorMoveLastCliente.Name = "bindingNavigatorMoveLastCliente";
            this.bindingNavigatorMoveLastCliente.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastCliente.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastCliente.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // clienteBindingNavigatorSaveCliente
            // 
            this.clienteBindingNavigatorSaveCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clienteBindingNavigatorSaveCliente.Image = ((System.Drawing.Image)(resources.GetObject("clienteBindingNavigatorSaveCliente.Image")));
            this.clienteBindingNavigatorSaveCliente.Name = "clienteBindingNavigatorSaveCliente";
            this.clienteBindingNavigatorSaveCliente.Size = new System.Drawing.Size(23, 22);
            this.clienteBindingNavigatorSaveCliente.Text = "Guardar datos";
            this.clienteBindingNavigatorSaveCliente.Click += new System.EventHandler(this.clienteBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // lblBuscar
            // 
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(45, 22);
            this.lblBuscar.Text = "Buscar:";
            // 
            // textBuscar
            // 
            this.textBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(170, 25);
            this.textBuscar.TextChanged += new System.EventHandler(this.textBuscar_TextChanged);
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
            this.clienteDataGridView.Location = new System.Drawing.Point(3, 31);
            this.clienteDataGridView.Name = "clienteDataGridView";
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
            this.clienteDataGridView.Size = new System.Drawing.Size(838, 395);
            this.clienteDataGridView.TabIndex = 0;
            this.clienteDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.clienteDataGridView_CellMouseDoubleClick);
            this.clienteDataGridView.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.clienteDataGridView_RowStateChanged);
            // 
            // id_cliente
            // 
            this.id_cliente.DataPropertyName = "id";
            this.id_cliente.HeaderText = "id";
            this.id_cliente.Name = "id_cliente";
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "apellido";
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            // 
            // localidad
            // 
            this.localidad.DataPropertyName = "localidad";
            this.localidad.HeaderText = "Localidad";
            this.localidad.Name = "localidad";
            // 
            // codigo_postal
            // 
            this.codigo_postal.DataPropertyName = "codigo_postal";
            this.codigo_postal.HeaderText = "Codigo Postal";
            this.codigo_postal.Name = "codigo_postal";
            // 
            // provincia
            // 
            this.provincia.DataPropertyName = "provincia";
            this.provincia.HeaderText = "Provincia";
            this.provincia.Name = "provincia";
            // 
            // empresa
            // 
            this.empresa.DataPropertyName = "empresa";
            this.empresa.HeaderText = "Empresa";
            this.empresa.Name = "empresa";
            // 
            // tabPolizas
            // 
            this.tabPolizas.Controls.Add(this.lblClientePolizas);
            this.tabPolizas.Controls.Add(this.polizaBindingNavigator);
            this.tabPolizas.Controls.Add(this.polizaDataGridView);
            this.tabPolizas.Location = new System.Drawing.Point(4, 22);
            this.tabPolizas.Name = "tabPolizas";
            this.tabPolizas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPolizas.Size = new System.Drawing.Size(844, 429);
            this.tabPolizas.TabIndex = 1;
            this.tabPolizas.Text = " Polizas";
            this.tabPolizas.UseVisualStyleBackColor = true;
            // 
            // lblClientePolizas
            // 
            this.lblClientePolizas.AutoSize = true;
            this.lblClientePolizas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientePolizas.Location = new System.Drawing.Point(7, 40);
            this.lblClientePolizas.Name = "lblClientePolizas";
            this.lblClientePolizas.Size = new System.Drawing.Size(89, 29);
            this.lblClientePolizas.TabIndex = 19;
            this.lblClientePolizas.Text = "Cliente";
            // 
            // polizaBindingNavigator
            // 
            this.polizaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewPoliza;
            this.polizaBindingNavigator.BindingSource = this.polizaBindingSource;
            this.polizaBindingNavigator.CountItem = this.bindingNavigatorCountPoliza;
            this.polizaBindingNavigator.DeleteItem = this.bindingNavigatorDeletePoliza;
            this.polizaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstPoliza,
            this.bindingNavigatorMovePreviousPoliza,
            this.toolStripSeparator1,
            this.bindingNavigatorPositionPoliza,
            this.bindingNavigatorCountPoliza,
            this.toolStripSeparator2,
            this.bindingNavigatorMoveNextPoliza,
            this.bindingNavigatorMoveLastPoliza,
            this.toolStripSeparator3,
            this.bindingNavigatorAddNewPoliza,
            this.bindingNavigatorDeletePoliza,
            this.polizaBindingNavigatorSavePoliza});
            this.polizaBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.polizaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstPoliza;
            this.polizaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastPoliza;
            this.polizaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextPoliza;
            this.polizaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousPoliza;
            this.polizaBindingNavigator.Name = "polizaBindingNavigator";
            this.polizaBindingNavigator.PositionItem = this.bindingNavigatorPositionPoliza;
            this.polizaBindingNavigator.Size = new System.Drawing.Size(838, 25);
            this.polizaBindingNavigator.TabIndex = 17;
            this.polizaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewPoliza
            // 
            this.bindingNavigatorAddNewPoliza.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewPoliza.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewPoliza.Image")));
            this.bindingNavigatorAddNewPoliza.Name = "bindingNavigatorAddNewPoliza";
            this.bindingNavigatorAddNewPoliza.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewPoliza.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewPoliza.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewPoliza.Click += new System.EventHandler(this.bindingNavigatorAddNewPoliza_Click);
            // 
            // polizaBindingSource
            // 
            this.polizaBindingSource.DataMember = "poliza";
            this.polizaBindingSource.DataSource = this.segurosDataSet;
            // 
            // bindingNavigatorCountPoliza
            // 
            this.bindingNavigatorCountPoliza.Name = "bindingNavigatorCountPoliza";
            this.bindingNavigatorCountPoliza.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountPoliza.Text = "de {0}";
            this.bindingNavigatorCountPoliza.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeletePoliza
            // 
            this.bindingNavigatorDeletePoliza.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeletePoliza.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeletePoliza.Image")));
            this.bindingNavigatorDeletePoliza.Name = "bindingNavigatorDeletePoliza";
            this.bindingNavigatorDeletePoliza.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeletePoliza.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeletePoliza.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstPoliza
            // 
            this.bindingNavigatorMoveFirstPoliza.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstPoliza.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstPoliza.Image")));
            this.bindingNavigatorMoveFirstPoliza.Name = "bindingNavigatorMoveFirstPoliza";
            this.bindingNavigatorMoveFirstPoliza.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstPoliza.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstPoliza.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousPoliza
            // 
            this.bindingNavigatorMovePreviousPoliza.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousPoliza.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousPoliza.Image")));
            this.bindingNavigatorMovePreviousPoliza.Name = "bindingNavigatorMovePreviousPoliza";
            this.bindingNavigatorMovePreviousPoliza.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousPoliza.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousPoliza.Text = "Mover anterior";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionPoliza
            // 
            this.bindingNavigatorPositionPoliza.AccessibleName = "Posición";
            this.bindingNavigatorPositionPoliza.AutoSize = false;
            this.bindingNavigatorPositionPoliza.Name = "bindingNavigatorPositionPoliza";
            this.bindingNavigatorPositionPoliza.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionPoliza.Text = "0";
            this.bindingNavigatorPositionPoliza.ToolTipText = "Posición actual";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextPoliza
            // 
            this.bindingNavigatorMoveNextPoliza.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextPoliza.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextPoliza.Image")));
            this.bindingNavigatorMoveNextPoliza.Name = "bindingNavigatorMoveNextPoliza";
            this.bindingNavigatorMoveNextPoliza.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextPoliza.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextPoliza.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastPoliza
            // 
            this.bindingNavigatorMoveLastPoliza.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastPoliza.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastPoliza.Image")));
            this.bindingNavigatorMoveLastPoliza.Name = "bindingNavigatorMoveLastPoliza";
            this.bindingNavigatorMoveLastPoliza.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastPoliza.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastPoliza.Text = "Mover último";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // polizaBindingNavigatorSavePoliza
            // 
            this.polizaBindingNavigatorSavePoliza.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.polizaBindingNavigatorSavePoliza.Image = ((System.Drawing.Image)(resources.GetObject("polizaBindingNavigatorSavePoliza.Image")));
            this.polizaBindingNavigatorSavePoliza.Name = "polizaBindingNavigatorSavePoliza";
            this.polizaBindingNavigatorSavePoliza.Size = new System.Drawing.Size(23, 22);
            this.polizaBindingNavigatorSavePoliza.Text = "Guardar datos";
            this.polizaBindingNavigatorSavePoliza.Click += new System.EventHandler(this.polizaBindingNavigatorSaveItem_Click);
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
            this.fecha,
            this.estado,
            this.observaciones});
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
            this.polizaDataGridView.Location = new System.Drawing.Point(3, 80);
            this.polizaDataGridView.Name = "polizaDataGridView";
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
            this.polizaDataGridView.Size = new System.Drawing.Size(838, 346);
            this.polizaDataGridView.TabIndex = 18;
            this.polizaDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.polizaDataGridView_CellBeginEdit);
            this.polizaDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.polizaDataGridView_CellEndEdit);
            this.polizaDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.polizaDataGridView_CellFormatting);
            this.polizaDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.polizaDataGridView_CellMouseDoubleClick);
            this.polizaDataGridView.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.polizaDataGridView_RowStateChanged);
            // 
            // id_poliza
            // 
            this.id_poliza.DataPropertyName = "id";
            this.id_poliza.HeaderText = "id";
            this.id_poliza.Name = "id_poliza";
            // 
            // fk_cliente
            // 
            this.fk_cliente.DataPropertyName = "id_cliente";
            this.fk_cliente.HeaderText = "id_cliente";
            this.fk_cliente.Name = "fk_cliente";
            // 
            // importe_poliza
            // 
            this.importe_poliza.DataPropertyName = "importe";
            this.importe_poliza.HeaderText = "Importe (EUR)";
            this.importe_poliza.Name = "importe_poliza";
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            // 
            // observaciones
            // 
            this.observaciones.DataPropertyName = "observaciones";
            this.observaciones.HeaderText = "Observaciones";
            this.observaciones.Name = "observaciones";
            // 
            // tabPagos
            // 
            this.tabPagos.Controls.Add(this.lblClientePagos);
            this.tabPagos.Controls.Add(this.pagoBindingNavigator);
            this.tabPagos.Controls.Add(this.pagoDataGridView);
            this.tabPagos.Location = new System.Drawing.Point(4, 22);
            this.tabPagos.Name = "tabPagos";
            this.tabPagos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagos.Size = new System.Drawing.Size(844, 429);
            this.tabPagos.TabIndex = 2;
            this.tabPagos.Text = "Pagos";
            this.tabPagos.UseVisualStyleBackColor = true;
            // 
            // lblClientePagos
            // 
            this.lblClientePagos.AutoSize = true;
            this.lblClientePagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientePagos.Location = new System.Drawing.Point(7, 40);
            this.lblClientePagos.Name = "lblClientePagos";
            this.lblClientePagos.Size = new System.Drawing.Size(89, 29);
            this.lblClientePagos.TabIndex = 20;
            this.lblClientePagos.Text = "Cliente";
            // 
            // pagoBindingNavigator
            // 
            this.pagoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewPago;
            this.pagoBindingNavigator.BindingSource = this.pagoBindingSource;
            this.pagoBindingNavigator.CountItem = this.bindingNavigatorCountPago;
            this.pagoBindingNavigator.DeleteItem = this.bindingNavigatorDeletePago;
            this.pagoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstPago,
            this.bindingNavigatorMovePreviousPago,
            this.toolStripSeparator5,
            this.bindingNavigatorPositionPago,
            this.bindingNavigatorCountPago,
            this.toolStripSeparator6,
            this.bindingNavigatorMoveNextPago,
            this.bindingNavigatorMoveLastPago,
            this.toolStripSeparator7,
            this.bindingNavigatorAddNewPago,
            this.bindingNavigatorDeletePago,
            this.pagoBindingNavigatorSavePago});
            this.pagoBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.pagoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstPago;
            this.pagoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastPago;
            this.pagoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextPago;
            this.pagoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousPago;
            this.pagoBindingNavigator.Name = "pagoBindingNavigator";
            this.pagoBindingNavigator.PositionItem = this.bindingNavigatorPositionPago;
            this.pagoBindingNavigator.Size = new System.Drawing.Size(838, 25);
            this.pagoBindingNavigator.TabIndex = 17;
            this.pagoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewPago
            // 
            this.bindingNavigatorAddNewPago.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewPago.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewPago.Image")));
            this.bindingNavigatorAddNewPago.Name = "bindingNavigatorAddNewPago";
            this.bindingNavigatorAddNewPago.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewPago.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewPago.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewPago.Click += new System.EventHandler(this.bindingNavigatorAddNewPago_Click);
            // 
            // pagoBindingSource
            // 
            this.pagoBindingSource.DataMember = "pago";
            this.pagoBindingSource.DataSource = this.segurosDataSet;
            // 
            // bindingNavigatorCountPago
            // 
            this.bindingNavigatorCountPago.Name = "bindingNavigatorCountPago";
            this.bindingNavigatorCountPago.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountPago.Text = "de {0}";
            this.bindingNavigatorCountPago.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeletePago
            // 
            this.bindingNavigatorDeletePago.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeletePago.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeletePago.Image")));
            this.bindingNavigatorDeletePago.Name = "bindingNavigatorDeletePago";
            this.bindingNavigatorDeletePago.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeletePago.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeletePago.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstPago
            // 
            this.bindingNavigatorMoveFirstPago.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstPago.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstPago.Image")));
            this.bindingNavigatorMoveFirstPago.Name = "bindingNavigatorMoveFirstPago";
            this.bindingNavigatorMoveFirstPago.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstPago.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstPago.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousPago
            // 
            this.bindingNavigatorMovePreviousPago.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousPago.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousPago.Image")));
            this.bindingNavigatorMovePreviousPago.Name = "bindingNavigatorMovePreviousPago";
            this.bindingNavigatorMovePreviousPago.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousPago.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousPago.Text = "Mover anterior";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionPago
            // 
            this.bindingNavigatorPositionPago.AccessibleName = "Posición";
            this.bindingNavigatorPositionPago.AutoSize = false;
            this.bindingNavigatorPositionPago.Name = "bindingNavigatorPositionPago";
            this.bindingNavigatorPositionPago.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionPago.Text = "0";
            this.bindingNavigatorPositionPago.ToolTipText = "Posición actual";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextPago
            // 
            this.bindingNavigatorMoveNextPago.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextPago.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextPago.Image")));
            this.bindingNavigatorMoveNextPago.Name = "bindingNavigatorMoveNextPago";
            this.bindingNavigatorMoveNextPago.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextPago.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextPago.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastPago
            // 
            this.bindingNavigatorMoveLastPago.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastPago.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastPago.Image")));
            this.bindingNavigatorMoveLastPago.Name = "bindingNavigatorMoveLastPago";
            this.bindingNavigatorMoveLastPago.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastPago.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastPago.Text = "Mover último";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // pagoBindingNavigatorSavePago
            // 
            this.pagoBindingNavigatorSavePago.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pagoBindingNavigatorSavePago.Image = ((System.Drawing.Image)(resources.GetObject("pagoBindingNavigatorSavePago.Image")));
            this.pagoBindingNavigatorSavePago.Name = "pagoBindingNavigatorSavePago";
            this.pagoBindingNavigatorSavePago.Size = new System.Drawing.Size(23, 22);
            this.pagoBindingNavigatorSavePago.Text = "Guardar datos";
            this.pagoBindingNavigatorSavePago.Click += new System.EventHandler(this.pagoBindingNavigatorSavePago_Click);
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
            this.importe_pago});
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
            this.pagoDataGridView.Location = new System.Drawing.Point(3, 80);
            this.pagoDataGridView.Name = "pagoDataGridView";
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
            this.pagoDataGridView.Size = new System.Drawing.Size(838, 346);
            this.pagoDataGridView.TabIndex = 17;
            // 
            // id_pago
            // 
            this.id_pago.DataPropertyName = "id";
            this.id_pago.HeaderText = "id";
            this.id_pago.Name = "id_pago";
            // 
            // fk_poliza
            // 
            this.fk_poliza.DataPropertyName = "id_poliza";
            this.fk_poliza.HeaderText = "id_poliza";
            this.fk_poliza.Name = "fk_poliza";
            // 
            // importe_pago
            // 
            this.importe_pago.DataPropertyName = "importe";
            this.importe_pago.HeaderText = "Importe (EUR)";
            this.importe_pago.Name = "importe_pago";
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(852, 455);
            this.Controls.Add(this.tabMain);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form";
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
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewCliente;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountCliente;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteCliente;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstCliente;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousCliente;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionCliente;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextCliente;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastCliente;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton clienteBindingNavigatorSaveCliente;
        private System.Windows.Forms.DataGridView clienteDataGridView;
        private System.Windows.Forms.BindingSource polizaBindingSource;
        private SegurosDataSetTableAdapters.polizaTableAdapter polizaTableAdapter;
        private System.Windows.Forms.BindingNavigator polizaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewPoliza;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountPoliza;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeletePoliza;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstPoliza;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousPoliza;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionPoliza;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextPoliza;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastPoliza;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton polizaBindingNavigatorSavePoliza;
        private System.Windows.Forms.DataGridView polizaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_poliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe_poliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn observaciones;
        private SegurosDataSetTableAdapters.TableAdapterManager polizaTableAdapterManager;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel lblBuscar;
        private System.Windows.Forms.ToolStripTextBox textBuscar;
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
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewPago;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountPago;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeletePago;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstPago;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousPago;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionPago;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextPago;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastPago;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton pagoBindingNavigatorSavePago;
        private System.Windows.Forms.BindingSource pagoBindingSource;
        private SegurosDataSetTableAdapters.pagoTableAdapter pagoTableAdapter;
        private System.Windows.Forms.DataGridView pagoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_poliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe_pago;
        private SegurosDataSetTableAdapters.TableAdapterManager pagoTableAdapterManager;
        private System.Windows.Forms.Label lblClientePolizas;
        private System.Windows.Forms.Label lblClientePagos;
    }
}


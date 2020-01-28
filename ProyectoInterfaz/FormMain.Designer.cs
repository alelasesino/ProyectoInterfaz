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
            this.clienteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPolizas = new System.Windows.Forms.TabPage();
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
            this.clienteTableAdapter = new ProyectoInterfaz.SegurosDataSetTableAdapters.clienteTableAdapter();
            this.clienteTableAdapterManager = new ProyectoInterfaz.SegurosDataSetTableAdapters.TableAdapterManager();
            this.polizaTableAdapter = new ProyectoInterfaz.SegurosDataSetTableAdapters.polizaTableAdapter();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polizaTableAdapterManager = new ProyectoInterfaz.SegurosDataSetTableAdapters.TableAdapterManager();
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
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabClientes);
            this.tabMain.Controls.Add(this.tabPolizas);
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
            this.clienteBindingNavigatorSaveCliente});
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
            this.bindingNavigatorPositionCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // clienteDataGridView
            // 
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn1});
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
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "apellido";
            this.dataGridViewTextBoxColumn3.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "telefono";
            this.dataGridViewTextBoxColumn4.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "localidad";
            this.dataGridViewTextBoxColumn5.HeaderText = "Localidad";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "codigo_postal";
            this.dataGridViewTextBoxColumn6.HeaderText = "Codigo Postal";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "provincia";
            this.dataGridViewTextBoxColumn7.HeaderText = "Provincia";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "empresa";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Empresa";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // tabPolizas
            // 
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
            this.bindingNavigatorPositionPoliza.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            this.polizaBindingNavigatorSavePoliza.Click += new System.EventHandler(this.polizaBindingNavigatorSavePoliza_Click);
            // 
            // polizaDataGridView
            // 
            this.polizaDataGridView.AllowUserToResizeRows = false;
            this.polizaDataGridView.AutoGenerateColumns = false;
            this.polizaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.polizaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.polizaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.polizaDataGridView.DataSource = this.polizaBindingSource;
            this.polizaDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.polizaDataGridView.Location = new System.Drawing.Point(3, 31);
            this.polizaDataGridView.Name = "polizaDataGridView";
            this.polizaDataGridView.RowHeadersVisible = false;
            this.polizaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.polizaDataGridView.Size = new System.Drawing.Size(838, 395);
            this.polizaDataGridView.TabIndex = 18;
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
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn8.HeaderText = "id";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "id_cliente";
            this.dataGridViewTextBoxColumn9.HeaderText = "id_cliente";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "importe";
            this.dataGridViewTextBoxColumn10.HeaderText = "Importe";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "fecha";
            this.dataGridViewTextBoxColumn11.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "estado";
            this.dataGridViewTextBoxColumn12.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "observaciones";
            this.dataGridViewTextBoxColumn13.HeaderText = "Observaciones";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 455);
            this.Controls.Add(this.tabMain);
            this.Name = "FormMain";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private SegurosDataSetTableAdapters.TableAdapterManager polizaTableAdapterManager;
    }
}


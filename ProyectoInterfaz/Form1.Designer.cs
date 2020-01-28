namespace ProyectoInterfaz {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textPronvincia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textCodigoPostal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textLocalidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.segurosDataSet = new ProyectoInterfaz.SegurosDataSet();
            this.polizaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.polizaTableAdapter = new ProyectoInterfaz.SegurosDataSetTableAdapters.polizaTableAdapter();
            this.tableAdapterManager = new ProyectoInterfaz.SegurosDataSetTableAdapters.TableAdapterManager();
            this.bindingNavigatorMoveFirstPoliza = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousPoliza = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionPoliza = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountPoliza = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextPoliza = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastPoliza = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewPoliza = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeletePoliza = new System.Windows.Forms.ToolStripButton();
            this.polizaBindingNavigatorSavePoliza = new System.Windows.Forms.ToolStripButton();
            this.polizaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polizaDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.segurosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polizaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polizaBindingNavigator)).BeginInit();
            this.polizaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.polizaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(31, 55);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(141, 20);
            this.textNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(31, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Telefono";
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(31, 114);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(141, 20);
            this.textTelefono.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Provincia";
            // 
            // textPronvincia
            // 
            this.textPronvincia.Location = new System.Drawing.Point(31, 174);
            this.textPronvincia.Name = "textPronvincia";
            this.textPronvincia.Size = new System.Drawing.Size(141, 20);
            this.textPronvincia.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Código postal";
            // 
            // textCodigoPostal
            // 
            this.textCodigoPostal.Location = new System.Drawing.Point(207, 174);
            this.textCodigoPostal.Name = "textCodigoPostal";
            this.textCodigoPostal.Size = new System.Drawing.Size(141, 20);
            this.textCodigoPostal.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Localidad";
            // 
            // textLocalidad
            // 
            this.textLocalidad.Location = new System.Drawing.Point(207, 114);
            this.textLocalidad.Name = "textLocalidad";
            this.textLocalidad.Size = new System.Drawing.Size(141, 20);
            this.textLocalidad.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Apellidos";
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(207, 55);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(141, 20);
            this.textApellido.TabIndex = 10;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(34, 220);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(66, 17);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Empresa";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(106, 220);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(69, 17);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Particular";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // btAceptar
            // 
            this.btAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAceptar.Location = new System.Drawing.Point(97, 261);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 14;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Location = new System.Drawing.Point(207, 261);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 15;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // segurosDataSet
            // 
            this.segurosDataSet.DataSetName = "SegurosDataSet";
            this.segurosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // polizaBindingSource
            // 
            this.polizaBindingSource.DataMember = "poliza";
            this.polizaBindingSource.DataSource = this.segurosDataSet;
            // 
            // polizaTableAdapter
            // 
            this.polizaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.pagoTableAdapter = null;
            this.tableAdapterManager.polizaTableAdapter = this.polizaTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProyectoInterfaz.SegurosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = null;
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
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorCountPoliza
            // 
            this.bindingNavigatorCountPoliza.Name = "bindingNavigatorCountPoliza";
            this.bindingNavigatorCountPoliza.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountPoliza.Text = "de {0}";
            this.bindingNavigatorCountPoliza.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeletePoliza
            // 
            this.bindingNavigatorDeletePoliza.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeletePoliza.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeletePoliza.Image")));
            this.bindingNavigatorDeletePoliza.Name = "bindingNavigatorDeletePoliza";
            this.bindingNavigatorDeletePoliza.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeletePoliza.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeletePoliza.Text = "Eliminar";
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
            // polizaBindingNavigator
            // 
            this.polizaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewPoliza;
            this.polizaBindingNavigator.BindingSource = this.polizaBindingSource;
            this.polizaBindingNavigator.CountItem = this.bindingNavigatorCountPoliza;
            this.polizaBindingNavigator.DeleteItem = this.bindingNavigatorDeletePoliza;
            this.polizaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstPoliza,
            this.bindingNavigatorMovePreviousPoliza,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionPoliza,
            this.bindingNavigatorCountPoliza,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextPoliza,
            this.bindingNavigatorMoveLastPoliza,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewPoliza,
            this.bindingNavigatorDeletePoliza,
            this.polizaBindingNavigatorSavePoliza});
            this.polizaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.polizaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstPoliza;
            this.polizaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastPoliza;
            this.polizaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextPoliza;
            this.polizaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousPoliza;
            this.polizaBindingNavigator.Name = "polizaBindingNavigator";
            this.polizaBindingNavigator.PositionItem = this.bindingNavigatorPositionPoliza;
            this.polizaBindingNavigator.Size = new System.Drawing.Size(890, 25);
            this.polizaBindingNavigator.TabIndex = 16;
            this.polizaBindingNavigator.Text = "bindingNavigator1";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "observaciones";
            this.dataGridViewTextBoxColumn6.HeaderText = "observaciones";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "estado";
            this.dataGridViewTextBoxColumn5.HeaderText = "estado";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "fecha";
            this.dataGridViewTextBoxColumn4.HeaderText = "fecha";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "importe";
            this.dataGridViewTextBoxColumn3.HeaderText = "importe";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_cliente";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_cliente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // polizaDataGridView
            // 
            this.polizaDataGridView.AutoGenerateColumns = false;
            this.polizaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.polizaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.polizaDataGridView.DataSource = this.polizaBindingSource;
            this.polizaDataGridView.Location = new System.Drawing.Point(570, 145);
            this.polizaDataGridView.Name = "polizaDataGridView";
            this.polizaDataGridView.Size = new System.Drawing.Size(300, 220);
            this.polizaDataGridView.TabIndex = 17;
            // 
            // Form1
            // 
            this.AcceptButton = this.btAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancelar;
            this.ClientSize = new System.Drawing.Size(890, 385);
            this.Controls.Add(this.polizaDataGridView);
            this.Controls.Add(this.polizaBindingNavigator);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textLocalidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textCodigoPostal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textPronvincia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.textNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.segurosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polizaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polizaBindingNavigator)).EndInit();
            this.polizaBindingNavigator.ResumeLayout(false);
            this.polizaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.polizaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPronvincia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCodigoPostal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textLocalidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
        private SegurosDataSet segurosDataSet;
        private System.Windows.Forms.BindingSource polizaBindingSource;
        private SegurosDataSetTableAdapters.polizaTableAdapter polizaTableAdapter;
        private SegurosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstPoliza;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousPoliza;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionPoliza;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountPoliza;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextPoliza;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastPoliza;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewPoliza;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeletePoliza;
        private System.Windows.Forms.ToolStripButton polizaBindingNavigatorSavePoliza;
        private System.Windows.Forms.BindingNavigator polizaBindingNavigator;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView polizaDataGridView;
    }
}
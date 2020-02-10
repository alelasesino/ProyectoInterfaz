namespace ProyectoInterfaz {
    partial class FormLogin {
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
            this.label3 = new System.Windows.Forms.Label();
            this.linkSignUp = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.segurosDataSet = new ProyectoInterfaz.SegurosDataSet();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new ProyectoInterfaz.SegurosDataSetTableAdapters.usuarioTableAdapter();
            this.tableAdapterManager = new ProyectoInterfaz.SegurosDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.segurosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "LOGIN ACCOUNT";
            // 
            // linkSignUp
            // 
            this.linkSignUp.AutoSize = true;
            this.linkSignUp.Location = new System.Drawing.Point(26, 142);
            this.linkSignUp.Name = "linkSignUp";
            this.linkSignUp.Size = new System.Drawing.Size(125, 13);
            this.linkSignUp.TabIndex = 11;
            this.linkSignUp.TabStop = true;
            this.linkSignUp.Text = "Don\' t have an account?";
            this.linkSignUp.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Contraseña";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(29, 114);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(157, 20);
            this.txtPassword.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Usuario";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(29, 64);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(157, 20);
            this.txtUsername.TabIndex = 9;
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(18)))));
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.btLogin.Location = new System.Drawing.Point(55, 151);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(103, 26);
            this.btLogin.TabIndex = 13;
            this.btLogin.Text = "Login in";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // segurosDataSet
            // 
            this.segurosDataSet.DataSetName = "SegurosDataSet";
            this.segurosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "usuario";
            this.usuarioBindingSource.DataSource = this.segurosDataSet;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.pagoTableAdapter = null;
            this.tableAdapterManager.polizaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectoInterfaz.SegurosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = this.usuarioTableAdapter;
            // 
            // FormLogin
            // 
            this.AcceptButton = this.btLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(221, 196);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkSignUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btLogin);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.segurosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkSignUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btLogin;
        private SegurosDataSet segurosDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private SegurosDataSetTableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private SegurosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}
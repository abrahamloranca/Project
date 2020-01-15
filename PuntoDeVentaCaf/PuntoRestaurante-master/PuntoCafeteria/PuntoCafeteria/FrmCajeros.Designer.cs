namespace PuntoCafeteria
{
    partial class FrmCajeros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCajeros));
            this.dtusuarios = new System.Windows.Forms.DataGridView();
            this.imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnEliminarcajero = new System.Windows.Forms.Button();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bntAgregarCajero = new System.Windows.Forms.Button();
            this.bntLimpiarpantalla = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.lblverfuser = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnguardarcambios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtusuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dtusuarios
            // 
            this.dtusuarios.AllowUserToAddRows = false;
            this.dtusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtusuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imagen});
            this.dtusuarios.Location = new System.Drawing.Point(9, 32);
            this.dtusuarios.MultiSelect = false;
            this.dtusuarios.Name = "dtusuarios";
            this.dtusuarios.RowTemplate.Height = 35;
            this.dtusuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtusuarios.Size = new System.Drawing.Size(312, 459);
            this.dtusuarios.TabIndex = 1;
            this.dtusuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtusuarios_CellClick);
            // 
            // imagen
            // 
            this.imagen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.imagen.FillWeight = 120F;
            this.imagen.HeaderText = "";
            this.imagen.Image = ((System.Drawing.Image)(resources.GetObject("imagen.Image")));
            this.imagen.Name = "imagen";
            this.imagen.Width = 34;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.Location = new System.Drawing.Point(354, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Nuevo Cajero";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnEliminarcajero
            // 
            this.BtnEliminarcajero.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarcajero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnEliminarcajero.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminarcajero.Image")));
            this.BtnEliminarcajero.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnEliminarcajero.Location = new System.Drawing.Point(479, 7);
            this.BtnEliminarcajero.Name = "BtnEliminarcajero";
            this.BtnEliminarcajero.Size = new System.Drawing.Size(119, 29);
            this.BtnEliminarcajero.TabIndex = 3;
            this.BtnEliminarcajero.Text = "Eliminar Cajero";
            this.BtnEliminarcajero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEliminarcajero.UseVisualStyleBackColor = true;
            this.BtnEliminarcajero.Click += new System.EventHandler(this.BtnEliminarcajero_Click);
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(451, 65);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(202, 20);
            this.txtusuario.TabIndex = 1;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(451, 117);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(202, 20);
            this.txtnombre.TabIndex = 3;
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(451, 91);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(202, 20);
            this.txtcontraseña.TabIndex = 2;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMensaje.Location = new System.Drawing.Point(354, 39);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(90, 17);
            this.lblMensaje.TabIndex = 7;
            this.lblMensaje.Text = "Nuevo Cajero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombre Completo";
            // 
            // bntAgregarCajero
            // 
            this.bntAgregarCajero.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAgregarCajero.Image = ((System.Drawing.Image)(resources.GetObject("bntAgregarCajero.Image")));
            this.bntAgregarCajero.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.bntAgregarCajero.Location = new System.Drawing.Point(357, 262);
            this.bntAgregarCajero.Name = "bntAgregarCajero";
            this.bntAgregarCajero.Size = new System.Drawing.Size(124, 23);
            this.bntAgregarCajero.TabIndex = 7;
            this.bntAgregarCajero.Text = "Guardar Cajero";
            this.bntAgregarCajero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntAgregarCajero.UseVisualStyleBackColor = true;
            this.bntAgregarCajero.Click += new System.EventHandler(this.button3_Click);
            // 
            // bntLimpiarpantalla
            // 
            this.bntLimpiarpantalla.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntLimpiarpantalla.Image = ((System.Drawing.Image)(resources.GetObject("bntLimpiarpantalla.Image")));
            this.bntLimpiarpantalla.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.bntLimpiarpantalla.Location = new System.Drawing.Point(487, 262);
            this.bntLimpiarpantalla.Name = "bntLimpiarpantalla";
            this.bntLimpiarpantalla.Size = new System.Drawing.Size(124, 23);
            this.bntLimpiarpantalla.TabIndex = 12;
            this.bntLimpiarpantalla.Text = "Limpiar Pantalla";
            this.bntLimpiarpantalla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntLimpiarpantalla.UseVisualStyleBackColor = true;
            this.bntLimpiarpantalla.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Telefono";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(451, 155);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(202, 20);
            this.txttelefono.TabIndex = 4;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(451, 193);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(202, 20);
            this.txtdireccion.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Direccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Rol";
            // 
            // cmbRoles
            // 
            this.cmbRoles.AutoCompleteCustomSource.AddRange(new string[] {
            "1-Administrador",
            "2-Empleado"});
            this.cmbRoles.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Items.AddRange(new object[] {
            "",
            "1-Administrador",
            "2-Empleado"});
            this.cmbRoles.Location = new System.Drawing.Point(451, 223);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(202, 21);
            this.cmbRoles.TabIndex = 6;
            // 
            // lblverfuser
            // 
            this.lblverfuser.AutoSize = true;
            this.lblverfuser.BackColor = System.Drawing.Color.White;
            this.lblverfuser.ForeColor = System.Drawing.Color.Red;
            this.lblverfuser.Location = new System.Drawing.Point(673, 68);
            this.lblverfuser.Name = "lblverfuser";
            this.lblverfuser.Size = new System.Drawing.Size(214, 13);
            this.lblverfuser.TabIndex = 18;
            this.lblverfuser.Text = "Usuario Existente ,Porfavor Seleccione Otro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(13, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Cajeros";
            // 
            // btnguardarcambios
            // 
            this.btnguardarcambios.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardarcambios.Image = ((System.Drawing.Image)(resources.GetObject("btnguardarcambios.Image")));
            this.btnguardarcambios.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnguardarcambios.Location = new System.Drawing.Point(617, 262);
            this.btnguardarcambios.Name = "btnguardarcambios";
            this.btnguardarcambios.Size = new System.Drawing.Size(124, 23);
            this.btnguardarcambios.TabIndex = 20;
            this.btnguardarcambios.Text = "Guardar cambios";
            this.btnguardarcambios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardarcambios.UseVisualStyleBackColor = true;
            // 
            // FrmCajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(897, 503);
            this.Controls.Add(this.btnguardarcambios);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblverfuser);
            this.Controls.Add(this.cmbRoles);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bntLimpiarpantalla);
            this.Controls.Add(this.bntAgregarCajero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.BtnEliminarcajero);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtusuarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCajeros";
            this.Text = "Cajeros";
            this.Load += new System.EventHandler(this.FrmCajeros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtusuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtusuarios;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnEliminarcajero;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bntAgregarCajero;
        private System.Windows.Forms.Button bntLimpiarpantalla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.Label lblverfuser;
        private System.Windows.Forms.DataGridViewImageColumn imagen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnguardarcambios;
    }
}
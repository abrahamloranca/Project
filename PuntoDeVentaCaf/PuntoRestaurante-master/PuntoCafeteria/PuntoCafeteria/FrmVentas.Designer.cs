namespace PuntoCafeteria
{
    partial class FrmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.label_MensajeVenta = new System.Windows.Forms.Label();
            this.button_BuscarProducto = new System.Windows.Forms.Button();
            this.txtproductos = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.textBox_Pagos = new System.Windows.Forms.TextBox();
            this.label_Cambio = new System.Windows.Forms.Label();
            this.label_SuCambio = new System.Windows.Forms.Label();
            this.label_ImportesVentas = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.button_CancelarVenta = new System.Windows.Forms.Button();
            this.button_Cobrar = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.dataGridView_Ventas = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new PuntoCafeteria.Clases.Numericupdown.NumericUpDownColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox17.SuspendLayout();
            this.groupBox18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ventas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox17
            // 
            this.groupBox17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox17.Controls.Add(this.label_MensajeVenta);
            this.groupBox17.Controls.Add(this.button_BuscarProducto);
            this.groupBox17.Controls.Add(this.txtproductos);
            this.groupBox17.Controls.Add(this.label21);
            this.groupBox17.Controls.Add(this.label22);
            this.groupBox17.ForeColor = System.Drawing.Color.Green;
            this.groupBox17.Location = new System.Drawing.Point(12, 12);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(721, 52);
            this.groupBox17.TabIndex = 6;
            this.groupBox17.TabStop = false;
            // 
            // label_MensajeVenta
            // 
            this.label_MensajeVenta.AutoSize = true;
            this.label_MensajeVenta.ForeColor = System.Drawing.Color.Crimson;
            this.label_MensajeVenta.Location = new System.Drawing.Point(665, 22);
            this.label_MensajeVenta.Name = "label_MensajeVenta";
            this.label_MensajeVenta.Size = new System.Drawing.Size(0, 13);
            this.label_MensajeVenta.TabIndex = 13;
            // 
            // button_BuscarProducto
            // 
            this.button_BuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_BuscarProducto.ForeColor = System.Drawing.Color.SteelBlue;
            this.button_BuscarProducto.Location = new System.Drawing.Point(572, 17);
            this.button_BuscarProducto.Name = "button_BuscarProducto";
            this.button_BuscarProducto.Size = new System.Drawing.Size(75, 23);
            this.button_BuscarProducto.TabIndex = 12;
            this.button_BuscarProducto.Text = "Buscar";
            this.button_BuscarProducto.UseVisualStyleBackColor = true;
            this.button_BuscarProducto.Click += new System.EventHandler(this.button_BuscarProducto_Click);
            // 
            // txtproductos
            // 
            this.txtproductos.Location = new System.Drawing.Point(368, 18);
            this.txtproductos.Multiline = true;
            this.txtproductos.Name = "txtproductos";
            this.txtproductos.Size = new System.Drawing.Size(198, 25);
            this.txtproductos.TabIndex = 1;
            this.txtproductos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtproductos_KeyPress);
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.SteelBlue;
            this.label21.Location = new System.Drawing.Point(306, 20);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 16);
            this.label21.TabIndex = 10;
            this.label21.Text = "Buscar";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.SteelBlue;
            this.label22.Location = new System.Drawing.Point(3, 12);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(113, 31);
            this.label22.TabIndex = 0;
            this.label22.Text = "Ventas ";
            // 
            // groupBox18
            // 
            this.groupBox18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox18.Controls.Add(this.label1);
            this.groupBox18.Controls.Add(this.label47);
            this.groupBox18.Controls.Add(this.textBox_Pagos);
            this.groupBox18.Controls.Add(this.label_Cambio);
            this.groupBox18.Controls.Add(this.label_SuCambio);
            this.groupBox18.Controls.Add(this.label_ImportesVentas);
            this.groupBox18.Controls.Add(this.label27);
            this.groupBox18.Controls.Add(this.label25);
            this.groupBox18.Controls.Add(this.button_CancelarVenta);
            this.groupBox18.Controls.Add(this.button_Cobrar);
            this.groupBox18.Controls.Add(this.label32);
            this.groupBox18.Location = new System.Drawing.Point(12, 70);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(303, 432);
            this.groupBox18.TabIndex = 7;
            this.groupBox18.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(2, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 39);
            this.label1.TabIndex = 33;
            this.label1.Text = "$";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.ForeColor = System.Drawing.Color.Teal;
            this.label47.Location = new System.Drawing.Point(8, 92);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(68, 17);
            this.label47.TabIndex = 32;
            this.label47.Text = "Pagó con";
            // 
            // textBox_Pagos
            // 
            this.textBox_Pagos.Location = new System.Drawing.Point(6, 118);
            this.textBox_Pagos.Name = "textBox_Pagos";
            this.textBox_Pagos.Size = new System.Drawing.Size(185, 20);
            this.textBox_Pagos.TabIndex = 31;
            this.textBox_Pagos.TextChanged += new System.EventHandler(this.textBox_Pagos_TextChanged);
            this.textBox_Pagos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Pagos_KeyPress);
            // 
            // label_Cambio
            // 
            this.label_Cambio.AutoSize = true;
            this.label_Cambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Cambio.ForeColor = System.Drawing.Color.SteelBlue;
            this.label_Cambio.Location = new System.Drawing.Point(4, 255);
            this.label_Cambio.Name = "label_Cambio";
            this.label_Cambio.Size = new System.Drawing.Size(102, 39);
            this.label_Cambio.TabIndex = 30;
            this.label_Cambio.Text = "$0.00";
            // 
            // label_SuCambio
            // 
            this.label_SuCambio.AutoSize = true;
            this.label_SuCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SuCambio.ForeColor = System.Drawing.Color.Teal;
            this.label_SuCambio.Location = new System.Drawing.Point(4, 233);
            this.label_SuCambio.Name = "label_SuCambio";
            this.label_SuCambio.Size = new System.Drawing.Size(74, 17);
            this.label_SuCambio.TabIndex = 29;
            this.label_SuCambio.Text = "Su cambio";
            // 
            // label_ImportesVentas
            // 
            this.label_ImportesVentas.AutoSize = true;
            this.label_ImportesVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ImportesVentas.ForeColor = System.Drawing.Color.SteelBlue;
            this.label_ImportesVentas.Location = new System.Drawing.Point(33, 178);
            this.label_ImportesVentas.Name = "label_ImportesVentas";
            this.label_ImportesVentas.Size = new System.Drawing.Size(83, 39);
            this.label_ImportesVentas.TabIndex = 27;
            this.label_ImportesVentas.Text = "0.00";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Teal;
            this.label27.Location = new System.Drawing.Point(6, 156);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(100, 17);
            this.label27.TabIndex = 26;
            this.label27.Text = "Monto a pagar";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.Teal;
            this.label25.Location = new System.Drawing.Point(6, 58);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(53, 13);
            this.label25.TabIndex = 21;
            this.label25.Text = "Se vende";
            // 
            // button_CancelarVenta
            // 
            this.button_CancelarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_CancelarVenta.Image = ((System.Drawing.Image)(resources.GetObject("button_CancelarVenta.Image")));
            this.button_CancelarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_CancelarVenta.Location = new System.Drawing.Point(141, 327);
            this.button_CancelarVenta.Name = "button_CancelarVenta";
            this.button_CancelarVenta.Size = new System.Drawing.Size(84, 39);
            this.button_CancelarVenta.TabIndex = 14;
            this.button_CancelarVenta.Text = "Cancelar";
            this.button_CancelarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_CancelarVenta.UseVisualStyleBackColor = true;
            // 
            // button_Cobrar
            // 
            this.button_Cobrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Cobrar.Image = ((System.Drawing.Image)(resources.GetObject("button_Cobrar.Image")));
            this.button_Cobrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Cobrar.Location = new System.Drawing.Point(22, 327);
            this.button_Cobrar.Name = "button_Cobrar";
            this.button_Cobrar.Size = new System.Drawing.Size(84, 39);
            this.button_Cobrar.TabIndex = 13;
            this.button_Cobrar.Text = "Cobrar";
            this.button_Cobrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Cobrar.UseVisualStyleBackColor = true;
            this.button_Cobrar.Click += new System.EventHandler(this.button_Cobrar_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.Navy;
            this.label32.Location = new System.Drawing.Point(6, 29);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(145, 16);
            this.label32.TabIndex = 0;
            this.label32.Text = "Configuración de venta";
            // 
            // dataGridView_Ventas
            // 
            this.dataGridView_Ventas.AllowUserToAddRows = false;
            this.dataGridView_Ventas.AllowUserToDeleteRows = false;
            this.dataGridView_Ventas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Ventas.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Ventas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Ventas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Ventas.ColumnHeadersHeight = 25;
            this.dataGridView_Ventas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Descripcion,
            this.Costo,
            this.cantidad,
            this.Eliminar});
            this.dataGridView_Ventas.Location = new System.Drawing.Point(321, 78);
            this.dataGridView_Ventas.MultiSelect = false;
            this.dataGridView_Ventas.Name = "dataGridView_Ventas";
            this.dataGridView_Ventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_Ventas.Size = new System.Drawing.Size(564, 165);
            this.dataGridView_Ventas.TabIndex = 8;
            this.dataGridView_Ventas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Ventas_CellClick);
            this.dataGridView_Ventas.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Ventas_CellEndEdit);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Costo
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Green;
            this.Costo.DefaultCellStyle = dataGridViewCellStyle2;
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.Name = "Eliminar";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Costo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // FrmVentas
            // 
            this.AcceptButton = this.button_BuscarProducto;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(897, 503);
            this.Controls.Add(this.dataGridView_Ventas);
            this.Controls.Add(this.groupBox18);
            this.Controls.Add(this.groupBox17);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ventas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.Label label_MensajeVenta;
        private System.Windows.Forms.Button button_BuscarProducto;
        private System.Windows.Forms.TextBox txtproductos;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox textBox_Pagos;
        private System.Windows.Forms.Label label_Cambio;
        private System.Windows.Forms.Label label_SuCambio;
        private System.Windows.Forms.Label label_ImportesVentas;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button button_CancelarVenta;
        private System.Windows.Forms.Button button_Cobrar;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.DataGridView dataGridView_Ventas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private Clases.Numericupdown.NumericUpDownColumn cantidad;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}
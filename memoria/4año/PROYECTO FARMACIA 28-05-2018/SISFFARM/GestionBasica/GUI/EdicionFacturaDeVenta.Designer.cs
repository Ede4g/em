namespace GestionBasica.GUI
{
    partial class EdicionFacturaDeVenta
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbIDFactura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txbIDCliente = new System.Windows.Forms.TextBox();
            this.txbCliente = new System.Windows.Forms.TextBox();
            this.txbIDEmpleado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbEmpleado = new System.Windows.Forms.TextBox();
            this.txbExcento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbGravado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbNoSujeto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbMontoDeIVA = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbSubTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbTotalAPagar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtgDetalles = new System.Windows.Forms.DataGridView();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnBuscarEmpleado = new System.Windows.Forms.Button();
            this.btnGuardarFact = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txbIDDetalle = new System.Windows.Forms.TextBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.txbProducto = new System.Windows.Forms.TextBox();
            this.txbIDProducto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txbPrecio = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnGenerarFactura = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoSujeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gravado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IDFactura: ";
            // 
            // txbIDFactura
            // 
            this.txbIDFactura.Location = new System.Drawing.Point(93, 23);
            this.txbIDFactura.Name = "txbIDFactura";
            this.txbIDFactura.Size = new System.Drawing.Size(91, 20);
            this.txbIDFactura.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(237, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(159, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "IDCliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Formas De Pago: ";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "EFECTIVO",
            "CHEQUE",
            "TARJETA"});
            this.comboBox1.Location = new System.Drawing.Point(121, 123);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // txbIDCliente
            // 
            this.txbIDCliente.Enabled = false;
            this.txbIDCliente.Location = new System.Drawing.Point(93, 88);
            this.txbIDCliente.Name = "txbIDCliente";
            this.txbIDCliente.ReadOnly = true;
            this.txbIDCliente.Size = new System.Drawing.Size(58, 20);
            this.txbIDCliente.TabIndex = 7;
            // 
            // txbCliente
            // 
            this.txbCliente.Enabled = false;
            this.txbCliente.Location = new System.Drawing.Point(150, 88);
            this.txbCliente.Name = "txbCliente";
            this.txbCliente.ReadOnly = true;
            this.txbCliente.Size = new System.Drawing.Size(203, 20);
            this.txbCliente.TabIndex = 9;
            // 
            // txbIDEmpleado
            // 
            this.txbIDEmpleado.Enabled = false;
            this.txbIDEmpleado.Location = new System.Drawing.Point(93, 55);
            this.txbIDEmpleado.Name = "txbIDEmpleado";
            this.txbIDEmpleado.ReadOnly = true;
            this.txbIDEmpleado.Size = new System.Drawing.Size(58, 20);
            this.txbIDEmpleado.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "IDEmpleado:";
            // 
            // txbEmpleado
            // 
            this.txbEmpleado.Enabled = false;
            this.txbEmpleado.Location = new System.Drawing.Point(150, 55);
            this.txbEmpleado.Name = "txbEmpleado";
            this.txbEmpleado.ReadOnly = true;
            this.txbEmpleado.Size = new System.Drawing.Size(203, 20);
            this.txbEmpleado.TabIndex = 13;
            // 
            // txbExcento
            // 
            this.txbExcento.Enabled = false;
            this.txbExcento.Location = new System.Drawing.Point(585, 269);
            this.txbExcento.Name = "txbExcento";
            this.txbExcento.ReadOnly = true;
            this.txbExcento.Size = new System.Drawing.Size(134, 20);
            this.txbExcento.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(530, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Excento:";
            // 
            // txbGravado
            // 
            this.txbGravado.Enabled = false;
            this.txbGravado.Location = new System.Drawing.Point(585, 294);
            this.txbGravado.Name = "txbGravado";
            this.txbGravado.ReadOnly = true;
            this.txbGravado.Size = new System.Drawing.Size(134, 20);
            this.txbGravado.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(530, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Gravado:";
            // 
            // txbNoSujeto
            // 
            this.txbNoSujeto.Enabled = false;
            this.txbNoSujeto.Location = new System.Drawing.Point(585, 318);
            this.txbNoSujeto.Name = "txbNoSujeto";
            this.txbNoSujeto.ReadOnly = true;
            this.txbNoSujeto.Size = new System.Drawing.Size(134, 20);
            this.txbNoSujeto.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(524, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "No Sujeto:";
            // 
            // txbMontoDeIVA
            // 
            this.txbMontoDeIVA.Enabled = false;
            this.txbMontoDeIVA.Location = new System.Drawing.Point(621, 447);
            this.txbMontoDeIVA.Name = "txbMontoDeIVA";
            this.txbMontoDeIVA.ReadOnly = true;
            this.txbMontoDeIVA.Size = new System.Drawing.Size(134, 20);
            this.txbMontoDeIVA.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(542, 450);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Monto de IVA:";
            // 
            // txbSubTotal
            // 
            this.txbSubTotal.Enabled = false;
            this.txbSubTotal.Location = new System.Drawing.Point(621, 470);
            this.txbSubTotal.Name = "txbSubTotal";
            this.txbSubTotal.ReadOnly = true;
            this.txbSubTotal.Size = new System.Drawing.Size(134, 20);
            this.txbSubTotal.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(559, 473);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Sub Total:";
            // 
            // txbTotalAPagar
            // 
            this.txbTotalAPagar.Enabled = false;
            this.txbTotalAPagar.Location = new System.Drawing.Point(621, 493);
            this.txbTotalAPagar.Name = "txbTotalAPagar";
            this.txbTotalAPagar.ReadOnly = true;
            this.txbTotalAPagar.Size = new System.Drawing.Size(134, 20);
            this.txbTotalAPagar.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(544, 496);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Total a pagar:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(414, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 131);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // dtgDetalles
            // 
            this.dtgDetalles.AllowUserToAddRows = false;
            this.dtgDetalles.AllowUserToDeleteRows = false;
            this.dtgDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.NombreProducto,
            this.PrecioUnitario,
            this.Descripcion,
            this.IDProducto,
            this.Exento,
            this.NoSujeto,
            this.Gravado});
            this.dtgDetalles.Location = new System.Drawing.Point(26, 224);
            this.dtgDetalles.Name = "dtgDetalles";
            this.dtgDetalles.ReadOnly = true;
            this.dtgDetalles.RowHeadersVisible = false;
            this.dtgDetalles.Size = new System.Drawing.Size(498, 308);
            this.dtgDetalles.TabIndex = 27;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(356, 86);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(26, 23);
            this.btnBuscarCliente.TabIndex = 28;
            this.btnBuscarCliente.Text = "...";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(356, 54);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(26, 23);
            this.btnBuscarEmpleado.TabIndex = 29;
            this.btnBuscarEmpleado.Text = "...";
            this.btnBuscarEmpleado.UseVisualStyleBackColor = true;
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
            // 
            // btnGuardarFact
            // 
            this.btnGuardarFact.Location = new System.Drawing.Point(442, 160);
            this.btnGuardarFact.Name = "btnGuardarFact";
            this.btnGuardarFact.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarFact.TabIndex = 30;
            this.btnGuardarFact.Text = "Guardar";
            this.btnGuardarFact.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "IDDetalle:";
            // 
            // txbIDDetalle
            // 
            this.txbIDDetalle.Location = new System.Drawing.Point(93, 160);
            this.txbIDDetalle.Name = "txbIDDetalle";
            this.txbIDDetalle.Size = new System.Drawing.Size(91, 20);
            this.txbIDDetalle.TabIndex = 32;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(359, 189);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(26, 23);
            this.btnBuscarProducto.TabIndex = 36;
            this.btnBuscarProducto.Text = "...";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // txbProducto
            // 
            this.txbProducto.Enabled = false;
            this.txbProducto.Location = new System.Drawing.Point(150, 191);
            this.txbProducto.Name = "txbProducto";
            this.txbProducto.ReadOnly = true;
            this.txbProducto.Size = new System.Drawing.Size(203, 20);
            this.txbProducto.TabIndex = 35;
            // 
            // txbIDProducto
            // 
            this.txbIDProducto.Enabled = false;
            this.txbIDProducto.Location = new System.Drawing.Point(93, 191);
            this.txbIDProducto.Name = "txbIDProducto";
            this.txbIDProducto.ReadOnly = true;
            this.txbIDProducto.Size = new System.Drawing.Size(58, 20);
            this.txbIDProducto.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 194);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "IDProducto:";
            // 
            // txbPrecio
            // 
            this.txbPrecio.Enabled = false;
            this.txbPrecio.Location = new System.Drawing.Point(585, 180);
            this.txbPrecio.Name = "txbPrecio";
            this.txbPrecio.ReadOnly = true;
            this.txbPrecio.Size = new System.Drawing.Size(58, 20);
            this.txbPrecio.TabIndex = 38;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(537, 184);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "Precio: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(536, 210);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 39;
            this.label15.Text = "Cantidad: ";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(585, 206);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(58, 20);
            this.nudCantidad.TabIndex = 40;
            this.nudCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudCantidad_KeyPress);
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Location = new System.Drawing.Point(545, 357);
            this.txbDescripcion.Multiline = true;
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(210, 84);
            this.txbDescripcion.TabIndex = 41;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(544, 341);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 13);
            this.label16.TabIndex = 42;
            this.label16.Text = "Descripcion: ";
            // 
            // btnGenerarFactura
            // 
            this.btnGenerarFactura.Location = new System.Drawing.Point(547, 512);
            this.btnGenerarFactura.Name = "btnGenerarFactura";
            this.btnGenerarFactura.Size = new System.Drawing.Size(198, 23);
            this.btnGenerarFactura.TabIndex = 43;
            this.btnGenerarFactura.Text = "Generar Factura";
            this.btnGenerarFactura.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(393, 191);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(131, 23);
            this.btnAgregar.TabIndex = 44;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Exento",
            "Gravada",
            "No Sujeta"});
            this.comboBox2.Location = new System.Drawing.Point(539, 242);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(180, 21);
            this.comboBox2.TabIndex = 45;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(542, 227);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 13);
            this.label17.TabIndex = 46;
            this.label17.Text = "Tipo de venta: ";
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 53;
            // 
            // NombreProducto
            // 
            this.NombreProducto.DataPropertyName = "NombreProducto";
            this.NombreProducto.HeaderText = "Nombre Prod";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.DataPropertyName = "Precio";
            this.PrecioUnitario.HeaderText = "Precio Unitario";
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Visible = false;
            // 
            // IDProducto
            // 
            this.IDProducto.HeaderText = "IDProducto";
            this.IDProducto.Name = "IDProducto";
            this.IDProducto.ReadOnly = true;
            this.IDProducto.Visible = false;
            // 
            // Exento
            // 
            this.Exento.DataPropertyName = "Exento";
            this.Exento.HeaderText = "Ventas exentas";
            this.Exento.Name = "Exento";
            this.Exento.ReadOnly = true;
            this.Exento.Width = 70;
            // 
            // NoSujeto
            // 
            this.NoSujeto.DataPropertyName = "NoSujeto";
            this.NoSujeto.HeaderText = "Ventas No Sujetas";
            this.NoSujeto.Name = "NoSujeto";
            this.NoSujeto.ReadOnly = true;
            // 
            // Gravado
            // 
            this.Gravado.DataPropertyName = "Gravado";
            this.Gravado.HeaderText = "Ventas Gravadas";
            this.Gravado.Name = "Gravado";
            this.Gravado.ReadOnly = true;
            // 
            // EdicionFacturaDeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 544);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnGenerarFactura);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txbDescripcion);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txbPrecio);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.txbProducto);
            this.Controls.Add(this.txbIDProducto);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txbIDDetalle);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnGuardarFact);
            this.Controls.Add(this.btnBuscarEmpleado);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.dtgDetalles);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txbTotalAPagar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txbSubTotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txbMontoDeIVA);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbNoSujeto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbGravado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbExcento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbEmpleado);
            this.Controls.Add(this.txbIDEmpleado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbCliente);
            this.Controls.Add(this.txbIDCliente);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbIDFactura);
            this.Controls.Add(this.label1);
            this.Name = "EdicionFacturaDeVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EdicionFacturaDeVenta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbIDFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txbIDCliente;
        private System.Windows.Forms.TextBox txbCliente;
        private System.Windows.Forms.TextBox txbIDEmpleado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbEmpleado;
        private System.Windows.Forms.TextBox txbExcento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbGravado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbNoSujeto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbMontoDeIVA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbSubTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbTotalAPagar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtgDetalles;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnBuscarEmpleado;
        private System.Windows.Forms.Button btnGuardarFact;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbIDDetalle;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.TextBox txbProducto;
        private System.Windows.Forms.TextBox txbIDProducto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbPrecio;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnGenerarFactura;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoSujeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gravado;
    }
}
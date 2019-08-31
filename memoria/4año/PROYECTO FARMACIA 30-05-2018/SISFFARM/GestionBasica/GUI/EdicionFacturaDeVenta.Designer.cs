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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbFormaDePago = new System.Windows.Forms.ComboBox();
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
            this.txbTotalGravado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbTotalExento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbTotalAPagar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
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
            this.btnGenerarFactura = new System.Windows.Forms.Button();
            this.btnAgregarALista = new System.Windows.Forms.Button();
            this.cbbTipoDeVenta = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txbNumFact = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txbTotalNoSujeto = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnQuitarDeLista = new System.Windows.Forms.Button();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VentasExcentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoSujeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VentasGravadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IDFactura: ";
            // 
            // txbIDFactura
            // 
            this.txbIDFactura.Enabled = false;
            this.txbIDFactura.Location = new System.Drawing.Point(19, 23);
            this.txbIDFactura.Name = "txbIDFactura";
            this.txbIDFactura.ReadOnly = true;
            this.txbIDFactura.Size = new System.Drawing.Size(91, 20);
            this.txbIDFactura.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha: ";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dd/MM/yyyy";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(246, 20);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(159, 20);
            this.dtpFecha.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Formas De Pago: ";
            // 
            // cbbFormaDePago
            // 
            this.cbbFormaDePago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFormaDePago.FormattingEnabled = true;
            this.cbbFormaDePago.Items.AddRange(new object[] {
            "EFECTIVO",
            "CHEQUE",
            "TARJETA"});
            this.cbbFormaDePago.Location = new System.Drawing.Point(12, 138);
            this.cbbFormaDePago.Name = "cbbFormaDePago";
            this.cbbFormaDePago.Size = new System.Drawing.Size(121, 21);
            this.cbbFormaDePago.TabIndex = 5;
            // 
            // txbIDCliente
            // 
            this.txbIDCliente.Enabled = false;
            this.txbIDCliente.Location = new System.Drawing.Point(86, 88);
            this.txbIDCliente.Name = "txbIDCliente";
            this.txbIDCliente.ReadOnly = true;
            this.txbIDCliente.Size = new System.Drawing.Size(58, 20);
            this.txbIDCliente.TabIndex = 7;
            // 
            // txbCliente
            // 
            this.txbCliente.Enabled = false;
            this.txbCliente.Location = new System.Drawing.Point(143, 88);
            this.txbCliente.Name = "txbCliente";
            this.txbCliente.ReadOnly = true;
            this.txbCliente.Size = new System.Drawing.Size(225, 20);
            this.txbCliente.TabIndex = 9;
            // 
            // txbIDEmpleado
            // 
            this.txbIDEmpleado.Enabled = false;
            this.txbIDEmpleado.Location = new System.Drawing.Point(86, 55);
            this.txbIDEmpleado.Name = "txbIDEmpleado";
            this.txbIDEmpleado.ReadOnly = true;
            this.txbIDEmpleado.Size = new System.Drawing.Size(58, 20);
            this.txbIDEmpleado.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Empleado:";
            // 
            // txbEmpleado
            // 
            this.txbEmpleado.Enabled = false;
            this.txbEmpleado.Location = new System.Drawing.Point(143, 55);
            this.txbEmpleado.Name = "txbEmpleado";
            this.txbEmpleado.ReadOnly = true;
            this.txbEmpleado.Size = new System.Drawing.Size(225, 20);
            this.txbEmpleado.TabIndex = 13;
            // 
            // txbExcento
            // 
            this.txbExcento.Enabled = false;
            this.txbExcento.Location = new System.Drawing.Point(571, 209);
            this.txbExcento.Name = "txbExcento";
            this.txbExcento.ReadOnly = true;
            this.txbExcento.Size = new System.Drawing.Size(134, 20);
            this.txbExcento.TabIndex = 15;
            this.txbExcento.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(574, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Excento:";
            // 
            // txbGravado
            // 
            this.txbGravado.Enabled = false;
            this.txbGravado.Location = new System.Drawing.Point(572, 256);
            this.txbGravado.Name = "txbGravado";
            this.txbGravado.ReadOnly = true;
            this.txbGravado.Size = new System.Drawing.Size(134, 20);
            this.txbGravado.TabIndex = 17;
            this.txbGravado.Text = "0.00";
            this.txbGravado.TextChanged += new System.EventHandler(this.txbGravado_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(575, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Gravado:";
            // 
            // txbNoSujeto
            // 
            this.txbNoSujeto.Enabled = false;
            this.txbNoSujeto.Location = new System.Drawing.Point(572, 303);
            this.txbNoSujeto.Name = "txbNoSujeto";
            this.txbNoSujeto.ReadOnly = true;
            this.txbNoSujeto.Size = new System.Drawing.Size(134, 20);
            this.txbNoSujeto.TabIndex = 19;
            this.txbNoSujeto.Text = "0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(575, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "No Sujeto:";
            // 
            // txbTotalGravado
            // 
            this.txbTotalGravado.Enabled = false;
            this.txbTotalGravado.Location = new System.Drawing.Point(675, 396);
            this.txbTotalGravado.Name = "txbTotalGravado";
            this.txbTotalGravado.ReadOnly = true;
            this.txbTotalGravado.Size = new System.Drawing.Size(105, 20);
            this.txbTotalGravado.TabIndex = 21;
            this.txbTotalGravado.Text = "0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(562, 399);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "VENTAS GRAVADAS:";
            // 
            // txbTotalExento
            // 
            this.txbTotalExento.Enabled = false;
            this.txbTotalExento.Location = new System.Drawing.Point(675, 422);
            this.txbTotalExento.Name = "txbTotalExento";
            this.txbTotalExento.ReadOnly = true;
            this.txbTotalExento.Size = new System.Drawing.Size(105, 20);
            this.txbTotalExento.TabIndex = 23;
            this.txbTotalExento.Text = "0.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(562, 425);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "VENTAS EXENTAS:";
            // 
            // txbTotalAPagar
            // 
            this.txbTotalAPagar.Enabled = false;
            this.txbTotalAPagar.Location = new System.Drawing.Point(675, 474);
            this.txbTotalAPagar.Name = "txbTotalAPagar";
            this.txbTotalAPagar.ReadOnly = true;
            this.txbTotalAPagar.Size = new System.Drawing.Size(105, 20);
            this.txbTotalAPagar.TabIndex = 25;
            this.txbTotalAPagar.Text = "0.00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(568, 477);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "TOTAL A PAGAR:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(458, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 131);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Producto,
            this.PrecioUnitario,
            this.VentasExcentas,
            this.NoSujeto,
            this.VentasGravadas,
            this.IDProducto});
            this.dgvDetalles.Location = new System.Drawing.Point(12, 260);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersVisible = false;
            this.dgvDetalles.Size = new System.Drawing.Size(541, 308);
            this.dgvDetalles.TabIndex = 27;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(374, 86);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(26, 23);
            this.btnBuscarCliente.TabIndex = 4;
            this.btnBuscarCliente.Text = "...";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(374, 53);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(26, 23);
            this.btnBuscarEmpleado.TabIndex = 3;
            this.btnBuscarEmpleado.Text = "...";
            this.btnBuscarEmpleado.UseVisualStyleBackColor = true;
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
            // 
            // btnGuardarFact
            // 
            this.btnGuardarFact.Location = new System.Drawing.Point(582, 519);
            this.btnGuardarFact.Name = "btnGuardarFact";
            this.btnGuardarFact.Size = new System.Drawing.Size(198, 23);
            this.btnGuardarFact.TabIndex = 10;
            this.btnGuardarFact.Text = "Guardar Factura";
            this.btnGuardarFact.UseVisualStyleBackColor = true;
            this.btnGuardarFact.Click += new System.EventHandler(this.btnGuardarFact_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "IDDetalle:";
            // 
            // txbIDDetalle
            // 
            this.txbIDDetalle.Enabled = false;
            this.txbIDDetalle.Location = new System.Drawing.Point(12, 187);
            this.txbIDDetalle.Name = "txbIDDetalle";
            this.txbIDDetalle.ReadOnly = true;
            this.txbIDDetalle.Size = new System.Drawing.Size(91, 20);
            this.txbIDDetalle.TabIndex = 32;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(272, 225);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(26, 23);
            this.btnBuscarProducto.TabIndex = 7;
            this.btnBuscarProducto.Text = "...";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // txbProducto
            // 
            this.txbProducto.Enabled = false;
            this.txbProducto.Location = new System.Drawing.Point(69, 227);
            this.txbProducto.Name = "txbProducto";
            this.txbProducto.ReadOnly = true;
            this.txbProducto.Size = new System.Drawing.Size(203, 20);
            this.txbProducto.TabIndex = 35;
            // 
            // txbIDProducto
            // 
            this.txbIDProducto.Enabled = false;
            this.txbIDProducto.Location = new System.Drawing.Point(12, 227);
            this.txbIDProducto.Name = "txbIDProducto";
            this.txbIDProducto.ReadOnly = true;
            this.txbIDProducto.Size = new System.Drawing.Size(58, 20);
            this.txbIDProducto.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 212);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Producto:";
            // 
            // txbPrecio
            // 
            this.txbPrecio.Enabled = false;
            this.txbPrecio.Location = new System.Drawing.Point(304, 227);
            this.txbPrecio.Name = "txbPrecio";
            this.txbPrecio.ReadOnly = true;
            this.txbPrecio.Size = new System.Drawing.Size(58, 20);
            this.txbPrecio.TabIndex = 38;
            this.txbPrecio.Text = "0.00";
            this.txbPrecio.TextChanged += new System.EventHandler(this.txbPrecio_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(307, 212);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "Precio: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(382, 213);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 39;
            this.label15.Text = "Cantidad: ";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(379, 228);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(58, 20);
            this.nudCantidad.TabIndex = 8;
            this.nudCantidad.ValueChanged += new System.EventHandler(this.nudCantidad_ValueChanged);
            this.nudCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudCantidad_KeyPress);
            // 
            // btnGenerarFactura
            // 
            this.btnGenerarFactura.Location = new System.Drawing.Point(582, 548);
            this.btnGenerarFactura.Name = "btnGenerarFactura";
            this.btnGenerarFactura.Size = new System.Drawing.Size(198, 23);
            this.btnGenerarFactura.TabIndex = 11;
            this.btnGenerarFactura.Text = "Generar Factura";
            this.btnGenerarFactura.UseVisualStyleBackColor = true;
            this.btnGenerarFactura.Click += new System.EventHandler(this.btnGenerarFactura_Click);
            // 
            // btnAgregarALista
            // 
            this.btnAgregarALista.Location = new System.Drawing.Point(456, 203);
            this.btnAgregarALista.Name = "btnAgregarALista";
            this.btnAgregarALista.Size = new System.Drawing.Size(97, 23);
            this.btnAgregarALista.TabIndex = 9;
            this.btnAgregarALista.Text = "Agregar a lista";
            this.btnAgregarALista.UseVisualStyleBackColor = true;
            this.btnAgregarALista.Click += new System.EventHandler(this.btnAgregarALista_Click);
            // 
            // cbbTipoDeVenta
            // 
            this.cbbTipoDeVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTipoDeVenta.FormattingEnabled = true;
            this.cbbTipoDeVenta.Items.AddRange(new object[] {
            "Exento",
            "Gravada",
            "No Sujeta"});
            this.cbbTipoDeVenta.Location = new System.Drawing.Point(188, 138);
            this.cbbTipoDeVenta.Name = "cbbTipoDeVenta";
            this.cbbTipoDeVenta.Size = new System.Drawing.Size(180, 21);
            this.cbbTipoDeVenta.TabIndex = 6;
            this.cbbTipoDeVenta.SelectedIndexChanged += new System.EventHandler(this.cbbTipoDeVenta_SelectedIndexChanged);
            this.cbbTipoDeVenta.SelectedValueChanged += new System.EventHandler(this.cbbTipoDeVenta_SelectedValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(191, 123);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 13);
            this.label17.TabIndex = 46;
            this.label17.Text = "Tipo de venta: ";
            // 
            // txbNumFact
            // 
            this.txbNumFact.Location = new System.Drawing.Point(133, 23);
            this.txbNumFact.Name = "txbNumFact";
            this.txbNumFact.Size = new System.Drawing.Size(91, 20);
            this.txbNumFact.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(136, 8);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 13);
            this.label18.TabIndex = 47;
            this.label18.Text = "Numero Factura: ";
            // 
            // txbTotalNoSujeto
            // 
            this.txbTotalNoSujeto.Enabled = false;
            this.txbTotalNoSujeto.Location = new System.Drawing.Point(675, 448);
            this.txbTotalNoSujeto.Name = "txbTotalNoSujeto";
            this.txbTotalNoSujeto.ReadOnly = true;
            this.txbTotalNoSujeto.Size = new System.Drawing.Size(105, 20);
            this.txbTotalNoSujeto.TabIndex = 50;
            this.txbTotalNoSujeto.Text = "0.00";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(562, 451);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(116, 13);
            this.label19.TabIndex = 49;
            this.label19.Text = "VENTAS NO SUJETA:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(537, 26);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(169, 13);
            this.label20.TabIndex = 51;
            this.label20.Text = "FARMACIA NUEVA ESPERANZA";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(472, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(93, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            // 
            // btnQuitarDeLista
            // 
            this.btnQuitarDeLista.Location = new System.Drawing.Point(456, 231);
            this.btnQuitarDeLista.Name = "btnQuitarDeLista";
            this.btnQuitarDeLista.Size = new System.Drawing.Size(97, 23);
            this.btnQuitarDeLista.TabIndex = 53;
            this.btnQuitarDeLista.Text = "Quitar de lista";
            this.btnQuitarDeLista.UseVisualStyleBackColor = true;
            this.btnQuitarDeLista.Click += new System.EventHandler(this.btnQuitarDeLista_Click);
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 53;
            // 
            // Producto
            // 
            this.Producto.DataPropertyName = "NombreProducto";
            this.Producto.HeaderText = "Descripción";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 150;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.DataPropertyName = "Precio";
            this.PrecioUnitario.HeaderText = "Precio Unitario";
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.ReadOnly = true;
            // 
            // VentasExcentas
            // 
            this.VentasExcentas.DataPropertyName = "Exento";
            this.VentasExcentas.HeaderText = "Ventas exentas";
            this.VentasExcentas.Name = "VentasExcentas";
            this.VentasExcentas.ReadOnly = true;
            this.VentasExcentas.Width = 70;
            // 
            // NoSujeto
            // 
            this.NoSujeto.DataPropertyName = "NoSujeto";
            this.NoSujeto.HeaderText = "Ventas No Sujetas";
            this.NoSujeto.Name = "NoSujeto";
            this.NoSujeto.ReadOnly = true;
            // 
            // VentasGravadas
            // 
            this.VentasGravadas.DataPropertyName = "Gravado";
            this.VentasGravadas.HeaderText = "Ventas Gravadas";
            this.VentasGravadas.Name = "VentasGravadas";
            this.VentasGravadas.ReadOnly = true;
            // 
            // IDProducto
            // 
            this.IDProducto.DataPropertyName = "IDProducto";
            this.IDProducto.HeaderText = "IDProducto";
            this.IDProducto.Name = "IDProducto";
            this.IDProducto.ReadOnly = true;
            this.IDProducto.Visible = false;
            // 
            // EdicionFacturaDeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(795, 580);
            this.Controls.Add(this.btnQuitarDeLista);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txbTotalNoSujeto);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txbNumFact);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cbbTipoDeVenta);
            this.Controls.Add(this.btnAgregarALista);
            this.Controls.Add(this.btnGenerarFactura);
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
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txbTotalAPagar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txbTotalExento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txbTotalGravado);
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
            this.Controls.Add(this.cbbFormaDePago);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbIDFactura);
            this.Controls.Add(this.label1);
            this.Name = "EdicionFacturaDeVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edición Factura de Venta";
            this.Load += new System.EventHandler(this.EdicionFacturaDeVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbIDFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbFormaDePago;
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
        private System.Windows.Forms.TextBox txbTotalGravado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbTotalExento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbTotalAPagar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvDetalles;
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
        private System.Windows.Forms.Button btnGenerarFactura;
        private System.Windows.Forms.Button btnAgregarALista;
        private System.Windows.Forms.ComboBox cbbTipoDeVenta;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txbNumFact;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txbTotalNoSujeto;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnQuitarDeLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn VentasExcentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoSujeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn VentasGravadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProducto;
    }
}
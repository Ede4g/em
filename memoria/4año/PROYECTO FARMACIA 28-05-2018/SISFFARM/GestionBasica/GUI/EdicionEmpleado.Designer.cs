namespace GestionBasica.GUI
{
    partial class EdicionEmpleado
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbIDEmpleado = new System.Windows.Forms.TextBox();
            this.txbNombres = new System.Windows.Forms.TextBox();
            this.txbApellidos = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cbbGenero = new System.Windows.Forms.ComboBox();
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txbTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBuscarFoto = new System.Windows.Forms.Button();
            this.pnNombreForm = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.txbDUI = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pbFotoEmpleado = new System.Windows.Forms.PictureBox();
            this.pnNombreForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "IDEmpleado: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 374);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de Nacimiento: ";
            // 
            // txbIDEmpleado
            // 
            this.txbIDEmpleado.Enabled = false;
            this.txbIDEmpleado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDEmpleado.Location = new System.Drawing.Point(41, 88);
            this.txbIDEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.txbIDEmpleado.Name = "txbIDEmpleado";
            this.txbIDEmpleado.ReadOnly = true;
            this.txbIDEmpleado.Size = new System.Drawing.Size(115, 23);
            this.txbIDEmpleado.TabIndex = 7;
            // 
            // txbNombres
            // 
            this.txbNombres.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombres.Location = new System.Drawing.Point(41, 139);
            this.txbNombres.Margin = new System.Windows.Forms.Padding(4);
            this.txbNombres.Name = "txbNombres";
            this.txbNombres.Size = new System.Drawing.Size(279, 23);
            this.txbNombres.TabIndex = 8;
            this.txbNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNombres_KeyPress);
            // 
            // txbApellidos
            // 
            this.txbApellidos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbApellidos.Location = new System.Drawing.Point(41, 190);
            this.txbApellidos.Margin = new System.Windows.Forms.Padding(4);
            this.txbApellidos.Name = "txbApellidos";
            this.txbApellidos.Size = new System.Drawing.Size(279, 23);
            this.txbApellidos.TabIndex = 9;
            this.txbApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbApellidos_KeyPress);
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(355, 392);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(353, 23);
            this.dtpFechaNacimiento.TabIndex = 10;
            // 
            // cbbGenero
            // 
            this.cbbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGenero.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGenero.FormattingEnabled = true;
            this.cbbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbbGenero.Location = new System.Drawing.Point(41, 394);
            this.cbbGenero.Margin = new System.Windows.Forms.Padding(4);
            this.cbbGenero.Name = "cbbGenero";
            this.cbbGenero.Size = new System.Drawing.Size(279, 25);
            this.cbbGenero.TabIndex = 11;
            // 
            // txbDireccion
            // 
            this.txbDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDireccion.Location = new System.Drawing.Point(355, 343);
            this.txbDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(353, 23);
            this.txbDireccion.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 156);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 325);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Dirección:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 321);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Teléfono:";
            // 
            // txbTelefono
            // 
            this.txbTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTelefono.Location = new System.Drawing.Point(41, 343);
            this.txbTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txbTelefono.Name = "txbTelefono";
            this.txbTelefono.Size = new System.Drawing.Size(279, 23);
            this.txbTelefono.TabIndex = 15;
            this.txbTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTelefono_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 372);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Género: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(417, 74);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Fotografía:";
            // 
            // btnBuscarFoto
            // 
            this.btnBuscarFoto.Location = new System.Drawing.Point(515, 277);
            this.btnBuscarFoto.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarFoto.Name = "btnBuscarFoto";
            this.btnBuscarFoto.Size = new System.Drawing.Size(100, 28);
            this.btnBuscarFoto.TabIndex = 20;
            this.btnBuscarFoto.Text = "Buscar";
            this.btnBuscarFoto.UseVisualStyleBackColor = true;
            // 
            // pnNombreForm
            // 
            this.pnNombreForm.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnNombreForm.Controls.Add(this.btnCerrar);
            this.pnNombreForm.Controls.Add(this.label10);
            this.pnNombreForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnNombreForm.Location = new System.Drawing.Point(0, 0);
            this.pnNombreForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnNombreForm.Name = "pnNombreForm";
            this.pnNombreForm.Size = new System.Drawing.Size(721, 44);
            this.pnNombreForm.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(0, 6);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(721, 31);
            this.label10.TabIndex = 0;
            this.label10.Text = "EMPLEADO";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ofd
            // 
            this.ofd.FileName = "Abrir Archivo de Dialogo";
            // 
            // txbDUI
            // 
            this.txbDUI.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDUI.Location = new System.Drawing.Point(41, 241);
            this.txbDUI.Margin = new System.Windows.Forms.Padding(4);
            this.txbDUI.MaxLength = 10;
            this.txbDUI.Name = "txbDUI";
            this.txbDUI.Size = new System.Drawing.Size(279, 23);
            this.txbDUI.TabIndex = 24;
            this.txbDUI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbDUI_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(45, 219);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "DUI: ";
            // 
            // txbEmail
            // 
            this.txbEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.Location = new System.Drawing.Point(41, 292);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txbEmail.MaxLength = 10;
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(279, 23);
            this.txbEmail.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(45, 270);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "Email: ";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::GestionBasica.Properties.Resources.producto;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(227, 434);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(250, 35);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackgroundImage = global::GestionBasica.Properties.Resources.cerrar;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(697, 5);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pbFotoEmpleado
            // 
            this.pbFotoEmpleado.Image = global::GestionBasica.Properties.Resources.boss_man_GRAY;
            this.pbFotoEmpleado.Location = new System.Drawing.Point(415, 92);
            this.pbFotoEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.pbFotoEmpleado.Name = "pbFotoEmpleado";
            this.pbFotoEmpleado.Size = new System.Drawing.Size(200, 185);
            this.pbFotoEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFotoEmpleado.TabIndex = 18;
            this.pbFotoEmpleado.TabStop = false;
            this.pbFotoEmpleado.DoubleClick += new System.EventHandler(this.pbFotoEmpleado_DoubleClick);
            // 
            // EdicionEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(721, 484);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txbDUI);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pnNombreForm);
            this.Controls.Add(this.btnBuscarFoto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pbFotoEmpleado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbTelefono);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbDireccion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbGenero);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.txbApellidos);
            this.Controls.Add(this.txbNombres);
            this.Controls.Add(this.txbIDEmpleado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EdicionEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EdicionEmpleado";
            this.pnNombreForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cbbGenero;
        public System.Windows.Forms.TextBox txbIDEmpleado;
        public System.Windows.Forms.TextBox txbNombres;
        public System.Windows.Forms.TextBox txbApellidos;
        public System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        public System.Windows.Forms.TextBox txbDireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txbTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBuscarFoto;
        private System.Windows.Forms.Panel pnNombreForm;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.OpenFileDialog ofd;
        public System.Windows.Forms.TextBox txbDUI;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.PictureBox pbFotoEmpleado;
    }
}
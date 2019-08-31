namespace GestionBasica.GUI
{
    partial class EdicionUsuario
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
            this.label5 = new System.Windows.Forms.Label();
            this.txbIDUsuario = new System.Windows.Forms.TextBox();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.txbCredencial = new System.Windows.Forms.TextBox();
            this.cbbRol = new System.Windows.Forms.ComboBox();
            this.btnGestionEmpleado = new System.Windows.Forms.Button();
            this.txbEmpleado = new System.Windows.Forms.TextBox();
            this.txbIDEmpleado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.pnNombreForm = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbCambiar = new System.Windows.Forms.CheckBox();
            this.pnNombreForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(38, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(38, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "IDUsuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(39, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Credencial:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(92, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Empleado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(39, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rol";
            // 
            // txbIDUsuario
            // 
            this.txbIDUsuario.Enabled = false;
            this.txbIDUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDUsuario.Location = new System.Drawing.Point(36, 90);
            this.txbIDUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbIDUsuario.Name = "txbIDUsuario";
            this.txbIDUsuario.ReadOnly = true;
            this.txbIDUsuario.Size = new System.Drawing.Size(100, 23);
            this.txbIDUsuario.TabIndex = 7;
            // 
            // txbUsuario
            // 
            this.txbUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsuario.Location = new System.Drawing.Point(36, 139);
            this.txbUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(262, 23);
            this.txbUsuario.TabIndex = 8;
            this.txbUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbUsuario_KeyPress);
            // 
            // txbCredencial
            // 
            this.txbCredencial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCredencial.Location = new System.Drawing.Point(36, 188);
            this.txbCredencial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbCredencial.Name = "txbCredencial";
            this.txbCredencial.PasswordChar = '*';
            this.txbCredencial.Size = new System.Drawing.Size(262, 23);
            this.txbCredencial.TabIndex = 9;
            // 
            // cbbRol
            // 
            this.cbbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRol.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbRol.FormattingEnabled = true;
            this.cbbRol.Location = new System.Drawing.Point(36, 300);
            this.cbbRol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbRol.Name = "cbbRol";
            this.cbbRol.Size = new System.Drawing.Size(262, 25);
            this.cbbRol.TabIndex = 13;
            // 
            // btnGestionEmpleado
            // 
            this.btnGestionEmpleado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnGestionEmpleado.Location = new System.Drawing.Point(299, 237);
            this.btnGestionEmpleado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGestionEmpleado.Name = "btnGestionEmpleado";
            this.btnGestionEmpleado.Size = new System.Drawing.Size(42, 25);
            this.btnGestionEmpleado.TabIndex = 14;
            this.btnGestionEmpleado.Text = "...";
            this.btnGestionEmpleado.UseVisualStyleBackColor = true;
            this.btnGestionEmpleado.Click += new System.EventHandler(this.btnGestionEmpleado_Click);
            // 
            // txbEmpleado
            // 
            this.txbEmpleado.Enabled = false;
            this.txbEmpleado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmpleado.Location = new System.Drawing.Point(89, 237);
            this.txbEmpleado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbEmpleado.Name = "txbEmpleado";
            this.txbEmpleado.ReadOnly = true;
            this.txbEmpleado.Size = new System.Drawing.Size(209, 23);
            this.txbEmpleado.TabIndex = 15;
            // 
            // txbIDEmpleado
            // 
            this.txbIDEmpleado.Enabled = false;
            this.txbIDEmpleado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDEmpleado.Location = new System.Drawing.Point(36, 237);
            this.txbIDEmpleado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbIDEmpleado.Name = "txbIDEmpleado";
            this.txbIDEmpleado.ReadOnly = true;
            this.txbIDEmpleado.Size = new System.Drawing.Size(52, 23);
            this.txbIDEmpleado.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(39, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "ID";
            // 
            // btnCambiar
            // 
            this.btnCambiar.Enabled = false;
            this.btnCambiar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiar.Location = new System.Drawing.Point(298, 187);
            this.btnCambiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(42, 26);
            this.btnCambiar.TabIndex = 18;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = false;
            this.btnCambiar.Visible = false;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // pnNombreForm
            // 
            this.pnNombreForm.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnNombreForm.Controls.Add(this.btnCerrar);
            this.pnNombreForm.Controls.Add(this.label7);
            this.pnNombreForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnNombreForm.Location = new System.Drawing.Point(0, 0);
            this.pnNombreForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnNombreForm.Name = "pnNombreForm";
            this.pnNombreForm.Size = new System.Drawing.Size(378, 44);
            this.pnNombreForm.TabIndex = 20;
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
            this.btnCerrar.Location = new System.Drawing.Point(355, 4);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(378, 31);
            this.label7.TabIndex = 0;
            this.label7.Text = "USUARIO";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnGuardar.Location = new System.Drawing.Point(65, 341);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(250, 35);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbCambiar
            // 
            this.cbCambiar.AutoSize = true;
            this.cbCambiar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbCambiar.Location = new System.Drawing.Point(310, 191);
            this.cbCambiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCambiar.Name = "cbCambiar";
            this.cbCambiar.Size = new System.Drawing.Size(15, 14);
            this.cbCambiar.TabIndex = 19;
            this.cbCambiar.UseVisualStyleBackColor = true;
            this.cbCambiar.Visible = false;
            // 
            // EdicionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(378, 392);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pnNombreForm);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbIDEmpleado);
            this.Controls.Add(this.txbEmpleado);
            this.Controls.Add(this.btnGestionEmpleado);
            this.Controls.Add(this.cbbRol);
            this.Controls.Add(this.txbCredencial);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.txbIDUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCambiar);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EdicionUsuario";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edicion de Usuarios";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.pnNombreForm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txbIDUsuario;
        public System.Windows.Forms.TextBox txbUsuario;
        public System.Windows.Forms.TextBox txbCredencial;
        private System.Windows.Forms.Button btnGestionEmpleado;
        public System.Windows.Forms.TextBox txbEmpleado;
        public System.Windows.Forms.ComboBox cbbRol;
        public System.Windows.Forms.TextBox txbIDEmpleado;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.Panel pnNombreForm;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.CheckBox cbCambiar;
    }
}
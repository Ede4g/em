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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txbIDUsuario = new System.Windows.Forms.TextBox();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.txbCredencial = new System.Windows.Forms.TextBox();
            this.cbbRol = new System.Windows.Forms.ComboBox();
            this.btnGestionEmpleado = new System.Windows.Forms.Button();
            this.txbEmpleados = new System.Windows.Forms.TextBox();
            this.txbIDEmpleado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "IDUsuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Credencial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Empleado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rol";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(125, 236);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(206, 236);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txbIDUsuario
            // 
            this.txbIDUsuario.Location = new System.Drawing.Point(83, 15);
            this.txbIDUsuario.Name = "txbIDUsuario";
            this.txbIDUsuario.ReadOnly = true;
            this.txbIDUsuario.Size = new System.Drawing.Size(198, 20);
            this.txbIDUsuario.TabIndex = 7;
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(83, 51);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(198, 20);
            this.txbUsuario.TabIndex = 8;
            // 
            // txbCredencial
            // 
            this.txbCredencial.Location = new System.Drawing.Point(83, 85);
            this.txbCredencial.Name = "txbCredencial";
            this.txbCredencial.PasswordChar = '*';
            this.txbCredencial.Size = new System.Drawing.Size(198, 20);
            this.txbCredencial.TabIndex = 9;
            // 
            // cbbRol
            // 
            this.cbbRol.FormattingEnabled = true;
            this.cbbRol.Location = new System.Drawing.Point(83, 186);
            this.cbbRol.Name = "cbbRol";
            this.cbbRol.Size = new System.Drawing.Size(178, 21);
            this.cbbRol.TabIndex = 13;
            // 
            // btnGestionEmpleado
            // 
            this.btnGestionEmpleado.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionEmpleado.Location = new System.Drawing.Point(266, 142);
            this.btnGestionEmpleado.Name = "btnGestionEmpleado";
            this.btnGestionEmpleado.Size = new System.Drawing.Size(32, 20);
            this.btnGestionEmpleado.TabIndex = 14;
            this.btnGestionEmpleado.Text = "...";
            this.btnGestionEmpleado.UseVisualStyleBackColor = true;
            this.btnGestionEmpleado.Click += new System.EventHandler(this.btnGestionEmpleado_Click_1);
            // 
            // txbEmpleados
            // 
            this.txbEmpleados.Location = new System.Drawing.Point(83, 142);
            this.txbEmpleados.Name = "txbEmpleados";
            this.txbEmpleados.ReadOnly = true;
            this.txbEmpleados.Size = new System.Drawing.Size(177, 20);
            this.txbEmpleados.TabIndex = 15;
            // 
            // txbIDEmpleado
            // 
            this.txbIDEmpleado.Location = new System.Drawing.Point(15, 142);
            this.txbIDEmpleado.Name = "txbIDEmpleado";
            this.txbIDEmpleado.ReadOnly = true;
            this.txbIDEmpleado.Size = new System.Drawing.Size(40, 20);
            this.txbIDEmpleado.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "ID";
            // 
            // EdicionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 285);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbIDEmpleado);
            this.Controls.Add(this.txbEmpleados);
            this.Controls.Add(this.btnGestionEmpleado);
            this.Controls.Add(this.cbbRol);
            this.Controls.Add(this.txbCredencial);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.txbIDUsuario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EdicionUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edicion de Usuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox txbIDUsuario;
        public System.Windows.Forms.TextBox txbUsuario;
        public System.Windows.Forms.TextBox txbCredencial;
        private System.Windows.Forms.Button btnGestionEmpleado;
        public System.Windows.Forms.TextBox txbEmpleados;
        public System.Windows.Forms.ComboBox cbbRol;
        public System.Windows.Forms.TextBox txbIDEmpleado;
        private System.Windows.Forms.Label label6;
    }
}
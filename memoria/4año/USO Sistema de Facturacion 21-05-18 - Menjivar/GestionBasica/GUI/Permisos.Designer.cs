namespace GestionBasica.GUI
{
    partial class Permisos
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
            this.cbbRoles = new System.Windows.Forms.ComboBox();
            this.dtgPermisos = new System.Windows.Forms.DataGridView();
            this.Asignado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IDOpcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPermiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clasificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Roles del Sistema";
            // 
            // cbbRoles
            // 
            this.cbbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRoles.FormattingEnabled = true;
            this.cbbRoles.Location = new System.Drawing.Point(12, 52);
            this.cbbRoles.Name = "cbbRoles";
            this.cbbRoles.Size = new System.Drawing.Size(273, 21);
            this.cbbRoles.TabIndex = 1;
            this.cbbRoles.SelectedValueChanged += new System.EventHandler(this.cbbRoles_SelectedValueChanged);
            // 
            // dtgPermisos
            // 
            this.dtgPermisos.AllowUserToAddRows = false;
            this.dtgPermisos.AllowUserToDeleteRows = false;
            this.dtgPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPermisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Asignado,
            this.IDOpcion,
            this.Opcion,
            this.IDPermiso,
            this.Clasificacion});
            this.dtgPermisos.Location = new System.Drawing.Point(12, 79);
            this.dtgPermisos.Name = "dtgPermisos";
            this.dtgPermisos.ReadOnly = true;
            this.dtgPermisos.RowHeadersVisible = false;
            this.dtgPermisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPermisos.Size = new System.Drawing.Size(452, 287);
            this.dtgPermisos.TabIndex = 2;
            this.dtgPermisos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPermisos_CellContentClick);
            // 
            // Asignado
            // 
            this.Asignado.DataPropertyName = "Asignado";
            this.Asignado.FalseValue = "0";
            this.Asignado.HeaderText = "Sel.";
            this.Asignado.IndeterminateValue = "0";
            this.Asignado.Name = "Asignado";
            this.Asignado.ReadOnly = true;
            this.Asignado.TrueValue = "1";
            this.Asignado.Width = 40;
            // 
            // IDOpcion
            // 
            this.IDOpcion.DataPropertyName = "IDOpcion";
            this.IDOpcion.HeaderText = "ID";
            this.IDOpcion.Name = "IDOpcion";
            this.IDOpcion.ReadOnly = true;
            this.IDOpcion.Width = 40;
            // 
            // Opcion
            // 
            this.Opcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Opcion.DataPropertyName = "Opcion";
            this.Opcion.HeaderText = "Opciones";
            this.Opcion.Name = "Opcion";
            this.Opcion.ReadOnly = true;
            // 
            // IDPermiso
            // 
            this.IDPermiso.DataPropertyName = "IDPermiso";
            this.IDPermiso.HeaderText = "IDPermiso";
            this.IDPermiso.Name = "IDPermiso";
            this.IDPermiso.ReadOnly = true;
            this.IDPermiso.Visible = false;
            // 
            // Clasificacion
            // 
            this.Clasificacion.DataPropertyName = "Clasificacion";
            this.Clasificacion.HeaderText = "Clasificacion";
            this.Clasificacion.Name = "Clasificacion";
            this.Clasificacion.ReadOnly = true;
            // 
            // Permisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 378);
            this.Controls.Add(this.dtgPermisos);
            this.Controls.Add(this.cbbRoles);
            this.Controls.Add(this.label1);
            this.Name = "Permisos";
            this.Text = "Permisos";
            this.Load += new System.EventHandler(this.Permisos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPermisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbRoles;
        private System.Windows.Forms.DataGridView dtgPermisos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Asignado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDOpcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPermiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clasificacion;
    }
}
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbbRoles = new System.Windows.Forms.ComboBox();
            this.dtgPermisos = new System.Windows.Forms.DataGridView();
            this.Asignado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IDOpcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPermiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clasificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnNombreForm = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblNumeroRegistros = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPermisos)).BeginInit();
            this.pnNombreForm.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbRoles
            // 
            this.cbbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRoles.FormattingEnabled = true;
            this.cbbRoles.Location = new System.Drawing.Point(12, 77);
            this.cbbRoles.Name = "cbbRoles";
            this.cbbRoles.Size = new System.Drawing.Size(273, 21);
            this.cbbRoles.TabIndex = 1;
            this.cbbRoles.SelectedValueChanged += new System.EventHandler(this.cbbRoles_SelectedValueChanged);
            // 
            // dtgPermisos
            // 
            this.dtgPermisos.AllowUserToAddRows = false;
            this.dtgPermisos.AllowUserToDeleteRows = false;
            this.dtgPermisos.AllowUserToResizeRows = false;
            this.dtgPermisos.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgPermisos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgPermisos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgPermisos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPermisos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgPermisos.ColumnHeadersHeight = 30;
            this.dtgPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgPermisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Asignado,
            this.IDOpcion,
            this.Opcion,
            this.IDPermiso,
            this.Clasificacion});
            this.dtgPermisos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgPermisos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgPermisos.EnableHeadersVisualStyles = false;
            this.dtgPermisos.GridColor = System.Drawing.Color.SteelBlue;
            this.dtgPermisos.Location = new System.Drawing.Point(0, 0);
            this.dtgPermisos.MultiSelect = false;
            this.dtgPermisos.Name = "dtgPermisos";
            this.dtgPermisos.ReadOnly = true;
            this.dtgPermisos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPermisos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgPermisos.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dtgPermisos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgPermisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPermisos.Size = new System.Drawing.Size(631, 268);
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
            // pnNombreForm
            // 
            this.pnNombreForm.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnNombreForm.Controls.Add(this.btnCerrar);
            this.pnNombreForm.Controls.Add(this.label2);
            this.pnNombreForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnNombreForm.Location = new System.Drawing.Point(0, 0);
            this.pnNombreForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnNombreForm.Name = "pnNombreForm";
            this.pnNombreForm.Size = new System.Drawing.Size(631, 44);
            this.pnNombreForm.TabIndex = 3;
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
            this.btnCerrar.Location = new System.Drawing.Point(608, 4);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.TabIndex = 19;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(631, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "PERMISOS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(15, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Roles del Sistema:";
            // 
            // pnlGrid
            // 
            this.pnlGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGrid.Controls.Add(this.dtgPermisos);
            this.pnlGrid.Location = new System.Drawing.Point(0, 104);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(631, 268);
            this.pnlGrid.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.statusStrip1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblNumeroRegistros});
            this.statusStrip1.Location = new System.Drawing.Point(0, 373);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(631, 24);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblNumeroRegistros
            // 
            this.lblNumeroRegistros.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroRegistros.ForeColor = System.Drawing.Color.White;
            this.lblNumeroRegistros.Name = "lblNumeroRegistros";
            this.lblNumeroRegistros.Size = new System.Drawing.Size(186, 19);
            this.lblNumeroRegistros.Text = "0 Registros Encontrados";
            // 
            // Permisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(631, 397);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnNombreForm);
            this.Controls.Add(this.cbbRoles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Permisos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Permisos";
            this.Load += new System.EventHandler(this.Permisos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPermisos)).EndInit();
            this.pnNombreForm.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbbRoles;
        private System.Windows.Forms.DataGridView dtgPermisos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Asignado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDOpcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPermiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clasificacion;
        private System.Windows.Forms.Panel pnNombreForm;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblNumeroRegistros;
    }
}
namespace IOGlobalView1.FormAtencionCl
{
    partial class BuscadorMascotas
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Dtv_Mascotas = new System.Windows.Forms.DataGridView();
            this.Pnl_BotonesYBuscador = new System.Windows.Forms.Panel();
            this.Tlp_NombreForm = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Buscador = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alergias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtv_Mascotas)).BeginInit();
            this.Pnl_BotonesYBuscador.SuspendLayout();
            this.Tlp_NombreForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.125176F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.87482F));
            this.tableLayoutPanel2.Controls.Add(this.Dtv_Mascotas, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 68);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.886792F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 98.1132F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(901, 382);
            this.tableLayoutPanel2.TabIndex = 19;
            // 
            // Dtv_Mascotas
            // 
            this.Dtv_Mascotas.AllowUserToAddRows = false;
            this.Dtv_Mascotas.AllowUserToDeleteRows = false;
            this.Dtv_Mascotas.AllowUserToResizeColumns = false;
            this.Dtv_Mascotas.AllowUserToResizeRows = false;
            this.Dtv_Mascotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dtv_Mascotas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dtv_Mascotas.BackgroundColor = System.Drawing.Color.White;
            this.Dtv_Mascotas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dtv_Mascotas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtv_Mascotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dtv_Mascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtv_Mascotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.FechaNacimiento,
            this.Sexo,
            this.Peso,
            this.Alergias,
            this.Descripcion,
            this.Especie,
            this.Raza});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtv_Mascotas.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dtv_Mascotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dtv_Mascotas.EnableHeadersVisualStyles = false;
            this.Dtv_Mascotas.Location = new System.Drawing.Point(10, 7);
            this.Dtv_Mascotas.Margin = new System.Windows.Forms.Padding(0);
            this.Dtv_Mascotas.MultiSelect = false;
            this.Dtv_Mascotas.Name = "Dtv_Mascotas";
            this.Dtv_Mascotas.ReadOnly = true;
            this.Dtv_Mascotas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dtv_Mascotas.RowHeadersVisible = false;
            this.Dtv_Mascotas.RowHeadersWidth = 50;
            this.Dtv_Mascotas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dtv_Mascotas.RowTemplate.Height = 35;
            this.Dtv_Mascotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dtv_Mascotas.Size = new System.Drawing.Size(891, 365);
            this.Dtv_Mascotas.TabIndex = 11;
            // 
            // Pnl_BotonesYBuscador
            // 
            this.Pnl_BotonesYBuscador.BackColor = System.Drawing.Color.Transparent;
            this.Pnl_BotonesYBuscador.Controls.Add(this.Tlp_NombreForm);
            this.Pnl_BotonesYBuscador.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_BotonesYBuscador.Location = new System.Drawing.Point(0, 0);
            this.Pnl_BotonesYBuscador.Name = "Pnl_BotonesYBuscador";
            this.Pnl_BotonesYBuscador.Size = new System.Drawing.Size(901, 68);
            this.Pnl_BotonesYBuscador.TabIndex = 18;
            // 
            // Tlp_NombreForm
            // 
            this.Tlp_NombreForm.ColumnCount = 3;
            this.Tlp_NombreForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Tlp_NombreForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Tlp_NombreForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Tlp_NombreForm.Controls.Add(this.label3, 0, 1);
            this.Tlp_NombreForm.Controls.Add(this.Txt_Buscador, 1, 1);
            this.Tlp_NombreForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp_NombreForm.Location = new System.Drawing.Point(0, 0);
            this.Tlp_NombreForm.Name = "Tlp_NombreForm";
            this.Tlp_NombreForm.RowCount = 3;
            this.Tlp_NombreForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.62162F));
            this.Tlp_NombreForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.37838F));
            this.Tlp_NombreForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.Tlp_NombreForm.Size = new System.Drawing.Size(901, 68);
            this.Tlp_NombreForm.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 43);
            this.label3.TabIndex = 2;
            this.label3.Text = "Buscador";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Txt_Buscador
            // 
            this.Txt_Buscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Buscador.Location = new System.Drawing.Point(104, 14);
            this.Txt_Buscador.Multiline = true;
            this.Txt_Buscador.Name = "Txt_Buscador";
            this.Txt_Buscador.Size = new System.Drawing.Size(501, 37);
            this.Txt_Buscador.TabIndex = 9;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "MascotaId";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 25;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Mascota";
            this.Nombre.FillWeight = 120F;
            this.Nombre.HeaderText = "Mascota";
            this.Nombre.MinimumWidth = 50;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.DataPropertyName = "FechaNacimiento";
            this.FechaNacimiento.HeaderText = "Fecha nacimiento";
            this.FechaNacimiento.MinimumWidth = 6;
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.MinimumWidth = 6;
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            // 
            // Peso
            // 
            this.Peso.DataPropertyName = "Peso";
            this.Peso.HeaderText = "Peso";
            this.Peso.MinimumWidth = 6;
            this.Peso.Name = "Peso";
            this.Peso.ReadOnly = true;
            // 
            // Alergias
            // 
            this.Alergias.DataPropertyName = "Alergias";
            this.Alergias.HeaderText = "Alergias";
            this.Alergias.MinimumWidth = 6;
            this.Alergias.Name = "Alergias";
            this.Alergias.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Especie
            // 
            this.Especie.DataPropertyName = "Especie";
            this.Especie.HeaderText = "Especie";
            this.Especie.MinimumWidth = 6;
            this.Especie.Name = "Especie";
            this.Especie.ReadOnly = true;
            // 
            // Raza
            // 
            this.Raza.DataPropertyName = "Raza";
            this.Raza.HeaderText = "Raza";
            this.Raza.MinimumWidth = 6;
            this.Raza.Name = "Raza";
            this.Raza.ReadOnly = true;
            // 
            // BuscadorMascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.Pnl_BotonesYBuscador);
            this.Name = "BuscadorMascotas";
            this.Text = "BuscadorMascotas";
            this.Load += new System.EventHandler(this.BuscadorMascotas_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dtv_Mascotas)).EndInit();
            this.Pnl_BotonesYBuscador.ResumeLayout(false);
            this.Tlp_NombreForm.ResumeLayout(false);
            this.Tlp_NombreForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView Dtv_Mascotas;
        private System.Windows.Forms.Panel Pnl_BotonesYBuscador;
        private System.Windows.Forms.TableLayoutPanel Tlp_NombreForm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Buscador;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alergias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raza;
    }
}
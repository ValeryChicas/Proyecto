namespace IOGlobalView1.FormAtencionCl
{
    partial class BuscadorClientes
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
            this.Tlp_DataGridViewYTextBoxt = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Dtv_Clientes = new System.Windows.Forms.DataGridView();
            this.Pnl_BotonesYBuscador = new System.Windows.Forms.Panel();
            this.Tlp_Buscador = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Buscador = new System.Windows.Forms.TextBox();
            this.Tlp_NombreForm = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tlp_DataGridViewYTextBoxt.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtv_Clientes)).BeginInit();
            this.Pnl_BotonesYBuscador.SuspendLayout();
            this.Tlp_Buscador.SuspendLayout();
            this.Tlp_NombreForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tlp_DataGridViewYTextBoxt
            // 
            this.Tlp_DataGridViewYTextBoxt.BackColor = System.Drawing.Color.Transparent;
            this.Tlp_DataGridViewYTextBoxt.ColumnCount = 1;
            this.Tlp_DataGridViewYTextBoxt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.18803F));
            this.Tlp_DataGridViewYTextBoxt.Controls.Add(this.panel1, 0, 0);
            this.Tlp_DataGridViewYTextBoxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp_DataGridViewYTextBoxt.Location = new System.Drawing.Point(0, 121);
            this.Tlp_DataGridViewYTextBoxt.Name = "Tlp_DataGridViewYTextBoxt";
            this.Tlp_DataGridViewYTextBoxt.RowCount = 1;
            this.Tlp_DataGridViewYTextBoxt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tlp_DataGridViewYTextBoxt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 329F));
            this.Tlp_DataGridViewYTextBoxt.Size = new System.Drawing.Size(800, 329);
            this.Tlp_DataGridViewYTextBoxt.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Dtv_Clientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 323);
            this.panel1.TabIndex = 14;
            // 
            // Dtv_Clientes
            // 
            this.Dtv_Clientes.AllowUserToAddRows = false;
            this.Dtv_Clientes.AllowUserToDeleteRows = false;
            this.Dtv_Clientes.AllowUserToResizeColumns = false;
            this.Dtv_Clientes.AllowUserToResizeRows = false;
            this.Dtv_Clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Dtv_Clientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dtv_Clientes.BackgroundColor = System.Drawing.Color.White;
            this.Dtv_Clientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dtv_Clientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dtv_Clientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtv_Clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dtv_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtv_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombres,
            this.Telefono,
            this.Direccion,
            this.Gmail});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtv_Clientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dtv_Clientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dtv_Clientes.EnableHeadersVisualStyles = false;
            this.Dtv_Clientes.Location = new System.Drawing.Point(0, 0);
            this.Dtv_Clientes.Margin = new System.Windows.Forms.Padding(0);
            this.Dtv_Clientes.MultiSelect = false;
            this.Dtv_Clientes.Name = "Dtv_Clientes";
            this.Dtv_Clientes.ReadOnly = true;
            this.Dtv_Clientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dtv_Clientes.RowHeadersVisible = false;
            this.Dtv_Clientes.RowHeadersWidth = 50;
            this.Dtv_Clientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dtv_Clientes.RowTemplate.Height = 35;
            this.Dtv_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dtv_Clientes.Size = new System.Drawing.Size(794, 323);
            this.Dtv_Clientes.TabIndex = 8;
            // 
            // Pnl_BotonesYBuscador
            // 
            this.Pnl_BotonesYBuscador.BackColor = System.Drawing.Color.Transparent;
            this.Pnl_BotonesYBuscador.Controls.Add(this.Tlp_Buscador);
            this.Pnl_BotonesYBuscador.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_BotonesYBuscador.Location = new System.Drawing.Point(0, 42);
            this.Pnl_BotonesYBuscador.Name = "Pnl_BotonesYBuscador";
            this.Pnl_BotonesYBuscador.Size = new System.Drawing.Size(800, 79);
            this.Pnl_BotonesYBuscador.TabIndex = 6;
            // 
            // Tlp_Buscador
            // 
            this.Tlp_Buscador.ColumnCount = 5;
            this.Tlp_Buscador.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Tlp_Buscador.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Tlp_Buscador.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Tlp_Buscador.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Tlp_Buscador.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Tlp_Buscador.Controls.Add(this.label3, 1, 1);
            this.Tlp_Buscador.Controls.Add(this.Txt_Buscador, 2, 1);
            this.Tlp_Buscador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp_Buscador.Location = new System.Drawing.Point(0, 0);
            this.Tlp_Buscador.Name = "Tlp_Buscador";
            this.Tlp_Buscador.RowCount = 3;
            this.Tlp_Buscador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.30769F));
            this.Tlp_Buscador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.69231F));
            this.Tlp_Buscador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.Tlp_Buscador.Size = new System.Drawing.Size(800, 79);
            this.Tlp_Buscador.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(3, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Buscador";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Txt_Buscador
            // 
            this.Txt_Buscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Txt_Buscador.Location = new System.Drawing.Point(104, 28);
            this.Txt_Buscador.Multiline = true;
            this.Txt_Buscador.Name = "Txt_Buscador";
            this.Txt_Buscador.Size = new System.Drawing.Size(679, 28);
            this.Txt_Buscador.TabIndex = 9;
            this.Txt_Buscador.TextChanged += new System.EventHandler(this.Txt_Buscador_TextChanged);
            // 
            // Tlp_NombreForm
            // 
            this.Tlp_NombreForm.BackColor = System.Drawing.Color.Transparent;
            this.Tlp_NombreForm.ColumnCount = 1;
            this.Tlp_NombreForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tlp_NombreForm.Controls.Add(this.label1, 0, 1);
            this.Tlp_NombreForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tlp_NombreForm.Location = new System.Drawing.Point(0, 0);
            this.Tlp_NombreForm.Name = "Tlp_NombreForm";
            this.Tlp_NombreForm.RowCount = 2;
            this.Tlp_NombreForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tlp_NombreForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.Tlp_NombreForm.Size = new System.Drawing.Size(800, 42);
            this.Tlp_NombreForm.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(794, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "CLIENTES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "ClienteId";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 25;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Nombres
            // 
            this.Nombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombres.DataPropertyName = "NombreCompleto";
            this.Nombres.FillWeight = 120F;
            this.Nombres.HeaderText = "Nombre completo";
            this.Nombres.MinimumWidth = 100;
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.FillWeight = 120F;
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 60;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 123;
            // 
            // Gmail
            // 
            this.Gmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gmail.DataPropertyName = "Correo";
            this.Gmail.FillWeight = 120F;
            this.Gmail.HeaderText = "Correo electronico";
            this.Gmail.MinimumWidth = 50;
            this.Gmail.Name = "Gmail";
            this.Gmail.ReadOnly = true;
            // 
            // BuscadorClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tlp_DataGridViewYTextBoxt);
            this.Controls.Add(this.Pnl_BotonesYBuscador);
            this.Controls.Add(this.Tlp_NombreForm);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuscadorClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscadorClientes";
            this.Load += new System.EventHandler(this.BuscadorClientes_Load);
            this.Tlp_DataGridViewYTextBoxt.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dtv_Clientes)).EndInit();
            this.Pnl_BotonesYBuscador.ResumeLayout(false);
            this.Tlp_Buscador.ResumeLayout(false);
            this.Tlp_Buscador.PerformLayout();
            this.Tlp_NombreForm.ResumeLayout(false);
            this.Tlp_NombreForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Tlp_DataGridViewYTextBoxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Dtv_Clientes;
        private System.Windows.Forms.Panel Pnl_BotonesYBuscador;
        private System.Windows.Forms.TableLayoutPanel Tlp_Buscador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Buscador;
        private System.Windows.Forms.TableLayoutPanel Tlp_NombreForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gmail;
    }
}
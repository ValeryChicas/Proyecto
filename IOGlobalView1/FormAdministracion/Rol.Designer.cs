namespace IOGlobalView1.FormAdministracion
{
    partial class Rol
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
            this.Pnl_escritorio = new System.Windows.Forms.Panel();
            this.Tlp_Dtv = new System.Windows.Forms.TableLayoutPanel();
            this.Dtv_RolUsuario = new System.Windows.Forms.DataGridView();
            this.Pnl_BotonesYBuscador = new System.Windows.Forms.Panel();
            this.Tlp_TxtBotones = new System.Windows.Forms.TableLayoutPanel();
            this.Txt_Buscador = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Txt_Rol = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Tlp_BotonesYBuscador = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pnl_escritorio.SuspendLayout();
            this.Tlp_Dtv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtv_RolUsuario)).BeginInit();
            this.Pnl_BotonesYBuscador.SuspendLayout();
            this.Tlp_TxtBotones.SuspendLayout();
            this.Tlp_BotonesYBuscador.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_escritorio
            // 
            this.Pnl_escritorio.Controls.Add(this.Tlp_Dtv);
            this.Pnl_escritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_escritorio.Location = new System.Drawing.Point(0, 122);
            this.Pnl_escritorio.Name = "Pnl_escritorio";
            this.Pnl_escritorio.Size = new System.Drawing.Size(1062, 539);
            this.Pnl_escritorio.TabIndex = 18;
            // 
            // Tlp_Dtv
            // 
            this.Tlp_Dtv.ColumnCount = 3;
            this.Tlp_Dtv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.9541985F));
            this.Tlp_Dtv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 99.0458F));
            this.Tlp_Dtv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.Tlp_Dtv.Controls.Add(this.Dtv_RolUsuario, 1, 1);
            this.Tlp_Dtv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp_Dtv.Location = new System.Drawing.Point(0, 0);
            this.Tlp_Dtv.Name = "Tlp_Dtv";
            this.Tlp_Dtv.RowCount = 3;
            this.Tlp_Dtv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.771654F));
            this.Tlp_Dtv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 98.22835F));
            this.Tlp_Dtv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.Tlp_Dtv.Size = new System.Drawing.Size(1062, 539);
            this.Tlp_Dtv.TabIndex = 13;
            // 
            // Dtv_RolUsuario
            // 
            this.Dtv_RolUsuario.AllowUserToAddRows = false;
            this.Dtv_RolUsuario.AllowUserToDeleteRows = false;
            this.Dtv_RolUsuario.AllowUserToResizeColumns = false;
            this.Dtv_RolUsuario.AllowUserToResizeRows = false;
            this.Dtv_RolUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Dtv_RolUsuario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dtv_RolUsuario.BackgroundColor = System.Drawing.Color.White;
            this.Dtv_RolUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dtv_RolUsuario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dtv_RolUsuario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtv_RolUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dtv_RolUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtv_RolUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtv_RolUsuario.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dtv_RolUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dtv_RolUsuario.EnableHeadersVisualStyles = false;
            this.Dtv_RolUsuario.Location = new System.Drawing.Point(9, 9);
            this.Dtv_RolUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.Dtv_RolUsuario.MultiSelect = false;
            this.Dtv_RolUsuario.Name = "Dtv_RolUsuario";
            this.Dtv_RolUsuario.ReadOnly = true;
            this.Dtv_RolUsuario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dtv_RolUsuario.RowHeadersVisible = false;
            this.Dtv_RolUsuario.RowHeadersWidth = 50;
            this.Dtv_RolUsuario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dtv_RolUsuario.RowTemplate.Height = 35;
            this.Dtv_RolUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dtv_RolUsuario.Size = new System.Drawing.Size(943, 504);
            this.Dtv_RolUsuario.TabIndex = 8;
            this.Dtv_RolUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtv_RolUsuario_CellContentClick);
            // 
            // Pnl_BotonesYBuscador
            // 
            this.Pnl_BotonesYBuscador.Controls.Add(this.Tlp_TxtBotones);
            this.Pnl_BotonesYBuscador.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_BotonesYBuscador.Location = new System.Drawing.Point(0, 52);
            this.Pnl_BotonesYBuscador.Name = "Pnl_BotonesYBuscador";
            this.Pnl_BotonesYBuscador.Size = new System.Drawing.Size(1062, 70);
            this.Pnl_BotonesYBuscador.TabIndex = 17;
            // 
            // Tlp_TxtBotones
            // 
            this.Tlp_TxtBotones.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Tlp_TxtBotones.ColumnCount = 8;
            this.Tlp_TxtBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.67072F));
            this.Tlp_TxtBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.09261F));
            this.Tlp_TxtBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.519177F));
            this.Tlp_TxtBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.519177F));
            this.Tlp_TxtBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.425632F));
            this.Tlp_TxtBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.57063F));
            this.Tlp_TxtBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.26661F));
            this.Tlp_TxtBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.748363F));
            this.Tlp_TxtBotones.Controls.Add(this.Txt_Buscador, 6, 1);
            this.Tlp_TxtBotones.Controls.Add(this.label5, 5, 1);
            this.Tlp_TxtBotones.Controls.Add(this.Btn_Eliminar, 4, 1);
            this.Tlp_TxtBotones.Controls.Add(this.Txt_Rol, 1, 1);
            this.Tlp_TxtBotones.Controls.Add(this.label4, 0, 1);
            this.Tlp_TxtBotones.Controls.Add(this.Btn_Modificar, 3, 1);
            this.Tlp_TxtBotones.Controls.Add(this.Btn_Agregar, 2, 1);
            this.Tlp_TxtBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp_TxtBotones.Location = new System.Drawing.Point(0, 0);
            this.Tlp_TxtBotones.Name = "Tlp_TxtBotones";
            this.Tlp_TxtBotones.RowCount = 3;
            this.Tlp_TxtBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Tlp_TxtBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33333F));
            this.Tlp_TxtBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.Tlp_TxtBotones.Size = new System.Drawing.Size(1062, 70);
            this.Tlp_TxtBotones.TabIndex = 0;
            // 
            // Txt_Buscador
            // 
            this.Txt_Buscador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_Buscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Txt_Buscador.Location = new System.Drawing.Point(678, 13);
            this.Txt_Buscador.Multiline = true;
            this.Txt_Buscador.Name = "Txt_Buscador";
            this.Txt_Buscador.Size = new System.Drawing.Size(369, 45);
            this.Txt_Buscador.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(566, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 51);
            this.label5.TabIndex = 17;
            this.label5.Text = "Buscador";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Eliminar.Image = global::IOGlobalView1.Properties.Resources.delete__1_;
            this.Btn_Eliminar.Location = new System.Drawing.Point(509, 13);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(51, 45);
            this.Btn_Eliminar.TabIndex = 18;
            this.Btn_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // Txt_Rol
            // 
            this.Txt_Rol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_Rol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Txt_Rol.Location = new System.Drawing.Point(84, 13);
            this.Txt_Rol.Multiline = true;
            this.Txt_Rol.Name = "Txt_Rol";
            this.Txt_Rol.Size = new System.Drawing.Size(303, 45);
            this.Txt_Rol.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(38, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 51);
            this.label4.TabIndex = 17;
            this.label4.Text = "Rol";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Modificar.Image = global::IOGlobalView1.Properties.Resources.pencil;
            this.Btn_Modificar.Location = new System.Drawing.Point(451, 13);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(52, 45);
            this.Btn_Modificar.TabIndex = 17;
            this.Btn_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.AccessibleDescription = "";
            this.Btn_Agregar.DialogResult = System.Windows.Forms.DialogResult.No;
            this.Btn_Agregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Agregar.Image = global::IOGlobalView1.Properties.Resources.add;
            this.Btn_Agregar.Location = new System.Drawing.Point(393, 13);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(52, 45);
            this.Btn_Agregar.TabIndex = 16;
            this.Btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Agregar.UseVisualStyleBackColor = true;
            // 
            // Tlp_BotonesYBuscador
            // 
            this.Tlp_BotonesYBuscador.BackColor = System.Drawing.Color.Transparent;
            this.Tlp_BotonesYBuscador.ColumnCount = 1;
            this.Tlp_BotonesYBuscador.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tlp_BotonesYBuscador.Controls.Add(this.label1, 0, 1);
            this.Tlp_BotonesYBuscador.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tlp_BotonesYBuscador.Location = new System.Drawing.Point(0, 0);
            this.Tlp_BotonesYBuscador.Name = "Tlp_BotonesYBuscador";
            this.Tlp_BotonesYBuscador.RowCount = 2;
            this.Tlp_BotonesYBuscador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tlp_BotonesYBuscador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.Tlp_BotonesYBuscador.Size = new System.Drawing.Size(1062, 52);
            this.Tlp_BotonesYBuscador.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1056, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "ROLES DE USUARIOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "RolUsuarioId";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 25;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn1.FillWeight = 120F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Rol usuario";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Rol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 661);
            this.Controls.Add(this.Pnl_escritorio);
            this.Controls.Add(this.Pnl_BotonesYBuscador);
            this.Controls.Add(this.Tlp_BotonesYBuscador);
            this.Name = "Rol";
            this.Text = "Rol";
            this.Load += new System.EventHandler(this.Rol_Load);
            this.Pnl_escritorio.ResumeLayout(false);
            this.Tlp_Dtv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dtv_RolUsuario)).EndInit();
            this.Pnl_BotonesYBuscador.ResumeLayout(false);
            this.Tlp_TxtBotones.ResumeLayout(false);
            this.Tlp_TxtBotones.PerformLayout();
            this.Tlp_BotonesYBuscador.ResumeLayout(false);
            this.Tlp_BotonesYBuscador.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_escritorio;
        private System.Windows.Forms.TableLayoutPanel Tlp_Dtv;
        private System.Windows.Forms.DataGridView Dtv_RolUsuario;
        private System.Windows.Forms.Panel Pnl_BotonesYBuscador;
        private System.Windows.Forms.TableLayoutPanel Tlp_TxtBotones;
        private System.Windows.Forms.TextBox Txt_Buscador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.TextBox Txt_Rol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.TableLayoutPanel Tlp_BotonesYBuscador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}
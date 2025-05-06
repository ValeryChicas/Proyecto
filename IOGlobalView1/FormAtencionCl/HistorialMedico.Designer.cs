namespace IOGlobalView1.FormAtencionCl
{
    partial class HistorialMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialMedico));
            this.Tlp_DataGridViewYTextBoxt = new System.Windows.Forms.TableLayoutPanel();
            this.Dtv_HistorialMedico = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tlp_RegistrarInfo = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Diagnostico = new System.Windows.Forms.TextBox();
            this.Dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Tratamiento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_Observaciones = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Pnl_BotonesYBuscador = new System.Windows.Forms.Panel();
            this.Tlp_Buscador = new System.Windows.Forms.TableLayoutPanel();
            this.Txt_Buscador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Tlp_NombreForm = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Txt_Mascota = new System.Windows.Forms.TextBox();
            this.Btn_BuscarMascotas = new System.Windows.Forms.Button();
            this.Tlp_DataGridViewYTextBoxt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtv_HistorialMedico)).BeginInit();
            this.Tlp_RegistrarInfo.SuspendLayout();
            this.Pnl_BotonesYBuscador.SuspendLayout();
            this.Tlp_Buscador.SuspendLayout();
            this.Tlp_NombreForm.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tlp_DataGridViewYTextBoxt
            // 
            this.Tlp_DataGridViewYTextBoxt.AutoSize = true;
            this.Tlp_DataGridViewYTextBoxt.BackColor = System.Drawing.Color.Transparent;
            this.Tlp_DataGridViewYTextBoxt.ColumnCount = 1;
            this.Tlp_DataGridViewYTextBoxt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.55932F));
            this.Tlp_DataGridViewYTextBoxt.Controls.Add(this.Dtv_HistorialMedico, 0, 0);
            this.Tlp_DataGridViewYTextBoxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp_DataGridViewYTextBoxt.Location = new System.Drawing.Point(0, 123);
            this.Tlp_DataGridViewYTextBoxt.Name = "Tlp_DataGridViewYTextBoxt";
            this.Tlp_DataGridViewYTextBoxt.RowCount = 2;
            this.Tlp_DataGridViewYTextBoxt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tlp_DataGridViewYTextBoxt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.Tlp_DataGridViewYTextBoxt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 514F));
            this.Tlp_DataGridViewYTextBoxt.Size = new System.Drawing.Size(707, 538);
            this.Tlp_DataGridViewYTextBoxt.TabIndex = 15;
            // 
            // Dtv_HistorialMedico
            // 
            this.Dtv_HistorialMedico.AllowUserToAddRows = false;
            this.Dtv_HistorialMedico.AllowUserToDeleteRows = false;
            this.Dtv_HistorialMedico.AllowUserToResizeColumns = false;
            this.Dtv_HistorialMedico.AllowUserToResizeRows = false;
            this.Dtv_HistorialMedico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dtv_HistorialMedico.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dtv_HistorialMedico.BackgroundColor = System.Drawing.Color.White;
            this.Dtv_HistorialMedico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dtv_HistorialMedico.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dtv_HistorialMedico.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtv_HistorialMedico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dtv_HistorialMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtv_HistorialMedico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Mascota,
            this.Fecha,
            this.Diagnostico,
            this.Tratamiento,
            this.Observaciones});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtv_HistorialMedico.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dtv_HistorialMedico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dtv_HistorialMedico.EnableHeadersVisualStyles = false;
            this.Dtv_HistorialMedico.Location = new System.Drawing.Point(0, 0);
            this.Dtv_HistorialMedico.Margin = new System.Windows.Forms.Padding(0);
            this.Dtv_HistorialMedico.MultiSelect = false;
            this.Dtv_HistorialMedico.Name = "Dtv_HistorialMedico";
            this.Dtv_HistorialMedico.ReadOnly = true;
            this.Dtv_HistorialMedico.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dtv_HistorialMedico.RowHeadersVisible = false;
            this.Dtv_HistorialMedico.RowHeadersWidth = 50;
            this.Dtv_HistorialMedico.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dtv_HistorialMedico.RowTemplate.Height = 35;
            this.Dtv_HistorialMedico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dtv_HistorialMedico.Size = new System.Drawing.Size(707, 519);
            this.Dtv_HistorialMedico.TabIndex = 13;
            this.Dtv_HistorialMedico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtv_HistorialMedico_CellContentClick_1);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "HistorialMedicoId";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 25;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Mascota
            // 
            this.Mascota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Mascota.DataPropertyName = "Mascota";
            this.Mascota.FillWeight = 120F;
            this.Mascota.HeaderText = "Mascota";
            this.Mascota.MinimumWidth = 50;
            this.Mascota.Name = "Mascota";
            this.Mascota.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Diagnostico
            // 
            this.Diagnostico.DataPropertyName = "Diagnostico";
            this.Diagnostico.HeaderText = "Diagnostico";
            this.Diagnostico.MinimumWidth = 6;
            this.Diagnostico.Name = "Diagnostico";
            this.Diagnostico.ReadOnly = true;
            // 
            // Tratamiento
            // 
            this.Tratamiento.DataPropertyName = "Tratamiento";
            this.Tratamiento.HeaderText = "Tratamiento";
            this.Tratamiento.MinimumWidth = 6;
            this.Tratamiento.Name = "Tratamiento";
            this.Tratamiento.ReadOnly = true;
            // 
            // Observaciones
            // 
            this.Observaciones.DataPropertyName = "Observaciones";
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.MinimumWidth = 6;
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            // 
            // Tlp_RegistrarInfo
            // 
            this.Tlp_RegistrarInfo.AutoScroll = true;
            this.Tlp_RegistrarInfo.ColumnCount = 3;
            this.Tlp_RegistrarInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.749141F));
            this.Tlp_RegistrarInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97.25086F));
            this.Tlp_RegistrarInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.Tlp_RegistrarInfo.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.Tlp_RegistrarInfo.Controls.Add(this.Btn_Agregar, 1, 11);
            this.Tlp_RegistrarInfo.Controls.Add(this.Btn_Eliminar, 1, 13);
            this.Tlp_RegistrarInfo.Controls.Add(this.Btn_Modificar, 1, 12);
            this.Tlp_RegistrarInfo.Controls.Add(this.label6, 1, 0);
            this.Tlp_RegistrarInfo.Controls.Add(this.label2, 1, 2);
            this.Tlp_RegistrarInfo.Controls.Add(this.label4, 1, 4);
            this.Tlp_RegistrarInfo.Controls.Add(this.Txt_Diagnostico, 1, 5);
            this.Tlp_RegistrarInfo.Controls.Add(this.Dtp_Fecha, 1, 3);
            this.Tlp_RegistrarInfo.Controls.Add(this.label5, 1, 6);
            this.Tlp_RegistrarInfo.Controls.Add(this.Txt_Tratamiento, 1, 7);
            this.Tlp_RegistrarInfo.Controls.Add(this.label7, 1, 8);
            this.Tlp_RegistrarInfo.Controls.Add(this.Txt_Observaciones, 1, 9);
            this.Tlp_RegistrarInfo.Controls.Add(this.label8, 1, 10);
            this.Tlp_RegistrarInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.Tlp_RegistrarInfo.Location = new System.Drawing.Point(707, 123);
            this.Tlp_RegistrarInfo.Name = "Tlp_RegistrarInfo";
            this.Tlp_RegistrarInfo.RowCount = 16;
            this.Tlp_RegistrarInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Tlp_RegistrarInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Tlp_RegistrarInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Tlp_RegistrarInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Tlp_RegistrarInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Tlp_RegistrarInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Tlp_RegistrarInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Tlp_RegistrarInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Tlp_RegistrarInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Tlp_RegistrarInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Tlp_RegistrarInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Tlp_RegistrarInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Tlp_RegistrarInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Tlp_RegistrarInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Tlp_RegistrarInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Tlp_RegistrarInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Tlp_RegistrarInfo.Size = new System.Drawing.Size(355, 538);
            this.Tlp_RegistrarInfo.TabIndex = 16;
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Agregar.Image = global::IOGlobalView1.Properties.Resources.add;
            this.Btn_Agregar.Location = new System.Drawing.Point(12, 458);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(318, 50);
            this.Btn_Agregar.TabIndex = 22;
            this.Btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Agregar.UseVisualStyleBackColor = true;
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Eliminar.Image")));
            this.Btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Eliminar.Location = new System.Drawing.Point(12, 570);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(318, 50);
            this.Btn_Eliminar.TabIndex = 2;
            this.Btn_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Modificar.Image = global::IOGlobalView1.Properties.Resources.pencil;
            this.Btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Modificar.Location = new System.Drawing.Point(12, 514);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(318, 50);
            this.Btn_Modificar.TabIndex = 1;
            this.Btn_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(12, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mascota";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Diagnostico";
            // 
            // Txt_Diagnostico
            // 
            this.Txt_Diagnostico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_Diagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Txt_Diagnostico.Location = new System.Drawing.Point(12, 155);
            this.Txt_Diagnostico.Multiline = true;
            this.Txt_Diagnostico.Name = "Txt_Diagnostico";
            this.Txt_Diagnostico.Size = new System.Drawing.Size(318, 70);
            this.Txt_Diagnostico.TabIndex = 16;
            // 
            // Dtp_Fecha
            // 
            this.Dtp_Fecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_Fecha.CustomFormat = "dd/MM/yyyy";
            this.Dtp_Fecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dtp_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Fecha.Location = new System.Drawing.Point(12, 94);
            this.Dtp_Fecha.Name = "Dtp_Fecha";
            this.Dtp_Fecha.Size = new System.Drawing.Size(318, 30);
            this.Dtp_Fecha.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(12, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tratamiento";
            // 
            // Txt_Tratamiento
            // 
            this.Txt_Tratamiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_Tratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Txt_Tratamiento.Location = new System.Drawing.Point(12, 256);
            this.Txt_Tratamiento.Multiline = true;
            this.Txt_Tratamiento.Name = "Txt_Tratamiento";
            this.Txt_Tratamiento.Size = new System.Drawing.Size(318, 70);
            this.Txt_Tratamiento.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(12, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Observaciones";
            // 
            // Txt_Observaciones
            // 
            this.Txt_Observaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_Observaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Txt_Observaciones.Location = new System.Drawing.Point(12, 357);
            this.Txt_Observaciones.Multiline = true;
            this.Txt_Observaciones.Name = "Txt_Observaciones";
            this.Txt_Observaciones.Size = new System.Drawing.Size(318, 70);
            this.Txt_Observaciones.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(12, 430);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 25);
            this.label8.TabIndex = 22;
            // 
            // Pnl_BotonesYBuscador
            // 
            this.Pnl_BotonesYBuscador.BackColor = System.Drawing.Color.Transparent;
            this.Pnl_BotonesYBuscador.Controls.Add(this.Tlp_Buscador);
            this.Pnl_BotonesYBuscador.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_BotonesYBuscador.Location = new System.Drawing.Point(0, 42);
            this.Pnl_BotonesYBuscador.Name = "Pnl_BotonesYBuscador";
            this.Pnl_BotonesYBuscador.Size = new System.Drawing.Size(1062, 81);
            this.Pnl_BotonesYBuscador.TabIndex = 13;
            // 
            // Tlp_Buscador
            // 
            this.Tlp_Buscador.ColumnCount = 5;
            this.Tlp_Buscador.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Tlp_Buscador.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Tlp_Buscador.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Tlp_Buscador.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Tlp_Buscador.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Tlp_Buscador.Controls.Add(this.Txt_Buscador, 2, 1);
            this.Tlp_Buscador.Controls.Add(this.label3, 1, 1);
            this.Tlp_Buscador.Controls.Add(this.label10, 0, 1);
            this.Tlp_Buscador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp_Buscador.Location = new System.Drawing.Point(0, 0);
            this.Tlp_Buscador.Name = "Tlp_Buscador";
            this.Tlp_Buscador.RowCount = 3;
            this.Tlp_Buscador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.81818F));
            this.Tlp_Buscador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.18182F));
            this.Tlp_Buscador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.Tlp_Buscador.Size = new System.Drawing.Size(1062, 81);
            this.Tlp_Buscador.TabIndex = 9;
            // 
            // Txt_Buscador
            // 
            this.Txt_Buscador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_Buscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Txt_Buscador.Location = new System.Drawing.Point(166, 24);
            this.Txt_Buscador.Multiline = true;
            this.Txt_Buscador.Name = "Txt_Buscador";
            this.Txt_Buscador.Size = new System.Drawing.Size(637, 39);
            this.Txt_Buscador.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(65, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Buscador";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(3, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "1234";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Visible = false;
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
            this.Tlp_NombreForm.Size = new System.Drawing.Size(1062, 42);
            this.Tlp_NombreForm.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1056, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "HISTORIAL MEDICO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.04984F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.95017F));
            this.tableLayoutPanel3.Controls.Add(this.Txt_Mascota, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.Btn_BuscarMascotas, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(9, 25);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(324, 41);
            this.tableLayoutPanel3.TabIndex = 33;
            // 
            // Txt_Mascota
            // 
            this.Txt_Mascota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_Mascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Mascota.Location = new System.Drawing.Point(3, 3);
            this.Txt_Mascota.Multiline = true;
            this.Txt_Mascota.Name = "Txt_Mascota";
            this.Txt_Mascota.ReadOnly = true;
            this.Txt_Mascota.Size = new System.Drawing.Size(269, 35);
            this.Txt_Mascota.TabIndex = 14;
            // 
            // Btn_BuscarMascotas
            // 
            this.Btn_BuscarMascotas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_BuscarMascotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_BuscarMascotas.FlatAppearance.BorderSize = 0;
            this.Btn_BuscarMascotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_BuscarMascotas.Image = global::IOGlobalView1.Properties.Resources.lupa;
            this.Btn_BuscarMascotas.Location = new System.Drawing.Point(278, 3);
            this.Btn_BuscarMascotas.Name = "Btn_BuscarMascotas";
            this.Btn_BuscarMascotas.Size = new System.Drawing.Size(43, 35);
            this.Btn_BuscarMascotas.TabIndex = 15;
            this.Btn_BuscarMascotas.UseVisualStyleBackColor = true;
            this.Btn_BuscarMascotas.Click += new System.EventHandler(this.Btn_BuscarMascotas_Click);
            // 
            // HistorialMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1062, 661);
            this.Controls.Add(this.Tlp_DataGridViewYTextBoxt);
            this.Controls.Add(this.Tlp_RegistrarInfo);
            this.Controls.Add(this.Pnl_BotonesYBuscador);
            this.Controls.Add(this.Tlp_NombreForm);
            this.Name = "HistorialMedico";
            this.Text = "HistorialMedico";
            this.Load += new System.EventHandler(this.HistorialMedico_Load);
            this.Tlp_DataGridViewYTextBoxt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dtv_HistorialMedico)).EndInit();
            this.Tlp_RegistrarInfo.ResumeLayout(false);
            this.Tlp_RegistrarInfo.PerformLayout();
            this.Pnl_BotonesYBuscador.ResumeLayout(false);
            this.Tlp_Buscador.ResumeLayout(false);
            this.Tlp_Buscador.PerformLayout();
            this.Tlp_NombreForm.ResumeLayout(false);
            this.Tlp_NombreForm.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Tlp_DataGridViewYTextBoxt;
        private System.Windows.Forms.TableLayoutPanel Tlp_RegistrarInfo;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Diagnostico;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Tratamiento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_Observaciones;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel Pnl_BotonesYBuscador;
        private System.Windows.Forms.TableLayoutPanel Tlp_Buscador;
        private System.Windows.Forms.TextBox Txt_Buscador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel Tlp_NombreForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Dtv_HistorialMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tratamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox Txt_Mascota;
        private System.Windows.Forms.Button Btn_BuscarMascotas;
    }
}
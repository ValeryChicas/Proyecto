namespace IOGlobalView1.FormAdministracion
{
    partial class Usuario
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Mensaje = new System.Windows.Forms.ToolTip(this.components);
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Dtv_Usuario = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tlp_DataGridViewYTextBoxt = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Tlp_Txt = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Contrasena = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_Empleado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Cbx_RolUsuario = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cbx_Estado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Pnl_BotonesYBuscador = new System.Windows.Forms.Panel();
            this.Tlp_NombreForm = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Buscador = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Tlp_BotonesYBuscador = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dtv_Usuario)).BeginInit();
            this.Tlp_DataGridViewYTextBoxt.SuspendLayout();
            this.panel3.SuspendLayout();
            this.Tlp_Txt.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Pnl_BotonesYBuscador.SuspendLayout();
            this.Tlp_NombreForm.SuspendLayout();
            this.Tlp_BotonesYBuscador.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Eliminar.Image = global::IOGlobalView1.Properties.Resources.delete__1_;
            this.Btn_Eliminar.Location = new System.Drawing.Point(3, 457);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(284, 50);
            this.Btn_Eliminar.TabIndex = 2;
            this.Btn_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Mensaje.SetToolTip(this.Btn_Eliminar, "Elimina un usuario");
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Modificar.Image = global::IOGlobalView1.Properties.Resources.pencil;
            this.Btn_Modificar.Location = new System.Drawing.Point(3, 401);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(284, 50);
            this.Btn_Modificar.TabIndex = 1;
            this.Btn_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Mensaje.SetToolTip(this.Btn_Modificar, "Modifca el nombre de un usuari que ya existe");
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Txt_Usuario.Location = new System.Drawing.Point(3, 28);
            this.Txt_Usuario.Multiline = true;
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(284, 32);
            this.Txt_Usuario.TabIndex = 11;
            this.Mensaje.SetToolTip(this.Txt_Usuario, "Ingresa el nombre para un usuario");
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Agregar.Image = global::IOGlobalView1.Properties.Resources.add;
            this.Btn_Agregar.Location = new System.Drawing.Point(3, 345);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(284, 50);
            this.Btn_Agregar.TabIndex = 0;
            this.Btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Mensaje.SetToolTip(this.Btn_Agregar, "Agrega un nuevo usuario");
            this.Btn_Agregar.UseVisualStyleBackColor = true;
            // 
            // Dtv_Usuario
            // 
            this.Dtv_Usuario.AllowUserToAddRows = false;
            this.Dtv_Usuario.AllowUserToDeleteRows = false;
            this.Dtv_Usuario.AllowUserToResizeColumns = false;
            this.Dtv_Usuario.AllowUserToResizeRows = false;
            this.Dtv_Usuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Dtv_Usuario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dtv_Usuario.BackgroundColor = System.Drawing.Color.White;
            this.Dtv_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dtv_Usuario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dtv_Usuario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtv_Usuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Dtv_Usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtv_Usuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Uss,
            this.contraseña,
            this.Empleado,
            this.Rol,
            this.Estado});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtv_Usuario.DefaultCellStyle = dataGridViewCellStyle6;
            this.Dtv_Usuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dtv_Usuario.EnableHeadersVisualStyles = false;
            this.Dtv_Usuario.Location = new System.Drawing.Point(13, 0);
            this.Dtv_Usuario.Margin = new System.Windows.Forms.Padding(0);
            this.Dtv_Usuario.MultiSelect = false;
            this.Dtv_Usuario.Name = "Dtv_Usuario";
            this.Dtv_Usuario.ReadOnly = true;
            this.Dtv_Usuario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dtv_Usuario.RowHeadersVisible = false;
            this.Dtv_Usuario.RowHeadersWidth = 50;
            this.Dtv_Usuario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dtv_Usuario.RowTemplate.Height = 35;
            this.Dtv_Usuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dtv_Usuario.Size = new System.Drawing.Size(737, 543);
            this.Dtv_Usuario.TabIndex = 7;
            this.Mensaje.SetToolTip(this.Dtv_Usuario, "Aquí se muestra toda la información sobre los usuarios que se encuentran registra" +
        "dos");
            this.Dtv_Usuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtv_Usuario_CellContentClick);
            this.Dtv_Usuario.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Dtv_Usuario_CellFormatting);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "UsuarioId";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 25;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Uss
            // 
            this.Uss.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Uss.DataPropertyName = "Nombre";
            this.Uss.FillWeight = 120F;
            this.Uss.HeaderText = "Usuario";
            this.Uss.MinimumWidth = 100;
            this.Uss.Name = "Uss";
            this.Uss.ReadOnly = true;
            // 
            // contraseña
            // 
            this.contraseña.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contraseña.DataPropertyName = "Contrasena";
            this.contraseña.FillWeight = 120F;
            this.contraseña.HeaderText = "Contraseña";
            this.contraseña.MinimumWidth = 60;
            this.contraseña.Name = "contraseña";
            this.contraseña.ReadOnly = true;
            // 
            // Empleado
            // 
            this.Empleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Empleado.DataPropertyName = "Empleado";
            this.Empleado.FillWeight = 120F;
            this.Empleado.HeaderText = "Rol";
            this.Empleado.MinimumWidth = 50;
            this.Empleado.Name = "Empleado";
            this.Empleado.ReadOnly = true;
            // 
            // Rol
            // 
            this.Rol.DataPropertyName = "Rol";
            this.Rol.HeaderText = "Empleado";
            this.Rol.MinimumWidth = 6;
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            this.Rol.Width = 128;
            // 
            // Estado
            // 
            this.Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Estado.DataPropertyName = "Estado";
            this.Estado.FillWeight = 120F;
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 50;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Tlp_DataGridViewYTextBoxt
            // 
            this.Tlp_DataGridViewYTextBoxt.BackColor = System.Drawing.Color.Transparent;
            this.Tlp_DataGridViewYTextBoxt.ColumnCount = 2;
            this.Tlp_DataGridViewYTextBoxt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.18803F));
            this.Tlp_DataGridViewYTextBoxt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.81197F));
            this.Tlp_DataGridViewYTextBoxt.Controls.Add(this.panel3, 1, 0);
            this.Tlp_DataGridViewYTextBoxt.Controls.Add(this.panel1, 0, 0);
            this.Tlp_DataGridViewYTextBoxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp_DataGridViewYTextBoxt.Location = new System.Drawing.Point(0, 112);
            this.Tlp_DataGridViewYTextBoxt.Name = "Tlp_DataGridViewYTextBoxt";
            this.Tlp_DataGridViewYTextBoxt.RowCount = 1;
            this.Tlp_DataGridViewYTextBoxt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tlp_DataGridViewYTextBoxt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 549F));
            this.Tlp_DataGridViewYTextBoxt.Size = new System.Drawing.Size(1062, 549);
            this.Tlp_DataGridViewYTextBoxt.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.Tlp_Txt);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(759, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 543);
            this.panel3.TabIndex = 13;
            // 
            // Tlp_Txt
            // 
            this.Tlp_Txt.ColumnCount = 2;
            this.Tlp_Txt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tlp_Txt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.Tlp_Txt.Controls.Add(this.Btn_Eliminar, 0, 13);
            this.Tlp_Txt.Controls.Add(this.Btn_Modificar, 0, 12);
            this.Tlp_Txt.Controls.Add(this.label5, 0, 2);
            this.Tlp_Txt.Controls.Add(this.Txt_Contrasena, 0, 3);
            this.Tlp_Txt.Controls.Add(this.label7, 0, 4);
            this.Tlp_Txt.Controls.Add(this.Txt_Empleado, 0, 5);
            this.Tlp_Txt.Controls.Add(this.Txt_Usuario, 0, 1);
            this.Tlp_Txt.Controls.Add(this.label6, 0, 0);
            this.Tlp_Txt.Controls.Add(this.label8, 0, 6);
            this.Tlp_Txt.Controls.Add(this.Cbx_RolUsuario, 0, 7);
            this.Tlp_Txt.Controls.Add(this.label4, 0, 8);
            this.Tlp_Txt.Controls.Add(this.Cbx_Estado, 0, 9);
            this.Tlp_Txt.Controls.Add(this.label2, 0, 10);
            this.Tlp_Txt.Controls.Add(this.Btn_Agregar, 0, 11);
            this.Tlp_Txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp_Txt.Location = new System.Drawing.Point(0, 0);
            this.Tlp_Txt.Name = "Tlp_Txt";
            this.Tlp_Txt.RowCount = 15;
            this.Tlp_Txt.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Tlp_Txt.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Tlp_Txt.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Tlp_Txt.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Tlp_Txt.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Tlp_Txt.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Tlp_Txt.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Tlp_Txt.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Tlp_Txt.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Tlp_Txt.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Tlp_Txt.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Tlp_Txt.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Tlp_Txt.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Tlp_Txt.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Tlp_Txt.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Tlp_Txt.Size = new System.Drawing.Size(300, 543);
            this.Tlp_Txt.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(3, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Contraseña";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Txt_Contrasena
            // 
            this.Txt_Contrasena.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_Contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Txt_Contrasena.Location = new System.Drawing.Point(3, 91);
            this.Txt_Contrasena.Multiline = true;
            this.Txt_Contrasena.Name = "Txt_Contrasena";
            this.Txt_Contrasena.Size = new System.Drawing.Size(284, 32);
            this.Txt_Contrasena.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(3, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Empleado";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Txt_Empleado
            // 
            this.Txt_Empleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_Empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Txt_Empleado.Location = new System.Drawing.Point(3, 154);
            this.Txt_Empleado.Multiline = true;
            this.Txt_Empleado.Name = "Txt_Empleado";
            this.Txt_Empleado.Size = new System.Drawing.Size(284, 32);
            this.Txt_Empleado.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Usuario";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(3, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "Rol usuario";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Cbx_RolUsuario
            // 
            this.Cbx_RolUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cbx_RolUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Cbx_RolUsuario.FormattingEnabled = true;
            this.Cbx_RolUsuario.Location = new System.Drawing.Point(3, 217);
            this.Cbx_RolUsuario.Name = "Cbx_RolUsuario";
            this.Cbx_RolUsuario.Size = new System.Drawing.Size(284, 33);
            this.Cbx_RolUsuario.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(3, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Estado";
            // 
            // Cbx_Estado
            // 
            this.Cbx_Estado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cbx_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Cbx_Estado.FormattingEnabled = true;
            this.Cbx_Estado.Location = new System.Drawing.Point(3, 281);
            this.Cbx_Estado.Name = "Cbx_Estado";
            this.Cbx_Estado.Size = new System.Drawing.Size(284, 33);
            this.Cbx_Estado.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(3, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Dtv_Usuario);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 543);
            this.panel1.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(13, 543);
            this.panel4.TabIndex = 0;
            // 
            // Pnl_BotonesYBuscador
            // 
            this.Pnl_BotonesYBuscador.BackColor = System.Drawing.Color.Transparent;
            this.Pnl_BotonesYBuscador.Controls.Add(this.Tlp_NombreForm);
            this.Pnl_BotonesYBuscador.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_BotonesYBuscador.Location = new System.Drawing.Point(0, 42);
            this.Pnl_BotonesYBuscador.Name = "Pnl_BotonesYBuscador";
            this.Pnl_BotonesYBuscador.Size = new System.Drawing.Size(1062, 70);
            this.Pnl_BotonesYBuscador.TabIndex = 6;
            // 
            // Tlp_NombreForm
            // 
            this.Tlp_NombreForm.ColumnCount = 5;
            this.Tlp_NombreForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Tlp_NombreForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Tlp_NombreForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Tlp_NombreForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Tlp_NombreForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Tlp_NombreForm.Controls.Add(this.label3, 1, 1);
            this.Tlp_NombreForm.Controls.Add(this.Txt_Buscador, 2, 1);
            this.Tlp_NombreForm.Controls.Add(this.label9, 0, 1);
            this.Tlp_NombreForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp_NombreForm.Location = new System.Drawing.Point(0, 0);
            this.Tlp_NombreForm.Name = "Tlp_NombreForm";
            this.Tlp_NombreForm.RowCount = 3;
            this.Tlp_NombreForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.48276F));
            this.Tlp_NombreForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.51724F));
            this.Tlp_NombreForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.Tlp_NombreForm.Size = new System.Drawing.Size(1062, 70);
            this.Tlp_NombreForm.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(65, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Buscador";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Txt_Buscador
            // 
            this.Txt_Buscador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_Buscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Txt_Buscador.Location = new System.Drawing.Point(166, 23);
            this.Txt_Buscador.Multiline = true;
            this.Txt_Buscador.Name = "Txt_Buscador";
            this.Txt_Buscador.Size = new System.Drawing.Size(766, 32);
            this.Txt_Buscador.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Left;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(3, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 38);
            this.label9.TabIndex = 11;
            this.label9.Text = "1234";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Visible = false;
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
            this.Tlp_BotonesYBuscador.Size = new System.Drawing.Size(1062, 42);
            this.Tlp_BotonesYBuscador.TabIndex = 7;
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
            this.label1.Text = "USUARIOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1062, 661);
            this.Controls.Add(this.Tlp_DataGridViewYTextBoxt);
            this.Controls.Add(this.Pnl_BotonesYBuscador);
            this.Controls.Add(this.Tlp_BotonesYBuscador);
            this.Name = "Usuario";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dtv_Usuario)).EndInit();
            this.Tlp_DataGridViewYTextBoxt.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.Tlp_Txt.ResumeLayout(false);
            this.Tlp_Txt.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.Pnl_BotonesYBuscador.ResumeLayout(false);
            this.Tlp_NombreForm.ResumeLayout(false);
            this.Tlp_NombreForm.PerformLayout();
            this.Tlp_BotonesYBuscador.ResumeLayout(false);
            this.Tlp_BotonesYBuscador.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip Mensaje;
        private System.Windows.Forms.TableLayoutPanel Tlp_DataGridViewYTextBoxt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel Tlp_Txt;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Contrasena;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_Empleado;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Cbx_RolUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cbx_Estado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Dtv_Usuario;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel Pnl_BotonesYBuscador;
        private System.Windows.Forms.TableLayoutPanel Tlp_NombreForm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Buscador;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TableLayoutPanel Tlp_BotonesYBuscador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uss;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseña;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}
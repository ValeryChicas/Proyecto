namespace IOGlobalView1
{
    partial class Contenedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contenedor));
            this.Pnl_escritorio = new System.Windows.Forms.Panel();
            this.Ts_Menu = new System.Windows.Forms.ToolStrip();
            this.Separator = new System.Windows.Forms.ToolStripSeparator();
            this.Img = new System.Windows.Forms.ToolStripLabel();
            this.separador = new System.Windows.Forms.ToolStripSeparator();
            this.AtencionAlCliente = new System.Windows.Forms.ToolStripSplitButton();
            this.Btn_Cliente = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Mascotas = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_HistorialMedico = new System.Windows.Forms.ToolStripMenuItem();
            this.Separador3 = new System.Windows.Forms.ToolStripSeparator();
            this.ServiciosYCitas = new System.Windows.Forms.ToolStripSplitButton();
            this.Btn_Citas = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_CitaServicios = new System.Windows.Forms.ToolStripMenuItem();
            this.Separador4 = new System.Windows.Forms.ToolStripSeparator();
            this.VentaProductos = new System.Windows.Forms.ToolStripButton();
            this.Separador7 = new System.Windows.Forms.ToolStripSeparator();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Inventario = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Btn_DevolucionVenta = new System.Windows.Forms.ToolStripButton();
            this.Ts_Menu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_escritorio
            // 
            this.Pnl_escritorio.BackColor = System.Drawing.Color.White;
            this.Pnl_escritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_escritorio.Location = new System.Drawing.Point(210, 40);
            this.Pnl_escritorio.Name = "Pnl_escritorio";
            this.Pnl_escritorio.Size = new System.Drawing.Size(1077, 708);
            this.Pnl_escritorio.TabIndex = 18;
            // 
            // Ts_Menu
            // 
            this.Ts_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(182)))), ((int)(((byte)(246)))));
            this.Ts_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Ts_Menu.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ts_Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Ts_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Separator,
            this.Img,
            this.separador,
            this.AtencionAlCliente,
            this.Separador3,
            this.ServiciosYCitas,
            this.Separador4,
            this.Btn_Inventario,
            this.toolStripSeparator1,
            this.VentaProductos,
            this.Separador7,
            this.Btn_DevolucionVenta});
            this.Ts_Menu.Location = new System.Drawing.Point(0, 40);
            this.Ts_Menu.Name = "Ts_Menu";
            this.Ts_Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Ts_Menu.Size = new System.Drawing.Size(210, 708);
            this.Ts_Menu.TabIndex = 17;
            this.Ts_Menu.Text = "Menu";
            // 
            // Separator
            // 
            this.Separator.Name = "Separator";
            this.Separator.Size = new System.Drawing.Size(207, 6);
            // 
            // Img
            // 
            this.Img.Image = ((System.Drawing.Image)(resources.GetObject("Img.Image")));
            this.Img.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Img.Name = "Img";
            this.Img.Size = new System.Drawing.Size(207, 128);
            // 
            // separador
            // 
            this.separador.ForeColor = System.Drawing.Color.Black;
            this.separador.Name = "separador";
            this.separador.Size = new System.Drawing.Size(207, 6);
            // 
            // AtencionAlCliente
            // 
            this.AtencionAlCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AtencionAlCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_Cliente,
            this.Btn_Mascotas});
            this.AtencionAlCliente.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtencionAlCliente.Image = ((System.Drawing.Image)(resources.GetObject("AtencionAlCliente.Image")));
            this.AtencionAlCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AtencionAlCliente.Name = "AtencionAlCliente";
            this.AtencionAlCliente.Size = new System.Drawing.Size(207, 30);
            this.AtencionAlCliente.Text = "Atencion al cliente";
            // 
            // Btn_Cliente
            // 
            this.Btn_Cliente.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cliente.Image = global::IOGlobalView1.Properties.Resources.clientes;
            this.Btn_Cliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Cliente.Name = "Btn_Cliente";
            this.Btn_Cliente.Size = new System.Drawing.Size(236, 38);
            this.Btn_Cliente.Text = "Clientes";
            this.Btn_Cliente.Click += new System.EventHandler(this.Btn_Cliente_Click);
            // 
            // Btn_Mascotas
            // 
            this.Btn_Mascotas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_HistorialMedico});
            this.Btn_Mascotas.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Mascotas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Mascotas.Image")));
            this.Btn_Mascotas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Mascotas.Name = "Btn_Mascotas";
            this.Btn_Mascotas.Size = new System.Drawing.Size(236, 38);
            this.Btn_Mascotas.Text = "Mascotas";
            this.Btn_Mascotas.Click += new System.EventHandler(this.Btn_Mascotas_Click);
            // 
            // Btn_HistorialMedico
            // 
            this.Btn_HistorialMedico.Image = global::IOGlobalView1.Properties.Resources.electronic_healthcare_17789179;
            this.Btn_HistorialMedico.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_HistorialMedico.Name = "Btn_HistorialMedico";
            this.Btn_HistorialMedico.Size = new System.Drawing.Size(242, 38);
            this.Btn_HistorialMedico.Text = "Historial Medico";
            this.Btn_HistorialMedico.Click += new System.EventHandler(this.Btn_HistorialMedico_Click);
            // 
            // Separador3
            // 
            this.Separador3.ForeColor = System.Drawing.Color.Black;
            this.Separador3.Name = "Separador3";
            this.Separador3.Size = new System.Drawing.Size(207, 6);
            // 
            // ServiciosYCitas
            // 
            this.ServiciosYCitas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ServiciosYCitas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_Citas,
            this.Btn_CitaServicios});
            this.ServiciosYCitas.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiciosYCitas.Image = ((System.Drawing.Image)(resources.GetObject("ServiciosYCitas.Image")));
            this.ServiciosYCitas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ServiciosYCitas.Name = "ServiciosYCitas";
            this.ServiciosYCitas.Size = new System.Drawing.Size(207, 30);
            this.ServiciosYCitas.Text = "Servicios y citas";
            // 
            // Btn_Citas
            // 
            this.Btn_Citas.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Citas.Image = global::IOGlobalView1.Properties.Resources.appointment_5559786;
            this.Btn_Citas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Citas.Name = "Btn_Citas";
            this.Btn_Citas.Size = new System.Drawing.Size(236, 38);
            this.Btn_Citas.Text = "Citas";
            this.Btn_Citas.Click += new System.EventHandler(this.Btn_Citas_Click);
            // 
            // Btn_CitaServicios
            // 
            this.Btn_CitaServicios.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CitaServicios.Image = global::IOGlobalView1.Properties.Resources.electronic_healthcare_17789179;
            this.Btn_CitaServicios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_CitaServicios.Name = "Btn_CitaServicios";
            this.Btn_CitaServicios.Size = new System.Drawing.Size(236, 38);
            this.Btn_CitaServicios.Text = "Cita servicios";
            this.Btn_CitaServicios.Click += new System.EventHandler(this.Btn_CitaServicios_Click);
            // 
            // Separador4
            // 
            this.Separador4.Name = "Separador4";
            this.Separador4.Size = new System.Drawing.Size(207, 6);
            // 
            // VentaProductos
            // 
            this.VentaProductos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.VentaProductos.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentaProductos.Image = ((System.Drawing.Image)(resources.GetObject("VentaProductos.Image")));
            this.VentaProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VentaProductos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.VentaProductos.Name = "VentaProductos";
            this.VentaProductos.Size = new System.Drawing.Size(207, 30);
            this.VentaProductos.Text = "Ventas";
            this.VentaProductos.Click += new System.EventHandler(this.VentaProductos_Click);
            // 
            // Separador7
            // 
            this.Separador7.Name = "Separador7";
            this.Separador7.Size = new System.Drawing.Size(207, 6);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(182)))), ((int)(((byte)(246)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.12006F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.87994F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 284F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1287, 40);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(285, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(714, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "CLÍNICA VETERINARIA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Inventario
            // 
            this.Btn_Inventario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Btn_Inventario.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Inventario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Inventario.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Inventario.Image")));
            this.Btn_Inventario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Inventario.Name = "Btn_Inventario";
            this.Btn_Inventario.Size = new System.Drawing.Size(207, 31);
            this.Btn_Inventario.Text = "Inventario";
            this.Btn_Inventario.Click += new System.EventHandler(this.Btn_Inventario_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // Btn_DevolucionVenta
            // 
            this.Btn_DevolucionVenta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Btn_DevolucionVenta.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DevolucionVenta.Image = ((System.Drawing.Image)(resources.GetObject("Btn_DevolucionVenta.Image")));
            this.Btn_DevolucionVenta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_DevolucionVenta.Name = "Btn_DevolucionVenta";
            this.Btn_DevolucionVenta.Size = new System.Drawing.Size(207, 31);
            this.Btn_DevolucionVenta.Text = "Devolucion venta";
            this.Btn_DevolucionVenta.Click += new System.EventHandler(this.Btn_DevolucionVenta_Click);
            // 
            // Contenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 748);
            this.Controls.Add(this.Pnl_escritorio);
            this.Controls.Add(this.Ts_Menu);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Contenedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Contenedor_Load);
            this.Ts_Menu.ResumeLayout(false);
            this.Ts_Menu.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_escritorio;
        private System.Windows.Forms.ToolStrip Ts_Menu;
        private System.Windows.Forms.ToolStripSeparator Separator;
        private System.Windows.Forms.ToolStripLabel Img;
        private System.Windows.Forms.ToolStripSeparator separador;
        private System.Windows.Forms.ToolStripSplitButton AtencionAlCliente;
        private System.Windows.Forms.ToolStripMenuItem Btn_Cliente;
        private System.Windows.Forms.ToolStripMenuItem Btn_Mascotas;
        private System.Windows.Forms.ToolStripMenuItem Btn_HistorialMedico;
        private System.Windows.Forms.ToolStripSeparator Separador3;
        private System.Windows.Forms.ToolStripSplitButton ServiciosYCitas;
        private System.Windows.Forms.ToolStripMenuItem Btn_Citas;
        private System.Windows.Forms.ToolStripMenuItem Btn_CitaServicios;
        private System.Windows.Forms.ToolStripSeparator Separador4;
        private System.Windows.Forms.ToolStripButton VentaProductos;
        private System.Windows.Forms.ToolStripSeparator Separador7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton Btn_Inventario;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Btn_DevolucionVenta;
    }
}
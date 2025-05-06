namespace IOGlobalView1
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Pnl_escritorio = new System.Windows.Forms.Panel();
            this.Ts_Menu = new System.Windows.Forms.ToolStrip();
            this.Separator = new System.Windows.Forms.ToolStripSeparator();
            this.Img = new System.Windows.Forms.ToolStripLabel();
            this.separador = new System.Windows.Forms.ToolStripSeparator();
            this.Administracion = new System.Windows.Forms.ToolStripSplitButton();
            this.Btn_Empleado = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_CargoEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Usuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.Separador2 = new System.Windows.Forms.ToolStripSeparator();
            this.AtencionAlCliente = new System.Windows.Forms.ToolStripSplitButton();
            this.Btn_Cliente = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Mascotas = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_HistorialMedico = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Especie = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Raza = new System.Windows.Forms.ToolStripMenuItem();
            this.Separador3 = new System.Windows.Forms.ToolStripSeparator();
            this.ServiciosYCitas = new System.Windows.Forms.ToolStripSplitButton();
            this.Btn_Citas = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Servicios = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_CitaServicios = new System.Windows.Forms.ToolStripMenuItem();
            this.Separador4 = new System.Windows.Forms.ToolStripSeparator();
            this.Inventario = new System.Windows.Forms.ToolStripSplitButton();
            this.Btn_CategoriaProd = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Productos = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Inventario = new System.Windows.Forms.ToolStripMenuItem();
            this.Separador5 = new System.Windows.Forms.ToolStripSeparator();
            this.Compras = new System.Windows.Forms.ToolStripSplitButton();
            this.Btn_Proveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Compras = new System.Windows.Forms.ToolStripMenuItem();
            this.Separador6 = new System.Windows.Forms.ToolStripSeparator();
            this.VentaProductos = new System.Windows.Forms.ToolStripButton();
            this.Separador7 = new System.Windows.Forms.ToolStripSeparator();
            this.Devoluciones = new System.Windows.Forms.ToolStripSplitButton();
            this.Btn_DevolucionCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_DevolucionVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_CierreCaja = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
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
            this.Pnl_escritorio.TabIndex = 15;
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
            this.Administracion,
            this.Separador2,
            this.AtencionAlCliente,
            this.Separador3,
            this.ServiciosYCitas,
            this.Separador4,
            this.Inventario,
            this.Separador5,
            this.Compras,
            this.Separador6,
            this.VentaProductos,
            this.Separador7,
            this.Devoluciones});
            this.Ts_Menu.Location = new System.Drawing.Point(0, 40);
            this.Ts_Menu.Name = "Ts_Menu";
            this.Ts_Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Ts_Menu.Size = new System.Drawing.Size(210, 708);
            this.Ts_Menu.TabIndex = 14;
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
            this.Img.Click += new System.EventHandler(this.Img_Click);
            // 
            // separador
            // 
            this.separador.ForeColor = System.Drawing.Color.Black;
            this.separador.Name = "separador";
            this.separador.Size = new System.Drawing.Size(207, 6);
            // 
            // Administracion
            // 
            this.Administracion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Administracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_Empleado,
            this.Btn_Usuarios});
            this.Administracion.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Administracion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Administracion.Name = "Administracion";
            this.Administracion.Size = new System.Drawing.Size(207, 30);
            this.Administracion.Tag = "s";
            this.Administracion.Text = "Administración";
            this.Administracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Empleado
            // 
            this.Btn_Empleado.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_CargoEmpleado});
            this.Btn_Empleado.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Empleado.Image = global::IOGlobalView1.Properties.Resources.crowd;
            this.Btn_Empleado.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Empleado.Name = "Btn_Empleado";
            this.Btn_Empleado.Size = new System.Drawing.Size(236, 38);
            this.Btn_Empleado.Text = "Empleados";
            this.Btn_Empleado.Click += new System.EventHandler(this.Btn_Empleado_Click);
            // 
            // Btn_CargoEmpleado
            // 
            this.Btn_CargoEmpleado.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CargoEmpleado.Image = global::IOGlobalView1.Properties.Resources.id_card;
            this.Btn_CargoEmpleado.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_CargoEmpleado.Name = "Btn_CargoEmpleado";
            this.Btn_CargoEmpleado.Size = new System.Drawing.Size(242, 38);
            this.Btn_CargoEmpleado.Text = "Cargo empleado";
            this.Btn_CargoEmpleado.Click += new System.EventHandler(this.Btn_CargoEmpleado_Click);
            // 
            // Btn_Usuarios
            // 
            this.Btn_Usuarios.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Usuarios.Image = global::IOGlobalView1.Properties.Resources.employees;
            this.Btn_Usuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Usuarios.Name = "Btn_Usuarios";
            this.Btn_Usuarios.Size = new System.Drawing.Size(236, 38);
            this.Btn_Usuarios.Text = "Usuarios";
            this.Btn_Usuarios.Click += new System.EventHandler(this.Btn_Usuarios_Click);
            // 
            // Separador2
            // 
            this.Separador2.ForeColor = System.Drawing.Color.Black;
            this.Separador2.Name = "Separador2";
            this.Separador2.Size = new System.Drawing.Size(207, 6);
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
            this.AtencionAlCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Cliente
            // 
            this.Btn_Cliente.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cliente.Image = global::IOGlobalView1.Properties.Resources.clientes;
            this.Btn_Cliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Cliente.Name = "Btn_Cliente";
            this.Btn_Cliente.Size = new System.Drawing.Size(185, 38);
            this.Btn_Cliente.Text = "Clientes";
            this.Btn_Cliente.Click += new System.EventHandler(this.Btn_Cliente_Click);
            // 
            // Btn_Mascotas
            // 
            this.Btn_Mascotas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_HistorialMedico,
            this.Btn_Especie,
            this.Btn_Raza});
            this.Btn_Mascotas.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Mascotas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Mascotas.Image")));
            this.Btn_Mascotas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Mascotas.Name = "Btn_Mascotas";
            this.Btn_Mascotas.Size = new System.Drawing.Size(185, 38);
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
            // Btn_Especie
            // 
            this.Btn_Especie.Image = global::IOGlobalView1.Properties.Resources.Especies_y_razas_32x32;
            this.Btn_Especie.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Especie.Name = "Btn_Especie";
            this.Btn_Especie.Size = new System.Drawing.Size(242, 38);
            this.Btn_Especie.Text = "Especie";
            this.Btn_Especie.Click += new System.EventHandler(this.Btn_Especie_Click);
            // 
            // Btn_Raza
            // 
            this.Btn_Raza.Image = global::IOGlobalView1.Properties.Resources.pacientess;
            this.Btn_Raza.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Raza.Name = "Btn_Raza";
            this.Btn_Raza.Size = new System.Drawing.Size(242, 38);
            this.Btn_Raza.Text = "Raza";
            this.Btn_Raza.Click += new System.EventHandler(this.Btn_Raza_Click);
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
            this.Btn_Servicios,
            this.Btn_CitaServicios});
            this.ServiciosYCitas.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiciosYCitas.Image = ((System.Drawing.Image)(resources.GetObject("ServiciosYCitas.Image")));
            this.ServiciosYCitas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ServiciosYCitas.Name = "ServiciosYCitas";
            this.ServiciosYCitas.Size = new System.Drawing.Size(207, 30);
            this.ServiciosYCitas.Text = "Servicios y citas";
            this.ServiciosYCitas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Citas
            // 
            this.Btn_Citas.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Citas.Image = global::IOGlobalView1.Properties.Resources.appointment_5559786;
            this.Btn_Citas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Citas.Name = "Btn_Citas";
            this.Btn_Citas.Size = new System.Drawing.Size(215, 38);
            this.Btn_Citas.Text = "Citas";
            this.Btn_Citas.Click += new System.EventHandler(this.Btn_Citas_Click);
            // 
            // Btn_Servicios
            // 
            this.Btn_Servicios.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Servicios.Image = global::IOGlobalView1.Properties.Resources.package_2764511;
            this.Btn_Servicios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Servicios.Name = "Btn_Servicios";
            this.Btn_Servicios.Size = new System.Drawing.Size(215, 38);
            this.Btn_Servicios.Text = "Servicios";
            this.Btn_Servicios.Click += new System.EventHandler(this.Btn_Servicios_Click);
            // 
            // Btn_CitaServicios
            // 
            this.Btn_CitaServicios.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CitaServicios.Image = global::IOGlobalView1.Properties.Resources.electronic_healthcare_17789179;
            this.Btn_CitaServicios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_CitaServicios.Name = "Btn_CitaServicios";
            this.Btn_CitaServicios.Size = new System.Drawing.Size(215, 38);
            this.Btn_CitaServicios.Text = "Cita servicios";
            this.Btn_CitaServicios.Click += new System.EventHandler(this.Btn_CitaServicios_Click);
            // 
            // Separador4
            // 
            this.Separador4.Name = "Separador4";
            this.Separador4.Size = new System.Drawing.Size(207, 6);
            // 
            // Inventario
            // 
            this.Inventario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Inventario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_CategoriaProd,
            this.Btn_Productos,
            this.Btn_Inventario});
            this.Inventario.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Inventario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Inventario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Inventario.Name = "Inventario";
            this.Inventario.Size = new System.Drawing.Size(207, 30);
            this.Inventario.Text = "Inventario";
            this.Inventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_CategoriaProd
            // 
            this.Btn_CategoriaProd.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CategoriaProd.Image = global::IOGlobalView1.Properties.Resources.product_merchandising_4857240;
            this.Btn_CategoriaProd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_CategoriaProd.Name = "Btn_CategoriaProd";
            this.Btn_CategoriaProd.Size = new System.Drawing.Size(282, 38);
            this.Btn_CategoriaProd.Text = "Categorías productos";
            this.Btn_CategoriaProd.Click += new System.EventHandler(this.Btn_CategoriaProd_Click);
            // 
            // Btn_Productos
            // 
            this.Btn_Productos.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Productos.Image = global::IOGlobalView1.Properties.Resources.pet_food_6170767;
            this.Btn_Productos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Productos.Name = "Btn_Productos";
            this.Btn_Productos.Size = new System.Drawing.Size(282, 38);
            this.Btn_Productos.Text = "Productos";
            this.Btn_Productos.Click += new System.EventHandler(this.Btn_Productos_Click);
            // 
            // Btn_Inventario
            // 
            this.Btn_Inventario.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Inventario.Image = global::IOGlobalView1.Properties.Resources.product_range_3897014;
            this.Btn_Inventario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Inventario.Name = "Btn_Inventario";
            this.Btn_Inventario.Size = new System.Drawing.Size(282, 38);
            this.Btn_Inventario.Text = "Inventario";
            this.Btn_Inventario.Click += new System.EventHandler(this.Btn_Inventario_Click);
            // 
            // Separador5
            // 
            this.Separador5.Name = "Separador5";
            this.Separador5.Size = new System.Drawing.Size(207, 6);
            // 
            // Compras
            // 
            this.Compras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Compras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_Proveedores,
            this.Btn_Compras});
            this.Compras.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Compras.Image = ((System.Drawing.Image)(resources.GetObject("Compras.Image")));
            this.Compras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Compras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Compras.Name = "Compras";
            this.Compras.Size = new System.Drawing.Size(207, 29);
            this.Compras.Text = "Compras";
            this.Compras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Proveedores
            // 
            this.Btn_Proveedores.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Proveedores.Image = global::IOGlobalView1.Properties.Resources.organization_3235799;
            this.Btn_Proveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Proveedores.Name = "Btn_Proveedores";
            this.Btn_Proveedores.Size = new System.Drawing.Size(210, 38);
            this.Btn_Proveedores.Text = "Proveedores";
            this.Btn_Proveedores.Click += new System.EventHandler(this.Btn_Proveedores_Click);
            // 
            // Btn_Compras
            // 
            this.Btn_Compras.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Compras.Image = global::IOGlobalView1.Properties.Resources.shopping_basket;
            this.Btn_Compras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Compras.Name = "Btn_Compras";
            this.Btn_Compras.Size = new System.Drawing.Size(210, 38);
            this.Btn_Compras.Text = "Compras";
            this.Btn_Compras.Click += new System.EventHandler(this.Btn_Compras_Click);
            // 
            // Separador6
            // 
            this.Separador6.Name = "Separador6";
            this.Separador6.Size = new System.Drawing.Size(207, 6);
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
            this.VentaProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VentaProductos.Click += new System.EventHandler(this.VentaProductos_Click);
            // 
            // Separador7
            // 
            this.Separador7.Name = "Separador7";
            this.Separador7.Size = new System.Drawing.Size(207, 6);
            // 
            // Devoluciones
            // 
            this.Devoluciones.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Devoluciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_DevolucionCompra,
            this.Btn_DevolucionVenta,
            this.Btn_CierreCaja});
            this.Devoluciones.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Devoluciones.Image = ((System.Drawing.Image)(resources.GetObject("Devoluciones.Image")));
            this.Devoluciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Devoluciones.Name = "Devoluciones";
            this.Devoluciones.Size = new System.Drawing.Size(207, 30);
            this.Devoluciones.Text = "Devoluciones";
            this.Devoluciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_DevolucionCompra
            // 
            this.Btn_DevolucionCompra.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DevolucionCompra.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_DevolucionCompra.Name = "Btn_DevolucionCompra";
            this.Btn_DevolucionCompra.Size = new System.Drawing.Size(256, 28);
            this.Btn_DevolucionCompra.Text = "Devolución compra";
            this.Btn_DevolucionCompra.Click += new System.EventHandler(this.Btn_DevolucionCompra_Click);
            // 
            // Btn_DevolucionVenta
            // 
            this.Btn_DevolucionVenta.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DevolucionVenta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_DevolucionVenta.Name = "Btn_DevolucionVenta";
            this.Btn_DevolucionVenta.Size = new System.Drawing.Size(256, 28);
            this.Btn_DevolucionVenta.Text = "Devolución venta";
            this.Btn_DevolucionVenta.Click += new System.EventHandler(this.Btn_DevolucionVenta_Click);
            // 
            // Btn_CierreCaja
            // 
            this.Btn_CierreCaja.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CierreCaja.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_CierreCaja.Name = "Btn_CierreCaja";
            this.Btn_CierreCaja.Size = new System.Drawing.Size(256, 28);
            this.Btn_CierreCaja.Text = "Cierre de caja";
            this.Btn_CierreCaja.Click += new System.EventHandler(this.Btn_CierreCaja_Click);
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
            this.tableLayoutPanel1.TabIndex = 13;
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
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 748);
            this.Controls.Add(this.Pnl_escritorio);
            this.Controls.Add(this.Ts_Menu);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
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
        private System.Windows.Forms.ToolStripSplitButton Administracion;
        private System.Windows.Forms.ToolStripMenuItem Btn_Empleado;
        private System.Windows.Forms.ToolStripMenuItem Btn_CargoEmpleado;
        private System.Windows.Forms.ToolStripMenuItem Btn_Usuarios;
        private System.Windows.Forms.ToolStripSeparator Separador2;
        private System.Windows.Forms.ToolStripSplitButton AtencionAlCliente;
        private System.Windows.Forms.ToolStripMenuItem Btn_Cliente;
        private System.Windows.Forms.ToolStripMenuItem Btn_Mascotas;
        private System.Windows.Forms.ToolStripMenuItem Btn_HistorialMedico;
        private System.Windows.Forms.ToolStripMenuItem Btn_Especie;
        private System.Windows.Forms.ToolStripMenuItem Btn_Raza;
        private System.Windows.Forms.ToolStripSeparator Separador3;
        private System.Windows.Forms.ToolStripSplitButton ServiciosYCitas;
        private System.Windows.Forms.ToolStripMenuItem Btn_Citas;
        private System.Windows.Forms.ToolStripMenuItem Btn_Servicios;
        private System.Windows.Forms.ToolStripMenuItem Btn_CitaServicios;
        private System.Windows.Forms.ToolStripSeparator Separador4;
        private System.Windows.Forms.ToolStripSplitButton Inventario;
        private System.Windows.Forms.ToolStripMenuItem Btn_CategoriaProd;
        private System.Windows.Forms.ToolStripMenuItem Btn_Productos;
        private System.Windows.Forms.ToolStripMenuItem Btn_Inventario;
        private System.Windows.Forms.ToolStripSeparator Separador5;
        private System.Windows.Forms.ToolStripSplitButton Compras;
        private System.Windows.Forms.ToolStripMenuItem Btn_Proveedores;
        private System.Windows.Forms.ToolStripMenuItem Btn_Compras;
        private System.Windows.Forms.ToolStripSeparator Separador6;
        private System.Windows.Forms.ToolStripButton VentaProductos;
        private System.Windows.Forms.ToolStripSeparator Separador7;
        private System.Windows.Forms.ToolStripSplitButton Devoluciones;
        private System.Windows.Forms.ToolStripMenuItem Btn_DevolucionCompra;
        private System.Windows.Forms.ToolStripMenuItem Btn_DevolucionVenta;
        private System.Windows.Forms.ToolStripMenuItem Btn_CierreCaja;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
    }
}
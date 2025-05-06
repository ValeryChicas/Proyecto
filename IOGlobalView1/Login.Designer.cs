namespace IOGlobalView1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Pb_Mayus = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_MostrarContrasena = new System.Windows.Forms.CheckBox();
            this.Btn_Inicio = new System.Windows.Forms.Button();
            this.Txt_Contrasena = new System.Windows.Forms.TextBox();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Mayus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pb_Mayus
            // 
            this.Pb_Mayus.BackColor = System.Drawing.Color.White;
            this.Pb_Mayus.Location = new System.Drawing.Point(369, 385);
            this.Pb_Mayus.Name = "Pb_Mayus";
            this.Pb_Mayus.Size = new System.Drawing.Size(30, 30);
            this.Pb_Mayus.TabIndex = 28;
            this.Pb_Mayus.TabStop = false;
            this.Pb_Mayus.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(155, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 27);
            this.label4.TabIndex = 27;
            this.label4.Text = "Inicio de sesion";
            // 
            // Btn_MostrarContrasena
            // 
            this.Btn_MostrarContrasena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_MostrarContrasena.AutoSize = true;
            this.Btn_MostrarContrasena.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_MostrarContrasena.Location = new System.Drawing.Point(236, 425);
            this.Btn_MostrarContrasena.Name = "Btn_MostrarContrasena";
            this.Btn_MostrarContrasena.Size = new System.Drawing.Size(152, 23);
            this.Btn_MostrarContrasena.TabIndex = 26;
            this.Btn_MostrarContrasena.Text = "Mostrar contraseña";
            this.Btn_MostrarContrasena.UseVisualStyleBackColor = true;
            this.Btn_MostrarContrasena.CheckedChanged += new System.EventHandler(this.Btn_MostrarContrasena_CheckedChanged);
            // 
            // Btn_Inicio
            // 
            this.Btn_Inicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Inicio.AutoEllipsis = true;
            this.Btn_Inicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Inicio.Location = new System.Drawing.Point(179, 465);
            this.Btn_Inicio.Name = "Btn_Inicio";
            this.Btn_Inicio.Size = new System.Drawing.Size(130, 39);
            this.Btn_Inicio.TabIndex = 25;
            this.Btn_Inicio.Text = "Ingresar";
            this.Btn_Inicio.UseVisualStyleBackColor = true;
            this.Btn_Inicio.Click += new System.EventHandler(this.Btn_Inicio_Click);
            // 
            // Txt_Contrasena
            // 
            this.Txt_Contrasena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt_Contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Txt_Contrasena.Location = new System.Drawing.Point(105, 385);
            this.Txt_Contrasena.Name = "Txt_Contrasena";
            this.Txt_Contrasena.Size = new System.Drawing.Size(294, 30);
            this.Txt_Contrasena.TabIndex = 24;
            this.Txt_Contrasena.UseSystemPasswordChar = true;
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Txt_Usuario.Location = new System.Drawing.Point(104, 299);
            this.Txt_Usuario.Multiline = true;
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(295, 32);
            this.Txt_Usuario.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 27);
            this.label2.TabIndex = 22;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 27);
            this.label1.TabIndex = 21;
            this.label1.Text = "Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::IOGlobalView1.Properties.Resources.Login;
            this.pictureBox1.Location = new System.Drawing.Point(105, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(502, 558);
            this.Controls.Add(this.Pb_Mayus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_MostrarContrasena);
            this.Controls.Add(this.Btn_Inicio);
            this.Controls.Add(this.Txt_Contrasena);
            this.Controls.Add(this.Txt_Usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Mayus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pb_Mayus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox Btn_MostrarContrasena;
        private System.Windows.Forms.Button Btn_Inicio;
        private System.Windows.Forms.TextBox Txt_Contrasena;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
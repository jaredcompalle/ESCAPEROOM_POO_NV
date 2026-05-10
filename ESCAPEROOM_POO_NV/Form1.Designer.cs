namespace ESCAPEROOM_POO_NV
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnJugar = new System.Windows.Forms.Button();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTituloJuego = new System.Windows.Forms.Label();
            this.pnlDialogo = new System.Windows.Forms.Panel();
            this.lblDialogo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pxbOsaka = new ESCAPEROOM_POO_NV.PixelBox();
            this.pnlDialogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxbOsaka)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJugar
            // 
            this.btnJugar.AutoSize = true;
            this.btnJugar.BackColor = System.Drawing.Color.Transparent;
            this.btnJugar.FlatAppearance.BorderSize = 0;
            this.btnJugar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnJugar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugar.Font = new System.Drawing.Font("Dogica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnJugar.Location = new System.Drawing.Point(259, 378);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(250, 44);
            this.btnJugar.TabIndex = 0;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = false;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            this.btnJugar.Enter += new System.EventHandler(this.btnJugar_Enter);
            this.btnJugar.Leave += new System.EventHandler(this.btnJugar_Leave);
            this.btnJugar.MouseEnter += new System.EventHandler(this.btnJugar_MouseEnter);
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.AutoSize = true;
            this.btnConfiguracion.BackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnConfiguracion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnConfiguracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.Font = new System.Drawing.Font("Dogica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfiguracion.Location = new System.Drawing.Point(504, 378);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(250, 44);
            this.btnConfiguracion.TabIndex = 1;
            this.btnConfiguracion.Text = "Configuracion";
            this.btnConfiguracion.UseVisualStyleBackColor = false;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            this.btnConfiguracion.Enter += new System.EventHandler(this.btnConfiguracion_Enter);
            this.btnConfiguracion.Leave += new System.EventHandler(this.btnConfiguracion_Leave);
            this.btnConfiguracion.MouseEnter += new System.EventHandler(this.btnConfiguracion_MouseEnter);
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Dogica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(12, 378);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(250, 44);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.Enter += new System.EventHandler(this.btnSalir_Enter);
            this.btnSalir.Leave += new System.EventHandler(this.btnSalir_Leave);
            this.btnSalir.MouseEnter += new System.EventHandler(this.btnSalir_MouseEnter);
            // 
            // lblTituloJuego
            // 
            this.lblTituloJuego.AutoSize = true;
            this.lblTituloJuego.Font = new System.Drawing.Font("Dogica", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloJuego.ForeColor = System.Drawing.Color.White;
            this.lblTituloJuego.Location = new System.Drawing.Point(113, 33);
            this.lblTituloJuego.Name = "lblTituloJuego";
            this.lblTituloJuego.Size = new System.Drawing.Size(544, 27);
            this.lblTituloJuego.TabIndex = 3;
            this.lblTituloJuego.Text = "ESCAPE ROOM DIGITAL";
            // 
            // pnlDialogo
            // 
            this.pnlDialogo.Controls.Add(this.lblDialogo);
            this.pnlDialogo.Location = new System.Drawing.Point(186, 322);
            this.pnlDialogo.Name = "pnlDialogo";
            this.pnlDialogo.Size = new System.Drawing.Size(382, 139);
            this.pnlDialogo.TabIndex = 5;
            this.pnlDialogo.Visible = false;
            this.pnlDialogo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDialogo_Paint);
            // 
            // lblDialogo
            // 
            this.lblDialogo.Enabled = false;
            this.lblDialogo.Font = new System.Drawing.Font("Dogica Pixel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDialogo.ForeColor = System.Drawing.Color.White;
            this.lblDialogo.Location = new System.Drawing.Point(18, 22);
            this.lblDialogo.Name = "lblDialogo";
            this.lblDialogo.Size = new System.Drawing.Size(344, 67);
            this.lblDialogo.TabIndex = 0;
            this.lblDialogo.Text = "label1";
            this.lblDialogo.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pxbOsaka
            // 
            this.pxbOsaka.Image = global::ESCAPEROOM_POO_NV.Properties.Resources.oSAKASMILE;
            this.pxbOsaka.Location = new System.Drawing.Point(238, 63);
            this.pxbOsaka.Name = "pxbOsaka";
            this.pxbOsaka.Size = new System.Drawing.Size(289, 253);
            this.pxbOsaka.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxbOsaka.TabIndex = 4;
            this.pxbOsaka.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(768, 473);
            this.Controls.Add(this.pxbOsaka);
            this.Controls.Add(this.lblTituloJuego);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConfiguracion);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.pnlDialogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.pnlDialogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pxbOsaka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblTituloJuego;
        private PixelBox pxbOsaka;
        private System.Windows.Forms.Panel pnlDialogo;
        private System.Windows.Forms.Label lblDialogo;
        private System.Windows.Forms.Timer timer1;
    }
}


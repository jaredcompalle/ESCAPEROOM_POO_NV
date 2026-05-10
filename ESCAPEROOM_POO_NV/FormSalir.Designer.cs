namespace ESCAPEROOM_POO_NV
{
    partial class FormSalir
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSiSalir = new System.Windows.Forms.Button();
            this.btnNoSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dogica", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Desea salir del juego?";
            // 
            // btnSiSalir
            // 
            this.btnSiSalir.AutoSize = true;
            this.btnSiSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSiSalir.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSiSalir.FlatAppearance.BorderSize = 0;
            this.btnSiSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnSiSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSiSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiSalir.Font = new System.Drawing.Font("Dogica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSiSalir.Location = new System.Drawing.Point(41, 133);
            this.btnSiSalir.Name = "btnSiSalir";
            this.btnSiSalir.Size = new System.Drawing.Size(122, 31);
            this.btnSiSalir.TabIndex = 5;
            this.btnSiSalir.Text = "Si";
            this.btnSiSalir.UseVisualStyleBackColor = false;
            this.btnSiSalir.Enter += new System.EventHandler(this.btnSiSalir_Enter);
            this.btnSiSalir.Leave += new System.EventHandler(this.btnSiSalir_Leave);
            this.btnSiSalir.MouseEnter += new System.EventHandler(this.btnSiSalir_MouseEnter);
            // 
            // btnNoSalir
            // 
            this.btnNoSalir.AutoSize = true;
            this.btnNoSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnNoSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNoSalir.FlatAppearance.BorderSize = 0;
            this.btnNoSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnNoSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnNoSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoSalir.Font = new System.Drawing.Font("Dogica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNoSalir.Location = new System.Drawing.Point(242, 133);
            this.btnNoSalir.Name = "btnNoSalir";
            this.btnNoSalir.Size = new System.Drawing.Size(122, 31);
            this.btnNoSalir.TabIndex = 6;
            this.btnNoSalir.Text = "No";
            this.btnNoSalir.UseVisualStyleBackColor = false;
            this.btnNoSalir.Enter += new System.EventHandler(this.btnNoSalir_Enter);
            this.btnNoSalir.Leave += new System.EventHandler(this.btnNoSalir_Leave);
            this.btnNoSalir.MouseEnter += new System.EventHandler(this.btnNoSalir_MouseEnter);
            // 
            // FormSalir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(433, 219);
            this.Controls.Add(this.btnNoSalir);
            this.Controls.Add(this.btnSiSalir);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormSalir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormSalir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSiSalir;
        private System.Windows.Forms.Button btnNoSalir;
    }
}
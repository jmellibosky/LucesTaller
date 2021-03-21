namespace Rawrawrawr
{
    partial class frmContenedor
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
            this.btnDepto = new System.Windows.Forms.Button();
            this.btnTaller = new System.Windows.Forms.Button();
            this.btnCasa = new System.Windows.Forms.Button();
            this.pnlMapa = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnDepto
            // 
            this.btnDepto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDepto.Location = new System.Drawing.Point(12, 12);
            this.btnDepto.Name = "btnDepto";
            this.btnDepto.Size = new System.Drawing.Size(246, 23);
            this.btnDepto.TabIndex = 0;
            this.btnDepto.Text = "Depto";
            this.btnDepto.UseVisualStyleBackColor = true;
            this.btnDepto.Click += new System.EventHandler(this.btnDepto_Click);
            // 
            // btnTaller
            // 
            this.btnTaller.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaller.Location = new System.Drawing.Point(264, 12);
            this.btnTaller.Name = "btnTaller";
            this.btnTaller.Size = new System.Drawing.Size(274, 23);
            this.btnTaller.TabIndex = 1;
            this.btnTaller.Text = "Taller";
            this.btnTaller.UseVisualStyleBackColor = true;
            this.btnTaller.Click += new System.EventHandler(this.btnTaller_Click);
            // 
            // btnCasa
            // 
            this.btnCasa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCasa.Enabled = false;
            this.btnCasa.Location = new System.Drawing.Point(544, 12);
            this.btnCasa.Name = "btnCasa";
            this.btnCasa.Size = new System.Drawing.Size(270, 23);
            this.btnCasa.TabIndex = 2;
            this.btnCasa.Text = "Casa";
            this.btnCasa.UseVisualStyleBackColor = true;
            this.btnCasa.Click += new System.EventHandler(this.btnCasa_Click);
            // 
            // pnlMapa
            // 
            this.pnlMapa.Location = new System.Drawing.Point(12, 41);
            this.pnlMapa.Name = "pnlMapa";
            this.pnlMapa.Size = new System.Drawing.Size(800, 450);
            this.pnlMapa.TabIndex = 3;
            // 
            // frmContenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 502);
            this.Controls.Add(this.pnlMapa);
            this.Controls.Add(this.btnCasa);
            this.Controls.Add(this.btnTaller);
            this.Controls.Add(this.btnDepto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmContenedor";
            this.Text = "Rawrawrawr";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDepto;
        private System.Windows.Forms.Button btnTaller;
        private System.Windows.Forms.Button btnCasa;
        private System.Windows.Forms.Panel pnlMapa;
    }
}


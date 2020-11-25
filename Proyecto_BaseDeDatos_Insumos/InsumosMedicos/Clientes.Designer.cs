namespace InsumosMedicos
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.Vendedores_btn = new System.Windows.Forms.Button();
            this.Ariticulos_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Vendedores_btn
            // 
            this.Vendedores_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vendedores_btn.Location = new System.Drawing.Point(74, 53);
            this.Vendedores_btn.Name = "Vendedores_btn";
            this.Vendedores_btn.Size = new System.Drawing.Size(193, 85);
            this.Vendedores_btn.TabIndex = 0;
            this.Vendedores_btn.Text = "Mostrar Vendedores";
            this.Vendedores_btn.UseVisualStyleBackColor = true;
            this.Vendedores_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ariticulos_btn
            // 
            this.Ariticulos_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ariticulos_btn.Location = new System.Drawing.Point(74, 169);
            this.Ariticulos_btn.Name = "Ariticulos_btn";
            this.Ariticulos_btn.Size = new System.Drawing.Size(193, 85);
            this.Ariticulos_btn.TabIndex = 1;
            this.Ariticulos_btn.Text = "Mostrar Artículos";
            this.Ariticulos_btn.UseVisualStyleBackColor = true;
            this.Ariticulos_btn.Click += new System.EventHandler(this.Ariticulos_btn_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 288);
            this.Controls.Add(this.Ariticulos_btn);
            this.Controls.Add(this.Vendedores_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Clientes";
            this.Text = "Insumos Mexico";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Vendedores_btn;
        private System.Windows.Forms.Button Ariticulos_btn;
    }
}
namespace InsumosMedicos
{
    partial class LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Regist_clic = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.user_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.psw_txt = new System.Windows.Forms.TextBox();
            this.check_psw = new System.Windows.Forms.CheckBox();
            this.check_cliente = new System.Windows.Forms.CheckBox();
            this.check_Vendedor = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENIDO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(333, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Iniciar Sesión";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(269, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "¿Aún no está registrado?";
            // 
            // Regist_clic
            // 
            this.Regist_clic.AutoSize = true;
            this.Regist_clic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regist_clic.Location = new System.Drawing.Point(467, 460);
            this.Regist_clic.Name = "Regist_clic";
            this.Regist_clic.Size = new System.Drawing.Size(118, 16);
            this.Regist_clic.TabIndex = 15;
            this.Regist_clic.TabStop = true;
            this.Regist_clic.Text = "Regístrese aquí";
            this.Regist_clic.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Regist_clic_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(378, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 34);
            this.label2.TabIndex = 16;
            this.label2.Text = "USUARIO";
            // 
            // user_txt
            // 
            this.user_txt.Location = new System.Drawing.Point(333, 182);
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(217, 20);
            this.user_txt.TabIndex = 17;
            this.user_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.user_txt.TextChanged += new System.EventHandler(this.user_txt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(346, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 34);
            this.label4.TabIndex = 18;
            this.label4.Text = "CONTRASEÑA";
            // 
            // psw_txt
            // 
            this.psw_txt.Location = new System.Drawing.Point(336, 256);
            this.psw_txt.Name = "psw_txt";
            this.psw_txt.Size = new System.Drawing.Size(217, 20);
            this.psw_txt.TabIndex = 19;
            this.psw_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.psw_txt.UseSystemPasswordChar = true;
            this.psw_txt.TextChanged += new System.EventHandler(this.psw_txt_TextChanged);
            // 
            // check_psw
            // 
            this.check_psw.AutoSize = true;
            this.check_psw.Location = new System.Drawing.Point(384, 282);
            this.check_psw.Name = "check_psw";
            this.check_psw.Size = new System.Drawing.Size(117, 17);
            this.check_psw.TabIndex = 20;
            this.check_psw.Text = "Mostrar contraseña";
            this.check_psw.UseVisualStyleBackColor = true;
            this.check_psw.CheckedChanged += new System.EventHandler(this.check_psw_CheckedChanged);
            // 
            // check_cliente
            // 
            this.check_cliente.AutoSize = true;
            this.check_cliente.Location = new System.Drawing.Point(352, 359);
            this.check_cliente.Name = "check_cliente";
            this.check_cliente.Size = new System.Drawing.Size(58, 17);
            this.check_cliente.TabIndex = 21;
            this.check_cliente.Text = "Cliente";
            this.check_cliente.UseVisualStyleBackColor = true;
            this.check_cliente.CheckedChanged += new System.EventHandler(this.check_cliente_CheckedChanged);
            // 
            // check_Vendedor
            // 
            this.check_Vendedor.AutoSize = true;
            this.check_Vendedor.Location = new System.Drawing.Point(469, 359);
            this.check_Vendedor.Name = "check_Vendedor";
            this.check_Vendedor.Size = new System.Drawing.Size(72, 17);
            this.check_Vendedor.TabIndex = 22;
            this.check_Vendedor.Text = "Vendedor";
            this.check_Vendedor.UseVisualStyleBackColor = true;
            this.check_Vendedor.CheckedChanged += new System.EventHandler(this.check_Vendedor_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(281, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(317, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Seleccione su tipo de cuenta";
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 495);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.check_Vendedor);
            this.Controls.Add(this.check_cliente);
            this.Controls.Add(this.check_psw);
            this.Controls.Add(this.psw_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.user_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Regist_clic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LOGIN";
            this.Text = "Insumos Mexico (Inicio sesión)";
            this.Load += new System.EventHandler(this.LOGIN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel Regist_clic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox user_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox psw_txt;
        private System.Windows.Forms.CheckBox check_psw;
        private System.Windows.Forms.CheckBox check_cliente;
        private System.Windows.Forms.CheckBox check_Vendedor;
        private System.Windows.Forms.Label label5;
    }
}


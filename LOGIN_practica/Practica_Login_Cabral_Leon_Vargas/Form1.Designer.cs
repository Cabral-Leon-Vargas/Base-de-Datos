namespace Practica_Login_Cabral_Leon_Vargas
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
            this.label3 = new System.Windows.Forms.Label();
            this.Regist_clic = new System.Windows.Forms.LinkLabel();
            this.login_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.psw_txt = new System.Windows.Forms.TextBox();
            this.user_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(221, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "¿Aún no está registrado?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Regist_clic
            // 
            this.Regist_clic.AutoSize = true;
            this.Regist_clic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regist_clic.Location = new System.Drawing.Point(462, 402);
            this.Regist_clic.Name = "Regist_clic";
            this.Regist_clic.Size = new System.Drawing.Size(118, 16);
            this.Regist_clic.TabIndex = 12;
            this.Regist_clic.TabStop = true;
            this.Regist_clic.Text = "Regístrese aquí";
            this.Regist_clic.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Regist_clic_LinkClicked);
            // 
            // login_button
            // 
            this.login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.Location = new System.Drawing.Point(299, 260);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(217, 76);
            this.login_button.TabIndex = 11;
            this.login_button.Text = "Iniciar Sesión";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 34);
            this.label2.TabIndex = 10;
            this.label2.Text = "CONTRASEÑA";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 34);
            this.label1.TabIndex = 9;
            this.label1.Text = "USUARIO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // psw_txt
            // 
            this.psw_txt.Location = new System.Drawing.Point(299, 206);
            this.psw_txt.Name = "psw_txt";
            this.psw_txt.Size = new System.Drawing.Size(217, 20);
            this.psw_txt.TabIndex = 8;
            this.psw_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.psw_txt.TextChanged += new System.EventHandler(this.psw_txt_TextChanged);
            // 
            // user_txt
            // 
            this.user_txt.Location = new System.Drawing.Point(299, 73);
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(217, 20);
            this.user_txt.TabIndex = 7;
            this.user_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.user_txt.TextChanged += new System.EventHandler(this.user_txt_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Regist_clic);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.psw_txt);
            this.Controls.Add(this.user_txt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel Regist_clic;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox psw_txt;
        private System.Windows.Forms.TextBox user_txt;
    }
}


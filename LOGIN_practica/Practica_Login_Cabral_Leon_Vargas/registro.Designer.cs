namespace Practica_Login_Cabral_Leon_Vargas
{
    partial class Form2
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
            this.crear_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.reg_psw_txt = new System.Windows.Forms.TextBox();
            this.reg_user_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // crear_btn
            // 
            this.crear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crear_btn.Location = new System.Drawing.Point(295, 315);
            this.crear_btn.Name = "crear_btn";
            this.crear_btn.Size = new System.Drawing.Size(214, 62);
            this.crear_btn.TabIndex = 11;
            this.crear_btn.Text = "Crear Usuario";
            this.crear_btn.UseVisualStyleBackColor = true;
            this.crear_btn.Click += new System.EventHandler(this.crear_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(340, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "(convinacion de numeros (0-9) y letrs (A-Z). No mayor a 16 caracteres).";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // reg_psw_txt
            // 
            this.reg_psw_txt.Location = new System.Drawing.Point(295, 263);
            this.reg_psw_txt.Name = "reg_psw_txt";
            this.reg_psw_txt.Size = new System.Drawing.Size(214, 20);
            this.reg_psw_txt.TabIndex = 9;
            this.reg_psw_txt.TextChanged += new System.EventHandler(this.reg_psw_txt_TextChanged);
            // 
            // reg_user_txt
            // 
            this.reg_user_txt.Location = new System.Drawing.Point(295, 110);
            this.reg_user_txt.Name = "reg_user_txt";
            this.reg_user_txt.Size = new System.Drawing.Size(214, 20);
            this.reg_user_txt.TabIndex = 8;
            this.reg_user_txt.TextChanged += new System.EventHandler(this.reg_user_txt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = "CONTRASEÑA";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // reg
            // 
            this.reg.AutoSize = true;
            this.reg.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg.Location = new System.Drawing.Point(332, 73);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(136, 34);
            this.reg.TabIndex = 6;
            this.reg.Text = "USUARIO";
            this.reg.Click += new System.EventHandler(this.reg_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crear_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reg_psw_txt);
            this.Controls.Add(this.reg_user_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reg);
            this.Name = "Form2";
            this.Text = "registro";
            this.Load += new System.EventHandler(this.registro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button crear_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox reg_psw_txt;
        private System.Windows.Forms.TextBox reg_user_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label reg;
    }
}
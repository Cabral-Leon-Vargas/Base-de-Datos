namespace InsumosMedicos
{
    partial class Registro
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
            this.CrearCliente_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.reg_psw_txt = new System.Windows.Forms.TextBox();
            this.reg_user_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reg = new System.Windows.Forms.Label();
            this.reg_name_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reg_ape_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.reg_cell_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.reg_direc_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.reg_hosp_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CrearVendedor_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CrearCliente_btn
            // 
            this.CrearCliente_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrearCliente_btn.Location = new System.Drawing.Point(50, 438);
            this.CrearCliente_btn.Name = "CrearCliente_btn";
            this.CrearCliente_btn.Size = new System.Drawing.Size(327, 45);
            this.CrearCliente_btn.TabIndex = 17;
            this.CrearCliente_btn.Text = "Crear Usuario Como Cliente";
            this.CrearCliente_btn.UseVisualStyleBackColor = true;
            this.CrearCliente_btn.Click += new System.EventHandler(this.crear_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(557, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "(convinacion de numeros (0-9) y letrs (A-Z). No mayor a 16 caracteres).";
            // 
            // reg_psw_txt
            // 
            this.reg_psw_txt.Location = new System.Drawing.Point(608, 125);
            this.reg_psw_txt.Name = "reg_psw_txt";
            this.reg_psw_txt.Size = new System.Drawing.Size(214, 20);
            this.reg_psw_txt.TabIndex = 15;
            this.reg_psw_txt.TextChanged += new System.EventHandler(this.reg_psw_txt_TextChanged);
            // 
            // reg_user_txt
            // 
            this.reg_user_txt.Location = new System.Drawing.Point(338, 125);
            this.reg_user_txt.Name = "reg_user_txt";
            this.reg_user_txt.Size = new System.Drawing.Size(214, 20);
            this.reg_user_txt.TabIndex = 14;
            this.reg_user_txt.TextChanged += new System.EventHandler(this.reg_user_txt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(617, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 34);
            this.label2.TabIndex = 13;
            this.label2.Text = "CONTRASEÑA";
            // 
            // reg
            // 
            this.reg.AutoSize = true;
            this.reg.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg.Location = new System.Drawing.Point(375, 88);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(136, 34);
            this.reg.TabIndex = 12;
            this.reg.Text = "USUARIO";
            // 
            // reg_name_txt
            // 
            this.reg_name_txt.Location = new System.Drawing.Point(34, 241);
            this.reg_name_txt.Name = "reg_name_txt";
            this.reg_name_txt.Size = new System.Drawing.Size(214, 20);
            this.reg_name_txt.TabIndex = 19;
            this.reg_name_txt.TextChanged += new System.EventHandler(this.reg_name_txt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre";
            // 
            // reg_ape_txt
            // 
            this.reg_ape_txt.Location = new System.Drawing.Point(346, 241);
            this.reg_ape_txt.Name = "reg_ape_txt";
            this.reg_ape_txt.Size = new System.Drawing.Size(214, 20);
            this.reg_ape_txt.TabIndex = 21;
            this.reg_ape_txt.TextChanged += new System.EventHandler(this.reg_ape_txt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(383, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 31);
            this.label4.TabIndex = 20;
            this.label4.Text = "Apellido";
            // 
            // reg_cell_txt
            // 
            this.reg_cell_txt.Location = new System.Drawing.Point(34, 353);
            this.reg_cell_txt.Name = "reg_cell_txt";
            this.reg_cell_txt.Size = new System.Drawing.Size(214, 20);
            this.reg_cell_txt.TabIndex = 23;
            this.reg_cell_txt.TextChanged += new System.EventHandler(this.reg_cell_txt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 31);
            this.label5.TabIndex = 22;
            this.label5.Text = "Numero Celular";
            // 
            // reg_direc_txt
            // 
            this.reg_direc_txt.Location = new System.Drawing.Point(608, 241);
            this.reg_direc_txt.Name = "reg_direc_txt";
            this.reg_direc_txt.Size = new System.Drawing.Size(214, 20);
            this.reg_direc_txt.TabIndex = 25;
            this.reg_direc_txt.TextChanged += new System.EventHandler(this.reg_direc_txt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(645, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 31);
            this.label6.TabIndex = 24;
            this.label6.Text = "Dirección";
            // 
            // reg_hosp_txt
            // 
            this.reg_hosp_txt.Location = new System.Drawing.Point(346, 353);
            this.reg_hosp_txt.Name = "reg_hosp_txt";
            this.reg_hosp_txt.Size = new System.Drawing.Size(214, 20);
            this.reg_hosp_txt.TabIndex = 27;
            this.reg_hosp_txt.TextChanged += new System.EventHandler(this.reg_hosp_txt_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(341, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 27);
            this.label7.TabIndex = 26;
            this.label7.Text = "Nombre Del Hospital";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(361, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 12);
            this.label8.TabIndex = 28;
            this.label8.Text = "(llenese el campo solo en caso de ser cliente).";
            // 
            // CrearVendedor_btn
            // 
            this.CrearVendedor_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrearVendedor_btn.Location = new System.Drawing.Point(452, 438);
            this.CrearVendedor_btn.Name = "CrearVendedor_btn";
            this.CrearVendedor_btn.Size = new System.Drawing.Size(354, 45);
            this.CrearVendedor_btn.TabIndex = 29;
            this.CrearVendedor_btn.Text = "Crear Usuario Como Vendedor";
            this.CrearVendedor_btn.UseVisualStyleBackColor = true;
            this.CrearVendedor_btn.Click += new System.EventHandler(this.CrearVendedor_btn_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 495);
            this.Controls.Add(this.CrearVendedor_btn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.reg_hosp_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.reg_direc_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.reg_cell_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.reg_ape_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reg_name_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CrearCliente_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reg_psw_txt);
            this.Controls.Add(this.reg_user_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reg);
            this.Name = "Registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CrearCliente_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox reg_psw_txt;
        private System.Windows.Forms.TextBox reg_user_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label reg;
        private System.Windows.Forms.TextBox reg_name_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox reg_ape_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox reg_cell_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox reg_direc_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox reg_hosp_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button CrearVendedor_btn;
    }
}
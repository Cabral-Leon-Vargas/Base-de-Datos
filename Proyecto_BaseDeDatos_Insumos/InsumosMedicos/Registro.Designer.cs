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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
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
            this.CrearUsuario_btn = new System.Windows.Forms.Button();
            this.vendedor = new System.Windows.Forms.CheckBox();
            this.cliente = new System.Windows.Forms.CheckBox();
            this.check_psw = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(293, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "(convinacion de numeros (0-9) y letrs (A-Z). No mayor a 16 caracteres).";
            // 
            // reg_psw_txt
            // 
            this.reg_psw_txt.Location = new System.Drawing.Point(338, 145);
            this.reg_psw_txt.Name = "reg_psw_txt";
            this.reg_psw_txt.Size = new System.Drawing.Size(214, 20);
            this.reg_psw_txt.TabIndex = 15;
            this.reg_psw_txt.UseSystemPasswordChar = true;
            this.reg_psw_txt.TextChanged += new System.EventHandler(this.reg_psw_txt_TextChanged);
            // 
            // reg_user_txt
            // 
            this.reg_user_txt.Location = new System.Drawing.Point(29, 146);
            this.reg_user_txt.Name = "reg_user_txt";
            this.reg_user_txt.Size = new System.Drawing.Size(214, 20);
            this.reg_user_txt.TabIndex = 14;
            this.reg_user_txt.TextChanged += new System.EventHandler(this.reg_user_txt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(352, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 34);
            this.label2.TabIndex = 13;
            this.label2.Text = "CONTRASEÑA";
            // 
            // reg
            // 
            this.reg.AutoSize = true;
            this.reg.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg.Location = new System.Drawing.Point(56, 109);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(136, 34);
            this.reg.TabIndex = 12;
            this.reg.Text = "USUARIO";
            // 
            // reg_name_txt
            // 
            this.reg_name_txt.Location = new System.Drawing.Point(29, 238);
            this.reg_name_txt.Name = "reg_name_txt";
            this.reg_name_txt.Size = new System.Drawing.Size(214, 20);
            this.reg_name_txt.TabIndex = 19;
            this.reg_name_txt.TextChanged += new System.EventHandler(this.reg_name_txt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre";
            // 
            // reg_ape_txt
            // 
            this.reg_ape_txt.Location = new System.Drawing.Point(341, 238);
            this.reg_ape_txt.Name = "reg_ape_txt";
            this.reg_ape_txt.Size = new System.Drawing.Size(214, 20);
            this.reg_ape_txt.TabIndex = 21;
            this.reg_ape_txt.TextChanged += new System.EventHandler(this.reg_ape_txt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(402, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 31);
            this.label4.TabIndex = 20;
            this.label4.Text = "Apellido";
            // 
            // reg_cell_txt
            // 
            this.reg_cell_txt.Location = new System.Drawing.Point(602, 238);
            this.reg_cell_txt.Name = "reg_cell_txt";
            this.reg_cell_txt.Size = new System.Drawing.Size(214, 20);
            this.reg_cell_txt.TabIndex = 23;
            this.reg_cell_txt.TextChanged += new System.EventHandler(this.reg_cell_txt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(611, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 31);
            this.label5.TabIndex = 22;
            this.label5.Text = "Numero Celular";
            // 
            // reg_direc_txt
            // 
            this.reg_direc_txt.Location = new System.Drawing.Point(29, 350);
            this.reg_direc_txt.Name = "reg_direc_txt";
            this.reg_direc_txt.Size = new System.Drawing.Size(214, 20);
            this.reg_direc_txt.TabIndex = 25;
            this.reg_direc_txt.TextChanged += new System.EventHandler(this.reg_direc_txt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(275, 31);
            this.label6.TabIndex = 24;
            this.label6.Text = "Zona de venta/compra";
            // 
            // reg_hosp_txt
            // 
            this.reg_hosp_txt.Location = new System.Drawing.Point(341, 350);
            this.reg_hosp_txt.Name = "reg_hosp_txt";
            this.reg_hosp_txt.Size = new System.Drawing.Size(214, 20);
            this.reg_hosp_txt.TabIndex = 27;
            this.reg_hosp_txt.TextChanged += new System.EventHandler(this.reg_hosp_txt_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(336, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 27);
            this.label7.TabIndex = 26;
            this.label7.Text = "Nombre Del Hospital";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(356, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 12);
            this.label8.TabIndex = 28;
            this.label8.Text = "(llenese el campo solo en caso de ser cliente).";
            // 
            // CrearUsuario_btn
            // 
            this.CrearUsuario_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrearUsuario_btn.Location = new System.Drawing.Point(338, 438);
            this.CrearUsuario_btn.Name = "CrearUsuario_btn";
            this.CrearUsuario_btn.Size = new System.Drawing.Size(226, 45);
            this.CrearUsuario_btn.TabIndex = 29;
            this.CrearUsuario_btn.Text = "Crear Usuario";
            this.CrearUsuario_btn.UseVisualStyleBackColor = true;
            this.CrearUsuario_btn.Click += new System.EventHandler(this.CrearVendedor_btn_Click);
            // 
            // vendedor
            // 
            this.vendedor.AutoSize = true;
            this.vendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendedor.Location = new System.Drawing.Point(338, 394);
            this.vendedor.Name = "vendedor";
            this.vendedor.Size = new System.Drawing.Size(112, 20);
            this.vendedor.TabIndex = 30;
            this.vendedor.Text = "VENDEDOR";
            this.vendedor.UseVisualStyleBackColor = true;
            this.vendedor.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cliente
            // 
            this.cliente.AutoSize = true;
            this.cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente.Location = new System.Drawing.Point(474, 394);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(90, 20);
            this.cliente.TabIndex = 31;
            this.cliente.Text = "CLIENTE";
            this.cliente.UseVisualStyleBackColor = true;
            this.cliente.CheckedChanged += new System.EventHandler(this.cliente_CheckedChanged);
            // 
            // check_psw
            // 
            this.check_psw.AutoSize = true;
            this.check_psw.Location = new System.Drawing.Point(602, 145);
            this.check_psw.Name = "check_psw";
            this.check_psw.Size = new System.Drawing.Size(117, 17);
            this.check_psw.TabIndex = 32;
            this.check_psw.Text = "Mostrar contraseña";
            this.check_psw.UseVisualStyleBackColor = true;
            this.check_psw.CheckedChanged += new System.EventHandler(this.check_psw_CheckedChanged);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 495);
            this.Controls.Add(this.check_psw);
            this.Controls.Add(this.cliente);
            this.Controls.Add(this.vendedor);
            this.Controls.Add(this.CrearUsuario_btn);
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reg_psw_txt);
            this.Controls.Add(this.reg_user_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro";
            this.Text = "Insumos Mexico (Crear cuenta)";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Button CrearUsuario_btn;
        private System.Windows.Forms.CheckBox vendedor;
        private System.Windows.Forms.CheckBox cliente;
        private System.Windows.Forms.CheckBox check_psw;
    }
}
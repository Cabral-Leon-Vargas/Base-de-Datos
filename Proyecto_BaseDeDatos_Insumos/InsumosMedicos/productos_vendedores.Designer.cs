namespace InsumosMedicos
{
    partial class productos_vendedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productos_vendedores));
            this.Clean_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Serie_txt = new System.Windows.Forms.TextBox();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Mod_btn = new System.Windows.Forms.Button();
            this.Ref_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Precio_txt = new System.Windows.Forms.TextBox();
            this.Descripcion_txt = new System.Windows.Forms.TextBox();
            this.Producto_txt = new System.Windows.Forms.TextBox();
            this.Search_btn = new System.Windows.Forms.Button();
            this.Guardar_btn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Serie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Producto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descrip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Clean_btn
            // 
            this.Clean_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clean_btn.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clean_btn.Location = new System.Drawing.Point(589, 380);
            this.Clean_btn.Name = "Clean_btn";
            this.Clean_btn.Size = new System.Drawing.Size(184, 42);
            this.Clean_btn.TabIndex = 37;
            this.Clean_btn.Text = "Limpiar campos";
            this.Clean_btn.UseVisualStyleBackColor = true;
            this.Clean_btn.Click += new System.EventHandler(this.Clean_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(626, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 21);
            this.label6.TabIndex = 36;
            this.label6.Text = "Busqueda (No. de Serie)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Serie_txt
            // 
            this.Serie_txt.Location = new System.Drawing.Point(682, 130);
            this.Serie_txt.Name = "Serie_txt";
            this.Serie_txt.Size = new System.Drawing.Size(60, 20);
            this.Serie_txt.TabIndex = 35;
            this.Serie_txt.TextChanged += new System.EventHandler(this.Serie_txt_TextChanged);
            // 
            // Delete_btn
            // 
            this.Delete_btn.BackColor = System.Drawing.Color.DarkRed;
            this.Delete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete_btn.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Delete_btn.Location = new System.Drawing.Point(645, 290);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(128, 59);
            this.Delete_btn.TabIndex = 34;
            this.Delete_btn.Text = "ELIMINAR PRODUCTO";
            this.Delete_btn.UseVisualStyleBackColor = false;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Mod_btn
            // 
            this.Mod_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Mod_btn.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mod_btn.Location = new System.Drawing.Point(645, 229);
            this.Mod_btn.Name = "Mod_btn";
            this.Mod_btn.Size = new System.Drawing.Size(128, 42);
            this.Mod_btn.TabIndex = 33;
            this.Mod_btn.Text = "Modificar";
            this.Mod_btn.UseVisualStyleBackColor = true;
            this.Mod_btn.Click += new System.EventHandler(this.Mod_btn_Click);
            // 
            // Ref_btn
            // 
            this.Ref_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ref_btn.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ref_btn.Location = new System.Drawing.Point(330, 350);
            this.Ref_btn.Name = "Ref_btn";
            this.Ref_btn.Size = new System.Drawing.Size(182, 72);
            this.Ref_btn.TabIndex = 32;
            this.Ref_btn.Text = "Refrescar";
            this.Ref_btn.UseVisualStyleBackColor = true;
            this.Ref_btn.Click += new System.EventHandler(this.Ref_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(313, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(585, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "Precio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Producto";
            // 
            // Precio_txt
            // 
            this.Precio_txt.Location = new System.Drawing.Point(542, 55);
            this.Precio_txt.Name = "Precio_txt";
            this.Precio_txt.Size = new System.Drawing.Size(153, 20);
            this.Precio_txt.TabIndex = 23;
            this.Precio_txt.TextChanged += new System.EventHandler(this.Precio_txt_TextChanged);
            // 
            // Descripcion_txt
            // 
            this.Descripcion_txt.Location = new System.Drawing.Point(170, 55);
            this.Descripcion_txt.Name = "Descripcion_txt";
            this.Descripcion_txt.Size = new System.Drawing.Size(366, 20);
            this.Descripcion_txt.TabIndex = 22;
            this.Descripcion_txt.TextChanged += new System.EventHandler(this.Descripcion_txt_TextChanged);
            // 
            // Producto_txt
            // 
            this.Producto_txt.Location = new System.Drawing.Point(13, 55);
            this.Producto_txt.Name = "Producto_txt";
            this.Producto_txt.Size = new System.Drawing.Size(141, 20);
            this.Producto_txt.TabIndex = 21;
            this.Producto_txt.TextChanged += new System.EventHandler(this.Producto_txt_TextChanged);
            // 
            // Search_btn
            // 
            this.Search_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search_btn.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_btn.Location = new System.Drawing.Point(645, 171);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(128, 42);
            this.Search_btn.TabIndex = 20;
            this.Search_btn.Text = "Buscar";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // Guardar_btn
            // 
            this.Guardar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guardar_btn.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar_btn.Location = new System.Drawing.Point(42, 350);
            this.Guardar_btn.Name = "Guardar_btn";
            this.Guardar_btn.Size = new System.Drawing.Size(182, 72);
            this.Guardar_btn.TabIndex = 19;
            this.Guardar_btn.Text = "Guardar";
            this.Guardar_btn.UseVisualStyleBackColor = true;
            this.Guardar_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Serie,
            this.Producto,
            this.Descrip,
            this.Precio});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 94);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(608, 235);
            this.listView1.TabIndex = 38;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Serie
            // 
            this.Serie.Text = "No. de Serie";
            this.Serie.Width = 97;
            // 
            // Producto
            // 
            this.Producto.Text = "Producto";
            this.Producto.Width = 174;
            // 
            // Descrip
            // 
            this.Descrip.Text = "Descripción";
            this.Descrip.Width = 272;
            // 
            // Precio
            // 
            this.Precio.Text = "Precio";
            // 
            // productos_vendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Clean_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Serie_txt);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Mod_btn);
            this.Controls.Add(this.Ref_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Precio_txt);
            this.Controls.Add(this.Descripcion_txt);
            this.Controls.Add(this.Producto_txt);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.Guardar_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "productos_vendedores";
            this.Text = "Insumos Mexico (Productos)";
            this.Load += new System.EventHandler(this.productos_vendedores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Clean_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Serie_txt;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Mod_btn;
        private System.Windows.Forms.Button Ref_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Precio_txt;
        private System.Windows.Forms.TextBox Descripcion_txt;
        private System.Windows.Forms.TextBox Producto_txt;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Button Guardar_btn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Serie;
        private System.Windows.Forms.ColumnHeader Producto;
        private System.Windows.Forms.ColumnHeader Descrip;
        private System.Windows.Forms.ColumnHeader Precio;
    }
}
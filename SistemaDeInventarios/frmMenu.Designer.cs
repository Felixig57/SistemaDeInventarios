namespace SistemaDeInventarios
{
    partial class frmMenu
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
            this.gbTitulos = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAlmacenes = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnProductos = new System.Windows.Forms.Button();
            this.gbTitulos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTitulos
            // 
            this.gbTitulos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTitulos.BackColor = System.Drawing.Color.White;
            this.gbTitulos.Controls.Add(this.label3);
            this.gbTitulos.Controls.Add(this.label2);
            this.gbTitulos.Controls.Add(this.label1);
            this.gbTitulos.Location = new System.Drawing.Point(1, 1);
            this.gbTitulos.Name = "gbTitulos";
            this.gbTitulos.Size = new System.Drawing.Size(804, 150);
            this.gbTitulos.TabIndex = 0;
            this.gbTitulos.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(138, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "de inventarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione una opcion para gestionar en el inventario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(1, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 503);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.btnAlmacenes);
            this.groupBox4.Location = new System.Drawing.Point(424, 275);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(313, 162);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // btnAlmacenes
            // 
            this.btnAlmacenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlmacenes.Image = global::SistemaDeInventarios.Properties.Resources.warehouse_3604092;
            this.btnAlmacenes.Location = new System.Drawing.Point(85, 21);
            this.btnAlmacenes.Name = "btnAlmacenes";
            this.btnAlmacenes.Size = new System.Drawing.Size(164, 123);
            this.btnAlmacenes.TabIndex = 2;
            this.btnAlmacenes.Text = "Almacenes";
            this.btnAlmacenes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlmacenes.UseVisualStyleBackColor = true;
            this.btnAlmacenes.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.btnProveedores);
            this.groupBox5.Location = new System.Drawing.Point(44, 275);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(313, 162);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // btnProveedores
            // 
            this.btnProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.Image = global::SistemaDeInventarios.Properties.Resources.proveedor;
            this.btnProveedores.Location = new System.Drawing.Point(64, 21);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(195, 123);
            this.btnProveedores.TabIndex = 3;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.btnCategorias);
            this.groupBox3.Location = new System.Drawing.Point(424, 75);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(313, 162);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // btnCategorias
            // 
            this.btnCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.Image = global::SistemaDeInventarios.Properties.Resources.menu;
            this.btnCategorias.Location = new System.Drawing.Point(85, 21);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(164, 118);
            this.btnCategorias.TabIndex = 1;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnProductos);
            this.groupBox2.Location = new System.Drawing.Point(42, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 162);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btnProductos
            // 
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Image = global::SistemaDeInventarios.Properties.Resources.bienes;
            this.btnProductos.Location = new System.Drawing.Point(64, 21);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(195, 124);
            this.btnProductos.TabIndex = 0;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(802, 683);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbTitulos);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.gbTitulos.ResumeLayout(false);
            this.gbTitulos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTitulos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAlmacenes;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnProductos;
    }
}


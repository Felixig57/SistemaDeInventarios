namespace SistemaDeInventarios
{
    partial class frmAlmacenes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtUbicacionAlmacen = new System.Windows.Forms.TextBox();
            this.txtTelefonoAlmacen = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblTituloAlmacenes = new System.Windows.Forms.Label();
            this.gbTituloC = new System.Windows.Forms.GroupBox();
            this.txtResponsableAlmacen = new System.Windows.Forms.TextBox();
            this.lblResponsableAlmacen = new System.Windows.Forms.Label();
            this.txtNombreAlmacen = new System.Windows.Forms.TextBox();
            this.lblNombreAlmacen = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtIdAlmacen = new System.Windows.Forms.TextBox();
            this.lbl_IdAlmacen = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUbicacionAlmacen = new System.Windows.Forms.Label();
            this.lblTelefonoAlmacen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAlmacenes = new System.Windows.Forms.DataGridView();
            this.IdAlmacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreAlmacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Responsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbTituloC.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmacenes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUbicacionAlmacen
            // 
            this.txtUbicacionAlmacen.Location = new System.Drawing.Point(241, 111);
            this.txtUbicacionAlmacen.Name = "txtUbicacionAlmacen";
            this.txtUbicacionAlmacen.Size = new System.Drawing.Size(225, 22);
            this.txtUbicacionAlmacen.TabIndex = 3;
            this.txtUbicacionAlmacen.TextChanged += new System.EventHandler(this.txtUbicacionAlmacen_TextChanged);
            this.txtUbicacionAlmacen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUbicacionAlmacen_KeyPress);
            // 
            // txtTelefonoAlmacen
            // 
            this.txtTelefonoAlmacen.Location = new System.Drawing.Point(241, 60);
            this.txtTelefonoAlmacen.Name = "txtTelefonoAlmacen";
            this.txtTelefonoAlmacen.Size = new System.Drawing.Size(220, 22);
            this.txtTelefonoAlmacen.TabIndex = 1;
            this.txtTelefonoAlmacen.TextChanged += new System.EventHandler(this.txtTelefonoAlmacen_TextChanged);
            this.txtTelefonoAlmacen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoAlmacen_KeyPress);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegresar.Location = new System.Drawing.Point(1020, 30);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(83, 50);
            this.btnRegresar.TabIndex = 6;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // lblTituloAlmacenes
            // 
            this.lblTituloAlmacenes.AutoSize = true;
            this.lblTituloAlmacenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAlmacenes.Location = new System.Drawing.Point(78, 34);
            this.lblTituloAlmacenes.Name = "lblTituloAlmacenes";
            this.lblTituloAlmacenes.Size = new System.Drawing.Size(164, 32);
            this.lblTituloAlmacenes.TabIndex = 5;
            this.lblTituloAlmacenes.Text = "Almacenes";
            // 
            // gbTituloC
            // 
            this.gbTituloC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTituloC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbTituloC.Controls.Add(this.btnRegresar);
            this.gbTituloC.Controls.Add(this.lblTituloAlmacenes);
            this.gbTituloC.Location = new System.Drawing.Point(6, 19);
            this.gbTituloC.Name = "gbTituloC";
            this.gbTituloC.Size = new System.Drawing.Size(1113, 100);
            this.gbTituloC.TabIndex = 9;
            this.gbTituloC.TabStop = false;
            this.gbTituloC.Text = "groupBox1";
            // 
            // txtResponsableAlmacen
            // 
            this.txtResponsableAlmacen.Location = new System.Drawing.Point(20, 171);
            this.txtResponsableAlmacen.Name = "txtResponsableAlmacen";
            this.txtResponsableAlmacen.Size = new System.Drawing.Size(441, 22);
            this.txtResponsableAlmacen.TabIndex = 4;
            this.txtResponsableAlmacen.TextChanged += new System.EventHandler(this.txtResponsableAlmacen_TextChanged);
            this.txtResponsableAlmacen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResponsableAlmacen_KeyPress);
            // 
            // lblResponsableAlmacen
            // 
            this.lblResponsableAlmacen.AutoSize = true;
            this.lblResponsableAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponsableAlmacen.Location = new System.Drawing.Point(16, 148);
            this.lblResponsableAlmacen.Name = "lblResponsableAlmacen";
            this.lblResponsableAlmacen.Size = new System.Drawing.Size(111, 20);
            this.lblResponsableAlmacen.TabIndex = 2;
            this.lblResponsableAlmacen.Text = "Responsable:";
            // 
            // txtNombreAlmacen
            // 
            this.txtNombreAlmacen.Location = new System.Drawing.Point(19, 111);
            this.txtNombreAlmacen.Name = "txtNombreAlmacen";
            this.txtNombreAlmacen.Size = new System.Drawing.Size(201, 22);
            this.txtNombreAlmacen.TabIndex = 2;
            this.txtNombreAlmacen.TextChanged += new System.EventHandler(this.txtNombreAlmacen_TextChanged);
            this.txtNombreAlmacen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreAlmacen_KeyPress);
            // 
            // lblNombreAlmacen
            // 
            this.lblNombreAlmacen.AutoSize = true;
            this.lblNombreAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAlmacen.Location = new System.Drawing.Point(16, 88);
            this.lblNombreAlmacen.Name = "lblNombreAlmacen";
            this.lblNombreAlmacen.Size = new System.Drawing.Size(143, 20);
            this.lblNombreAlmacen.TabIndex = 0;
            this.lblNombreAlmacen.Text = "Nombre Almacen:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(24, 175);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(150, 45);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(24, 124);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 45);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(24, 75);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(150, 45);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(24, 24);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(150, 45);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtIdAlmacen
            // 
            this.txtIdAlmacen.Location = new System.Drawing.Point(19, 60);
            this.txtIdAlmacen.Name = "txtIdAlmacen";
            this.txtIdAlmacen.Size = new System.Drawing.Size(201, 22);
            this.txtIdAlmacen.TabIndex = 0;
            this.txtIdAlmacen.TextChanged += new System.EventHandler(this.txtIdAlmacen_TextChanged);
            this.txtIdAlmacen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdAlmacen_KeyPress);
            // 
            // lbl_IdAlmacen
            // 
            this.lbl_IdAlmacen.AutoSize = true;
            this.lbl_IdAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdAlmacen.Location = new System.Drawing.Point(16, 37);
            this.lbl_IdAlmacen.Name = "lbl_IdAlmacen";
            this.lbl_IdAlmacen.Size = new System.Drawing.Size(102, 20);
            this.lbl_IdAlmacen.TabIndex = 5;
            this.lbl_IdAlmacen.Text = "Id Almacen: ";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.btnLimpiar);
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Controls.Add(this.btnEditar);
            this.groupBox3.Controls.Add(this.btnAgregar);
            this.groupBox3.Location = new System.Drawing.Point(472, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(196, 234);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(325, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(83, 50);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(0, 30);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(49, 16);
            this.lblBuscar.TabIndex = 5;
            this.lblBuscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Location = new System.Drawing.Point(55, 27);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(264, 22);
            this.txtBuscar.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Controls.Add(this.btnBuscar);
            this.groupBox4.Controls.Add(this.lblBuscar);
            this.groupBox4.Controls.Add(this.txtBuscar);
            this.groupBox4.Location = new System.Drawing.Point(674, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(430, 234);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txtUbicacionAlmacen);
            this.groupBox1.Controls.Add(this.txtTelefonoAlmacen);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.lblUbicacionAlmacen);
            this.groupBox1.Controls.Add(this.lblTelefonoAlmacen);
            this.groupBox1.Controls.Add(this.txtIdAlmacen);
            this.groupBox1.Controls.Add(this.lbl_IdAlmacen);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txtResponsableAlmacen);
            this.groupBox1.Controls.Add(this.lblResponsableAlmacen);
            this.groupBox1.Controls.Add(this.txtNombreAlmacen);
            this.groupBox1.Controls.Add(this.lblNombreAlmacen);
            this.groupBox1.Location = new System.Drawing.Point(15, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1104, 253);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblUbicacionAlmacen
            // 
            this.lblUbicacionAlmacen.AutoSize = true;
            this.lblUbicacionAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicacionAlmacen.Location = new System.Drawing.Point(237, 88);
            this.lblUbicacionAlmacen.Name = "lblUbicacionAlmacen";
            this.lblUbicacionAlmacen.Size = new System.Drawing.Size(88, 20);
            this.lblUbicacionAlmacen.TabIndex = 8;
            this.lblUbicacionAlmacen.Text = "Ubicacion:";
            // 
            // lblTelefonoAlmacen
            // 
            this.lblTelefonoAlmacen.AutoSize = true;
            this.lblTelefonoAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoAlmacen.Location = new System.Drawing.Point(237, 37);
            this.lblTelefonoAlmacen.Name = "lblTelefonoAlmacen";
            this.lblTelefonoAlmacen.Size = new System.Drawing.Size(78, 20);
            this.lblTelefonoAlmacen.TabIndex = 7;
            this.lblTelefonoAlmacen.Text = "Telefono:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Categorias";
            // 
            // dgvAlmacenes
            // 
            this.dgvAlmacenes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAlmacenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlmacenes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAlmacenes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlmacenes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlmacenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlmacenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAlmacen,
            this.NombreAlmacen,
            this.Responsable,
            this.Telefono,
            this.Ubicacion});
            this.dgvAlmacenes.Location = new System.Drawing.Point(20, 47);
            this.dgvAlmacenes.Name = "dgvAlmacenes";
            this.dgvAlmacenes.RowHeadersWidth = 51;
            this.dgvAlmacenes.RowTemplate.Height = 24;
            this.dgvAlmacenes.Size = new System.Drawing.Size(1078, 233);
            this.dgvAlmacenes.TabIndex = 0;
            // 
            // IdAlmacen
            // 
            this.IdAlmacen.HeaderText = "Id Almacen";
            this.IdAlmacen.MinimumWidth = 6;
            this.IdAlmacen.Name = "IdAlmacen";
            // 
            // NombreAlmacen
            // 
            this.NombreAlmacen.HeaderText = "Nombre almacen";
            this.NombreAlmacen.MinimumWidth = 6;
            this.NombreAlmacen.Name = "NombreAlmacen";
            // 
            // Responsable
            // 
            this.Responsable.HeaderText = "Responsable";
            this.Responsable.MinimumWidth = 6;
            this.Responsable.Name = "Responsable";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            // 
            // Ubicacion
            // 
            this.Ubicacion.HeaderText = "Ubicacion";
            this.Ubicacion.MinimumWidth = 6;
            this.Ubicacion.Name = "Ubicacion";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dgvAlmacenes);
            this.groupBox2.Location = new System.Drawing.Point(15, 392);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1104, 305);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // frmAlmacenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 716);
            this.Controls.Add(this.gbTituloC);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmAlmacenes";
            this.Text = "Almacenes";
            this.gbTituloC.ResumeLayout(false);
            this.gbTituloC.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmacenes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtUbicacionAlmacen;
        private System.Windows.Forms.TextBox txtTelefonoAlmacen;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblTituloAlmacenes;
        private System.Windows.Forms.GroupBox gbTituloC;
        private System.Windows.Forms.TextBox txtResponsableAlmacen;
        private System.Windows.Forms.Label lblResponsableAlmacen;
        private System.Windows.Forms.TextBox txtNombreAlmacen;
        private System.Windows.Forms.Label lblNombreAlmacen;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtIdAlmacen;
        private System.Windows.Forms.Label lbl_IdAlmacen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblUbicacionAlmacen;
        private System.Windows.Forms.Label lblTelefonoAlmacen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAlmacenes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAlmacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreAlmacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Responsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicacion;
    }
}
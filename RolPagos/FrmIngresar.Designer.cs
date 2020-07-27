namespace RolPagos
{
    partial class FrmIngresar
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
            this.txtNombre = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.Label();
            this.txtDepartamento = new System.Windows.Forms.Label();
            this.txtIngresos = new System.Windows.Forms.Label();
            this.txtEgresos = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.LinkModificar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.LinkEliminar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Location = new System.Drawing.Point(34, 76);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(111, 13);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Text = "Nombre del Empleado";
            // 
            // txtClave
            // 
            this.txtClave.AutoSize = true;
            this.txtClave.Location = new System.Drawing.Point(34, 34);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(77, 13);
            this.txtClave.TabIndex = 1;
            this.txtClave.Text = "Clave Principal";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.AutoSize = true;
            this.txtDepartamento.Location = new System.Drawing.Point(34, 119);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(74, 13);
            this.txtDepartamento.TabIndex = 2;
            this.txtDepartamento.Text = "Departamento";
            this.txtDepartamento.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtIngresos
            // 
            this.txtIngresos.AutoSize = true;
            this.txtIngresos.Location = new System.Drawing.Point(34, 162);
            this.txtIngresos.Name = "txtIngresos";
            this.txtIngresos.Size = new System.Drawing.Size(74, 13);
            this.txtIngresos.TabIndex = 3;
            this.txtIngresos.Text = "Total Ingresos";
            // 
            // txtEgresos
            // 
            this.txtEgresos.AutoSize = true;
            this.txtEgresos.Location = new System.Drawing.Point(34, 208);
            this.txtEgresos.Name = "txtEgresos";
            this.txtEgresos.Size = new System.Drawing.Size(72, 13);
            this.txtEgresos.TabIndex = 4;
            this.txtEgresos.Text = "Total Egresos";
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LinkModificar,
            this.LinkEliminar});
            this.dataGrid.Location = new System.Drawing.Point(37, 249);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(717, 189);
            this.dataGrid.TabIndex = 5;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(183, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(183, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(183, 112);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(136, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(183, 155);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(136, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(183, 201);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(136, 20);
            this.textBox5.TabIndex = 10;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(454, 34);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(454, 100);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // LinkModificar
            // 
            this.LinkModificar.HeaderText = "Accion";
            this.LinkModificar.Name = "LinkModificar";
            this.LinkModificar.Text = "Modificar";
            this.LinkModificar.UseColumnTextForLinkValue = true;
            // 
            // LinkEliminar
            // 
            this.LinkEliminar.HeaderText = "Accion";
            this.LinkEliminar.Name = "LinkEliminar";
            this.LinkEliminar.Text = "Eliminar";
            this.LinkEliminar.UseColumnTextForLinkValue = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(454, 66);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // FrmIngresar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.txtEgresos);
            this.Controls.Add(this.txtIngresos);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtNombre);
            this.Name = "FrmIngresar";
            this.Text = "TotalEgresos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Label txtClave;
        private System.Windows.Forms.Label txtDepartamento;
        private System.Windows.Forms.Label txtIngresos;
        private System.Windows.Forms.Label txtEgresos;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridViewLinkColumn LinkModificar;
        private System.Windows.Forms.DataGridViewLinkColumn LinkEliminar;
        private System.Windows.Forms.Button btnEliminar;
    }
}


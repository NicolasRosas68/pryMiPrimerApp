namespace pryMiPrimerApp
{
    partial class frmAlacena
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlacena));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.mrcCategoria = new System.Windows.Forms.GroupBox();
            this.lstCantidad = new System.Windows.Forms.ComboBox();
            this.lstTipo = new System.Windows.Forms.ComboBox();
            this.lstNombre = new System.Windows.Forms.ComboBox();
            this.lstProductos = new System.Windows.Forms.ComboBox();
            this.txtTipo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.Label();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.optCaduca = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.mrcCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // mrcCategoria
            // 
            this.mrcCategoria.Controls.Add(this.lstCantidad);
            this.mrcCategoria.Controls.Add(this.lstTipo);
            this.mrcCategoria.Controls.Add(this.lstNombre);
            this.mrcCategoria.Controls.Add(this.lstProductos);
            this.mrcCategoria.Controls.Add(this.txtTipo);
            this.mrcCategoria.Controls.Add(this.txtNombre);
            this.mrcCategoria.Controls.Add(this.txtCantidad);
            this.mrcCategoria.Controls.Add(this.txtProducto);
            this.mrcCategoria.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.mrcCategoria.Location = new System.Drawing.Point(12, 12);
            this.mrcCategoria.Name = "mrcCategoria";
            this.mrcCategoria.Size = new System.Drawing.Size(229, 219);
            this.mrcCategoria.TabIndex = 0;
            this.mrcCategoria.TabStop = false;
            this.mrcCategoria.Text = "Categorias";
            // 
            // lstCantidad
            // 
            this.lstCantidad.FormattingEnabled = true;
            this.lstCantidad.Location = new System.Drawing.Point(109, 166);
            this.lstCantidad.Name = "lstCantidad";
            this.lstCantidad.Size = new System.Drawing.Size(105, 31);
            this.lstCantidad.TabIndex = 7;
            // 
            // lstTipo
            // 
            this.lstTipo.FormattingEnabled = true;
            this.lstTipo.Location = new System.Drawing.Point(109, 76);
            this.lstTipo.Name = "lstTipo";
            this.lstTipo.Size = new System.Drawing.Size(105, 31);
            this.lstTipo.TabIndex = 6;
            // 
            // lstNombre
            // 
            this.lstNombre.FormattingEnabled = true;
            this.lstNombre.Location = new System.Drawing.Point(109, 123);
            this.lstNombre.Name = "lstNombre";
            this.lstNombre.Size = new System.Drawing.Size(105, 31);
            this.lstNombre.TabIndex = 5;
            // 
            // lstProductos
            // 
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.Location = new System.Drawing.Point(109, 36);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(105, 31);
            this.lstProductos.TabIndex = 4;
            // 
            // txtTipo
            // 
            this.txtTipo.AutoSize = true;
            this.txtTipo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.ForeColor = System.Drawing.Color.Blue;
            this.txtTipo.Location = new System.Drawing.Point(9, 81);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(45, 21);
            this.txtTipo.TabIndex = 3;
            this.txtTipo.Text = "Tipo";
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Blue;
            this.txtNombre.Location = new System.Drawing.Point(9, 123);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(71, 21);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Text = "Nombre";
            // 
            // txtCantidad
            // 
            this.txtCantidad.AutoSize = true;
            this.txtCantidad.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.Color.Blue;
            this.txtCantidad.Location = new System.Drawing.Point(9, 176);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(77, 21);
            this.txtCantidad.TabIndex = 1;
            this.txtCantidad.Text = "Cantidad";
            // 
            // txtProducto
            // 
            this.txtProducto.AutoSize = true;
            this.txtProducto.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.ForeColor = System.Drawing.Color.Blue;
            this.txtProducto.Location = new System.Drawing.Point(9, 46);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(80, 21);
            this.txtProducto.TabIndex = 0;
            this.txtProducto.Text = "Producto";
            this.txtProducto.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.BackColor = System.Drawing.Color.White;
            this.cmdGuardar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Location = new System.Drawing.Point(121, 314);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(89, 33);
            this.cmdGuardar.TabIndex = 8;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = false;
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.BackColor = System.Drawing.Color.White;
            this.cmdBorrar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBorrar.ForeColor = System.Drawing.Color.Black;
            this.cmdBorrar.Location = new System.Drawing.Point(16, 314);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(85, 33);
            this.cmdBorrar.TabIndex = 9;
            this.cmdBorrar.Text = "Borrar";
            this.cmdBorrar.UseVisualStyleBackColor = false;
            // 
            // optCaduca
            // 
            this.optCaduca.AutoSize = true;
            this.optCaduca.Location = new System.Drawing.Point(16, 252);
            this.optCaduca.Name = "optCaduca";
            this.optCaduca.Size = new System.Drawing.Size(62, 17);
            this.optCaduca.TabIndex = 10;
            this.optCaduca.TabStop = true;
            this.optCaduca.Text = "Caduca";
            this.optCaduca.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 275);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // frmAlacena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 359);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.optCaduca);
            this.Controls.Add(this.cmdBorrar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.mrcCategoria);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAlacena";
            this.Text = "frmAlacena";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.mrcCategoria.ResumeLayout(false);
            this.mrcCategoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox mrcCategoria;
        private System.Windows.Forms.Label txtProducto;
        private System.Windows.Forms.Label txtTipo;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Label txtCantidad;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton optCaduca;
        private System.Windows.Forms.Button cmdBorrar;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.ComboBox lstCantidad;
        private System.Windows.Forms.ComboBox lstTipo;
        private System.Windows.Forms.ComboBox lstNombre;
        private System.Windows.Forms.ComboBox lstProductos;
    }
}
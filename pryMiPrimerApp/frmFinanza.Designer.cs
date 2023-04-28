
namespace pryMiPrimerApp
{
    partial class frmFinanzas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinanzas));
            this.mrcIngresos = new System.Windows.Forms.GroupBox();
            this.txtdeposito = new System.Windows.Forms.TextBox();
            this.lblDeposito = new System.Windows.Forms.Label();
            this.mrcGastosFijos = new System.Windows.Forms.GroupBox();
            this.lblComida = new System.Windows.Forms.Label();
            this.txttComida = new System.Windows.Forms.TextBox();
            this.txttImpuestos = new System.Windows.Forms.TextBox();
            this.lblImpuestos = new System.Windows.Forms.Label();
            this.txtAlquleres = new System.Windows.Forms.TextBox();
            this.lblAlquileres = new System.Windows.Forms.Label();
            this.mrcGastosVariados = new System.Windows.Forms.GroupBox();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.lblSalida = new System.Windows.Forms.Label();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.mrcIngresos.SuspendLayout();
            this.mrcGastosFijos.SuspendLayout();
            this.mrcGastosVariados.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcIngresos
            // 
            this.mrcIngresos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mrcIngresos.Controls.Add(this.txtdeposito);
            this.mrcIngresos.Controls.Add(this.lblDeposito);
            this.mrcIngresos.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcIngresos.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.mrcIngresos.Location = new System.Drawing.Point(12, 12);
            this.mrcIngresos.Name = "mrcIngresos";
            this.mrcIngresos.Size = new System.Drawing.Size(251, 88);
            this.mrcIngresos.TabIndex = 5;
            this.mrcIngresos.TabStop = false;
            this.mrcIngresos.Text = "ingresos";
            this.mrcIngresos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtdeposito
            // 
            this.txtdeposito.Location = new System.Drawing.Point(132, 44);
            this.txtdeposito.Name = "txtdeposito";
            this.txtdeposito.Size = new System.Drawing.Size(100, 29);
            this.txtdeposito.TabIndex = 1;
            // 
            // lblDeposito
            // 
            this.lblDeposito.AutoSize = true;
            this.lblDeposito.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposito.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDeposito.Location = new System.Drawing.Point(8, 44);
            this.lblDeposito.Name = "lblDeposito";
            this.lblDeposito.Size = new System.Drawing.Size(69, 19);
            this.lblDeposito.TabIndex = 0;
            this.lblDeposito.Text = "Deposito";
            // 
            // mrcGastosFijos
            // 
            this.mrcGastosFijos.Controls.Add(this.lblComida);
            this.mrcGastosFijos.Controls.Add(this.txttComida);
            this.mrcGastosFijos.Controls.Add(this.txttImpuestos);
            this.mrcGastosFijos.Controls.Add(this.lblImpuestos);
            this.mrcGastosFijos.Controls.Add(this.txtAlquleres);
            this.mrcGastosFijos.Controls.Add(this.lblAlquileres);
            this.mrcGastosFijos.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcGastosFijos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.mrcGastosFijos.Location = new System.Drawing.Point(12, 106);
            this.mrcGastosFijos.Name = "mrcGastosFijos";
            this.mrcGastosFijos.Size = new System.Drawing.Size(251, 168);
            this.mrcGastosFijos.TabIndex = 6;
            this.mrcGastosFijos.TabStop = false;
            this.mrcGastosFijos.Text = "Gastos Fijos";
            // 
            // lblComida
            // 
            this.lblComida.AutoSize = true;
            this.lblComida.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComida.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblComida.Location = new System.Drawing.Point(8, 125);
            this.lblComida.Name = "lblComida";
            this.lblComida.Size = new System.Drawing.Size(56, 19);
            this.lblComida.TabIndex = 5;
            this.lblComida.Text = "comida";
            this.lblComida.Click += new System.EventHandler(this.label4_Click);
            // 
            // txttComida
            // 
            this.txttComida.Location = new System.Drawing.Point(132, 125);
            this.txttComida.Name = "txttComida";
            this.txttComida.Size = new System.Drawing.Size(100, 29);
            this.txttComida.TabIndex = 4;
            // 
            // txttImpuestos
            // 
            this.txttImpuestos.Location = new System.Drawing.Point(132, 79);
            this.txttImpuestos.Name = "txttImpuestos";
            this.txttImpuestos.Size = new System.Drawing.Size(100, 29);
            this.txttImpuestos.TabIndex = 3;
            // 
            // lblImpuestos
            // 
            this.lblImpuestos.AutoSize = true;
            this.lblImpuestos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpuestos.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblImpuestos.Location = new System.Drawing.Point(8, 79);
            this.lblImpuestos.Name = "lblImpuestos";
            this.lblImpuestos.Size = new System.Drawing.Size(82, 19);
            this.lblImpuestos.TabIndex = 2;
            this.lblImpuestos.Text = "Impuestos ";
            this.lblImpuestos.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtAlquleres
            // 
            this.txtAlquleres.Location = new System.Drawing.Point(132, 30);
            this.txtAlquleres.Name = "txtAlquleres";
            this.txtAlquleres.Size = new System.Drawing.Size(100, 29);
            this.txtAlquleres.TabIndex = 1;
            // 
            // lblAlquileres
            // 
            this.lblAlquileres.AutoSize = true;
            this.lblAlquileres.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlquileres.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblAlquileres.Location = new System.Drawing.Point(8, 35);
            this.lblAlquileres.Name = "lblAlquileres";
            this.lblAlquileres.Size = new System.Drawing.Size(81, 19);
            this.lblAlquileres.TabIndex = 0;
            this.lblAlquileres.Text = "Alquileres ";
            // 
            // mrcGastosVariados
            // 
            this.mrcGastosVariados.Controls.Add(this.txtSalida);
            this.mrcGastosVariados.Controls.Add(this.lblSalida);
            this.mrcGastosVariados.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcGastosVariados.ForeColor = System.Drawing.SystemColors.Highlight;
            this.mrcGastosVariados.Location = new System.Drawing.Point(12, 280);
            this.mrcGastosVariados.Name = "mrcGastosVariados";
            this.mrcGastosVariados.Size = new System.Drawing.Size(251, 83);
            this.mrcGastosVariados.TabIndex = 7;
            this.mrcGastosVariados.TabStop = false;
            this.mrcGastosVariados.Text = "Gastos Variados ";
            // 
            // txtSalida
            // 
            this.txtSalida.Location = new System.Drawing.Point(132, 35);
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(100, 29);
            this.txtSalida.TabIndex = 1;
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalida.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblSalida.Location = new System.Drawing.Point(8, 40);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(50, 19);
            this.lblSalida.TabIndex = 0;
            this.lblSalida.Text = "Salida";
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmdCancelar.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Location = new System.Drawing.Point(14, 402);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(109, 34);
            this.cmdCancelar.TabIndex = 8;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = false;
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdAceptar.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAceptar.Location = new System.Drawing.Point(154, 402);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(109, 34);
            this.cmdAceptar.TabIndex = 9;
            this.cmdAceptar.Text = "Aceptar";
            this.cmdAceptar.UseVisualStyleBackColor = false;
            this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(21, 377);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(35, 13);
            this.lblResultado.TabIndex = 11;
            this.lblResultado.Text = "label2";
            // 
            // frmFinanzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 455);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdAceptar);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.mrcGastosVariados);
            this.Controls.Add(this.mrcGastosFijos);
            this.Controls.Add(this.mrcIngresos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFinanzas";
            this.Text = "Gestiòn De Gastos Mensuales ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mrcIngresos.ResumeLayout(false);
            this.mrcIngresos.PerformLayout();
            this.mrcGastosFijos.ResumeLayout(false);
            this.mrcGastosFijos.PerformLayout();
            this.mrcGastosVariados.ResumeLayout(false);
            this.mrcGastosVariados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox mrcIngresos;
        private System.Windows.Forms.Label lblDeposito;
        private System.Windows.Forms.TextBox txtdeposito;
        private System.Windows.Forms.GroupBox mrcGastosFijos;
        private System.Windows.Forms.TextBox txttImpuestos;
        private System.Windows.Forms.Label lblImpuestos;
        private System.Windows.Forms.TextBox txtAlquleres;
        private System.Windows.Forms.Label lblAlquileres;
        private System.Windows.Forms.Label lblComida;
        private System.Windows.Forms.TextBox txttComida;
        private System.Windows.Forms.GroupBox mrcGastosVariados;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultado;
    }
}


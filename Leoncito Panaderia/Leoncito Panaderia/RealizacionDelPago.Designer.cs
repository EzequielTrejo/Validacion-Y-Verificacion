namespace Leoncito_Panaderia
{
    partial class RealizacionDelPago
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
            if(disposing && (components != null))
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
            this.dgvInformeDeCompra = new System.Windows.Forms.DataGridView();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.txtMontoCliente = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblVuelto = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformeDeCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInformeDeCompra
            // 
            this.dgvInformeDeCompra.AllowUserToAddRows = false;
            this.dgvInformeDeCompra.AllowUserToDeleteRows = false;
            this.dgvInformeDeCompra.AllowUserToResizeColumns = false;
            this.dgvInformeDeCompra.AllowUserToResizeRows = false;
            this.dgvInformeDeCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInformeDeCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformeDeCompra.Location = new System.Drawing.Point(0, 0);
            this.dgvInformeDeCompra.Name = "dgvInformeDeCompra";
            this.dgvInformeDeCompra.ReadOnly = true;
            this.dgvInformeDeCompra.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvInformeDeCompra.Size = new System.Drawing.Size(788, 286);
            this.dgvInformeDeCompra.TabIndex = 0;
            // 
            // btnCobrar
            // 
            this.btnCobrar.Location = new System.Drawing.Point(0, 292);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(110, 42);
            this.btnCobrar.TabIndex = 1;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = true;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // txtMontoCliente
            // 
            this.txtMontoCliente.Location = new System.Drawing.Point(116, 304);
            this.txtMontoCliente.Name = "txtMontoCliente";
            this.txtMontoCliente.Size = new System.Drawing.Size(146, 20);
            this.txtMontoCliente.TabIndex = 3;
            this.txtMontoCliente.Text = "Monto abonado por el cliente";
            this.txtMontoCliente.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtMontoCliente_MouseClick);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(319, 292);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 24);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total";
            // 
            // lblVuelto
            // 
            this.lblVuelto.AutoSize = true;
            this.lblVuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVuelto.Location = new System.Drawing.Point(320, 321);
            this.lblVuelto.Name = "lblVuelto";
            this.lblVuelto.Size = new System.Drawing.Size(70, 24);
            this.lblVuelto.TabIndex = 5;
            this.lblVuelto.Text = "Vuelto";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(441, 292);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(110, 42);
            this.btnFinalizar.TabIndex = 6;
            this.btnFinalizar.Text = "Finalizar Venta";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Visible = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // RealizacionDelPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.lblVuelto);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtMontoCliente);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.dgvInformeDeCompra);
            this.Name = "RealizacionDelPago";
            this.Text = "RealizacionDelPago";
            this.Load += new System.EventHandler(this.RealizacionDelPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformeDeCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInformeDeCompra;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.TextBox txtMontoCliente;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblVuelto;
        private System.Windows.Forms.Button btnFinalizar;
    }
}
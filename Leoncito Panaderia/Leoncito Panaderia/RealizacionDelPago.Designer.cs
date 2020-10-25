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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 304);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Monto abonado por el cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(312, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total";
            // 
            // RealizacionDelPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}
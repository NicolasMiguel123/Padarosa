namespace Padarosa
{
    partial class FrmCaixa
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
            this.dgvCaixa = new System.Windows.Forms.DataGridView();
            this.lblcomandacaixa = new System.Windows.Forms.Label();
            this.txbnumerocomandacaixa = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.lbltotal = new System.Windows.Forms.Label();
            this.chbpagamentorecebido = new System.Windows.Forms.CheckBox();
            this.btnencerrarcomanda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCaixa
            // 
            this.dgvCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaixa.Location = new System.Drawing.Point(3, 95);
            this.dgvCaixa.Name = "dgvCaixa";
            this.dgvCaixa.Size = new System.Drawing.Size(718, 211);
            this.dgvCaixa.TabIndex = 0;
            // 
            // lblcomandacaixa
            // 
            this.lblcomandacaixa.AutoSize = true;
            this.lblcomandacaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcomandacaixa.Location = new System.Drawing.Point(12, 45);
            this.lblcomandacaixa.Name = "lblcomandacaixa";
            this.lblcomandacaixa.Size = new System.Drawing.Size(291, 31);
            this.lblcomandacaixa.TabIndex = 1;
            this.lblcomandacaixa.Text = "Numero da comanda:";
            // 
            // txbnumerocomandacaixa
            // 
            this.txbnumerocomandacaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbnumerocomandacaixa.Location = new System.Drawing.Point(309, 48);
            this.txbnumerocomandacaixa.Name = "txbnumerocomandacaixa";
            this.txbnumerocomandacaixa.Size = new System.Drawing.Size(310, 31);
            this.txbnumerocomandacaixa.TabIndex = 2;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(625, 48);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(91, 32);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(536, 326);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(101, 29);
            this.lbltotal.TabIndex = 4;
            this.lbltotal.Text = "R$ 0,00";
            // 
            // chbpagamentorecebido
            // 
            this.chbpagamentorecebido.AutoSize = true;
            this.chbpagamentorecebido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbpagamentorecebido.Location = new System.Drawing.Point(442, 368);
            this.chbpagamentorecebido.Name = "chbpagamentorecebido";
            this.chbpagamentorecebido.Size = new System.Drawing.Size(279, 29);
            this.chbpagamentorecebido.TabIndex = 5;
            this.chbpagamentorecebido.Text = "PAGAMENTO RECEBIDO";
            this.chbpagamentorecebido.UseVisualStyleBackColor = true;
            this.chbpagamentorecebido.CheckedChanged += new System.EventHandler(this.chbpagamentorecebido_CheckedChanged);
            // 
            // btnencerrarcomanda
            // 
            this.btnencerrarcomanda.Enabled = false;
            this.btnencerrarcomanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnencerrarcomanda.Location = new System.Drawing.Point(442, 403);
            this.btnencerrarcomanda.Name = "btnencerrarcomanda";
            this.btnencerrarcomanda.Size = new System.Drawing.Size(269, 35);
            this.btnencerrarcomanda.TabIndex = 6;
            this.btnencerrarcomanda.Text = "Encerrar Comanda";
            this.btnencerrarcomanda.UseVisualStyleBackColor = true;
            this.btnencerrarcomanda.Click += new System.EventHandler(this.btnencerrarcomanda_Click);
            // 
            // FrmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 450);
            this.Controls.Add(this.btnencerrarcomanda);
            this.Controls.Add(this.chbpagamentorecebido);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txbnumerocomandacaixa);
            this.Controls.Add(this.lblcomandacaixa);
            this.Controls.Add(this.dgvCaixa);
            this.Name = "FrmCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCaixa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCaixa;
        private System.Windows.Forms.Label lblcomandacaixa;
        private System.Windows.Forms.TextBox txbnumerocomandacaixa;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.CheckBox chbpagamentorecebido;
        private System.Windows.Forms.Button btnencerrarcomanda;
    }
}
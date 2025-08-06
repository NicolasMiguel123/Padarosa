namespace Padarosa
{
    partial class FrmComanda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmComanda));
            this.dgvComandas = new System.Windows.Forms.DataGridView();
            this.grblancamento = new System.Windows.Forms.GroupBox();
            this.txblancarquantidade = new System.Windows.Forms.TextBox();
            this.lblComanda2 = new System.Windows.Forms.Label();
            this.txblancarproduto = new System.Windows.Forms.TextBox();
            this.lblProduto2 = new System.Windows.Forms.Label();
            this.btnlancar = new System.Windows.Forms.Button();
            this.grbinformacao = new System.Windows.Forms.GroupBox();
            this.txbcastararproduto = new System.Windows.Forms.TextBox();
            this.txbcastrarcomanda = new System.Windows.Forms.TextBox();
            this.btncontinuar = new System.Windows.Forms.Button();
            this.lblproduto = new System.Windows.Forms.Label();
            this.lblComanda = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComandas)).BeginInit();
            this.grblancamento.SuspendLayout();
            this.grbinformacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvComandas
            // 
            this.dgvComandas.AllowUserToAddRows = false;
            this.dgvComandas.AllowUserToDeleteRows = false;
            this.dgvComandas.AllowUserToResizeColumns = false;
            this.dgvComandas.AllowUserToResizeRows = false;
            this.dgvComandas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComandas.Location = new System.Drawing.Point(2, 3);
            this.dgvComandas.Name = "dgvComandas";
            this.dgvComandas.ReadOnly = true;
            this.dgvComandas.Size = new System.Drawing.Size(408, 447);
            this.dgvComandas.TabIndex = 8;
            this.dgvComandas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComandas_CellClick);
            // 
            // grblancamento
            // 
            this.grblancamento.Controls.Add(this.txblancarquantidade);
            this.grblancamento.Controls.Add(this.lblComanda2);
            this.grblancamento.Controls.Add(this.txblancarproduto);
            this.grblancamento.Controls.Add(this.lblProduto2);
            this.grblancamento.Controls.Add(this.btnlancar);
            this.grblancamento.Enabled = false;
            this.grblancamento.Location = new System.Drawing.Point(418, 214);
            this.grblancamento.Name = "grblancamento";
            this.grblancamento.Size = new System.Drawing.Size(373, 187);
            this.grblancamento.TabIndex = 6;
            this.grblancamento.TabStop = false;
            this.grblancamento.Text = "Lançamento";
            // 
            // txblancarquantidade
            // 
            this.txblancarquantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txblancarquantidade.Location = new System.Drawing.Point(119, 71);
            this.txblancarquantidade.Name = "txblancarquantidade";
            this.txblancarquantidade.Size = new System.Drawing.Size(242, 26);
            this.txblancarquantidade.TabIndex = 12;
            // 
            // lblComanda2
            // 
            this.lblComanda2.AutoSize = true;
            this.lblComanda2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComanda2.Location = new System.Drawing.Point(8, 37);
            this.lblComanda2.Name = "lblComanda2";
            this.lblComanda2.Size = new System.Drawing.Size(77, 20);
            this.lblComanda2.TabIndex = 7;
            this.lblComanda2.Text = "Produto:";
            // 
            // txblancarproduto
            // 
            this.txblancarproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txblancarproduto.Location = new System.Drawing.Point(119, 31);
            this.txblancarproduto.Name = "txblancarproduto";
            this.txblancarproduto.Size = new System.Drawing.Size(242, 26);
            this.txblancarproduto.TabIndex = 11;
            // 
            // lblProduto2
            // 
            this.lblProduto2.AutoSize = true;
            this.lblProduto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto2.Location = new System.Drawing.Point(6, 73);
            this.lblProduto2.Name = "lblProduto2";
            this.lblProduto2.Size = new System.Drawing.Size(107, 20);
            this.lblProduto2.TabIndex = 8;
            this.lblProduto2.Text = "Quantidade:";
            // 
            // btnlancar
            // 
            this.btnlancar.Location = new System.Drawing.Point(26, 107);
            this.btnlancar.Name = "btnlancar";
            this.btnlancar.Size = new System.Drawing.Size(335, 47);
            this.btnlancar.TabIndex = 10;
            this.btnlancar.Text = "Lançar";
            this.btnlancar.UseVisualStyleBackColor = true;
            this.btnlancar.Click += new System.EventHandler(this.btnlancar_Click);
            // 
            // grbinformacao
            // 
            this.grbinformacao.Controls.Add(this.txbcastararproduto);
            this.grbinformacao.Controls.Add(this.txbcastrarcomanda);
            this.grbinformacao.Controls.Add(this.btncontinuar);
            this.grbinformacao.Controls.Add(this.lblproduto);
            this.grbinformacao.Controls.Add(this.lblComanda);
            this.grbinformacao.Location = new System.Drawing.Point(416, 12);
            this.grbinformacao.Name = "grbinformacao";
            this.grbinformacao.Size = new System.Drawing.Size(375, 187);
            this.grbinformacao.TabIndex = 5;
            this.grbinformacao.TabStop = false;
            this.grbinformacao.Text = "Informações ";
            // 
            // txbcastararproduto
            // 
            this.txbcastararproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbcastararproduto.Location = new System.Drawing.Point(106, 79);
            this.txbcastararproduto.Name = "txbcastararproduto";
            this.txbcastararproduto.Size = new System.Drawing.Size(263, 29);
            this.txbcastararproduto.TabIndex = 5;
            // 
            // txbcastrarcomanda
            // 
            this.txbcastrarcomanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbcastrarcomanda.Location = new System.Drawing.Point(106, 41);
            this.txbcastrarcomanda.Name = "txbcastrarcomanda";
            this.txbcastrarcomanda.Size = new System.Drawing.Size(263, 29);
            this.txbcastrarcomanda.TabIndex = 4;
            // 
            // btncontinuar
            // 
            this.btncontinuar.Location = new System.Drawing.Point(28, 124);
            this.btncontinuar.Name = "btncontinuar";
            this.btncontinuar.Size = new System.Drawing.Size(335, 47);
            this.btncontinuar.TabIndex = 3;
            this.btncontinuar.Text = "Continuar";
            this.btncontinuar.UseVisualStyleBackColor = true;
            this.btncontinuar.Click += new System.EventHandler(this.btncontinuar_Click);
            // 
            // lblproduto
            // 
            this.lblproduto.AutoSize = true;
            this.lblproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproduto.Location = new System.Drawing.Point(10, 83);
            this.lblproduto.Name = "lblproduto";
            this.lblproduto.Size = new System.Drawing.Size(77, 20);
            this.lblproduto.TabIndex = 1;
            this.lblproduto.Text = "Produto:";
            // 
            // lblComanda
            // 
            this.lblComanda.AutoSize = true;
            this.lblComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComanda.Location = new System.Drawing.Point(10, 41);
            this.lblComanda.Name = "lblComanda";
            this.lblComanda.Size = new System.Drawing.Size(90, 20);
            this.lblComanda.TabIndex = 0;
            this.lblComanda.Text = "Comanda:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(418, 407);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(373, 47);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvComandas);
            this.Controls.Add(this.grblancamento);
            this.Controls.Add(this.grbinformacao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmComanda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comanda";
            ((System.ComponentModel.ISupportInitialize)(this.dgvComandas)).EndInit();
            this.grblancamento.ResumeLayout(false);
            this.grblancamento.PerformLayout();
            this.grbinformacao.ResumeLayout(false);
            this.grbinformacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComandas;
        private System.Windows.Forms.GroupBox grblancamento;
        private System.Windows.Forms.TextBox txblancarquantidade;
        private System.Windows.Forms.Label lblComanda2;
        private System.Windows.Forms.TextBox txblancarproduto;
        private System.Windows.Forms.Label lblProduto2;
        private System.Windows.Forms.Button btnlancar;
        private System.Windows.Forms.GroupBox grbinformacao;
        private System.Windows.Forms.TextBox txbcastararproduto;
        private System.Windows.Forms.TextBox txbcastrarcomanda;
        private System.Windows.Forms.Button btncontinuar;
        private System.Windows.Forms.Label lblproduto;
        private System.Windows.Forms.Label lblComanda;
        private System.Windows.Forms.Button btnCancelar;
    }
}
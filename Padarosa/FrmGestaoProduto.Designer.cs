namespace Padarosa
{
    partial class FrmGestaoProduto
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
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.grbCadastrarProdutos = new System.Windows.Forms.GroupBox();
            this.txbcadastrarcategoria = new System.Windows.Forms.TextBox();
            this.txbcadastrarpreco = new System.Windows.Forms.TextBox();
            this.txbcadastrarproduto = new System.Windows.Forms.TextBox();
            this.btncadastrarproduto = new System.Windows.Forms.Button();
            this.lblcategoriaproduto = new System.Windows.Forms.Label();
            this.lblprecoproduto = new System.Windows.Forms.Label();
            this.lblnomeproduto = new System.Windows.Forms.Label();
            this.grpeditarprodutos = new System.Windows.Forms.GroupBox();
            this.txbeditarcategoria = new System.Windows.Forms.TextBox();
            this.txbeditarpreco = new System.Windows.Forms.TextBox();
            this.txbeditarproduto = new System.Windows.Forms.TextBox();
            this.btneditarproduto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grbapagarproduto = new System.Windows.Forms.GroupBox();
            this.lblapagar2 = new System.Windows.Forms.Label();
            this.btnapagarproduto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.grbCadastrarProdutos.SuspendLayout();
            this.grpeditarprodutos.SuspendLayout();
            this.grbapagarproduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeColumns = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(12, 5);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(817, 188);
            this.dgvProdutos.TabIndex = 5;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellContentClick);
            // 
            // grbCadastrarProdutos
            // 
            this.grbCadastrarProdutos.Controls.Add(this.txbcadastrarcategoria);
            this.grbCadastrarProdutos.Controls.Add(this.txbcadastrarpreco);
            this.grbCadastrarProdutos.Controls.Add(this.txbcadastrarproduto);
            this.grbCadastrarProdutos.Controls.Add(this.btncadastrarproduto);
            this.grbCadastrarProdutos.Controls.Add(this.lblcategoriaproduto);
            this.grbCadastrarProdutos.Controls.Add(this.lblprecoproduto);
            this.grbCadastrarProdutos.Controls.Add(this.lblnomeproduto);
            this.grbCadastrarProdutos.Location = new System.Drawing.Point(21, 199);
            this.grbCadastrarProdutos.Name = "grbCadastrarProdutos";
            this.grbCadastrarProdutos.Size = new System.Drawing.Size(401, 188);
            this.grbCadastrarProdutos.TabIndex = 6;
            this.grbCadastrarProdutos.TabStop = false;
            this.grbCadastrarProdutos.Text = "Produtos";
            // 
            // txbcadastrarcategoria
            // 
            this.txbcadastrarcategoria.Location = new System.Drawing.Point(162, 98);
            this.txbcadastrarcategoria.Name = "txbcadastrarcategoria";
            this.txbcadastrarcategoria.Size = new System.Drawing.Size(213, 20);
            this.txbcadastrarcategoria.TabIndex = 13;
            // 
            // txbcadastrarpreco
            // 
            this.txbcadastrarpreco.Location = new System.Drawing.Point(162, 62);
            this.txbcadastrarpreco.Name = "txbcadastrarpreco";
            this.txbcadastrarpreco.Size = new System.Drawing.Size(213, 20);
            this.txbcadastrarpreco.TabIndex = 12;
            // 
            // txbcadastrarproduto
            // 
            this.txbcadastrarproduto.Location = new System.Drawing.Point(162, 26);
            this.txbcadastrarproduto.Name = "txbcadastrarproduto";
            this.txbcadastrarproduto.Size = new System.Drawing.Size(213, 20);
            this.txbcadastrarproduto.TabIndex = 11;
            // 
            // btncadastrarproduto
            // 
            this.btncadastrarproduto.Location = new System.Drawing.Point(29, 136);
            this.btncadastrarproduto.Name = "btncadastrarproduto";
            this.btncadastrarproduto.Size = new System.Drawing.Size(335, 47);
            this.btncadastrarproduto.TabIndex = 10;
            this.btncadastrarproduto.Text = "Cadastrar Produto";
            this.btncadastrarproduto.UseVisualStyleBackColor = true;
            this.btncadastrarproduto.Click += new System.EventHandler(this.btncadastrarproduto_Click);
            // 
            // lblcategoriaproduto
            // 
            this.lblcategoriaproduto.AutoSize = true;
            this.lblcategoriaproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategoriaproduto.Location = new System.Drawing.Point(11, 96);
            this.lblcategoriaproduto.Name = "lblcategoriaproduto";
            this.lblcategoriaproduto.Size = new System.Drawing.Size(89, 20);
            this.lblcategoriaproduto.TabIndex = 9;
            this.lblcategoriaproduto.Text = "categoria:";
            // 
            // lblprecoproduto
            // 
            this.lblprecoproduto.AutoSize = true;
            this.lblprecoproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecoproduto.Location = new System.Drawing.Point(11, 62);
            this.lblprecoproduto.Name = "lblprecoproduto";
            this.lblprecoproduto.Size = new System.Drawing.Size(59, 20);
            this.lblprecoproduto.TabIndex = 8;
            this.lblprecoproduto.Text = "preço:";
            // 
            // lblnomeproduto
            // 
            this.lblnomeproduto.AutoSize = true;
            this.lblnomeproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomeproduto.Location = new System.Drawing.Point(11, 24);
            this.lblnomeproduto.Name = "lblnomeproduto";
            this.lblnomeproduto.Size = new System.Drawing.Size(150, 20);
            this.lblnomeproduto.TabIndex = 7;
            this.lblnomeproduto.Text = "nome do produto:";
            // 
            // grpeditarprodutos
            // 
            this.grpeditarprodutos.Controls.Add(this.txbeditarcategoria);
            this.grpeditarprodutos.Controls.Add(this.txbeditarpreco);
            this.grpeditarprodutos.Controls.Add(this.txbeditarproduto);
            this.grpeditarprodutos.Controls.Add(this.btneditarproduto);
            this.grpeditarprodutos.Controls.Add(this.label1);
            this.grpeditarprodutos.Controls.Add(this.label2);
            this.grpeditarprodutos.Controls.Add(this.label3);
            this.grpeditarprodutos.Location = new System.Drawing.Point(428, 199);
            this.grpeditarprodutos.Name = "grpeditarprodutos";
            this.grpeditarprodutos.Size = new System.Drawing.Size(401, 188);
            this.grpeditarprodutos.TabIndex = 14;
            this.grpeditarprodutos.TabStop = false;
            this.grpeditarprodutos.Text = "Produtos";
            // 
            // txbeditarcategoria
            // 
            this.txbeditarcategoria.Location = new System.Drawing.Point(162, 98);
            this.txbeditarcategoria.Name = "txbeditarcategoria";
            this.txbeditarcategoria.Size = new System.Drawing.Size(213, 20);
            this.txbeditarcategoria.TabIndex = 13;
            // 
            // txbeditarpreco
            // 
            this.txbeditarpreco.Location = new System.Drawing.Point(162, 62);
            this.txbeditarpreco.Name = "txbeditarpreco";
            this.txbeditarpreco.Size = new System.Drawing.Size(213, 20);
            this.txbeditarpreco.TabIndex = 12;
            // 
            // txbeditarproduto
            // 
            this.txbeditarproduto.Location = new System.Drawing.Point(162, 26);
            this.txbeditarproduto.Name = "txbeditarproduto";
            this.txbeditarproduto.Size = new System.Drawing.Size(213, 20);
            this.txbeditarproduto.TabIndex = 11;
            // 
            // btneditarproduto
            // 
            this.btneditarproduto.Location = new System.Drawing.Point(40, 136);
            this.btneditarproduto.Name = "btneditarproduto";
            this.btneditarproduto.Size = new System.Drawing.Size(335, 47);
            this.btneditarproduto.TabIndex = 10;
            this.btneditarproduto.Text = "Editar Produto";
            this.btneditarproduto.UseVisualStyleBackColor = true;
            this.btneditarproduto.Click += new System.EventHandler(this.btneditarproduto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "categoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "preço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "nome do produto:";
            // 
            // grbapagarproduto
            // 
            this.grbapagarproduto.Controls.Add(this.lblapagar2);
            this.grbapagarproduto.Controls.Add(this.btnapagarproduto);
            this.grbapagarproduto.Enabled = false;
            this.grbapagarproduto.Location = new System.Drawing.Point(21, 393);
            this.grbapagarproduto.Name = "grbapagarproduto";
            this.grbapagarproduto.Size = new System.Drawing.Size(808, 54);
            this.grbapagarproduto.TabIndex = 15;
            this.grbapagarproduto.TabStop = false;
            this.grbapagarproduto.Text = "Apagar";
            // 
            // lblapagar2
            // 
            this.lblapagar2.AutoSize = true;
            this.lblapagar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapagar2.Location = new System.Drawing.Point(87, 18);
            this.lblapagar2.Name = "lblapagar2";
            this.lblapagar2.Size = new System.Drawing.Size(324, 20);
            this.lblapagar2.TabIndex = 7;
            this.lblapagar2.Text = "Selecione o produto que deseja apagar";
            // 
            // btnapagarproduto
            // 
            this.btnapagarproduto.Location = new System.Drawing.Point(504, 13);
            this.btnapagarproduto.Name = "btnapagarproduto";
            this.btnapagarproduto.Size = new System.Drawing.Size(253, 35);
            this.btnapagarproduto.TabIndex = 4;
            this.btnapagarproduto.Text = "Apagar";
            this.btnapagarproduto.UseVisualStyleBackColor = true;
            this.btnapagarproduto.Click += new System.EventHandler(this.btnapagarproduto_Click);
            // 
            // FrmGestaoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 450);
            this.Controls.Add(this.grbapagarproduto);
            this.Controls.Add(this.grpeditarprodutos);
            this.Controls.Add(this.grbCadastrarProdutos);
            this.Controls.Add(this.dgvProdutos);
            this.Name = "FrmGestaoProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGestaoProduto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.grbCadastrarProdutos.ResumeLayout(false);
            this.grbCadastrarProdutos.PerformLayout();
            this.grpeditarprodutos.ResumeLayout(false);
            this.grpeditarprodutos.PerformLayout();
            this.grbapagarproduto.ResumeLayout(false);
            this.grbapagarproduto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.GroupBox grbCadastrarProdutos;
        private System.Windows.Forms.TextBox txbcadastrarcategoria;
        private System.Windows.Forms.TextBox txbcadastrarpreco;
        private System.Windows.Forms.TextBox txbcadastrarproduto;
        private System.Windows.Forms.Button btncadastrarproduto;
        private System.Windows.Forms.Label lblcategoriaproduto;
        private System.Windows.Forms.Label lblprecoproduto;
        private System.Windows.Forms.Label lblnomeproduto;
        private System.Windows.Forms.GroupBox grpeditarprodutos;
        private System.Windows.Forms.TextBox txbeditarcategoria;
        private System.Windows.Forms.TextBox txbeditarpreco;
        private System.Windows.Forms.TextBox txbeditarproduto;
        private System.Windows.Forms.Button btneditarproduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grbapagarproduto;
        private System.Windows.Forms.Label lblapagar2;
        private System.Windows.Forms.Button btnapagarproduto;
    }
}
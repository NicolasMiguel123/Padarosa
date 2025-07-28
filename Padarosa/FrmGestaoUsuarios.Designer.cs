namespace Padarosa
{
    partial class FrmGestaoUsuarios
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
            this.grbCadastro = new System.Windows.Forms.GroupBox();
            this.txbsenha = new System.Windows.Forms.TextBox();
            this.txbemail = new System.Windows.Forms.TextBox();
            this.txbnome = new System.Windows.Forms.TextBox();
            this.btncadastras = new System.Windows.Forms.Button();
            this.lblsenha = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.grbEdicao = new System.Windows.Forms.GroupBox();
            this.txbsenhaedicao = new System.Windows.Forms.TextBox();
            this.lblsenha2 = new System.Windows.Forms.Label();
            this.txbemailedicao = new System.Windows.Forms.TextBox();
            this.lblnome2 = new System.Windows.Forms.Label();
            this.txbnomeedicao = new System.Windows.Forms.TextBox();
            this.lblemail2 = new System.Windows.Forms.Label();
            this.btneditar = new System.Windows.Forms.Button();
            this.grbapagar = new System.Windows.Forms.GroupBox();
            this.lblapagar = new System.Windows.Forms.Label();
            this.btnapagar = new System.Windows.Forms.Button();
            this.dgvUsuarios1 = new System.Windows.Forms.DataGridView();
            this.grbCadastro.SuspendLayout();
            this.grbEdicao.SuspendLayout();
            this.grbapagar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbCadastro
            // 
            this.grbCadastro.Controls.Add(this.txbsenha);
            this.grbCadastro.Controls.Add(this.txbemail);
            this.grbCadastro.Controls.Add(this.txbnome);
            this.grbCadastro.Controls.Add(this.btncadastras);
            this.grbCadastro.Controls.Add(this.lblsenha);
            this.grbCadastro.Controls.Add(this.lblemail);
            this.grbCadastro.Controls.Add(this.lblnome);
            this.grbCadastro.Location = new System.Drawing.Point(34, 304);
            this.grbCadastro.Name = "grbCadastro";
            this.grbCadastro.Size = new System.Drawing.Size(375, 206);
            this.grbCadastro.TabIndex = 0;
            this.grbCadastro.TabStop = false;
            this.grbCadastro.Text = "Cadastro ";
            // 
            // txbsenha
            // 
            this.txbsenha.Location = new System.Drawing.Point(156, 115);
            this.txbsenha.Name = "txbsenha";
            this.txbsenha.Size = new System.Drawing.Size(213, 20);
            this.txbsenha.TabIndex = 6;
            // 
            // txbemail
            // 
            this.txbemail.Location = new System.Drawing.Point(156, 79);
            this.txbemail.Name = "txbemail";
            this.txbemail.Size = new System.Drawing.Size(213, 20);
            this.txbemail.TabIndex = 5;
            // 
            // txbnome
            // 
            this.txbnome.Location = new System.Drawing.Point(156, 41);
            this.txbnome.Name = "txbnome";
            this.txbnome.Size = new System.Drawing.Size(213, 20);
            this.txbnome.TabIndex = 4;
            // 
            // btncadastras
            // 
            this.btncadastras.Location = new System.Drawing.Point(27, 153);
            this.btncadastras.Name = "btncadastras";
            this.btncadastras.Size = new System.Drawing.Size(335, 47);
            this.btncadastras.TabIndex = 3;
            this.btncadastras.Text = "Cadastrar";
            this.btncadastras.UseVisualStyleBackColor = true;
            this.btncadastras.Click += new System.EventHandler(this.btncadastras_Click);
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsenha.Location = new System.Drawing.Point(23, 113);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(63, 20);
            this.lblsenha.TabIndex = 2;
            this.lblsenha.Text = "senha:";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(23, 79);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(56, 20);
            this.lblemail.TabIndex = 1;
            this.lblemail.Text = "email:";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(23, 41);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(136, 20);
            this.lblnome.TabIndex = 0;
            this.lblnome.Text = "nome completo:";
            // 
            // grbEdicao
            // 
            this.grbEdicao.Controls.Add(this.txbsenhaedicao);
            this.grbEdicao.Controls.Add(this.lblsenha2);
            this.grbEdicao.Controls.Add(this.txbemailedicao);
            this.grbEdicao.Controls.Add(this.lblnome2);
            this.grbEdicao.Controls.Add(this.txbnomeedicao);
            this.grbEdicao.Controls.Add(this.lblemail2);
            this.grbEdicao.Controls.Add(this.btneditar);
            this.grbEdicao.Enabled = false;
            this.grbEdicao.Location = new System.Drawing.Point(416, 304);
            this.grbEdicao.Name = "grbEdicao";
            this.grbEdicao.Size = new System.Drawing.Size(373, 206);
            this.grbEdicao.TabIndex = 1;
            this.grbEdicao.TabStop = false;
            this.grbEdicao.Text = "Edição";
            // 
            // txbsenhaedicao
            // 
            this.txbsenhaedicao.Location = new System.Drawing.Point(143, 105);
            this.txbsenhaedicao.Name = "txbsenhaedicao";
            this.txbsenhaedicao.Size = new System.Drawing.Size(213, 20);
            this.txbsenhaedicao.TabIndex = 13;
            // 
            // lblsenha2
            // 
            this.lblsenha2.AutoSize = true;
            this.lblsenha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsenha2.Location = new System.Drawing.Point(6, 103);
            this.lblsenha2.Name = "lblsenha2";
            this.lblsenha2.Size = new System.Drawing.Size(63, 20);
            this.lblsenha2.TabIndex = 9;
            this.lblsenha2.Text = "senha:";
            // 
            // txbemailedicao
            // 
            this.txbemailedicao.Location = new System.Drawing.Point(143, 71);
            this.txbemailedicao.Name = "txbemailedicao";
            this.txbemailedicao.Size = new System.Drawing.Size(213, 20);
            this.txbemailedicao.TabIndex = 12;
            // 
            // lblnome2
            // 
            this.lblnome2.AutoSize = true;
            this.lblnome2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome2.Location = new System.Drawing.Point(6, 31);
            this.lblnome2.Name = "lblnome2";
            this.lblnome2.Size = new System.Drawing.Size(136, 20);
            this.lblnome2.TabIndex = 7;
            this.lblnome2.Text = "nome completo:";
            // 
            // txbnomeedicao
            // 
            this.txbnomeedicao.Location = new System.Drawing.Point(143, 31);
            this.txbnomeedicao.Name = "txbnomeedicao";
            this.txbnomeedicao.Size = new System.Drawing.Size(213, 20);
            this.txbnomeedicao.TabIndex = 11;
            // 
            // lblemail2
            // 
            this.lblemail2.AutoSize = true;
            this.lblemail2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail2.Location = new System.Drawing.Point(6, 69);
            this.lblemail2.Name = "lblemail2";
            this.lblemail2.Size = new System.Drawing.Size(56, 20);
            this.lblemail2.TabIndex = 8;
            this.lblemail2.Text = "email:";
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(17, 153);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(335, 47);
            this.btneditar.TabIndex = 10;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // grbapagar
            // 
            this.grbapagar.Controls.Add(this.lblapagar);
            this.grbapagar.Controls.Add(this.btnapagar);
            this.grbapagar.Enabled = false;
            this.grbapagar.Location = new System.Drawing.Point(32, 516);
            this.grbapagar.Name = "grbapagar";
            this.grbapagar.Size = new System.Drawing.Size(746, 54);
            this.grbapagar.TabIndex = 3;
            this.grbapagar.TabStop = false;
            this.grbapagar.Text = "Apagar";
            // 
            // lblapagar
            // 
            this.lblapagar.AutoSize = true;
            this.lblapagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapagar.Location = new System.Drawing.Point(87, 18);
            this.lblapagar.Name = "lblapagar";
            this.lblapagar.Size = new System.Drawing.Size(321, 20);
            this.lblapagar.TabIndex = 7;
            this.lblapagar.Text = "Selecione o usuario que deseja apagar";
            // 
            // btnapagar
            // 
            this.btnapagar.Location = new System.Drawing.Point(487, 13);
            this.btnapagar.Name = "btnapagar";
            this.btnapagar.Size = new System.Drawing.Size(253, 35);
            this.btnapagar.TabIndex = 4;
            this.btnapagar.Text = "Apagar";
            this.btnapagar.UseVisualStyleBackColor = true;
            this.btnapagar.Click += new System.EventHandler(this.btnapagar_Click);
            // 
            // dgvUsuarios1
            // 
            this.dgvUsuarios1.AllowUserToAddRows = false;
            this.dgvUsuarios1.AllowUserToDeleteRows = false;
            this.dgvUsuarios1.AllowUserToResizeColumns = false;
            this.dgvUsuarios1.AllowUserToResizeRows = false;
            this.dgvUsuarios1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios1.Location = new System.Drawing.Point(32, 23);
            this.dgvUsuarios1.Name = "dgvUsuarios1";
            this.dgvUsuarios1.ReadOnly = true;
            this.dgvUsuarios1.Size = new System.Drawing.Size(757, 266);
            this.dgvUsuarios1.TabIndex = 4;
            this.dgvUsuarios1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios1_CellClick);
            // 
            // FrmGestaoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 573);
            this.Controls.Add(this.dgvUsuarios1);
            this.Controls.Add(this.grbapagar);
            this.Controls.Add(this.grbEdicao);
            this.Controls.Add(this.grbCadastro);
            this.Name = "FrmGestaoUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGestaoUsuarios";
            this.grbCadastro.ResumeLayout(false);
            this.grbCadastro.PerformLayout();
            this.grbEdicao.ResumeLayout(false);
            this.grbEdicao.PerformLayout();
            this.grbapagar.ResumeLayout(false);
            this.grbapagar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCadastro;
        private System.Windows.Forms.GroupBox grbEdicao;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.GroupBox grbapagar;
        private System.Windows.Forms.TextBox txbsenha;
        private System.Windows.Forms.TextBox txbemail;
        private System.Windows.Forms.TextBox txbnome;
        private System.Windows.Forms.Button btncadastras;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txbsenhaedicao;
        private System.Windows.Forms.Label lblsenha2;
        private System.Windows.Forms.TextBox txbemailedicao;
        private System.Windows.Forms.Label lblnome2;
        private System.Windows.Forms.TextBox txbnomeedicao;
        private System.Windows.Forms.Label lblemail2;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnapagar;
        private System.Windows.Forms.Label lblapagar;
        private System.Windows.Forms.DataGridView dgvUsuarios1;
    }
}
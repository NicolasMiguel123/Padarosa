namespace Padarosa
{
    partial class FormMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.btngestaoprodutos = new System.Windows.Forms.Button();
            this.btncomandas = new System.Windows.Forms.Button();
            this.btncaixa = new System.Windows.Forms.Button();
            this.btnusuario = new System.Windows.Forms.Button();
            this.lblusuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrincipal.Location = new System.Drawing.Point(279, 6);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(206, 31);
            this.lblPrincipal.TabIndex = 1;
            this.lblPrincipal.Text = "Menu Principal";
            // 
            // btngestaoprodutos
            // 
            this.btngestaoprodutos.BackColor = System.Drawing.Color.White;
            this.btngestaoprodutos.Location = new System.Drawing.Point(235, 52);
            this.btngestaoprodutos.Name = "btngestaoprodutos";
            this.btngestaoprodutos.Size = new System.Drawing.Size(309, 34);
            this.btngestaoprodutos.TabIndex = 2;
            this.btngestaoprodutos.Text = "Gestão de Produtos";
            this.btngestaoprodutos.UseVisualStyleBackColor = false;
            this.btngestaoprodutos.Click += new System.EventHandler(this.btngestaoprodutos_Click);
            // 
            // btncomandas
            // 
            this.btncomandas.BackColor = System.Drawing.Color.White;
            this.btncomandas.Location = new System.Drawing.Point(235, 92);
            this.btncomandas.Name = "btncomandas";
            this.btncomandas.Size = new System.Drawing.Size(309, 34);
            this.btncomandas.TabIndex = 3;
            this.btncomandas.Text = "Lançamento de Comandas";
            this.btncomandas.UseVisualStyleBackColor = false;
            this.btncomandas.Click += new System.EventHandler(this.btncomandas_Click);
            // 
            // btncaixa
            // 
            this.btncaixa.BackColor = System.Drawing.Color.White;
            this.btncaixa.Location = new System.Drawing.Point(235, 132);
            this.btncaixa.Name = "btncaixa";
            this.btncaixa.Size = new System.Drawing.Size(309, 34);
            this.btncaixa.TabIndex = 4;
            this.btncaixa.Text = "Caixa";
            this.btncaixa.UseVisualStyleBackColor = false;
            this.btncaixa.Click += new System.EventHandler(this.btncaixa_Click);
            // 
            // btnusuario
            // 
            this.btnusuario.BackColor = System.Drawing.Color.White;
            this.btnusuario.Location = new System.Drawing.Point(235, 172);
            this.btnusuario.Name = "btnusuario";
            this.btnusuario.Size = new System.Drawing.Size(309, 34);
            this.btnusuario.TabIndex = 5;
            this.btnusuario.Text = "Gestão de Usuários";
            this.btnusuario.UseVisualStyleBackColor = false;
            this.btnusuario.Click += new System.EventHandler(this.btnusuario_Click);
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(10, 228);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(213, 19);
            this.lblusuario.TabIndex = 6;
            this.lblusuario.Text = "Você esta logado como - usuario";
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 257);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.btnusuario);
            this.Controls.Add(this.btncaixa);
            this.Controls.Add(this.btncomandas);
            this.Controls.Add(this.btngestaoprodutos);
            this.Controls.Add(this.lblPrincipal);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormMenuPrincipal";
            this.Text = "FormMenuPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.Button btngestaoprodutos;
        private System.Windows.Forms.Button btncomandas;
        private System.Windows.Forms.Button btncaixa;
        private System.Windows.Forms.Button btnusuario;
        private System.Windows.Forms.Label lblusuario;
    }
}
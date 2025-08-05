using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Padarosa
{
    public partial class FrmGestaoProduto : Form
    {
        // Variavel global:
        Model.Usuario usuario;
        Model.Produto produto = new Model.Produto();
        Model.Categoria Categoria = new Model.Categoria();
        public FrmGestaoProduto(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            // Obter as Categorias do banco:
            DataTable resultadoCategoria = Categoria.Listar();

            foreach(DataRow linha  in resultadoCategoria.Rows)
            {
                cmbcategoria.Items.Add($"{linha["id"]} - {linha["nome"]}");
            }

            // Puxar o dados da tabela "produtos"
            Atualizardgv();
        }

        public void Atualizardgv()
        {
            dgvProdutos.DataSource = produto.Listar();
        }
        private void btncadastrarproduto_Click(object sender, EventArgs e)
        {
            // Validação de erro:
            if (txbcadastrarpreco.Text.Length < 2)
            {
                MessageBox.Show("O preço informado é invalido!", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbcadastrarproduto.Text.Length < 2)
            {
                MessageBox.Show("O nome informado é invalido!", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbcategoria.Text.Length == 0)
            {
                MessageBox.Show("O produto cadastrado invalido!", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Inicia edição no bd:
                Model.Produto produto = new Model.Produto();
                produto.nome = txbcadastrarproduto.Text;
                produto.preco = double.Parse(txbcadastrarpreco.Text);
               // produto.id_categoria = int.Parse(txbcadastrarcategoria.Text);
                produto.id_respcadastro = usuario.Id;

                if (produto.Cadastrar())
                {
                    MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Limpar os campos de cadastro
                    txbcadastrarproduto.Clear();
                    txbcadastrarpreco.Clear();
                    //txbcadastrarcategoria.Clear();
                    Atualizardgv();
                }
                else
                {
                    MessageBox.Show("falha ao cadastrar o produto", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btneditarproduto_Click(object sender, EventArgs e)
        {
            // Validação de erro:
            if (txbeditarproduto.Text.Length < 2)
            {
                MessageBox.Show("O produto informado é invalido!", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbeditarpreco.Text.Length < 2)
            {
                MessageBox.Show("O preço informado é invalido!", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbeditarcategoria.Text.Length < 2)
            {
                MessageBox.Show("A categoria esta errada!", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Inicia edição no bd:
                // Instanciar o usuario
                Model.Produto produto = new Model.Produto();
                produto.nome = txbcadastrarproduto.Text;
                produto.preco = double.Parse(txbcadastrarpreco.Text);
                //produto.id_categoria = int.Parse(txbcadastrarcategoria.Text);
                produto.id_respcadastro = produto.Id;

                if (usuario.Cadastrar())
                {
                    MessageBox.Show("Usuario cadastradi com sucesso!!", "Sucesso!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Limpar os campos 
                    //cmbcategoria.Clear();
                    txbcadastrarpreco.Clear();
                    txbcadastrarproduto.Clear();

                    // Atualizar o dgv (reexecutar o SELECT):
                    Atualizardgv();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar o usuario!", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaSelecionada = dgvProdutos.SelectedCells[0].RowIndex;

            this.produto.nome = dgvProdutos.Rows[linhaSelecionada].Cells[1].Value.ToString();
            this.produto.preco = (double)dgvProdutos.Rows[linhaSelecionada].Cells[2].Value;
            this.produto.id_categoria = (int)dgvProdutos.Rows[linhaSelecionada].Cells[3].Value;
            this.produto.Id = (int)dgvProdutos.Rows[linhaSelecionada].Cells[0].Value;
            // Atribuir os dados da linha selecionada no grbEditar:
            txbeditarcategoria.Text = this.produto.id_categoria.ToString();
            txbeditarpreco.Text = this.produto.preco.ToString();
            txbeditarproduto.Text = this.produto.nome;

            // Ativar o grbEditar
            grpeditarprodutos.Enabled = true;

            // Ativar o grbApagar
            grbapagarproduto.Enabled = true;
        }

        private void btnapagarproduto_Click(object sender, EventArgs e)
        {
            DialogResult apagar = MessageBox.Show("Tem certza que quer apagar este produto?", "ATENÇÃO!!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (apagar == DialogResult.Yes)
            {
                // Executar o delete no bd

                // o id ja esta no usuario global
                if (this.produto.Remover())
                {
                    MessageBox.Show("Produto Removido com sucesso!!", "Sucesso!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Atualizardgv();

                    // Limpar os campos e desabilitar os gdvrbd:
                    grbapagarproduto.Enabled = false;
                    grbapagarproduto.Enabled = false;
                    txbeditarcategoria.Clear();
                    txbeditarpreco.Clear();
                    txbeditarproduto.Clear();
                }
                else
                {
                    MessageBox.Show("Falha ao Remover o produto!", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

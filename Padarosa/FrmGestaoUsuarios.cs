using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padarosa
{
    public partial class FrmGestaoUsuarios : Form
    {
        // Variavel global:
        Model.Usuario usuario;
        private string email;

        public FrmGestaoUsuarios(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            // Puxar o dados da tabela "usuarios"
            Atualizardgv();
        }

        public void Atualizardgv()
        {
            dgvUsuarios1.DataSource = usuario.Listar();   
           // dgvusarios.DataSource = usuario.Listar();
        }

        private void btncadastras_Click(object sender, EventArgs e)
        {
            // Validação de erro:
            if(txbemail.Text.Length < 6)
            {
                MessageBox.Show("O e-mail informado é invalido!", "ERROR!!", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if(txbnome.Text.Length < 7) 
            {
                MessageBox.Show("O nome informado é invalido!", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txbsenha.Text.Length < 6)
            {
                MessageBox.Show("A senha deve ter no minimo 6 caracteres!", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Inicia edição no bd:
                Model.Usuario usuario = new Model.Usuario();
                usuario.Email = txbemail.Text;
                usuario.NomeCompleto = txbnome.Text;
                usuario.Senha = txbsenha.Text;

                if (usuario.Cadastrar())
                {
                    MessageBox.Show("Usuario cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Limpar os campos de cadastro
                    txbemail.Clear();
                    txbnome.Clear();
                    txbsenha.Clear();
                    //Atualiza o dgv (reexecutando o select);
                    Atualizardgv();
                }
                else
                {
                    MessageBox.Show("fala ao cadastrar o usuario", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            // Validação de erro:
            if (txbemailedicao.Text.Length < 6)
            {
                MessageBox.Show("O e-mail informado é invalido!", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbnomeedicao.Text.Length < 7)
            {
                MessageBox.Show("O nome informado é invalido!", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbsenhaedicao.Text.Length < 6)
            {
                MessageBox.Show("A senha deve ter no minimo 6 caracteres!", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Inicia edição no bd:
                this.usuario.NomeCompleto = txbnomeedicao.Text;
                this.usuario.Email = txbemailedicao.Text;
                this.usuario.Senha = txbsenhaedicao.Text;
                // Instanciar o usuario
                Model.Usuario usuario = new Model.Usuario();
                usuario.Email = txbemail.Text;
                usuario.Senha = txbsenha.Text;
                usuario.NomeCompleto = txbnome.Text;

                if (usuario.Cadastrar())
                {
                    MessageBox.Show("Usuario cadastradi com sucesso!!", "Sucesso!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Limpar os campos 
                    txbnome.Clear();
                    txbemail.Clear();
                    txbsenha.Clear();

                    // Atualizar o dgv (reexecutar o SELECT):
                    Atualizardgv();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar o usuario!", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnapagar_Click(object sender, EventArgs e)
        {
            DialogResult apagar = MessageBox.Show("Tem certza que quer apagar este usuario?", "ATENÇÃO!!",MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if(apagar == DialogResult.Yes)
            {
                // Executar o delete no bd

                // o id ja esta no usuario global
                if (this.usuario.Remover())
                {
                    MessageBox.Show("Usuario Removido com sucesso!!", "Sucesso!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Atualizardgv();

                    // Limpar os campos e desabilitar os gdvrbd:
                    grbapagar.Enabled = false;
                    grbapagar.Enabled = false;
                    txbemailedicao.Clear();
                    txbnomeedicao.Clear();
                    txbsenhaedicao.Clear();
                }
                else
                {
                    MessageBox.Show("Falha ao Remover o usuario!", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
        }

        private void dgvUsuarios1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaSelecionada = dgvUsuarios1.SelectedCells[0].RowIndex;

            this.usuario.NomeCompleto = dgvUsuarios1.Rows[linhaSelecionada].Cells[1].Value.ToString();
            this.usuario.Email = dgvUsuarios1.Rows[linhaSelecionada].Cells[2].Value.ToString();
            this.usuario.Id = (int)dgvUsuarios1.Rows[linhaSelecionada].Cells[0].Value;
            // Atribuir os dados da linha selecionada no grbEditar:
            txbnomeedicao.Text = Name;
            txbemailedicao.Text = email;
            // Ativar o grbEditar
            grbEdicao.Enabled = true;

            // Ativar o grbApagar
            grbapagar.Enabled = true;
        }
    }
}

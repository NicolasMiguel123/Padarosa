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
    public partial class FrmGestaoProduto : Form
    {
        // Variavel global:
        Model.Usuario usuario;
        public FrmGestaoProduto(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void btncadastrarproduto_Click(object sender, EventArgs e)
        {
            // Validação de erro:
            if (txbcadastrarcategoria.Text.Length < 6)
            {
                MessageBox.Show("O Produto informado é invalido!", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbcadastrarpreco.Text.Length < 7)
            {
                MessageBox.Show("O preço é invalido!", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbcadastrarproduto.Text.Length < 6)
            {
                MessageBox.Show("O Cadastro do produto esta invalido!", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Inicia edição no bd:
                

                if (usuario.Cadastrar())
                {
                    MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Limpar os campos de cadastro
                    txbcadastrarcategoria.Clear();
                    txbcadastrarpreco.Clear();
                    txbcadastrarproduto.Clear();
                    //Atualiza o dgv (reexecutando o select)
                }
                else
                {
                    MessageBox.Show("fala ao cadastrar o usuario", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btneditarproduto_Click(object sender, EventArgs e)
        {

        }
    }
}

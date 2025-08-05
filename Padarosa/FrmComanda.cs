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
    public partial class FrmComanda : Form
    {
        // Variavel global:
        Model.Usuario usuario;

        Model .Produto produto = new Model .Produto ();
        Model.OrdemComanda ordemComanda = new Model .OrdemComanda ();
        public FrmComanda(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            Atualizardgv();
        }

        public void Atualizardgv()
        {
            dgvComandas.DataSource = produto.Listar();
        }

        private void btncontinuar_Click(object sender, EventArgs e)
        {
            if(txbcastrarcomanda.Text == "")
            {
                MessageBox.Show("Informe o número da comanda" , "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txbcastararproduto.Text == "")
            {
                MessageBox.Show("Informe o código do produto", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Habilitar o comando de lançamento:
                grblancamento.Enabled = true;
                txblancarproduto.Enabled = false;

                // Desativar o grbInfos:
                grbinformacao.Enabled = false;
            }
        }

        private void dgvComandas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           int linhaselecionada = dgvComandas.SelectedCells[0].RowIndex;
            txbcastararproduto.Text = dgvComandas.Rows[linhaselecionada].Cells[0].Value.ToString();
           txblancarproduto.Text = dgvComandas.Rows[linhaselecionada].Cells[1].Value.ToString();
        }

        public void ResetarCampos()
        {
            grbinformacao.Enabled = false;
            grblancamento.Enabled = true;

            // Limpar campos
            txbcastararproduto.Clear();
            txblancarquantidade.Clear();
            txblancarproduto.Clear();
            txbcastrarcomanda.Clear();
        }

        private void btnlancar_Click(object sender, EventArgs e)
        {
            if(txblancarquantidade.Text == "")
            {
                MessageBox.Show("Informe a quantidade do produto","ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult r = MessageBox.Show("Tem certeza que deseja lançar" + $"{txblancarquantidade.Text} usuarios de {txblancarproduto.Text} na comanda{txbcastrarcomanda.Text}?" 
                    , "ATENÇÃO!!" , MessageBoxButtons.YesNo , MessageBoxIcon.Question);

                // Se "sim":
                if(r == DialogResult.Yes)
                {
                    ordemComanda.idresp = usuario.Id;
                    ordemComanda.idproduto = int.Parse(txbcastararproduto.Text);
                    ordemComanda.idficha = int.Parse(txbcastrarcomanda.Text);
                    ordemComanda.quantidade = int.Parse(txblancarquantidade.Text);
                    ordemComanda.situacao = 1;
                    if (ordemComanda.Cadastrar())
                    {
                        MessageBox.Show("Lançamento efetuado com sucesso", "SUCESSO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Falha ao efetuar o lançamento", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Resetar os campos
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ResetarCampos();
        }
    }
}

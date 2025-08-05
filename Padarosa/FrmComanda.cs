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
           txblancarproduto.Text = dgvComandas.Rows[linhaselecionada].Cells[0].Value.ToString();
           txblancarcomandas.Text = dgvComandas.Rows[linhaselecionada].Cells[1].Value.ToString();
        }

        private void btnlancar_Click(object sender, EventArgs e)
        {
            if(txblancarproduto.Text == "")
            {
                MessageBox.Show("Informe a quantidade do produto","ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult r = MessageBox.Show("Tem certeza que deseja lançar" + $"{txblancarproduto.Text} usuarios de {txblancarcomandas.Text} na comanda{txbcastrarcomanda.Text}?");
                // Se "sim":
                if(r == DialogResult.Yes)
                {
                    ordemComanda.idresp = usuario.Id;
                    ordemComanda.idproduto = int.Parse(txblancarproduto.Text);
                    ordemComanda.idficha = int.Parse(txblancarcomandas.Text);
                    ordemComanda.quantidade = int.Parse(txblancarproduto.Text);
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
    }
}

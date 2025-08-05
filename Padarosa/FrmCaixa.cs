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
    public partial class FrmCaixa : Form
    {
        // Variavel global:
        Model.Usuario usuario;
        Model.OrdemComanda OrdemComanda = new Model.OrdemComanda();
        public FrmCaixa(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if(txbnumerocomandacaixa.Text == "" || txbnumerocomandacaixa.Text.Length < 2)
            {
                MessageBox.Show("Informe corretamente o número da ficha!!", "ATENÇÃO!!" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                OrdemComanda.idficha = int.Parse(txbnumerocomandacaixa.Text);
                DataTable consulta = OrdemComanda.BuscarFicha();

                // Verificar se existe lançamentos na comanda
                if(consulta.Rows.Count == 0)
                {
                    MessageBox.Show("Não existe lançamento desta comanda!!", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Mostrar a consulta no dgv
                    dgvCaixa.DataSource = consulta;
                    // Mostrar o total no lbl:
                    lbltotal.Text = "R$" + consulta.Compute("Sum(total_item)", "True").ToString();
                }
            }
        }

        private void chbpagamentorecebido_CheckedChanged(object sender, EventArgs e)
        {
            btnencerrarcomanda.Enabled = chbpagamentorecebido.Checked;
        }

        private void btnencerrarcomanda_Click(object sender, EventArgs e)
        {
            DialogResult pergunta = MessageBox.Show($"Tem certeza que deseja encerrar a comanda?{OrdemComanda.idficha}", "ATENÇÃO!!", MessageBoxButtons.OK, MessageBoxIcon.Question);

            if(pergunta == DialogResult.Yes)
            {
                if (OrdemComanda.Encerrar())
                {
                    MessageBox.Show("Comanda encerrada!!", "SUCESSO!!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    // desabilitar o botão de encerrar e o chb:
                    btnencerrarcomanda.Enabled = false;
                    chbpagamentorecebido.Checked = false;
                    // limpar o dgv
                    dgvCaixa.DataSource = null;
                    // apagar o numero da comanda:
                    dgvCaixa.DataSource = null;
                    // apagar numero da comanda:
                    txbnumerocomandacaixa.Clear();
                    // Resetar o lbltotal
                    lbltotal.Text = "R$ 0,00";  
                }
            }
        }
    }
}

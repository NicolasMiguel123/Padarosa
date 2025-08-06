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
    public partial class FormMenuPrincipal : Form
    {
        // Variaveis globais:
        Model.Usuario usuario;
        public FormMenuPrincipal(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            lblusuario.Text = $"Você esta logado como : {usuario.NomeCompleto}";


            // Ocultar ps botoes de usuarios e produto
            if(usuario.Id != 1)
            {
                btnusuario.Visible = false;
                btngestaoprodutos.Visible = false;
            }
        }

        private void btngestaoprodutos_Click(object sender, EventArgs e)
        {
            FrmGestaoProduto frmGestaoProduto = new FrmGestaoProduto(usuario);
            frmGestaoProduto.ShowDialog();
        }

        private void btncomandas_Click(object sender, EventArgs e)
        {
            FrmComanda frmComanda = new FrmComanda(usuario);
            frmComanda.ShowDialog();
        }

        private void btncaixa_Click(object sender, EventArgs e)
        {
            FrmCaixa frmCaixa = new FrmCaixa(usuario);
            frmCaixa.ShowDialog();
        }

        private void btnusuario_Click(object sender, EventArgs e)
        {
            FrmGestaoUsuarios frmGestaoUsuarios = new FrmGestaoUsuarios(usuario);
            frmGestaoUsuarios.ShowDialog();
        }
    }
}

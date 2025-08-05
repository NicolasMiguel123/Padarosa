using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyEncryption;
using MySqlConnector;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Padarosa.Model
{
    internal class OrdemComanda
    {
        public int id { get; set; }
        public int idficha { get; set; }
        public int idproduto { get; set; }
        public int quantidade { get; set; }
        public int idresp { get; set; }
        public DateTime dataadic {  get; set; }
        public int situacao { get; set; }

        public DataTable Listar()
        {
            string comando = "SELECT * FROM ordem_comanda";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Prepare();
            // Declarar tabela que irá receber o resultado:
            DataTable tabela = new DataTable();
            // Preencher a tabela com o resultado da consulta
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }

        public bool Cadastrar()
        {
            string comando = "INSERT INTO ordens_comandas (id_ficha, id_produto, quantidade, id_resp, situacao) " +
                "VALUES (@id_ficha, @id_produto, @quantidade, @id_resp, @situacao)";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@id_ficha", idficha);
            cmd.Parameters.AddWithValue("@id_produto" , idproduto);
            cmd.Parameters.AddWithValue("@quantidade" , quantidade);
            cmd.Parameters.AddWithValue("@id_resp", idresp);
            cmd.Parameters.AddWithValue("@siatucao", situacao);
            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }
    }
}

using System;
using System.Data.SqlClient;
using System.Data;
using Modelos;

namespace DAL
{
    public class DALCategoria
    {
        int id;
        private DALConexao conexao;
        private SqlCommand cmd;
        public DALValidacoes v = new DALValidacoes();

        #region Conexão
        public DALCategoria(DALConexao con)
        {
            conexao = con;
        }
        #endregion
        
        #region Incluir
        public string Incluir(ModCatergoria md)
        {
            //Se TRUE retorna mensagem de alerta, se FALSE Insere os dados
            if (v.Existe(SELECT(md.Categoria)))
                return "Categoria já cadastrada !";
            else
            {
                string inserir = "INSERT INTO TB_Categoria(Categoria)" +
                                 "VALUES(@Cat)";

                cmd = new SqlCommand(inserir, conexao.Con);
                cmd.Parameters.AddWithValue("@Cat", md.Categoria);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();

                return "Cadastrado com sucesso !";
            }
        }
        #endregion
        
        #region Excluir
        public string Excluir(ModCatergoria md)
        {
            //Se TRUE retorna mensagem de alerta, se FALSE Exclui os dados
            if (!v.Existe(SELECT(md.Categoria)))
                return "O registro não existe !";
            else
            {
                string Deletar = "DELETE FROM TB_Categoria WHERE Categoria='" + md.Categoria + "'";

                cmd = new SqlCommand(Deletar, conexao.Con);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();

                return "Excluído com sucesso !";
            }
                
        }
        #endregion
        
        #region Alterar
        public string Alterar(ModCatergoria md)
        {
            if (v.Existe(SELECT(md.Categoria)))
            {
                return "Categoria já cadastrada !";
            }
            else
            {
                cmd = new SqlCommand();

                cmd.Connection = conexao.Con;
                cmd.CommandText = "UPDATE TB_Categoria SET Categoria = @cat WHERE ID_Categoria= @id";
                cmd.Parameters.AddWithValue("@cat", md.Categoria);
                cmd.Parameters.AddWithValue("@id", md.Id);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();

                return "Categoria alterada com sucesso !";
            }
        }
        #endregion
        
        #region Localizar
        public DataTable Localizar(String valor, bool IdOuCat)
        {
            try
            {
                if (IdOuCat == true)
                {
                    string comando = "SELECT ID_Categoria as 'Código', Categoria as 'Categoria' FROM TB_Categoria WHERE Categoria LIKE '%"
                                          + valor + "%' ORDER BY Categoria";
                    DataTable tabela = new DataTable();
                    SqlDataAdapter DA = new SqlDataAdapter(comando, conexao.StrCon);
                    DA.Fill(tabela);
                    return tabela;
                }
                else
                {
                    string comando = "SELECT ID_Categoria as 'Código', Categoria as 'Categoria' FROM TB_Categoria WHERE ID_Categoria LIKE '%"
                                        + valor + "%' ORDER BY Categoria";
                    DataTable tabela = new DataTable();
                    SqlDataAdapter DA = new SqlDataAdapter(comando, conexao.StrCon);
                    DA.Fill(tabela);
                    return tabela;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
            
        }
        #endregion
       
        #region Retorna Categoria ordenada por nome
        public DataTable GetCategoria()
        {
            DataTable cat = new DataTable();

            DALConexao cn = new DALConexao(DALDadosConexao.ConStr);
            SqlCommand cmd = new SqlCommand("Select ID_Categoria, Categoria From TB_Categoria ORDER BY Categoria", cn.Con);
            {
                cn.Conectar();
                cat.Load(cmd.ExecuteReader());
            }
            return cat;
        }
        #endregion
        
        #region Retorna ID da categoria
        public int GetIDCategoria(string cat)
        {
            
            cmd = new SqlCommand("SELECT ID_Categoria FROM TB_Categoria WHERE Categoria=@C", conexao.Con);
            cmd.Parameters.AddWithValue("@C", cat);
            conexao.Conectar();
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                id = int.Parse(DR["ID_Categoria"].ToString());

            }

            conexao.Desconectar();
            return id;
        }
        #endregion
        
        #region SELECT
        private string SELECT(string md)
        {
            return "Select * FROM TB_Categoria WHERE Categoria='" + md + "'";
        }
        #endregion

    }
}

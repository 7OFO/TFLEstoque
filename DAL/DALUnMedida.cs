using System;
using System.Data.SqlClient;
using System.Data;
using Modelos;

namespace DAL
{
    public class DALUnMedida
    {
        int id;
        private DALConexao conexao; 
        private SqlCommand cmd;
        public DALValidacoes v = new DALValidacoes();
        

        #region Conexão
        public DALUnMedida(DALConexao con)
        {
            conexao = con;
        }
        #endregion

        #region Incluir
        public string Incluir(ModUnMedida md)
        {
            if (v.Existe(SELECT(md.Medida)))
                return "Unidade de Medida já cadastrada !";
            else
            {
                conexao.Desconectar();

                string inserir = "INSERT INTO TB_UMedida(Medida)" +
                             "VALUES(@Med)";

                cmd = new SqlCommand(inserir, conexao.Con);
                cmd.Parameters.AddWithValue("@Med", md.Medida);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                return "Cadastrado com sucesso !";
            }
        }
        #endregion

        #region Excluir
        public string Excluir(ModUnMedida md)
        {
            if (v.Existe(SELECT(md.Medida)))
            {
                string Deletar = "DELETE FROM TB_UMedida WHERE Medida='" + md.Medida + "'";

                cmd = new SqlCommand(Deletar, conexao.Con);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();

                return "Excluído com sucesso !";
            }
            else
                return "O registro não existe !";
        }
        #endregion

        #region Alterar
        public string Alterar(ModUnMedida md)
        {
            if (v.Existe(SELECT(md.Medida)))
            {
                return "Unidade de Medida já cadastrada !";
            }
            else
            {
                conexao.Desconectar();
                cmd = new SqlCommand();

                cmd.Connection = conexao.Con;
                cmd.CommandText = "UPDATE TB_UMedida SET Medida = @med WHERE ID_UMedida= @id";
                cmd.Parameters.AddWithValue("@med", md.Medida);
                cmd.Parameters.AddWithValue("@id", md.Id);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                return "Unidade de Medida alterada com sucesso !";
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
                    string comando = "SELECT ID_UMedida as 'Código', Medida as 'Un.Medida' FROM TB_UMedida WHERE Medida LIKE '%"
                                        + valor + "%' ORDER BY Medida";
                    DataTable tabela = new DataTable();
                    SqlDataAdapter DA = new SqlDataAdapter(comando, conexao.StrCon);
                    DA.Fill(tabela);
                    return tabela;
                }
                else
                {
                    string comando = "SELECT ID_UMedida as 'Código', Medida as 'Un.Medida' FROM TB_UMedida WHERE ID_UMedida LIKE '%"
                                        + valor + "%' ORDER BY ID_UMedida";
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
            finally
            {
                conexao.Desconectar();
            }

        }
        #endregion

        #region Retorna a Unidade de medida ordenada por nome
        public DataTable GetUnMedida()
        {
            DataTable Um = new DataTable();

            DALConexao cn = new DALConexao(DALDadosConexao.ConStr);
            SqlCommand cmd = new SqlCommand("Select ID_UMedida, Medida From TB_UMedida ORDER BY Medida", cn.Con);
            {
                cn.Conectar();
                Um.Load(cmd.ExecuteReader());
            }
            return Um;
        }
        #endregion

        #region Retorna o ID da Unidade de Medida
        public int GetIDUnMedida(string m)
        {

            cmd = new SqlCommand("SELECT ID_UMedida FROM TB_UMedida WHERE Medida=@MED", conexao.Con);
            cmd.Parameters.AddWithValue("@MED", m);
            conexao.Conectar();
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                id = int.Parse(DR["ID_UMedida"].ToString());

            }

            conexao.Desconectar();
            return id;
        }
        #endregion

        #region SELECT
        private string SELECT(string md)
        {
            return "Select * FROM TB_UMedida WHERE Medida='" + md + "'";
        }
        #endregion

    }
}

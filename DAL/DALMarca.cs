using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Modelos;

namespace DAL
{
    public class DALMarca
    {
        int id;
        private DALConexao conexao;
        private SqlCommand cmd;

        #region Conexão
        public DALMarca(DALConexao con)
        {
            conexao = con;
        }
        #endregion
        //-------------------------------------------------\\
        #region Incluir
        public string Incluir(ModSubCategoria md)
        {
            string Validar = "Select * FROM TB_Marcas WHERE Marca='" + md.Marca + "'";

            cmd = new SqlCommand(Validar, conexao.Con);
            SqlDataReader DA = null;
            conexao.Conectar();
            DA = cmd.ExecuteReader();

            if (DA.Read())
            {
                return "Marca já cadastrada !";
            }
            else
            {
                conexao.Desconectar();
                string inserir = "INSERT INTO TB_Marcas(Marca)" +
                             "VALUES(@Marca)";

                cmd = new SqlCommand(inserir, conexao.Con);
                cmd.Parameters.AddWithValue("@Marca", md.Marca);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                return "Cadastrado com sucesso !";
            }
        }
        #endregion
        //-------------------------------------------------\\
        #region Excluir
        public string Excluir(ModSubCategoria md)
        {
            if (Validar(md.Marca))
            {
                string Deletar = "DELETE FROM TB_Marcas WHERE Marca='" + md.Marca + "'";

                cmd = new SqlCommand(Deletar, conexao.Con);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();

                return "Excluído com sucesso !";
            }
            else
            {
                return "O registro não existe !";
            }
        }
        #endregion
        //-------------------------------------------------\\
        #region Alterar
        public string Alterar(ModSubCategoria md)
        {
            string Validar = "Select * FROM TB_Marcas WHERE Marca='" + md.Marca + "'";

            cmd = new SqlCommand(Validar, conexao.Con);
            SqlDataReader DA = null;
            conexao.Conectar();
            DA = cmd.ExecuteReader();

            if (DA.Read())
            {
                return "Marca já cadastrada !";
            }
            else
            {
                conexao.Desconectar();
                cmd = new SqlCommand();

                cmd.Connection = conexao.Con;
                cmd.CommandText = "UPDATE TB_Marcas SET Marca = @mrc WHERE ID_Marca= @id";
                cmd.Parameters.AddWithValue("@mrc", md.Marca);
                cmd.Parameters.AddWithValue("@id", md.Id);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                return "Marca alterada com sucesso !";
            }
        }
        #endregion
        //-------------------------------------------------\\
        #region Localizar
        public DataTable Localizar(String valor, bool IdOuMarc)
        {
            if (IdOuMarc == true)
            {
                string comando = "SELECT ID_Marca as 'Código', Marca as 'Marca' FROM TB_Marcas WHERE Marca LIKE '%"
                                      + valor + "%' ORDER BY Marca";
                DataTable tabela = new DataTable();
                SqlDataAdapter DA = new SqlDataAdapter(comando, conexao.StrCon);
                DA.Fill(tabela);
                return tabela;
            }
            else
            {
                string comando = "SELECT ID_Marca as 'Código', Marca as 'Marca' FROM TB_Marcas WHERE ID_Marca LIKE '%"
                                    + valor + "%' ORDER BY Marca";
                DataTable tabela = new DataTable();
                SqlDataAdapter DA = new SqlDataAdapter(comando, conexao.StrCon);
                DA.Fill(tabela);
                return tabela;
            }
        }
        #endregion
        //-------------------------------------------------\\
        #region Retorna a marca ordenada por nome
        public DataTable GetMarca()
        {
            DataTable marca = new DataTable();

            DALConexao cn = new DALConexao(DALDadosConexao.ConStr);
            SqlCommand cmd = new SqlCommand("Select ID_Marca, Marca From TB_Marcas ORDER BY Marca", cn.Con);
            {
                cn.Conectar();
                marca.Load(cmd.ExecuteReader());
            }
            return marca;
        }
        #endregion
        //-------------------------------------------------\\
        #region Retorna ID da marca
        public int GetIDMarca(string mar)
        {

            cmd = new SqlCommand("SELECT ID_Marca FROM TB_Marcas WHERE Marca=@M", conexao.Con);
            cmd.Parameters.AddWithValue("@M", mar);
            conexao.Conectar();
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                id = int.Parse(DR["ID_Marca"].ToString());

            }

            conexao.Desconectar();
            return id;
        }
        #endregion

        public bool Validar(string marca)
        {
            string Validar = "Select * FROM TB_Marcas WHERE Marca='" + marca + "'";

            try
            {
                cmd = new SqlCommand(Validar, conexao.Con);
                SqlDataReader DA = null;
                conexao.Conectar();
                DA = cmd.ExecuteReader();
                if (DA.Read())
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao tentar validar MARCA\n" + ex.Message);
    }
            finally
            {
                conexao.Desconectar();
            }
            
        }
    }
}

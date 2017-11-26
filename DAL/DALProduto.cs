                        using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Modelos;

namespace DAL
{
    public class DALProduto
    {
        private DALConexao conexao;
        private SqlCommand cmd;

        #region Conexão
        public DALProduto(DALConexao con)
        {
            conexao = con;
        }
        #endregion
        //-------------------------------------------------\\
        #region Incluir
        public string Incluir(ModProduto md)
        {
            string Validar = "Select * FROM TB_Produto WHERE ID_Produto = '" + md.Id + "'";

            cmd = new SqlCommand(Validar, conexao.Con);
            SqlDataReader DA = null;
            conexao.Conectar();
            DA = cmd.ExecuteReader();

            if(DA.Read())
            {
                return "Produto já cadastrado !";
            }
            else
            {
                conexao.Desconectar();

                string inserir = "INSERT INTO TB_Produto(Produto, " +
                                                     "Descricao, " +
                                                     "ID_Categoria, " +
                                                     "ID_Marca, " +
                                                     "ID_UMedida, " +
                                                     "EMinimo, " +
                                                     "EMaximo, " +
                                                     "Data_Cadastro)" +
                                                     
                                                     "VALUES(@PROD, @DESC," +
                                                            "@CATE, @MARC, @UMED, " +
                                                            "@EMIN, @EMAX, @DATA)";
                cmd = new SqlCommand(inserir, conexao.Con);
                cmd.Parameters.AddWithValue("@PROD", md.Prod);
                cmd.Parameters.AddWithValue("@DESC", md.Descricao);
                cmd.Parameters.AddWithValue("@CATE", md.Categoria);
                cmd.Parameters.AddWithValue("@MARC", md.Marca);
                cmd.Parameters.AddWithValue("@UMED", md.Unidade_Medida);
                cmd.Parameters.AddWithValue("@EMIN", md.EMinimo);
                cmd.Parameters.AddWithValue("@EMAX", md.EMaximo);
                cmd.Parameters.AddWithValue("@DATA", md.Data);

                conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                return "Cadastrado com Sucesso !";

            }
        }
        #endregion
    }
}

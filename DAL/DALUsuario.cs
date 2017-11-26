using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Modelos;
using System.Data;

namespace DAL
{
    public class DALUsuario
    {
        private DALConexao conexao;
        private SqlCommand cmd;

        #region Conexão
        public DALUsuario(DALConexao con)
        {
            conexao = con;
        }
        #endregion
        //-------------------------------------------------\\
        #region Incluir
        public string Incluir(ModUsuario md)
        {
            string Validar = "Select * FROM TB_Usuario WHERE Login = '" + md.Login + "'";

            cmd = new SqlCommand(Validar, conexao.Con);
            SqlDataReader DA = null;
            conexao.Conectar();
            DA = cmd.ExecuteReader();

            if (DA.Read())
            {
                return "Usuário já cadastrado !";
            }
            else
            {
                conexao.Desconectar();


                string inserir = "INSERT INTO TB_Usuario(Login," +
                                                        "Senha," +
                                                        "Tipo, " +
                                                        "Status," +
                                                        "Data_Cadastro)" +
                                 "VALUES(@Use, @Sen, @Tip, @Stat, @Data)";

                cmd = new SqlCommand(inserir, conexao.Con);
                cmd.Parameters.AddWithValue("@Use", md.Login);
                cmd.Parameters.AddWithValue("@Sen", md.Senha);
                cmd.Parameters.AddWithValue("@Tip", md.Tipo);
                cmd.Parameters.AddWithValue("@Stat", md.Status);
                cmd.Parameters.AddWithValue("@Data", md.Data);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                return "Cadastrado com sucesso !";
            }
        }
        #endregion
        //-------------------------------------------------\\
        #region Valida USUÁRIO
        public string ValidaUsuario(ModUsuario md)
        {
            string Validar = "Select * FROM TB_Usuario WHERE Login='" + md.Login + "' and Senha='" + md.Senha + "'";
            if(conexao.Con!=null)
            {
                cmd = new SqlCommand(Validar, conexao.Con);
                SqlDataReader DA = null;
                conexao.Conectar();
                DA = cmd.ExecuteReader();

                if (DA.Read())
                {

                    Dal.Default.Nivel = DA.GetValue(1).ToString();
                    return Dal.Default.User = DA.GetValue(4).ToString();
                }
                else
                    return "Usuário não cadastrado";
            }
            else
                throw new Exception("Impossível se conectar");
        }
        #endregion
    }
}

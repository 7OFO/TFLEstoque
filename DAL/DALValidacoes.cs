using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Modelos;

namespace DAL{
    public class DALValidacoes{

        private SqlCommand cmd;
        private DALConexao conexao = new DALConexao(DALDadosConexao.ConStr);

        #region Verifica se o Registro Existe
        public bool Existe(String comando){
            
            cmd = new SqlCommand();
            cmd.CommandText = comando;
            cmd.Connection = conexao.Con;
                SqlDataReader DA = null;
            try{
                conexao.Conectar();
                DA = cmd.ExecuteReader();

                if (DA.Read())
                    return true;
                else
                    return false;
            }
            catch (Exception ex){
                throw new Exception("Falha ao tentar validar\n" +
                                     ex.Message);
            }
            finally{
                conexao.Desconectar();
            }
        }
        #endregion
    }
}

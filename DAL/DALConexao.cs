using System;
using System.Data.SqlClient;

//classe de manipulaçao da conexão
namespace DAL
{
    public class DALConexao
    {
        #region Conexão
        public SqlConnection Con { get; set; }
        #endregion

        #region String de conexão
        public String StrCon { get;}
        #endregion

        #region Construtor que recebe como parâmetro a string de Conexão e instancia o objeto conexão
        public DALConexao(String DadosCon)
        {
            StrCon = DadosCon;
            Con = new SqlConnection(StrCon);
        }
        #endregion

        #region Abre a conexão
        public void Conectar()
        {
            try
            { 
                if (Con.State == System.Data.ConnectionState.Open)
                    Con.Close();

                Con.Open();
            }
            catch (Exception e)
            {
                throw new Exception("Falha ao tentar estabelecer a conexão",e);
            }
            
        }
        #endregion

        #region Fecha a conexão
        public void Desconectar()
        {
            if(Con.State == System.Data.ConnectionState.Open)
                Con.Close();
        }
        #endregion
    }

}
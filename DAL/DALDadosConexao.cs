using System;

namespace DAL
{
    public class DALDadosConexao
    {
        
        #region String de Conexão
        public static String ConStr
        {
            //"Data Source=localhost;Initial Catalog=Banco_Teste;User Id=sa;Password=123456"
            
            get
            {   
                //Retorno da string de conexão
                return @"Data Source=" + Environment.MachineName +
                                   @"\"+ Dal.Default.SQLNamespace +
                    ";Initial Catalog="+ Dal.Default.BDName + 
                            ";User Id="+ Dal.Default.UserName +
                           ";Password="+ Dal.Default.Password + "";
            }
        }

       
        #endregion
    }
}

using DAL;
using Modelos;

namespace BLL
{
    public class BLLUsuario
    {
        private DALConexao conexao;

        #region conexão
        public BLLUsuario(DALConexao con)
        {
            conexao = con;
        }
        #endregion

        #region Incluir Usuário
        public string IncluirUsuaio(ModUsuario md, int tam, int senha)
        {
            if (tam == 0)
                return "O campo login deve ser preenchido !\n";
            else
            {
                if (senha == 0)
                {
                    return "O campo senha deve ser preenchido !";
                }
                else
                {
                    DALUsuario user = new DALUsuario(conexao);
                    return user.Incluir(md);
                }
            }
        }
        #endregion

        #region Validar Usuário
        public string ValidarUsuaio(ModUsuario md)
        {
            DALUsuario user = new DALUsuario(conexao);
            return user.ValidaUsuario(md);

        }
        #endregion

    }
}

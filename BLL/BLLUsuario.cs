using DAL;
using Modelos;

namespace BLL
{
    public class BLLUsuario
    {
        private DALConexao conexao;
        
        public BLLUsuario(DALConexao con)
        {
            conexao = con;
        }
        
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
       
        public string ValidarUsuaio(ModUsuario md)
        {
            DALUsuario user = new DALUsuario(conexao);
            return user.ValidaUsuario(md);

        }
    }
}

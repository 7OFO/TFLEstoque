using DAL;
using Modelos;

namespace BLL{
    public class BLLUsuario{
        private DALConexao conexao;
        
        public BLLUsuario(DALConexao con){
            conexao = con;
        }
        
        public string IncluirUsuaio(ModUsuario md, int tam, int senha, string senha1, string senha2){
            if (tam == 0)
                return "O campo login deve ser preenchido !";
            else{
                if (senha == 0){
                    return "O campo senha deve ser preenchido !";
                }
                else{
                    if (senha1 != senha2) {
                        return "As Senhas não coincidem !";
                    }
                    else {
                        DALUsuario user = new DALUsuario(conexao);
                        return user.Incluir(md);
                    }
                }
            }
        }
       
        public string ValidarUsuaio(ModUsuario md){

            DALUsuario user = new DALUsuario(conexao);
            return user.ValidaUsuario(md);

        }
    }
}

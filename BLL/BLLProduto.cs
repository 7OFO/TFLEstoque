using DAL;
using Modelos;

namespace BLL
{
    public class BLLProduto
    {
        private DALConexao conexao;
        
        public BLLProduto(DALConexao con)
        {
            conexao = con;
        }
        
        public string IncluirProd(ModProduto md)
        {
            DALProduto Prod = new DALProduto(conexao);
            return Prod.Incluir(md);
        }
    }
}

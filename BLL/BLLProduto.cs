using DAL;
using Modelos;

namespace BLL
{
    public class BLLProduto
    {
        private DALConexao conexao;

        #region Conexão
        public BLLProduto(DALConexao con)
        {
            conexao = con;
        }
        #endregion

        #region Incluir Produto
        public string IncluirProd(ModProduto md)
        {
            DALProduto Prod = new DALProduto(conexao);
            return Prod.Incluir(md);
        }
        #endregion
    }
}

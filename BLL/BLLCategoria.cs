using System;
using System.Data;

//Projeto
using DAL;
using Modelos;


namespace BLL
{
    public class BLLCategoria
    {
        private DALConexao conexao;

        #region Conexão
        public BLLCategoria(DALConexao con)
        {
            conexao = con;
        }
        #endregion

        #region Incluir Categoria
        public string IncluirCategoria(ModCatergoria md, int tam)
        {
            if (tam == 0)
                return "O campo 'Categoria' deve ser preenchido !";
            else
            {
                DALCategoria categoria = new DALCategoria(conexao);
                return categoria.Incluir(md);
            }
        }
        #endregion

        #region Alterar Categoria
        public string AlterarCategoria(ModCatergoria md, int tam)
        {
            if (tam == 0)
                return "O campo 'Categoria' deve ser preenchido !";
            else
            {
                DALCategoria categoria = new DALCategoria(conexao);
                return categoria.Alterar(md);
            }
        }
        #endregion

        #region Excluir Categoria
        public string ExcluirCategoria(ModCatergoria md, int tam, string valida)
        {
            if (tam == 0)
                return "Registro deve ser diferente de vazio !";
            else
            {
                if (md.Categoria == valida)
                {
                    DALCategoria cat = new DALCategoria(conexao);
                    return cat.Excluir(md);
                }
                else
                    return "O nome do Registro não pode ser alterado !";
            }
        }
        #endregion

        #region Localizar Categoria
        public DataTable LocalizarCategoria(String valor, bool IdOuCat)
        {
            DALCategoria categoria = new DALCategoria(conexao);
            return categoria.Localizar(valor, IdOuCat);
        }
        #endregion
    }
}

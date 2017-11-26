using System;

//Projeto
using DAL;
using Modelos;
using System.Data;

namespace BLL
{
    public class BLLUnMedida
    {
        private DALConexao conexao;
        
        public BLLUnMedida(DALConexao con)
        {
            conexao = con;
        }
        
        public string IncluirUnMed(ModUnMedida md, int tam)
        {
            if (tam == 0)
                return "O campo 'Unidade de Medida' é exigido !";
            else
            {
                DALUnMedida UnMed = new DALUnMedida(conexao);
                return UnMed.Incluir(md);
            }

        }
        
        public string AlterarUMedida(ModUnMedida md, int tam)
        {
            if (tam == 0)
                return "O campo 'Unidade de Medida' deve ser preenchido !";
            else
            {
                DALUnMedida med = new DALUnMedida(conexao);
                return med.Alterar(md);
            }
        }
        
        public string ExcluirUMedida(ModUnMedida md, int tam, string valida)
        {
            if (tam == 0)
                return "Registro deve ser diferente de vazio !";
            else
            {
                if (md.Medida == valida)
                {
                    DALUnMedida med = new DALUnMedida(conexao);
                    return med.Excluir(md);
                }else
                    return "O nome do Registro não pode ser alterado !";
            }
        }
        
        public DataTable LocalizarUMedida(String valor, bool IdOuUn)
        {
            DALUnMedida med = new DALUnMedida(conexao);
            return med.Localizar(valor, IdOuUn);
        }
    }
}

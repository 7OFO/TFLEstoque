using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModProduto
    {
        #region Id       

        private int _id;
        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }
        #endregion

        #region Prod       
        private string _prod;
        public string Prod
        {
            get
            {
                return _prod;
            }

            set
            {
                _prod = value;
            }
        }
        #endregion

        #region Descrição       
        private string _descricao;
        public string Descricao
        {
            get
            {
                return _descricao;
            }

            set
            {
                _descricao = value;
            }
        }
        #endregion

        #region Categoria       
        private int _categoria;
        public int Categoria
        {
            get
            {
                return _categoria;
            }

            set
            {
                _categoria = value;
            }
        }
        #endregion

        #region Marca       
        private int _marca;
        public int Marca
        {
            get
            {
                return _marca;
            }

            set
            {
                _marca = value;
            }
        }
        #endregion

        #region Unidade_Medida       
        private int _unidade_Medida;
        public int Unidade_Medida
        {
            get
            {
                return _unidade_Medida;
            }

            set
            {
                _unidade_Medida = value;
            }
        }
        #endregion

        #region Fornecedor       
        private int _fornecedor;
        public int Fornecedor
        {
            get
            {
                return _fornecedor;
            }

            set
            {
                _fornecedor = value;
            }
        }
        #endregion

        #region Estoque Minimo       
        private double _eMinimo;
        public double EMinimo
        {
            get
            {
                return _eMinimo;
            }

            set
            {
                _eMinimo = value;
            }
        }
        #endregion

        #region Estoque Maximo      
        private double _eMaximo;
        public double EMaximo
        {
            get
            {
                return _eMaximo;
            }

            set
            {
                _eMaximo = value;
            }
        }
        #endregion

        #region Data       
        private string _data;
        public string Data
        {
            get
            {
                return _data;
            }

            set
            {
                _data = value;
            }
        }
        #endregion
        
    }
}

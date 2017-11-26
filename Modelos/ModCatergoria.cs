using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModCatergoria
    {
        #region ID
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        #endregion

        #region Categoria
        private string _categoria;
        public string Categoria
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

    }
}

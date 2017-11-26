using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModUnMedida
    {
        #region ID

        private int _Id;
        public int Id
        {
         get { return _Id; }
         set { _Id = value; }
        }
        #endregion

        #region Medida
        private string _Medida;
        public string Medida
        {
            get { return _Medida; }
            set { _Medida = value; }
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModUsuario
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        #region Usuário
        private string _login;
        public string Login
        {
            get
            {
                return _login;
            }

            set
            {
                _login = value;
            }
        }
        #endregion

        #region Senha
        private string _senha;
        public string Senha
        {
            get
            {
                return _senha;
            }

            set
            {
                _senha = value;
            }
        }
        #endregion

        #region Tipo
        private string _tipo;
        public string Tipo
        {
            get
            {
                return _tipo;
            }

            set
            {
                _tipo = value;
            }
        }
        #endregion

        #region Status
        private bool _status;
        public bool Status
        {
            get
            {
                return _status;
            }

            set
            {
                _status = value;
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

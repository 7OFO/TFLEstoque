using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace GUI
{
    public partial class FrmConsultaCategoria : Form
    {
        public FrmConsultaCategoria()
        {
            InitializeComponent();
        }

        public void Localizar()
        {
            bool IdOuCat;
            if (cBoxTipoPesquisa.SelectedIndex == 0)
                IdOuCat = true;
            else
                IdOuCat = false;

            DALConexao cn = new DALConexao(DALDadosConexao.ConStr);
            BLLCategoria bll = new BLLCategoria(cn);
            GridDados.DataSource = bll.LocalizarCategoria(tBoxConsulta.Text, IdOuCat);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmModeloConsulta_Load(object sender, EventArgs e)
        {
            AlterarCor(GridDados);
            Localizar();
            cBoxTipoPesquisa.SelectedIndex = 0;
        }

        public void AlterarCor(DataGridView dt)
        {
            dt.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dt.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private void tBoxConsulta_TextChanged(object sender, EventArgs e)
        {
            Localizar();
        }

        private void TtbtnLocalizar_Click(object sender, EventArgs e)
        {
            Localizar();
        }
    }
}

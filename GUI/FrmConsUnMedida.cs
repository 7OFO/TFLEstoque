using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DAL;
using BLL;
using Modelos;
using System.Linq;

namespace GUI
{
    public partial class FrmConsUnMedida : GUI.FrmModConsulta
    {
        Formularios f;

        public FrmConsUnMedida()
        {
            InitializeComponent();
        }

       
        //---------------------------------------------------------------
        //  Botões de consulta por Click ou Textchanged
        //---------------------------------------------------------------
        #region Consulta/Localizar
        private void tBoxConsulta_TextChanged(object sender, EventArgs e)
        {
            f.Localizar(GridDados, cBoxTipoPesquisa, tBoxConsUMed); 
        }
        #endregion
        private void FrmConsUnMedida_Load(object sender, EventArgs e)
        {
            
            f = new Formularios();
            f.AlterarCor(GridDados);
            f.Localizar(GridDados, cBoxTipoPesquisa, tBoxConsUMed);
            cBoxTipoPesquisa.SelectedIndex = 0;
            SORT();

        }

        private void cBoxTipoPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cBoxTipoPesquisa.SelectedIndex >=0)
            SORT();
        }
        public void SORT()
        {
            GridDados.Sort(GridDados.Columns[cBoxTipoPesquisa.SelectedIndex], ListSortDirection.Ascending);
        }

        private void GridDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridDados[0, e.RowIndex].Value.ToString() == "")
                MessageBox.Show("Impossível selecionar um registro inexistente !", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Properties.Settings.Default["idMedida"] = Convert.ToInt32(GridDados[0, e.RowIndex].Value);
                Properties.Settings.Default["medida"] = (GridDados[1, e.RowIndex].Value).ToString();

                Properties.Settings.Default.editar = true;
                Properties.Settings.Default.Save();
                f.ShowOrCreate<FrmCadUnMedida>();
                this.Close();
            }
            
        }

        
    }
}

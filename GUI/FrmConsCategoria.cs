using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmConsCategoria : GUI.FrmModConsulta
    {
        Formularios f = new Formularios();
        public FrmConsCategoria()
        {
            InitializeComponent();
        }

        private void tBoxConsulta_TextChanged(object sender, EventArgs e)
        {
            f.Localizar(GridDados, cBoxTipoPesquisa, tBoxConsCat);
        }

        private void FrmConsCategoria_Load(object sender, EventArgs e)
        {
            f.AlterarCor(GridDados);
            f.Localizar(GridDados, cBoxTipoPesquisa, tBoxConsCat);
            cBoxTipoPesquisa.SelectedIndex = 0;
            SORT();
        }

        private void cBoxTipoPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxTipoPesquisa.SelectedIndex >= 0)
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
                Properties.Settings.Default["idCategoria"] = Convert.ToInt32(GridDados[0, e.RowIndex].Value);
                Properties.Settings.Default["categoria"] = (GridDados[1, e.RowIndex].Value).ToString();

                Properties.Settings.Default.editar = true;
                Properties.Settings.Default.Save();
                f.ShowOrCreate<FrmCadCategoria>();
                this.Close();
            }
        }
    }
}

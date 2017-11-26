using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DAL;
using Modelos;
using BLL;
using System.Data.SqlClient;

namespace GUI
{
    public partial class FrmProduto : GUI.FrmModeloDeCadastro
    {
        DALConexao cn = new DALConexao(DALDadosConexao.ConStr);
        DALMarca marc;
        DALCategoria cat;
        DALUnMedida umed;
        int ID_CAT, ID_UMED, ID_MARCA;
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void cBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            cat = new DALCategoria(cn);

            ID_CAT = cat.GetIDCategoria(cBoxCategoria.Text);
        }

        private void cBoxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            marc = new DALMarca(cn);

            ID_MARCA = marc.GetIDMarca(cBoxMarca.Text);
        }

        private void cBoxUnMed_SelectedIndexChanged(object sender, EventArgs e)
        {
            umed = new DALUnMedida(cn);

            ID_UMED = umed.GetIDUnMedida(cBoxUnMed.Text);
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            marc = new DALMarca(cn);
            tBoxProduto.Focus();
            cBoxMarca.DataSource = marc.GetMarca();
            cBoxMarca.ValueMember = "ID_Marca";
            cBoxMarca.DisplayMember = "Marca";
            //cBoxMarca.SelectedIndex = 1;
            cBoxMarca.Update();

            cat = new DALCategoria(cn);
            cBoxCategoria.DataSource = cat.GetCategoria();
            cBoxCategoria.ValueMember = "ID_Categoria";
            cBoxCategoria.DisplayMember = "Categoria";
            //cBoxCategoria.SelectedIndex = 1;
            cBoxCategoria.Update();

            umed = new DALUnMedida(cn);
            cBoxUnMed.DataSource = umed.GetUnMedida();
            cBoxUnMed.ValueMember = "ID_UMedida";
            cBoxUnMed.DisplayMember = "Medida";
            //cBoxUnMed.SelectedIndex = 1;
            cBoxUnMed.Update();
        }

        private void btdInserir_Click(object sender, EventArgs e)
        {
            ModProduto mod = new ModProduto();

            mod.Prod = tBoxProduto.Text;
            mod.Descricao = tBoxDescricao.Text;
            mod.Categoria = ID_CAT;
            mod.Marca = ID_MARCA;
            mod.Unidade_Medida = ID_UMED;
            mod.EMinimo = Convert.ToDouble(tBoxEMinimo.Text);
            mod.EMaximo = Convert.ToDouble(tBoxEMaximo.Text);
            mod.Data = DateTime.Today.ToShortDateString();

            DALConexao cn = new DALConexao(DALDadosConexao.ConStr);
            BLLProduto prod = new BLLProduto(cn);
            MessageBox.Show(prod.IncluirProd(mod));
        }
    }
}

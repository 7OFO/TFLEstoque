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


namespace GUI
{
    public partial class FrmCadCategoria : GUI.FrmModCad
    {
        Formularios i = new Formularios();
        public FrmCadCategoria()
        {
            InitializeComponent();
        }

        #region Inserir
        private void btnInserir_Click(object sender, EventArgs e)
        {
            tsCadStatus.Image = null;
            tsCadStatus.Text = "";
            tempo.Start();
            tsCadProgress.Value = 0;
            string mensagem = "";
            ModCatergoria mod = new ModCatergoria();

            mod.Categoria = tBoxCategoria.Text.ToUpper();

            DALConexao cn = new DALConexao(DALDadosConexao.ConStr);
            BLLCategoria u = new BLLCategoria(cn);
            mensagem = u.IncluirCategoria(mod, tBoxCategoria.TextLength);
            if (mensagem.Contains("sucesso"))
            {
                tsCadStatus.Text = mensagem;
                tsCadStatus.Image = Properties.Resources.Sucesso;
            }
            else
            {

                tsCadStatus.Text = mensagem;
                tsCadStatus.Image = Properties.Resources.Aviso;
            }

            tBoxCategoria.Clear();
            tBoxCategoria.Focus();
        }
        #endregion

        private void tempo_Tick(object sender, EventArgs e)
        {
            if (tsCadProgress.Value < 100)
                tsCadProgress.Increment(50);
            else
                tempo.Stop();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            tsCadStatus.Image = null;
            tsCadStatus.Text = "";
            tempo.Start();
            tsCadProgress.Value = 0;
            string mensagem = "";
            ModCatergoria md = new ModCatergoria();
            md.Categoria = tBoxCategoria.Text.ToUpper();
            md.Id = Convert.ToInt32(Properties.Settings.Default.idCategoria);
            DALConexao cn = new DALConexao(DALDadosConexao.ConStr);
            BLLCategoria u = new BLLCategoria(cn);

            mensagem = u.AlterarCategoria(md, tBoxCategoria.TextLength);

            if (mensagem.Contains("sucesso"))
            {
                MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK);
                tsCadStatus.Text = "";
                tsCadStatus.Image = null;
                tsCadProgress.Value = 0;

                tBoxCategoria.Clear();
                i.Novo(new Button[] { btnInserir, btnProcurar, btnEditar, btnExcluir, btnCancelar });
                FrmConsCategoria f = new FrmConsCategoria();
                f.MdiParent = FrmMain.ActiveForm;
                f.Show();
            }
            else
            {
                tsCadStatus.Text = mensagem;
                tsCadStatus.Image = Properties.Resources.Aviso;
            }


            tBoxCategoria.Focus();


        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            FrmConsCategoria f = new FrmConsCategoria();
            if (i.VerificaDisponibilidade(f.Name, FrmMain.ActiveForm))
            {
                f.MdiParent = FrmMain.ActiveForm;
                f.Show();
                f.StartPosition = FormStartPosition.CenterScreen;
            }
        }

        private void FrmCadCategoria_Enter(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.editar == true)
            {
                i = new Formularios();
                tBoxCategoria.Text = Properties.Settings.Default.categoria;
                i.Alterar(new Button[] { btnInserir, btnProcurar, btnEditar, btnExcluir, btnCancelar });
                Properties.Settings.Default.editar = false;
                Properties.Settings.Default.Save();
                tsCadStatus.Image = null;
                tsCadStatus.Text = "";
                tsCadProgress.Value = 0;
            }
        }

        private void FrmCadCategoria_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.editar == false)
                Properties.Settings.Default.editar = false;

            Properties.Settings.Default.Save();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmConsCategoria f = new FrmConsCategoria();
            tBoxCategoria.Clear();
            f.MdiParent = FrmMain.ActiveForm;
            f.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tsCadStatus.Image = null;
            tsCadStatus.Text = "";
            tempo.Start();
            tsCadProgress.Value = 0;
            string mensagem = "";
            ModCatergoria md = new ModCatergoria();
            md.Categoria = Properties.Settings.Default.categoria;
            md.Id = Convert.ToInt32(Properties.Settings.Default.idCategoria);
            DALConexao cn = new DALConexao(DALDadosConexao.ConStr);
            BLLCategoria u = new BLLCategoria(cn);

            mensagem = u.ExcluirCategoria(md, tBoxCategoria.TextLength, tBoxCategoria.Text);

            if (mensagem.Contains("sucesso"))
            {
                MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK);
                tsCadStatus.Text = "";
                tsCadStatus.Image = null;
                tsCadProgress.Value = 0;

                tBoxCategoria.Clear();
                i.Novo(new Button[] { btnInserir, btnProcurar, btnEditar, btnExcluir, btnCancelar });
                FrmConsCategoria f = new FrmConsCategoria();
                f.MdiParent = FrmMain.ActiveForm;
                f.Show();
            }
            else
            {
                tsCadStatus.Text = mensagem;
                tsCadStatus.Image = Properties.Resources.Aviso;
                tBoxCategoria.Text = md.Categoria;
            }


            tBoxCategoria.Focus();
        }
        

        private void FrmCadCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnInserir_Click(sender, e);
            if (e.KeyCode == Keys.Delete)
                btnExcluir_Click(sender, e);
        }
    }
}

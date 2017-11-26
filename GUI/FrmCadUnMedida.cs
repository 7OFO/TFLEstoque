using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using BLL;
using Modelos;
using DAL;


namespace GUI
{
    public partial class FrmCadUnMedida : GUI.FrmModCad
    {
        Formularios i;
        ModUnMedida m = new ModUnMedida();
        public FrmCadUnMedida(FrmConsUnMedida cons)
        {
            InitializeComponent();
        }
        public FrmCadUnMedida()
        {
            InitializeComponent();
        }

        //---------------------------------------------------------------
        //  Botão de inclusão dos dados
        //---------------------------------------------------------------
        #region Incluir()
        private void btnInserir_Click(object sender, EventArgs e)
        {
            tsCadStatus.Image = null;
            tsCadStatus.Text = ""; 
            tempo.Start();
            tsCadProgress.Value = 0;
            string mensagem = "";
            ModUnMedida mod = new ModUnMedida();

            mod.Medida = tBoxUnMed.Text.ToUpper();

            DALConexao cn = new DALConexao(DALDadosConexao.ConStr);
            BLLUnMedida u = new BLLUnMedida(cn);
            mensagem = u.IncluirUnMed(mod, tBoxUnMed.TextLength);
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

            tBoxUnMed.Clear();
            tBoxUnMed.Focus();

        }
        #endregion
        private void tempo_Tick(object sender, EventArgs e)
        {

            if (tsCadProgress.Value < 100)
                tsCadProgress.Increment(50);
            else
                tempo.Stop();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            i = new Formularios();
            FrmConsUnMedida f = new FrmConsUnMedida();
            if (i.VerificaDisponibilidade(f.Name, FrmMain.ActiveForm))
            {
                f.MdiParent = FrmMain.ActiveForm;
                f.Show();
            }
        }
        

        private void FrmCadUnMedida_Enter(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.editar == true)
            {
                i = new Formularios();
                tBoxUnMed.Text = Properties.Settings.Default.medida;
                i.Alterar(new Button[] { btnInserir, btnProcurar, btnEditar, btnExcluir, btnCancelar });
                Properties.Settings.Default.editar = false;
                Properties.Settings.Default.Save();
                tsCadStatus.Image = null;
                tsCadStatus.Text = "";
                tsCadProgress.Value = 0;
            }
        }

        private void FrmCadUnMedida_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.editar == false)
                Properties.Settings.Default.editar = false;

            Properties.Settings.Default.Save();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmConsUnMedida f = new FrmConsUnMedida();
            tBoxUnMed.Clear();
            f.MdiParent = FrmMain.ActiveForm;
            f.Show();
        }

        #region Alterar()
        private void btnEditar_Click(object sender, EventArgs e)
        {
            tsCadStatus.Image = null;
            tsCadStatus.Text = "";
            tempo.Start();
            tsCadProgress.Value = 0;
            string mensagem = "";
            ModUnMedida md = new ModUnMedida();
            md.Medida = tBoxUnMed.Text.ToUpper();
            md.Id = Convert.ToInt32(Properties.Settings.Default.idMedida);
            DALConexao cn = new DALConexao(DALDadosConexao.ConStr);
            BLLUnMedida u = new BLLUnMedida(cn);

            mensagem = u.AlterarUMedida(md, tBoxUnMed.TextLength);

            if (mensagem.Contains("sucesso"))
            {
                MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK);
                tsCadStatus.Text = "";
                tsCadStatus.Image = null;
                tsCadProgress.Value = 0;

                tBoxUnMed.Clear();
                i.Novo(new Button[] { btnInserir, btnProcurar, btnEditar, btnExcluir, btnCancelar });
                FrmConsUnMedida f = new FrmConsUnMedida();
                f.MdiParent = FrmMain.ActiveForm;
                f.Show();
            }
            else
            {
                tsCadStatus.Text = mensagem;
                tsCadStatus.Image = Properties.Resources.Aviso;
            }


            tBoxUnMed.Focus();
            

        }
        #endregion

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tsCadStatus.Image = null;
            tsCadStatus.Text = "";
            tempo.Start();
            tsCadProgress.Value = 0;
            string mensagem = "";
            ModUnMedida md = new ModUnMedida();
            md.Medida = Properties.Settings.Default.medida;
            md.Id = Convert.ToInt32(Properties.Settings.Default.idMedida);
            DALConexao cn = new DALConexao(DALDadosConexao.ConStr);
            BLLUnMedida u = new BLLUnMedida(cn);

            mensagem = u.ExcluirUMedida(md, tBoxUnMed.TextLength, tBoxUnMed.Text);

            if (mensagem.Contains("sucesso"))
            {
                MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK);
                tsCadStatus.Text = "";
                tsCadStatus.Image = null;
                tsCadProgress.Value = 0;

                tBoxUnMed.Clear();
                i.Novo(new Button[] { btnInserir, btnProcurar, btnEditar, btnExcluir, btnCancelar });
                FrmConsUnMedida f = new FrmConsUnMedida();
                f.MdiParent = FrmMain.ActiveForm;
                f.Show();
            }
            else
            {
                tsCadStatus.Text = mensagem;
                tsCadStatus.Image = Properties.Resources.Aviso;
                tBoxUnMed.Text = md.Medida;
            }


            tBoxUnMed.Focus();
        }
    }
}

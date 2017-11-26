using System;
using System.Windows.Forms;
using DAL;
using BLL;
using Modelos;

namespace GUI {
    public partial class frmCadUsuario : GUI.FrmModCad {
        public frmCadUsuario() {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e) {

            tsCadStatus.Image = null;
            tsCadStatus.Text = "";
            tempo.Start();
            tsCadProgress.Value = 0;

            string mensagem = "";
            ModUsuario mod = new ModUsuario();

            mod.Login = tBoxLogin.Text;
            mod.Senha = tBoxSenha.Text;
            if (rButtonAtivo.Checked == true)
                mod.Status = true;
            else
                mod.Status = false;
            mod.Tipo = cBoxTipo.Text;
            mod.Data = DateTime.Today.ToShortDateString();

            DALConexao cn = new DALConexao(DALDadosConexao.ConStr);
            BLLUsuario u = new BLLUsuario(cn);
            mensagem = u.IncluirUsuaio(mod, tBoxLogin.TextLength, tBoxSenha.TextLength, tBoxSenha.Text, tBoxCSenha.Text);

            if (mensagem.Contains("sucesso")) {
                tsCadStatus.Text = mensagem;
                tsCadStatus.Image = Properties.Resources.Sucesso;
            }
            else {
                tsCadStatus.Text = mensagem;
                tsCadStatus.Image = Properties.Resources.Aviso;
            }
        }

        private void tempo_Tick(object sender, EventArgs e) {
            if (tsCadProgress.Value < 100)
                tsCadProgress.Increment(50);
            else
                tempo.Stop();
        }
    }
}

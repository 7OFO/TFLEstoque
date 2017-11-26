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
                MessageBox.Show(mensagem, "sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tBoxLogin.Clear();
                tBoxSenha.Clear();
                tBoxCSenha.Clear();
                cBoxTipo.SelectedIndex = 0;
            }
            else
                MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}

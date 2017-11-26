using DAL;
using BLL;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmUsuario : GUI.FrmModeloDeCadastro
    {
        public FrmUsuario()
        {
            InitializeComponent();
            lblData.Text = DateTime.Today.ToShortDateString();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            string mensagem = "";
            ModUsuario mod = new ModUsuario();

            mod.Login = tBoxLogin.Text;
            mod.Senha = tBoxSenha.Text;
            if (rButtonAtivo.Checked == true)
                mod.Status = true;
            else
                mod.Status = false;
            mod.Tipo = cBoxTipo.Text;
            mod.Data = lblData.Text;

            DALConexao cn = new DALConexao(DALDadosConexao.ConStr);
            BLLUsuario u = new BLLUsuario(cn);
            if (tBoxCSenha.Text == tBoxSenha.Text)
            {
                //mensagem = u.IncluirUsuaio(mod, tBoxLogin.TextLength, tBoxSenha.TextLength);

                if (mensagem.Contains("sucesso"))
                {
                    MessageBox.Show(mensagem, "sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tBoxLogin.Clear();
                    tBoxSenha.Clear();
                    tBoxCSenha.Clear();
                    cBoxTipo.SelectedIndex = 0;
                }
                else
                    MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("As senhas não são iguais", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tBoxCSenha.Focus();
            }



            /*
                string mensagem = "";

                ModUsuario mod = new ModUsuario();

                mod.Login = tBoxLogin.Text;
                mod.Senha = tBoxSenha.Text;
                if (rButtonAtivo.Checked == true)
                    mod.Status = true;
                else
                    mod.Status = false;
                mod.Tipo = cBoxTipo.Text;
                mod.Data = lblData.Text;

                DALConexao cn = new DALConexao(DALDadosConexao.ConStr);
                BLLUsuario user = new BLLUsuario(cn);
                mensagem = user.IncluirUsuaio(mod);

                Erro.Clear();
                MessageBox.Show(mensagem);
                */

        }
    }
}

using System;
using System.Threading;
using System.Windows.Forms;
using DAL;
using Modelos;
using BLL;
using System.IO;
using System.Diagnostics;

namespace GUI
{
    public partial class FrmSplash : Form
    {

        public FrmSplash()
        {
                InitializeComponent();
        }

        private void FrmSplash_Load(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
                Application.Exit();
            else
                pBoxLoading.SizeMode = PictureBoxSizeMode.Zoom;

        }
        
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Formularios frm = new Formularios();
                Thread th;

            
                pBoxLoading.Visible = true;
                ModUsuario md = new ModUsuario();
                md.Login = tBoxLogin.Text;
                md.Senha = tBoxSenha.Text;

                DALConexao cn = new DALConexao(DAL.DALDadosConexao.ConStr);
                BLLUsuario bll = new BLLUsuario(cn);
            try
            {
                string msg, desc;
                if (!bll.ValidarUsuaio(md).Contains("não"))
                {
                   
                    Properties.Settings.Default.user = md.Login;
                    Properties.Settings.Default.Save();
                    MessageBox.Show(md.Login + " conectado com sucesso !", "Bem Vindo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.ExitThread();

                    th = new Thread(TelaMain);

                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                    msg = md.Login;
                    desc = "LOGADO COM SUCESSO";
                    frm.NovoLogLogin(msg, desc);
                    Application.ExitThread();
                }
                else
                {
                    MessageBox.Show("Falha ao conectar. Verifique seu Login e Senha !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tBoxLogin.Focus();
                    msg = md.Login;
                    desc = "LOGIN FALHOU";
                    frm.NovoLogLogin(msg, desc);
                    pBoxLoading.Visible = false;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                frm.NovoLogErro(ex.Message, ex.InnerException.ToString());
                pBoxLoading.Visible = false;
            
            }


        }
        private void tBoxLogin_Enter(object sender, EventArgs e)
        {
            if(tBoxLogin.Text == "Login" && lblLogin.Visible==false)
            {
                tBoxLogin.Clear();
                lblLogin.Visible = true;
            }
        }
        
        private void tBoxLogin_Leave(object sender, EventArgs e)
        {
            if (tBoxLogin.Text == "")
            {
                lblLogin.Visible = false;
                tBoxLogin.Text = "Login";
            }
        }

        private void FrmSplash_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnEntrar_Click(sender, e);
        }

        private void tBoxSenha_Enter(object sender, EventArgs e)
        {
            if (tBoxSenha.Text == "Senha"&&tBoxSenha.UseSystemPasswordChar == false)
            {
                tBoxSenha.Clear();
                lblSenha.Visible = true;
            }
        }

        private void tBoxSenha_Leave(object sender, EventArgs e)
        {
            if (tBoxSenha.Text == "")
            {
                lblSenha.Visible = false;
                tBoxSenha.Text = "Senha";
                tBoxSenha.UseSystemPasswordChar = false;
            }else
                tBoxSenha.UseSystemPasswordChar = true;


        }
        private void tBoxSenha_TextChanged(object sender, EventArgs e)
        {
            if (tBoxSenha.Text != "")
                tBoxSenha.UseSystemPasswordChar = true;
            else
                tBoxSenha.UseSystemPasswordChar = false;
        }
        private void TelaMain()
        {
            Application.Run(new FrmMain());
        }
        private void Splash()
        {
            Application.Run(new FrmSplash());
        }
    }
}

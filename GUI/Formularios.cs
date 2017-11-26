using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

//Projeto
using BLL;
using DAL;

namespace GUI
{
    public class Formularios
    {
        #region Gera Log de Erros Relacionados a conexão e ao Login
        public void NovoLogErro(string err, string desc)
        {
            string d = System.Environment.CurrentDirectory + @"\log";
            string l = @"\LOG_erro.log";
            if (!Directory.Exists(d))
            {
                Directory.CreateDirectory(d);
            }

                StreamWriter a = new StreamWriter(d + l, true);
                a.Close();


                StreamWriter arquivo = new StreamWriter(d + l, true);
                arquivo.WriteLine(DateTime.Now.ToString());
                arquivo.WriteLine(err);
                arquivo.WriteLine(desc);
                arquivo.WriteLine("\n");
                arquivo.Close();
        }
        
        public void NovoLogLogin(string msg, string titulo)
        {
            StreamWriter arquivo;
            string d = System.Environment.CurrentDirectory + @"\log";
            string l = @"\LOG_Login.log";
            if (!Directory.Exists(d))
            {
                Directory.CreateDirectory(d);
                
            }

                StreamWriter a = new StreamWriter(d + l, true);
                a.Close();


                FileInfo info = new FileInfo(d + l);

                if (info.Length > 2000)
                    arquivo = new StreamWriter(d + l, false);
                else
                    arquivo = new StreamWriter(d + l, true);


                arquivo.WriteLine(DateTime.Now.ToString());
                arquivo.WriteLine(titulo);
                arquivo.WriteLine("Usuário " + msg);
                arquivo.WriteLine("\n" + "________________________");
                arquivo.Close();
            
        }
        #endregion
        
        #region Balão de informação que retorna o nome da função do botão no Frm
        public void Balao(ToolTip dica, string nome, Button botao)
        {
            dica.Show(nome, botao);
        }
        #endregion
        
        #region Alterna as cores do Grid
        public void AlterarCor(DataGridView dt)
        {
            dt.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(127, 143, 172);
            GC.SuppressFinalize(this);
        }
        #endregion
        
        #region Localização dos dados por tipo de pesquisa
        public void Localizar(DataGridView dt, ComboBox c, TextBox t)
        {
            bool IdOuN;
            DALConexao cn = new DALConexao(DALDadosConexao.ConStr);
            if (t.Name == "tBoxConsUMed")
            {
                if (c.SelectedIndex == 0)
                    IdOuN = false;
                else
                    IdOuN = true;
                
                BLLUnMedida bll = new BLLUnMedida(cn);
                dt.DataSource = bll.LocalizarUMedida(t.Text, IdOuN);
            }
            else
            {
                if (t.Name == "tBoxConsCat")
                {
                    if (c.SelectedIndex == 0)
                        IdOuN = false;
                    else
                        IdOuN = true;

                    BLLCategoria bll = new BLLCategoria(cn);
                    dt.DataSource = bll.LocalizarCategoria(t.Text, IdOuN);
                }
            }
        }
        #endregion
        
        #region Altera Acesso dos Botões por meio da propriedade "enabled"
        public void Alterar(Button[] btn)
        {
            TextBox t = new TextBox();

            btn[0].Visible = false;
            btn[1].Visible = false;

            for (int i = 2; i < btn.Length; i++)
                btn[i].Visible = true;
                
        }

        public void Novo(Button[] btn)
        {
            btn[0].Visible = true;
            btn[1].Visible = true;
            for (int i = 2; i < btn.Length; i++)
                btn[i].Visible = false;
        }
        #endregion
        
        #region Verificar se algum Frm Filho está aberto
        public bool VerificaDisponibilidade(string nome, Form frm)
        {
            bool disponivel = true;

            foreach (Form f in frm.MdiChildren)
            {
                if (!f.Disposing && f.Name == nome)
                {
                    disponivel = false;
                    f.WindowState = FormWindowState.Normal;
                    f.StartPosition = FormStartPosition.CenterParent;
                }
            }
            return disponivel;
        }
        #endregion

        #region Cria um novo Frm ou apenas mostra caso ja esteja aberto, para que seja feita a transferência de dados do grid para o Frm de edição.
        public void ShowOrCreate<TForm>() where TForm : Form, new()
        {

            var instance = Application.OpenForms.OfType<TForm>().FirstOrDefault();
            if (instance == null)
            {
                instance = new TForm();
                instance.MdiParent = FrmMain.ActiveForm;

                instance.Show();

            }
            else {
                instance.Focus();
                instance.WindowState = FormWindowState.Normal;

            }
        }
        #endregion
    }
}

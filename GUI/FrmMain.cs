using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        #region Variáveis de Controle
        //Thread Responsavel por Alternar entre a tela de Login e a Main
        Thread th;
        //Classe que contém métodos úteis Relacionados a Estética dos FRM's
        Formularios f;
        //Variável responsável pelo controle da expansão dos Botões Principais
        int aux=1;
        //Variável responsável por redimencionar o painel interno do MDI
        int auxRetract = 0;
        #endregion
        
        #region Botões Fechar e Minimizar
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Método que mata o FRM Main e instancia o FRM Login
        private void NovaTela()
        {
            Application.Exit();
            Application.Run(new FrmLogin());
        }
        #endregion

        #region Abertura dos formulários de cadastro
        //***************Cadastro de Usuário*************
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            f = new Formularios();
            FrmUsuario frm = new FrmUsuario();
            if (f.VerificaDisponibilidade(frm.Name, this) == true)
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }
        //***************Cadastro de Unidades de Medida*************
        private void btnUnMedida_Click(object sender, EventArgs e)
        {
            f = new Formularios();
            FrmCadUnMedida frm = new FrmCadUnMedida();
            if (f.VerificaDisponibilidade(frm.Name, this) ==true)
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }
        //***************Cadastro de Marca/SubCategoria*************
        private void btnSCategoria_Click(object sender, EventArgs e)
        {
            f = new Formularios();
            FrmCadSubCategoria frm = new FrmCadSubCategoria();
            if (f.VerificaDisponibilidade(frm.Name, this) == true)
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }
        //***************Cadastro de Categoria*************
        private void btnCategoria_Click(object sender, EventArgs e)
        {
            f = new Formularios();
            FrmCadCategoria frm = new FrmCadCategoria();
            if (f.VerificaDisponibilidade(frm.Name, this) ==true)
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }
        //***************Cadastro de Produto*************
        private void btnProduto_Click(object sender, EventArgs e)
        {
            f = new Formularios();
            FrmProduto frm = new FrmProduto();
            if (f.VerificaDisponibilidade(frm.Name, this) == true)
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }
        #endregion

        #region Aspéctos estéticos do FRM Main

        private void DimDoPainelPrincipal()
        {
            int lar, alt;
            lar = Screen.PrimaryScreen.WorkingArea.Width;
            alt = Screen.PrimaryScreen.WorkingArea.Height;

            if (auxRetract == 0)
            {
                this.Size = new Size(lar, alt);

                foreach (var c in Controls)
                {
                    if (c is MdiClient)
                    {
                        var client = (MdiClient)c;
                        client.BackColor = SystemColors.Control;
                        client.Dock = DockStyle.None;
                        client.Size = new Size(lar - 205, alt - 25);
                        client.Location = new Point(207,0);

                        break;
                    }
                }
            }
            else
            {
                this.Size = new Size(lar, alt);

                foreach (var c in Controls)
                {
                    if (c is MdiClient)
                    {
                        var client = (MdiClient)c;
                        client.BackColor = SystemColors.Control;
                        client.Dock = DockStyle.None;
                        client.Size = new Size(lar, alt - 25);
                        client.Location = new Point(12, 0);

                        break;
                    }
                }
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            DimDoPainelPrincipal();
                try
                {
                    this.CenterToScreen();
                }
                catch
                {
                    MessageBox.Show("Saindo");
                }

                tStripUsuario.Text = DAL.Dal.Default.User;
                tStripNivelUsuario.Text = "Nível de Acesso : " + DAL.Dal.Default.Nivel;
            
        }
        #endregion

        #region "Expandir" ou "Retrair" Panel de cadastros 
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            if (aux == 0)
            {
                pnCadastro.Visible = false;
                this.aux = 1;
            }
            else
            {
                pnCadastro.Visible = true;
                this.aux = 0;
            }
        }
        #endregion

        #region Mudar Cor do Panel ao Entrar ou Sair com o mouse
        private void btnCadastro_MouseEnter(object sender, EventArgs e)
        {
            pnExpand.BackColor = Color.FromArgb(98, 116, 150);
        }

        private void btnCadastro_MouseLeave(object sender, EventArgs e)
        {
            pnExpand.BackColor = ((Button)sender).BackColor;
        }
        #endregion

        #region Altera cor dos Panel's e "Recua" o Panel Principal com os Botões
        private void pnExpand_Click(object sender, EventArgs e)
        {
            
            if (auxRetract == 0)
            {
                pnDash.Visible = false;
                pnExpand.BackgroundImage = Properties.Resources.expand;
                pnExpand.BackColor = btnCadastro.FlatAppearance.MouseOverBackColor;
                pnHeader.Size = new Size(160,0);
                auxRetract = 1;
            }
            else
            {
                pnDash.Visible = true;
                pnExpand.BackgroundImage = Properties.Resources.hide;
                pnExpand.BackColor = btnCadastro.BackColor;
                pnHeader.Size = new Size(370, 0);
                auxRetract = 0;
            }
            DimDoPainelPrincipal();
        }
        #endregion

        #region Volta para a tela Login e Finaliza a Main
        private void tStripSair_Click(object sender, EventArgs e)
        {
            if (Thread.CurrentThread.IsAlive)
            {
                Application.ExitThread();
                th = new Thread(NovaTela);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            
        }
        #endregion

    }
}

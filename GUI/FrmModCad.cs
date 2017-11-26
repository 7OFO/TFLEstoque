using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmModCad : Form
    {
        int X, Y;
        Formularios i;
        #region Acesso aos Botões
        public FrmModCad()
        {
            InitializeComponent();

            i = new Formularios();
            i.Novo(new Button[] { btnInserir, btnProcurar, btnEditar, btnExcluir, btnCancelar });
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            i.Novo(new Button[] { btnInserir, btnProcurar, btnEditar, btnExcluir, btnCancelar });
        }
        #endregion

        #region Fechar e Minimizar
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void tSCadastros_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region LOAD
        private void FrmModCad_Load(object sender, EventArgs e)
        {
            tsCadUsuario.Text = DAL.Dal.Default.User;
        }
        #endregion

        #region mover Frm
        private void pnCabecalho_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
        private void pnCabecalho_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }
        #endregion

        #region Balões de informação
        private void btnInserir_MouseHover(object sender, EventArgs e)
        {
            Formularios f = new Formularios();
            f.Balao(BalaoInfo, btnInserir.Name.Substring(3), btnInserir);
        }

        private void btnEditar_MouseHover(object sender, EventArgs e)
        {
            Formularios f = new Formularios();
            f.Balao(BalaoInfo, btnEditar.Name.Substring(3), btnEditar);
        }

        private void btnExcluir_MouseHover(object sender, EventArgs e)
        {
            Formularios f = new Formularios();
            f.Balao(BalaoInfo, btnExcluir.Name.Substring(3), btnExcluir);
        }

        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            Formularios f = new Formularios();
            f.Balao(BalaoInfo, btnCancelar.Name.Substring(3), btnCancelar);
        }

        private void btnProcurar_MouseHover(object sender, EventArgs e)
        {
            Formularios f = new Formularios();
            f.Balao(BalaoInfo, btnProcurar.Name.Substring(3), btnProcurar);
        }
        #endregion
        
    }
}

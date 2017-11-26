namespace GUI
{
    partial class FrmCadCategoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.tBoxCategoria = new System.Windows.Forms.TextBox();
            this.tempo = new System.Windows.Forms.Timer(this.components);
            this.pnCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icone)).BeginInit();
            this.pnInfoCad.SuspendLayout();
            this.pnAcoes.SuspendLayout();
            this.pnAcoesFilho.SuspendLayout();
            this.pn.SuspendLayout();
            this.SuspendLayout();
            // 
            // Icone
            // 
            this.Icone.BackgroundImage = global::GUI.Properties.Resources.Categoria;
            // 
            // pnInfoCad
            // 
            this.pnInfoCad.Size = new System.Drawing.Size(516, 61);
            // 
            // pnAcoes
            // 
            this.pnAcoes.Location = new System.Drawing.Point(0, 86);
            // 
            // btnInserir
            // 
            this.btnInserir.FlatAppearance.BorderSize = 0;
            this.btnInserir.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnProcurar
            // 
            this.btnProcurar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnProcurar.FlatAppearance.BorderSize = 0;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // pn
            // 
            this.pn.Controls.Add(this.lblCategoria);
            this.pn.Controls.Add(this.tBoxCategoria);
            this.pn.Location = new System.Drawing.Point(0, 18);
            this.pn.Size = new System.Drawing.Size(516, 43);
            // 
            // lblCadastro
            // 
            this.lblCadastro.Size = new System.Drawing.Size(169, 18);
            this.lblCadastro.Text = "Cadastro de Categoria";
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.ForeColor = System.Drawing.Color.White;
            this.lblCategoria.Location = new System.Drawing.Point(0, 4);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "Categoria";
            // 
            // tBoxCategoria
            // 
            this.tBoxCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxCategoria.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tBoxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxCategoria.ForeColor = System.Drawing.Color.Black;
            this.tBoxCategoria.Location = new System.Drawing.Point(0, 17);
            this.tBoxCategoria.Name = "tBoxCategoria";
            this.tBoxCategoria.Size = new System.Drawing.Size(516, 26);
            this.tBoxCategoria.TabIndex = 2;
            // 
            // tempo
            // 
            this.tempo.Interval = 1;
            this.tempo.Tick += new System.EventHandler(this.tempo_Tick);
            // 
            // FrmCadCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(516, 180);
            this.Name = "FrmCadCategoria";
            this.Text = "Cadastro de Categoria";
            this.Load += new System.EventHandler(this.FrmCadCategoria_Load);
            this.Enter += new System.EventHandler(this.FrmCadCategoria_Enter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadCategoria_KeyDown);
            this.pnCabecalho.ResumeLayout(false);
            this.pnCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icone)).EndInit();
            this.pnInfoCad.ResumeLayout(false);
            this.pnAcoes.ResumeLayout(false);
            this.pnAcoesFilho.ResumeLayout(false);
            this.pn.ResumeLayout(false);
            this.pn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox tBoxCategoria;
        private System.Windows.Forms.Timer tempo;
    }
}

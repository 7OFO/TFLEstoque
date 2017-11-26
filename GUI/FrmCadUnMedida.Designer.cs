namespace GUI
{
    partial class FrmCadUnMedida
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
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxUnMed = new System.Windows.Forms.TextBox();
            this.tempo = new System.Windows.Forms.Timer(this.components);
            this.pnCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icone)).BeginInit();
            this.pnInfoCad.SuspendLayout();
            this.pnAcoes.SuspendLayout();
            this.pnAcoesFilho.SuspendLayout();
            this.pn.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnCabecalho
            // 
            this.pnCabecalho.Size = new System.Drawing.Size(494, 25);
            this.pnCabecalho.TabIndex = 0;
            // 
            // Icone
            // 
            this.Icone.BackgroundImage = global::GUI.Properties.Resources.medida;
            // 
            // pnInfoCad
            // 
            this.pnInfoCad.Size = new System.Drawing.Size(494, 62);
            this.pnInfoCad.TabIndex = 0;
            // 
            // pnAcoes
            // 
            this.pnAcoes.Location = new System.Drawing.Point(0, 87);
            this.pnAcoes.Size = new System.Drawing.Size(494, 45);
            this.pnAcoes.TabIndex = 1;
            // 
            // pnAcoesFilho
            // 
            this.pnAcoesFilho.Size = new System.Drawing.Size(494, 34);
            this.pnAcoesFilho.TabIndex = 0;
            // 
            // btnInserir
            // 
            this.btnInserir.FlatAppearance.BorderSize = 0;
            this.btnInserir.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnProcurar
            // 
            this.btnProcurar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnProcurar.FlatAppearance.BorderSize = 0;
            this.btnProcurar.Location = new System.Drawing.Point(469, 0);
            this.btnProcurar.TabIndex = 1;
            this.btnProcurar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // pn
            // 
            this.pn.Controls.Add(this.label2);
            this.pn.Controls.Add(this.tBoxUnMed);
            this.pn.Size = new System.Drawing.Size(494, 45);
            this.pn.TabIndex = 0;
            // 
            // lblCadastro
            // 
            this.lblCadastro.Size = new System.Drawing.Size(237, 18);
            this.lblCadastro.Text = "Cadastro de Unidade de Medida";
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Location = new System.Drawing.Point(444, 0);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unidade de Medida";
            // 
            // tBoxUnMed
            // 
            this.tBoxUnMed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxUnMed.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tBoxUnMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxUnMed.ForeColor = System.Drawing.Color.Black;
            this.tBoxUnMed.Location = new System.Drawing.Point(0, 19);
            this.tBoxUnMed.Name = "tBoxUnMed";
            this.tBoxUnMed.Size = new System.Drawing.Size(494, 26);
            this.tBoxUnMed.TabIndex = 0;
            // 
            // tempo
            // 
            this.tempo.Interval = 1;
            this.tempo.Tick += new System.EventHandler(this.tempo_Tick);
            // 
            // FrmCadUnMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 167);
            this.Name = "FrmCadUnMedida";
            this.Text = "Cadastro de Un. Medida";
            this.Load += new System.EventHandler(this.FrmCadUnMedida_Load);
            this.Enter += new System.EventHandler(this.FrmCadUnMedida_Enter);
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

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer tempo;
        public System.Windows.Forms.TextBox tBoxUnMed;
    }
}

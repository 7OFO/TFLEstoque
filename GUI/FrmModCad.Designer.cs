namespace GUI
{
    partial class FrmModCad
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
            this.pnCabecalho = new System.Windows.Forms.Panel();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.Icone = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pnInfoCad = new System.Windows.Forms.Panel();
            this.pn = new System.Windows.Forms.Panel();
            this.tSCadastros = new System.Windows.Forms.ToolStrip();
            this.tsCadUsuario = new System.Windows.Forms.ToolStripLabel();
            this.tsCadSeparador1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsCadProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.tsCadSeparador2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsCadStatus = new System.Windows.Forms.ToolStripLabel();
            this.pnAcoes = new System.Windows.Forms.Panel();
            this.pnAcoesFilho = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.BalaoInfo = new System.Windows.Forms.ToolTip(this.components);
            this.pnCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icone)).BeginInit();
            this.pnInfoCad.SuspendLayout();
            this.tSCadastros.SuspendLayout();
            this.pnAcoes.SuspendLayout();
            this.pnAcoesFilho.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnCabecalho
            // 
            this.pnCabecalho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(116)))), ((int)(((byte)(150)))));
            this.pnCabecalho.Controls.Add(this.lblCadastro);
            this.pnCabecalho.Controls.Add(this.Icone);
            this.pnCabecalho.Controls.Add(this.btnMinimizar);
            this.pnCabecalho.Controls.Add(this.btnFechar);
            this.pnCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCabecalho.Location = new System.Drawing.Point(0, 0);
            this.pnCabecalho.Name = "pnCabecalho";
            this.pnCabecalho.Size = new System.Drawing.Size(516, 25);
            this.pnCabecalho.TabIndex = 3;
            this.pnCabecalho.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnCabecalho_MouseDown);
            this.pnCabecalho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnCabecalho_MouseMove);
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCadastro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.ForeColor = System.Drawing.Color.White;
            this.lblCadastro.Location = new System.Drawing.Point(38, 0);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(95, 18);
            this.lblCadastro.TabIndex = 5;
            this.lblCadastro.Text = "Cadastro de";
            this.lblCadastro.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnCabecalho_MouseDown);
            this.lblCadastro.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnCabecalho_MouseMove);
            // 
            // Icone
            // 
            this.Icone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Icone.Dock = System.Windows.Forms.DockStyle.Left;
            this.Icone.Location = new System.Drawing.Point(0, 0);
            this.Icone.Name = "Icone";
            this.Icone.Size = new System.Drawing.Size(38, 25);
            this.Icone.TabIndex = 4;
            this.Icone.TabStop = false;
            this.Icone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnCabecalho_MouseDown);
            this.Icone.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnCabecalho_MouseMove);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(116)))), ((int)(((byte)(150)))));
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(129)))), ((int)(((byte)(162)))));
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(129)))), ((int)(((byte)(162)))));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(466, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.TabIndex = 0;
            this.btnMinimizar.Text = "-";
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(129)))), ((int)(((byte)(162)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(129)))), ((int)(((byte)(162)))));
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(491, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(25, 25);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "X";
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pnInfoCad
            // 
            this.pnInfoCad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(129)))), ((int)(((byte)(162)))));
            this.pnInfoCad.Controls.Add(this.pn);
            this.pnInfoCad.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnInfoCad.Location = new System.Drawing.Point(0, 25);
            this.pnInfoCad.Name = "pnInfoCad";
            this.pnInfoCad.Size = new System.Drawing.Size(516, 102);
            this.pnInfoCad.TabIndex = 4;
            // 
            // pn
            // 
            this.pn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(129)))), ((int)(((byte)(162)))));
            this.pn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn.Location = new System.Drawing.Point(0, 17);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(516, 85);
            this.pn.TabIndex = 4;
            // 
            // tSCadastros
            // 
            this.tSCadastros.BackColor = System.Drawing.Color.White;
            this.tSCadastros.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tSCadastros.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCadUsuario,
            this.tsCadSeparador1,
            this.tsCadProgress,
            this.tsCadSeparador2,
            this.tsCadStatus});
            this.tSCadastros.Location = new System.Drawing.Point(0, 191);
            this.tSCadastros.Name = "tSCadastros";
            this.tSCadastros.Size = new System.Drawing.Size(516, 25);
            this.tSCadastros.TabIndex = 5;
            this.tSCadastros.DoubleClick += new System.EventHandler(this.tSCadastros_DoubleClick);
            // 
            // tsCadUsuario
            // 
            this.tsCadUsuario.Name = "tsCadUsuario";
            this.tsCadUsuario.Size = new System.Drawing.Size(47, 22);
            this.tsCadUsuario.Text = "Usuário";
            // 
            // tsCadSeparador1
            // 
            this.tsCadSeparador1.Name = "tsCadSeparador1";
            this.tsCadSeparador1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsCadProgress
            // 
            this.tsCadProgress.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsCadProgress.BackColor = System.Drawing.Color.Silver;
            this.tsCadProgress.Name = "tsCadProgress";
            this.tsCadProgress.Size = new System.Drawing.Size(86, 22);
            this.tsCadProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // tsCadSeparador2
            // 
            this.tsCadSeparador2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsCadSeparador2.Name = "tsCadSeparador2";
            this.tsCadSeparador2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsCadStatus
            // 
            this.tsCadStatus.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsCadStatus.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsCadStatus.Name = "tsCadStatus";
            this.tsCadStatus.Size = new System.Drawing.Size(0, 22);
            this.tsCadStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // pnAcoes
            // 
            this.pnAcoes.BackColor = System.Drawing.Color.White;
            this.pnAcoes.Controls.Add(this.pnAcoesFilho);
            this.pnAcoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnAcoes.Location = new System.Drawing.Point(0, 127);
            this.pnAcoes.Name = "pnAcoes";
            this.pnAcoes.Size = new System.Drawing.Size(516, 55);
            this.pnAcoes.TabIndex = 6;
            // 
            // pnAcoesFilho
            // 
            this.pnAcoesFilho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(143)))), ((int)(((byte)(172)))));
            this.pnAcoesFilho.Controls.Add(this.btnCancelar);
            this.pnAcoesFilho.Controls.Add(this.btnExcluir);
            this.pnAcoesFilho.Controls.Add(this.btnEditar);
            this.pnAcoesFilho.Controls.Add(this.btnProcurar);
            this.pnAcoesFilho.Controls.Add(this.groupBox1);
            this.pnAcoesFilho.Controls.Add(this.btnInserir);
            this.pnAcoesFilho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnAcoesFilho.Location = new System.Drawing.Point(0, 0);
            this.pnAcoesFilho.Name = "pnAcoesFilho";
            this.pnAcoesFilho.Size = new System.Drawing.Size(516, 34);
            this.pnAcoesFilho.TabIndex = 8;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(143)))), ((int)(((byte)(172)))));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = global::GUI.Properties.Resources.cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(466, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(25, 34);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseHover += new System.EventHandler(this.btnCancelar_MouseHover);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(143)))), ((int)(((byte)(172)))));
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExcluir.Image = global::GUI.Properties.Resources.deletar;
            this.btnExcluir.Location = new System.Drawing.Point(50, 0);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(25, 34);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.MouseHover += new System.EventHandler(this.btnExcluir_MouseHover);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(143)))), ((int)(((byte)(172)))));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditar.Image = global::GUI.Properties.Resources.editar;
            this.btnEditar.Location = new System.Drawing.Point(25, 0);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(25, 34);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.MouseHover += new System.EventHandler(this.btnEditar_MouseHover);
            // 
            // btnProcurar
            // 
            this.btnProcurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(143)))), ((int)(((byte)(172)))));
            this.btnProcurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProcurar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnProcurar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnProcurar.FlatAppearance.BorderSize = 0;
            this.btnProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcurar.Image = global::GUI.Properties.Resources.localizar;
            this.btnProcurar.Location = new System.Drawing.Point(491, 0);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(25, 34);
            this.btnProcurar.TabIndex = 3;
            this.btnProcurar.UseVisualStyleBackColor = false;
            this.btnProcurar.MouseHover += new System.EventHandler(this.btnProcurar_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(-3, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 10);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(143)))), ((int)(((byte)(172)))));
            this.btnInserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInserir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnInserir.FlatAppearance.BorderSize = 0;
            this.btnInserir.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInserir.Image = global::GUI.Properties.Resources.novo;
            this.btnInserir.Location = new System.Drawing.Point(0, 0);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(25, 34);
            this.btnInserir.TabIndex = 1;
            this.btnInserir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.MouseHover += new System.EventHandler(this.btnInserir_MouseHover);
            // 
            // FrmModCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(516, 216);
            this.Controls.Add(this.pnAcoes);
            this.Controls.Add(this.tSCadastros);
            this.Controls.Add(this.pnInfoCad);
            this.Controls.Add(this.pnCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmModCad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmModCad";
            this.Load += new System.EventHandler(this.FrmModCad_Load);
            this.pnCabecalho.ResumeLayout(false);
            this.pnCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icone)).EndInit();
            this.pnInfoCad.ResumeLayout(false);
            this.tSCadastros.ResumeLayout(false);
            this.tSCadastros.PerformLayout();
            this.pnAcoes.ResumeLayout(false);
            this.pnAcoesFilho.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Panel pnCabecalho;
        public System.Windows.Forms.PictureBox Icone;
        public System.Windows.Forms.Panel pnInfoCad;
        public System.Windows.Forms.ToolStrip tSCadastros;
        public System.Windows.Forms.ToolStripLabel tsCadUsuario;
        public System.Windows.Forms.ToolStripSeparator tsCadSeparador1;
        public System.Windows.Forms.ToolStripLabel tsCadStatus;
        public System.Windows.Forms.ToolStripSeparator tsCadSeparador2;
        public System.Windows.Forms.ToolStripProgressBar tsCadProgress;
        public System.Windows.Forms.Panel pnAcoes;
        public System.Windows.Forms.Panel pnAcoesFilho;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnInserir;
        public System.Windows.Forms.Button btnProcurar;
        public System.Windows.Forms.Panel pn;
        public System.Windows.Forms.Label lblCadastro;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ToolTip BalaoInfo;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnFechar;
    }
}
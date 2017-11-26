namespace GUI
{
    partial class FrmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            this.gBoxLogin = new System.Windows.Forms.GroupBox();
            this.tBoxLogin = new System.Windows.Forms.TextBox();
            this.gBoxStatus = new System.Windows.Forms.GroupBox();
            this.rButtonInativo = new System.Windows.Forms.RadioButton();
            this.rButtonAtivo = new System.Windows.Forms.RadioButton();
            this.gBoxSenha = new System.Windows.Forms.GroupBox();
            this.tBoxSenha = new System.Windows.Forms.TextBox();
            this.gBoxCSenha = new System.Windows.Forms.GroupBox();
            this.tBoxCSenha = new System.Windows.Forms.TextBox();
            this.gBoxTipo = new System.Windows.Forms.GroupBox();
            this.cBoxTipo = new System.Windows.Forms.ComboBox();
            this.gBoxData = new System.Windows.Forms.GroupBox();
            this.lblData = new System.Windows.Forms.Label();
            this.Erro = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnCabecalho.SuspendLayout();
            this.pnInfoCad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icone)).BeginInit();
            this.gBoxLogin.SuspendLayout();
            this.gBoxStatus.SuspendLayout();
            this.gBoxSenha.SuspendLayout();
            this.gBoxCSenha.SuspendLayout();
            this.gBoxTipo.SuspendLayout();
            this.gBoxData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Erro)).BeginInit();
            this.SuspendLayout();
            // 
            // pnCabecalho
            // 
            this.pnCabecalho.Size = new System.Drawing.Size(614, 25);
            this.pnCabecalho.TabIndex = 1;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.Location = new System.Drawing.Point(564, 0);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.Location = new System.Drawing.Point(589, 0);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblCadastro
            // 
            this.lblCadastro.Size = new System.Drawing.Size(155, 20);
            this.lblCadastro.TabIndex = 0;
            this.lblCadastro.Text = "Cadastro de Usuário";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(16, 208);
            this.btnInserir.TabIndex = 6;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(544, 208);
            this.btnCancelar.TabIndex = 7;
            // 
            // pnInfoCad
            // 
            this.pnInfoCad.BackColor = System.Drawing.Color.White;
            this.pnInfoCad.Controls.Add(this.gBoxData);
            this.pnInfoCad.Controls.Add(this.gBoxTipo);
            this.pnInfoCad.Controls.Add(this.gBoxCSenha);
            this.pnInfoCad.Controls.Add(this.gBoxStatus);
            this.pnInfoCad.Controls.Add(this.gBoxLogin);
            this.pnInfoCad.Controls.Add(this.gBoxSenha);
            this.pnInfoCad.Size = new System.Drawing.Size(590, 239);
            this.pnInfoCad.TabIndex = 2;
            this.pnInfoCad.Controls.SetChildIndex(this.gBoxSenha, 0);
            this.pnInfoCad.Controls.SetChildIndex(this.gBoxLogin, 0);
            this.pnInfoCad.Controls.SetChildIndex(this.gBoxStatus, 0);
            this.pnInfoCad.Controls.SetChildIndex(this.gBoxCSenha, 0);
            this.pnInfoCad.Controls.SetChildIndex(this.gBoxTipo, 0);
            this.pnInfoCad.Controls.SetChildIndex(this.gBoxData, 0);
            this.pnInfoCad.Controls.SetChildIndex(this.btnCancelar, 0);
            this.pnInfoCad.Controls.SetChildIndex(this.btnInserir, 0);
            // 
           
            // gBoxLogin
            // 
            this.gBoxLogin.Controls.Add(this.tBoxLogin);
            this.gBoxLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxLogin.ForeColor = System.Drawing.Color.DimGray;
            this.gBoxLogin.Location = new System.Drawing.Point(16, 13);
            this.gBoxLogin.Name = "gBoxLogin";
            this.gBoxLogin.Size = new System.Drawing.Size(280, 65);
            this.gBoxLogin.TabIndex = 0;
            this.gBoxLogin.TabStop = false;
            this.gBoxLogin.Text = "Login";
            // 
            // tBoxLogin
            // 
            this.tBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxLogin.Location = new System.Drawing.Point(23, 24);
            this.tBoxLogin.Name = "tBoxLogin";
            this.tBoxLogin.Size = new System.Drawing.Size(245, 26);
            this.tBoxLogin.TabIndex = 0;
            // 
            // gBoxStatus
            // 
            this.gBoxStatus.Controls.Add(this.rButtonInativo);
            this.gBoxStatus.Controls.Add(this.rButtonAtivo);
            this.gBoxStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxStatus.ForeColor = System.Drawing.Color.DimGray;
            this.gBoxStatus.Location = new System.Drawing.Point(300, 13);
            this.gBoxStatus.Name = "gBoxStatus";
            this.gBoxStatus.Size = new System.Drawing.Size(280, 65);
            this.gBoxStatus.TabIndex = 3;
            this.gBoxStatus.TabStop = false;
            this.gBoxStatus.Text = "Status";
            // 
            // rButtonInativo
            // 
            this.rButtonInativo.AutoSize = true;
            this.rButtonInativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rButtonInativo.Location = new System.Drawing.Point(164, 28);
            this.rButtonInativo.Name = "rButtonInativo";
            this.rButtonInativo.Size = new System.Drawing.Size(65, 20);
            this.rButtonInativo.TabIndex = 1;
            this.rButtonInativo.Text = "Inativo";
            this.rButtonInativo.UseVisualStyleBackColor = true;
            // 
            // rButtonAtivo
            // 
            this.rButtonAtivo.AutoSize = true;
            this.rButtonAtivo.Checked = true;
            this.rButtonAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rButtonAtivo.Location = new System.Drawing.Point(52, 28);
            this.rButtonAtivo.Name = "rButtonAtivo";
            this.rButtonAtivo.Size = new System.Drawing.Size(56, 20);
            this.rButtonAtivo.TabIndex = 0;
            this.rButtonAtivo.TabStop = true;
            this.rButtonAtivo.Text = "Ativo";
            this.rButtonAtivo.UseVisualStyleBackColor = true;
            // 
            // gBoxSenha
            // 
            this.gBoxSenha.Controls.Add(this.tBoxSenha);
            this.gBoxSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gBoxSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxSenha.ForeColor = System.Drawing.Color.DimGray;
            this.gBoxSenha.Location = new System.Drawing.Point(16, 77);
            this.gBoxSenha.Name = "gBoxSenha";
            this.gBoxSenha.Size = new System.Drawing.Size(280, 65);
            this.gBoxSenha.TabIndex = 1;
            this.gBoxSenha.TabStop = false;
            this.gBoxSenha.Text = "Senha";
            // 
            // tBoxSenha
            // 
            this.tBoxSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxSenha.Location = new System.Drawing.Point(23, 24);
            this.tBoxSenha.Name = "tBoxSenha";
            this.tBoxSenha.Size = new System.Drawing.Size(245, 26);
            this.tBoxSenha.TabIndex = 0;
            this.tBoxSenha.UseSystemPasswordChar = true;
            // 
            // gBoxCSenha
            // 
            this.gBoxCSenha.Controls.Add(this.tBoxCSenha);
            this.gBoxCSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gBoxCSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxCSenha.ForeColor = System.Drawing.Color.DimGray;
            this.gBoxCSenha.Location = new System.Drawing.Point(300, 77);
            this.gBoxCSenha.Name = "gBoxCSenha";
            this.gBoxCSenha.Size = new System.Drawing.Size(280, 65);
            this.gBoxCSenha.TabIndex = 4;
            this.gBoxCSenha.TabStop = false;
            this.gBoxCSenha.Text = "Confirmar Senha";
            // 
            // tBoxCSenha
            // 
            this.tBoxCSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxCSenha.Location = new System.Drawing.Point(22, 24);
            this.tBoxCSenha.Name = "tBoxCSenha";
            this.tBoxCSenha.Size = new System.Drawing.Size(245, 26);
            this.tBoxCSenha.TabIndex = 2;
            this.tBoxCSenha.UseSystemPasswordChar = true;
            // 
            // gBoxTipo
            // 
            this.gBoxTipo.Controls.Add(this.cBoxTipo);
            this.gBoxTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gBoxTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxTipo.ForeColor = System.Drawing.Color.DimGray;
            this.gBoxTipo.Location = new System.Drawing.Point(16, 141);
            this.gBoxTipo.Name = "gBoxTipo";
            this.gBoxTipo.Size = new System.Drawing.Size(280, 65);
            this.gBoxTipo.TabIndex = 2;
            this.gBoxTipo.TabStop = false;
            this.gBoxTipo.Text = "Tipo de Usuário";
            // 
            // cBoxTipo
            // 
            this.cBoxTipo.Enabled = false;
            this.cBoxTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxTipo.FormattingEnabled = true;
            this.cBoxTipo.Items.AddRange(new object[] {
            "Administrador",
            "Funcionário"});
            this.cBoxTipo.Location = new System.Drawing.Point(23, 24);
            this.cBoxTipo.Name = "cBoxTipo";
            this.cBoxTipo.Size = new System.Drawing.Size(245, 28);
            this.cBoxTipo.TabIndex = 0;
            this.cBoxTipo.Text = "Administrador";
            // 
            // gBoxData
            // 
            this.gBoxData.Controls.Add(this.lblData);
            this.gBoxData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gBoxData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxData.ForeColor = System.Drawing.Color.DimGray;
            this.gBoxData.Location = new System.Drawing.Point(300, 141);
            this.gBoxData.Name = "gBoxData";
            this.gBoxData.Size = new System.Drawing.Size(280, 65);
            this.gBoxData.TabIndex = 5;
            this.gBoxData.TabStop = false;
            this.gBoxData.Text = "Data do Cadastro";
            // 
            // lblData
            // 
            this.lblData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(95, 27);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(41, 20);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "data";
            // 
            // Erro
            // 
            this.Erro.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.Erro.ContainerControl = this;
            this.Erro.Icon = ((System.Drawing.Icon)(resources.GetObject("Erro.Icon")));
            this.Erro.RightToLeft = true;
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(614, 293);
            this.Name = "FrmUsuario";
            this.Text = "C. Usuário";
            this.pnCabecalho.ResumeLayout(false);
            this.pnCabecalho.PerformLayout();
            this.pnInfoCad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Icone)).EndInit();
            this.gBoxLogin.ResumeLayout(false);
            this.gBoxLogin.PerformLayout();
            this.gBoxStatus.ResumeLayout(false);
            this.gBoxStatus.PerformLayout();
            this.gBoxSenha.ResumeLayout(false);
            this.gBoxSenha.PerformLayout();
            this.gBoxCSenha.ResumeLayout(false);
            this.gBoxCSenha.PerformLayout();
            this.gBoxTipo.ResumeLayout(false);
            this.gBoxData.ResumeLayout(false);
            this.gBoxData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Erro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxData;
        private System.Windows.Forms.GroupBox gBoxTipo;
        private System.Windows.Forms.GroupBox gBoxCSenha;
        private System.Windows.Forms.GroupBox gBoxSenha;
        private System.Windows.Forms.GroupBox gBoxStatus;
        private System.Windows.Forms.GroupBox gBoxLogin;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.ComboBox cBoxTipo;
        private System.Windows.Forms.TextBox tBoxCSenha;
        private System.Windows.Forms.RadioButton rButtonInativo;
        private System.Windows.Forms.RadioButton rButtonAtivo;
        private System.Windows.Forms.TextBox tBoxLogin;
        private System.Windows.Forms.TextBox tBoxSenha;
        private System.Windows.Forms.ErrorProvider Erro;
    }
}

namespace GUI
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnDash = new System.Windows.Forms.Panel();
            this.btnMovimentacao = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.pnCadastro = new System.Windows.Forms.Panel();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnUnMedida = new System.Windows.Forms.Button();
            this.btnProduto = new System.Windows.Forms.Button();
            this.btnSCategoria = new System.Windows.Forms.Button();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.tStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tStripSair = new System.Windows.Forms.ToolStripButton();
            this.tStripUsuario = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.tStripNivelUsuario = new System.Windows.Forms.ToolStripButton();
            this.pnExpand = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnDash.SuspendLayout();
            this.pnCadastro.SuspendLayout();
            this.tStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(116)))), ((int)(((byte)(150)))));
            this.panel2.Controls.Add(this.btnMinimizar);
            this.panel2.Controls.Add(this.btnFechar);
            this.panel2.Controls.Add(this.pnHeader);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 43);
            this.panel2.TabIndex = 0;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(116)))), ((int)(((byte)(150)))));
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(602, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(37, 43);
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.Text = "-";
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(116)))), ((int)(((byte)(150)))));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(639, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(37, 43);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "X";
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pnHeader
            // 
            this.pnHeader.Controls.Add(this.label1);
            this.pnHeader.Controls.Add(this.lblHeader);
            this.pnHeader.Controls.Add(this.pictureBox1);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(372, 43);
            this.pnHeader.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sistemas";
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(246, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(65, 43);
            this.lblHeader.TabIndex = 6;
            this.lblHeader.Text = "TFL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(211, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 43);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pnDash
            // 
            this.pnDash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(116)))), ((int)(((byte)(150)))));
            this.pnDash.Controls.Add(this.btnMovimentacao);
            this.pnDash.Controls.Add(this.btnConsulta);
            this.pnDash.Controls.Add(this.pnCadastro);
            this.pnDash.Controls.Add(this.btnCadastro);
            this.pnDash.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnDash.Location = new System.Drawing.Point(0, 43);
            this.pnDash.Name = "pnDash";
            this.pnDash.Size = new System.Drawing.Size(194, 584);
            this.pnDash.TabIndex = 1;
            // 
            // btnMovimentacao
            // 
            this.btnMovimentacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(129)))), ((int)(((byte)(162)))));
            this.btnMovimentacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMovimentacao.FlatAppearance.BorderSize = 0;
            this.btnMovimentacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(116)))), ((int)(((byte)(150)))));
            this.btnMovimentacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovimentacao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovimentacao.ForeColor = System.Drawing.Color.White;
            this.btnMovimentacao.Image = global::GUI.Properties.Resources.entrada;
            this.btnMovimentacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovimentacao.Location = new System.Drawing.Point(0, 372);
            this.btnMovimentacao.Name = "btnMovimentacao";
            this.btnMovimentacao.Size = new System.Drawing.Size(194, 64);
            this.btnMovimentacao.TabIndex = 4;
            this.btnMovimentacao.Text = "     &Movimentação";
            this.btnMovimentacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMovimentacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMovimentacao.UseVisualStyleBackColor = false;
            this.btnMovimentacao.MouseEnter += new System.EventHandler(this.btnCadastro_MouseEnter);
            this.btnMovimentacao.MouseLeave += new System.EventHandler(this.btnCadastro_MouseLeave);
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(129)))), ((int)(((byte)(162)))));
            this.btnConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(116)))), ((int)(((byte)(150)))));
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.ForeColor = System.Drawing.Color.White;
            this.btnConsulta.Image = global::GUI.Properties.Resources.Consulta;
            this.btnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.Location = new System.Drawing.Point(0, 308);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(194, 64);
            this.btnConsulta.TabIndex = 3;
            this.btnConsulta.Text = "     C&onsulta";
            this.btnConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.MouseEnter += new System.EventHandler(this.btnCadastro_MouseEnter);
            this.btnConsulta.MouseLeave += new System.EventHandler(this.btnCadastro_MouseLeave);
            // 
            // pnCadastro
            // 
            this.pnCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(143)))), ((int)(((byte)(172)))));
            this.pnCadastro.Controls.Add(this.btnUsuario);
            this.pnCadastro.Controls.Add(this.btnUnMedida);
            this.pnCadastro.Controls.Add(this.btnProduto);
            this.pnCadastro.Controls.Add(this.btnSCategoria);
            this.pnCadastro.Controls.Add(this.btnCategoria);
            this.pnCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCadastro.Location = new System.Drawing.Point(0, 64);
            this.pnCadastro.Name = "pnCadastro";
            this.pnCadastro.Size = new System.Drawing.Size(194, 244);
            this.pnCadastro.TabIndex = 2;
            this.pnCadastro.Visible = false;
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(143)))), ((int)(((byte)(172)))));
            this.btnUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(129)))), ((int)(((byte)(162)))));
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnUsuario.Image = global::GUI.Properties.Resources.usuario;
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.Location = new System.Drawing.Point(0, 184);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(194, 46);
            this.btnUsuario.TabIndex = 6;
            this.btnUsuario.Text = "     Usuário";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnUnMedida
            // 
            this.btnUnMedida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(143)))), ((int)(((byte)(172)))));
            this.btnUnMedida.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUnMedida.FlatAppearance.BorderSize = 0;
            this.btnUnMedida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(129)))), ((int)(((byte)(162)))));
            this.btnUnMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnMedida.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnMedida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnUnMedida.Image = global::GUI.Properties.Resources.medida;
            this.btnUnMedida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnMedida.Location = new System.Drawing.Point(0, 138);
            this.btnUnMedida.Name = "btnUnMedida";
            this.btnUnMedida.Size = new System.Drawing.Size(194, 46);
            this.btnUnMedida.TabIndex = 5;
            this.btnUnMedida.Text = "     Unidade de Medida";
            this.btnUnMedida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUnMedida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUnMedida.UseVisualStyleBackColor = false;
            this.btnUnMedida.Click += new System.EventHandler(this.btnUnMedida_Click);
            // 
            // btnProduto
            // 
            this.btnProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(143)))), ((int)(((byte)(172)))));
            this.btnProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduto.FlatAppearance.BorderSize = 0;
            this.btnProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(129)))), ((int)(((byte)(162)))));
            this.btnProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnProduto.Image = global::GUI.Properties.Resources.produto;
            this.btnProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduto.Location = new System.Drawing.Point(0, 92);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(194, 46);
            this.btnProduto.TabIndex = 4;
            this.btnProduto.Text = "     Produto";
            this.btnProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProduto.UseVisualStyleBackColor = false;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // btnSCategoria
            // 
            this.btnSCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(143)))), ((int)(((byte)(172)))));
            this.btnSCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSCategoria.FlatAppearance.BorderSize = 0;
            this.btnSCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(129)))), ((int)(((byte)(162)))));
            this.btnSCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSCategoria.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSCategoria.Image = global::GUI.Properties.Resources.SubCategoria;
            this.btnSCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSCategoria.Location = new System.Drawing.Point(0, 46);
            this.btnSCategoria.Name = "btnSCategoria";
            this.btnSCategoria.Size = new System.Drawing.Size(194, 46);
            this.btnSCategoria.TabIndex = 3;
            this.btnSCategoria.Text = "     Sub-Categoria";
            this.btnSCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSCategoria.UseVisualStyleBackColor = false;
            this.btnSCategoria.Click += new System.EventHandler(this.btnSCategoria_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(143)))), ((int)(((byte)(172)))));
            this.btnCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategoria.FlatAppearance.BorderSize = 0;
            this.btnCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(129)))), ((int)(((byte)(162)))));
            this.btnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoria.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnCategoria.Image = global::GUI.Properties.Resources.Categoria;
            this.btnCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategoria.Location = new System.Drawing.Point(0, 0);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(194, 46);
            this.btnCategoria.TabIndex = 2;
            this.btnCategoria.Text = "     Categoria";
            this.btnCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategoria.UseVisualStyleBackColor = false;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(129)))), ((int)(((byte)(162)))));
            this.btnCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastro.FlatAppearance.BorderSize = 0;
            this.btnCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(116)))), ((int)(((byte)(150)))));
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.ForeColor = System.Drawing.Color.White;
            this.btnCadastro.Image = global::GUI.Properties.Resources.Cadastrar;
            this.btnCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastro.Location = new System.Drawing.Point(0, 0);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(194, 64);
            this.btnCadastro.TabIndex = 1;
            this.btnCadastro.Text = "     &Cadastro";
            this.btnCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            this.btnCadastro.MouseEnter += new System.EventHandler(this.btnCadastro_MouseEnter);
            this.btnCadastro.MouseLeave += new System.EventHandler(this.btnCadastro_MouseLeave);
            // 
            // tStrip
            // 
            this.tStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tStrip.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.tStripSair,
            this.tStripUsuario,
            this.toolStripButton5,
            this.tStripNivelUsuario});
            this.tStrip.Location = new System.Drawing.Point(211, 595);
            this.tStrip.Name = "tStrip";
            this.tStrip.Size = new System.Drawing.Size(465, 32);
            this.tStrip.TabIndex = 15;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoToolTip = false;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton1.Enabled = false;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 29);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.AutoToolTip = false;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton2.Enabled = false;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 29);
            this.toolStripButton2.Text = "toolStripButton1";
            // 
            // tStripSair
            // 
            this.tStripSair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tStripSair.AutoToolTip = false;
            this.tStripSair.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tStripSair.Image = global::GUI.Properties.Resources.SairIco;
            this.tStripSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tStripSair.Name = "tStripSair";
            this.tStripSair.Size = new System.Drawing.Size(60, 29);
            this.tStripSair.Text = "Sair";
            this.tStripSair.Click += new System.EventHandler(this.tStripSair_Click);
            // 
            // tStripUsuario
            // 
            this.tStripUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tStripUsuario.Image = ((System.Drawing.Image)(resources.GetObject("tStripUsuario.Image")));
            this.tStripUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tStripUsuario.Name = "tStripUsuario";
            this.tStripUsuario.Size = new System.Drawing.Size(20, 29);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton5.AutoToolTip = false;
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton5.Enabled = false;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 29);
            this.toolStripButton5.Text = "toolStripButton1";
            // 
            // tStripNivelUsuario
            // 
            this.tStripNivelUsuario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tStripNivelUsuario.AutoToolTip = false;
            this.tStripNivelUsuario.Checked = true;
            this.tStripNivelUsuario.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tStripNivelUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tStripNivelUsuario.Enabled = false;
            this.tStripNivelUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tStripNivelUsuario.Image = ((System.Drawing.Image)(resources.GetObject("tStripNivelUsuario.Image")));
            this.tStripNivelUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStripNivelUsuario.Name = "tStripNivelUsuario";
            this.tStripNivelUsuario.Size = new System.Drawing.Size(112, 29);
            this.tStripNivelUsuario.Text = "Nível de Acesso :";
            // 
            // pnExpand
            // 
            this.pnExpand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(129)))), ((int)(((byte)(162)))));
            this.pnExpand.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnExpand.BackgroundImage")));
            this.pnExpand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnExpand.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnExpand.ForeColor = System.Drawing.Color.White;
            this.pnExpand.Location = new System.Drawing.Point(194, 43);
            this.pnExpand.Name = "pnExpand";
            this.pnExpand.Size = new System.Drawing.Size(17, 584);
            this.pnExpand.TabIndex = 13;
            this.pnExpand.Click += new System.EventHandler(this.pnExpand_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 627);
            this.Controls.Add(this.tStrip);
            this.Controls.Add(this.pnExpand);
            this.Controls.Add(this.pnDash);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel2.ResumeLayout(false);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnDash.ResumeLayout(false);
            this.pnCadastro.ResumeLayout(false);
            this.tStrip.ResumeLayout(false);
            this.tStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Button btnMinimizar;
        protected System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel pnDash;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnCadastro;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnUnMedida;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Button btnSCategoria;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Panel pnExpand;
        private System.Windows.Forms.Button btnMovimentacao;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.ToolStrip tStrip;
        private System.Windows.Forms.ToolStripButton tStripNivelUsuario;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripLabel tStripUsuario;
        private System.Windows.Forms.ToolStripButton tStripSair;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}


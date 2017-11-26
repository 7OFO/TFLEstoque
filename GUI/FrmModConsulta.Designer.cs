namespace GUI
{
    partial class FrmModConsulta
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
            this.pnGrid = new System.Windows.Forms.Panel();
            this.tsCadSeparador1 = new System.Windows.Forms.ToolStripSeparator();
            this.tSCadastros = new System.Windows.Forms.ToolStrip();
            this.tsCadUsuario = new System.Windows.Forms.ToolStripLabel();
            this.pnInfoLocFilho = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnInfoLoc = new System.Windows.Forms.Panel();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.pnCabecalho = new System.Windows.Forms.Panel();
            this.Icone = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tSCadastros.SuspendLayout();
            this.pnInfoLocFilho.SuspendLayout();
            this.pnInfoLoc.SuspendLayout();
            this.pnCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icone)).BeginInit();
            this.SuspendLayout();
            // 
            // pnGrid
            // 
            this.pnGrid.BackColor = System.Drawing.Color.White;
            this.pnGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnGrid.Location = new System.Drawing.Point(0, 95);
            this.pnGrid.Name = "pnGrid";
            this.pnGrid.Size = new System.Drawing.Size(505, 372);
            this.pnGrid.TabIndex = 10;
            // 
            // tsCadSeparador1
            // 
            this.tsCadSeparador1.Name = "tsCadSeparador1";
            this.tsCadSeparador1.Size = new System.Drawing.Size(6, 25);
            // 
            // tSCadastros
            // 
            this.tSCadastros.BackColor = System.Drawing.Color.White;
            this.tSCadastros.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tSCadastros.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCadUsuario,
            this.tsCadSeparador1});
            this.tSCadastros.Location = new System.Drawing.Point(0, 467);
            this.tSCadastros.Name = "tSCadastros";
            this.tSCadastros.Size = new System.Drawing.Size(505, 25);
            this.tSCadastros.TabIndex = 9;
            // 
            // tsCadUsuario
            // 
            this.tsCadUsuario.Name = "tsCadUsuario";
            this.tsCadUsuario.Size = new System.Drawing.Size(47, 22);
            this.tsCadUsuario.Text = "Usuário";
            // 
            // pnInfoLocFilho
            // 
            this.pnInfoLocFilho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(129)))), ((int)(((byte)(162)))));
            this.pnInfoLocFilho.Controls.Add(this.label1);
            this.pnInfoLocFilho.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnInfoLocFilho.Location = new System.Drawing.Point(0, 25);
            this.pnInfoLocFilho.Name = "pnInfoLocFilho";
            this.pnInfoLocFilho.Size = new System.Drawing.Size(505, 35);
            this.pnInfoLocFilho.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pesquisa";
            // 
            // pnInfoLoc
            // 
            this.pnInfoLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(129)))), ((int)(((byte)(162)))));
            this.pnInfoLoc.Controls.Add(this.pnInfoLocFilho);
            this.pnInfoLoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnInfoLoc.Location = new System.Drawing.Point(0, 25);
            this.pnInfoLoc.Name = "pnInfoLoc";
            this.pnInfoLoc.Size = new System.Drawing.Size(505, 60);
            this.pnInfoLoc.TabIndex = 8;
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCadastro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.ForeColor = System.Drawing.Color.White;
            this.lblCadastro.Location = new System.Drawing.Point(38, 0);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(87, 18);
            this.lblCadastro.TabIndex = 5;
            this.lblCadastro.Text = "Localizar ...";
            this.lblCadastro.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnCabecalho_MouseDown);
            this.lblCadastro.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnCabecalho_MouseMove);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(116)))), ((int)(((byte)(150)))));
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(455, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.TabIndex = 0;
            this.btnMinimizar.Text = "-";
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
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
            this.pnCabecalho.Size = new System.Drawing.Size(505, 25);
            this.pnCabecalho.TabIndex = 7;
            this.pnCabecalho.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnCabecalho_MouseDown);
            this.pnCabecalho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnCabecalho_MouseMove);
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
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(480, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(25, 25);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "X";
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(129)))), ((int)(((byte)(162)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 10);
            this.panel1.TabIndex = 5;
            // 
            // FrmModConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(505, 492);
            this.Controls.Add(this.pnGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tSCadastros);
            this.Controls.Add(this.pnInfoLoc);
            this.Controls.Add(this.pnCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmModConsulta";
            this.Load += new System.EventHandler(this.FrmModConsulta_Load);
            this.tSCadastros.ResumeLayout(false);
            this.tSCadastros.PerformLayout();
            this.pnInfoLocFilho.ResumeLayout(false);
            this.pnInfoLocFilho.PerformLayout();
            this.pnInfoLoc.ResumeLayout(false);
            this.pnCabecalho.ResumeLayout(false);
            this.pnCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Panel pnGrid;
        public System.Windows.Forms.ToolStripSeparator tsCadSeparador1;
        public System.Windows.Forms.ToolStripLabel tsCadUsuario;
        public System.Windows.Forms.ToolStrip tSCadastros;
        public System.Windows.Forms.Label lblCadastro;
        public System.Windows.Forms.PictureBox Icone;
        protected System.Windows.Forms.Button btnMinimizar;
        protected System.Windows.Forms.Button btnFechar;
        public System.Windows.Forms.Panel pnCabecalho;
        protected System.Windows.Forms.Panel pnInfoLocFilho;
        private System.Windows.Forms.Panel pnInfoLoc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
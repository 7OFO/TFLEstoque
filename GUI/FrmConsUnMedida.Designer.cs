namespace GUI
{
    partial class FrmConsUnMedida
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tBoxConsUMed = new System.Windows.Forms.TextBox();
            this.cBoxTipoPesquisa = new System.Windows.Forms.ComboBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.GridDados = new System.Windows.Forms.DataGridView();
            this.pnGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icone)).BeginInit();
            this.pnCabecalho.SuspendLayout();
            this.pnInfoLocFilho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDados)).BeginInit();
            this.SuspendLayout();
            // 
            // pnGrid
            // 
            this.pnGrid.Controls.Add(this.GridDados);
            this.pnGrid.Size = new System.Drawing.Size(505, 366);
            // 
            // lblCadastro
            // 
            this.lblCadastro.Size = new System.Drawing.Size(210, 18);
            this.lblCadastro.Text = "Procurar Unidade de Medida";
            // 
            // Icone
            // 
            this.Icone.BackgroundImage = global::GUI.Properties.Resources.medida;
            // 
            // pnInfoLocFilho
            // 
            this.pnInfoLocFilho.Controls.Add(this.tBoxConsUMed);
            this.pnInfoLocFilho.Controls.Add(this.cBoxTipoPesquisa);
            this.pnInfoLocFilho.Location = new System.Drawing.Point(0, 16);
            this.pnInfoLocFilho.Size = new System.Drawing.Size(505, 44);
            this.pnInfoLocFilho.Controls.SetChildIndex(this.cBoxTipoPesquisa, 0);
            this.pnInfoLocFilho.Controls.SetChildIndex(this.tBoxConsUMed, 0);
            // 
            // tBoxConsUMed
            // 
            this.tBoxConsUMed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBoxConsUMed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxConsUMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxConsUMed.ForeColor = System.Drawing.Color.DimGray;
            this.tBoxConsUMed.Location = new System.Drawing.Point(160, 20);
            this.tBoxConsUMed.Name = "tBoxConsUMed";
            this.tBoxConsUMed.Size = new System.Drawing.Size(345, 24);
            this.tBoxConsUMed.TabIndex = 3;
            this.tBoxConsUMed.TextChanged += new System.EventHandler(this.tBoxConsulta_TextChanged);
            // 
            // cBoxTipoPesquisa
            // 
            this.cBoxTipoPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBoxTipoPesquisa.DisplayMember = "0";
            this.cBoxTipoPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxTipoPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxTipoPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxTipoPesquisa.FormattingEnabled = true;
            this.cBoxTipoPesquisa.Items.AddRange(new object[] {
            "Código",
            "Un.Medida"});
            this.cBoxTipoPesquisa.Location = new System.Drawing.Point(1, 20);
            this.cBoxTipoPesquisa.Name = "cBoxTipoPesquisa";
            this.cBoxTipoPesquisa.Size = new System.Drawing.Size(152, 24);
            this.cBoxTipoPesquisa.TabIndex = 2;
            this.cBoxTipoPesquisa.ValueMember = "1";
            this.cBoxTipoPesquisa.SelectedIndexChanged += new System.EventHandler(this.cBoxTipoPesquisa_SelectedIndexChanged);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPesquisa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPesquisa.Location = new System.Drawing.Point(0, 15);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(50, 13);
            this.lblPesquisa.TabIndex = 4;
            this.lblPesquisa.Text = "Pesquisa";
            // 
            // GridDados
            // 
            this.GridDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridDados.BackgroundColor = System.Drawing.Color.White;
            this.GridDados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridDados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(143)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(80)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(80)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridDados.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridDados.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GridDados.Location = new System.Drawing.Point(0, 0);
            this.GridDados.Name = "GridDados";
            this.GridDados.ReadOnly = true;
            this.GridDados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridDados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridDados.RowHeadersVisible = false;
            this.GridDados.RowHeadersWidth = 40;
            this.GridDados.RowTemplate.Height = 30;
            this.GridDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridDados.Size = new System.Drawing.Size(505, 366);
            this.GridDados.TabIndex = 10;
            this.GridDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDados_CellDoubleClick);
            // 
            // FrmConsUnMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(505, 486);
            this.Name = "FrmConsUnMedida";
            this.Text = "Procurar Un. Medida";
            this.Load += new System.EventHandler(this.FrmConsUnMedida_Load);
            this.pnGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Icone)).EndInit();
            this.pnCabecalho.ResumeLayout(false);
            this.pnCabecalho.PerformLayout();
            this.pnInfoLocFilho.ResumeLayout(false);
            this.pnInfoLocFilho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPesquisa;
        public System.Windows.Forms.DataGridView GridDados;
        public System.Windows.Forms.TextBox tBoxConsUMed;
        public System.Windows.Forms.ComboBox cBoxTipoPesquisa;
    }
}

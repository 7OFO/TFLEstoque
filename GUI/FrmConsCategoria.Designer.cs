namespace GUI
{
    partial class FrmConsCategoria
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
            this.tBoxConsCat = new System.Windows.Forms.TextBox();
            this.cBoxTipoPesquisa = new System.Windows.Forms.ComboBox();
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
            // 
            // lblCadastro
            // 
            this.lblCadastro.Size = new System.Drawing.Size(142, 18);
            this.lblCadastro.Text = "Procurar Categoria";
            // 
            // Icone
            // 
            this.Icone.BackgroundImage = global::GUI.Properties.Resources.Categoria;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            // 
            // pnInfoLocFilho
            // 
            this.pnInfoLocFilho.Controls.Add(this.tBoxConsCat);
            this.pnInfoLocFilho.Controls.Add(this.cBoxTipoPesquisa);
            this.pnInfoLocFilho.Location = new System.Drawing.Point(0, 19);
            this.pnInfoLocFilho.Size = new System.Drawing.Size(505, 41);
            this.pnInfoLocFilho.Controls.SetChildIndex(this.cBoxTipoPesquisa, 0);
            this.pnInfoLocFilho.Controls.SetChildIndex(this.tBoxConsCat, 0);
            // 
            // tBoxConsCat
            // 
            this.tBoxConsCat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBoxConsCat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxConsCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxConsCat.ForeColor = System.Drawing.Color.DimGray;
            this.tBoxConsCat.Location = new System.Drawing.Point(160, 18);
            this.tBoxConsCat.Name = "tBoxConsCat";
            this.tBoxConsCat.Size = new System.Drawing.Size(345, 24);
            this.tBoxConsCat.TabIndex = 7;
            this.tBoxConsCat.TextChanged += new System.EventHandler(this.tBoxConsulta_TextChanged);
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
            "Categoria"});
            this.cBoxTipoPesquisa.Location = new System.Drawing.Point(1, 18);
            this.cBoxTipoPesquisa.Name = "cBoxTipoPesquisa";
            this.cBoxTipoPesquisa.Size = new System.Drawing.Size(152, 24);
            this.cBoxTipoPesquisa.TabIndex = 6;
            this.cBoxTipoPesquisa.ValueMember = "1";
            this.cBoxTipoPesquisa.SelectedIndexChanged += new System.EventHandler(this.cBoxTipoPesquisa_SelectedIndexChanged);
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
            this.GridDados.Size = new System.Drawing.Size(505, 372);
            this.GridDados.TabIndex = 11;
            this.GridDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDados_CellDoubleClick);
            // 
            // FrmConsCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(505, 492);
            this.Name = "FrmConsCategoria";
            this.Text = "Procurar Categoria";
            this.Load += new System.EventHandler(this.FrmConsCategoria_Load);
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

        public System.Windows.Forms.TextBox tBoxConsCat;
        public System.Windows.Forms.ComboBox cBoxTipoPesquisa;
        public System.Windows.Forms.DataGridView GridDados;
    }
}

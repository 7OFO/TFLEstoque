namespace GUI
{
    partial class FrmProduto
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
            this.gBoxProduto = new System.Windows.Forms.GroupBox();
            this.tBoxProduto = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tBoxDescricao = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gBoxCategoria = new System.Windows.Forms.GroupBox();
            this.cBoxCategoria = new System.Windows.Forms.ComboBox();
            this.gBoxMarca = new System.Windows.Forms.GroupBox();
            this.cBoxMarca = new System.Windows.Forms.ComboBox();
            this.cBoxUnMed = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gBoxUnMed = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tBoxEMaximo = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tBoxEMinimo = new System.Windows.Forms.TextBox();
            this.pnCabecalho.SuspendLayout();
            this.pnInfoCad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icone)).BeginInit();
            this.gBoxProduto.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gBoxCategoria.SuspendLayout();
            this.gBoxMarca.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gBoxUnMed.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnCabecalho
            // 
            this.pnCabecalho.Size = new System.Drawing.Size(319, 25);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.Location = new System.Drawing.Point(269, 0);
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.Location = new System.Drawing.Point(294, 0);
            // 
            // lblCadastro
            // 
            this.lblCadastro.Size = new System.Drawing.Size(156, 20);
            this.lblCadastro.Text = "Cadastro de Produto";
            // 
            // btnInserir
            // 
            this.btnInserir.Click += new System.EventHandler(this.btdInserir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(218, 9);
            // 
            // pnInfoCad
            // 
            this.pnInfoCad.Controls.Add(this.groupBox3);
            this.pnInfoCad.Controls.Add(this.groupBox2);
            this.pnInfoCad.Controls.Add(this.groupBox1);
            this.pnInfoCad.Controls.Add(this.gBoxProduto);
            this.pnInfoCad.Size = new System.Drawing.Size(295, 495);
            this.pnInfoCad.TabIndex = 1;
            this.pnInfoCad.Controls.SetChildIndex(this.gBoxProduto, 0);
            this.pnInfoCad.Controls.SetChildIndex(this.groupBox1, 0);
            this.pnInfoCad.Controls.SetChildIndex(this.groupBox2, 0);
            this.pnInfoCad.Controls.SetChildIndex(this.groupBox3, 0);
            this.pnInfoCad.Controls.SetChildIndex(this.btnCancelar, 0);
            this.pnInfoCad.Controls.SetChildIndex(this.btnInserir, 0);
            // 
            
            // gBoxProduto
            // 
            this.gBoxProduto.Controls.Add(this.tBoxProduto);
            this.gBoxProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxProduto.ForeColor = System.Drawing.Color.DimGray;
            this.gBoxProduto.Location = new System.Drawing.Point(23, 12);
            this.gBoxProduto.Name = "gBoxProduto";
            this.gBoxProduto.Size = new System.Drawing.Size(249, 60);
            this.gBoxProduto.TabIndex = 0;
            this.gBoxProduto.TabStop = false;
            this.gBoxProduto.Text = "Produto";
            // 
            // tBoxProduto
            // 
            this.tBoxProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxProduto.Location = new System.Drawing.Point(17, 21);
            this.tBoxProduto.Name = "tBoxProduto";
            this.tBoxProduto.Size = new System.Drawing.Size(214, 26);
            this.tBoxProduto.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tBoxDescricao);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(23, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 60);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descrição";
            // 
            // tBoxDescricao
            // 
            this.tBoxDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxDescricao.Location = new System.Drawing.Point(17, 21);
            this.tBoxDescricao.Name = "tBoxDescricao";
            this.tBoxDescricao.Size = new System.Drawing.Size(214, 26);
            this.tBoxDescricao.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gBoxCategoria);
            this.groupBox2.Controls.Add(this.gBoxMarca);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox2.Location = new System.Drawing.Point(23, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 165);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // gBoxCategoria
            // 
            this.gBoxCategoria.Controls.Add(this.cBoxCategoria);
            this.gBoxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxCategoria.ForeColor = System.Drawing.Color.DimGray;
            this.gBoxCategoria.Location = new System.Drawing.Point(6, 12);
            this.gBoxCategoria.Name = "gBoxCategoria";
            this.gBoxCategoria.Size = new System.Drawing.Size(235, 65);
            this.gBoxCategoria.TabIndex = 1;
            this.gBoxCategoria.TabStop = false;
            this.gBoxCategoria.Text = "Categoria";
            // 
            // cBoxCategoria
            // 
            this.cBoxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxCategoria.FormattingEnabled = true;
            this.cBoxCategoria.Location = new System.Drawing.Point(17, 25);
            this.cBoxCategoria.MaxDropDownItems = 10;
            this.cBoxCategoria.Name = "cBoxCategoria";
            this.cBoxCategoria.Size = new System.Drawing.Size(208, 28);
            this.cBoxCategoria.TabIndex = 1;
            this.cBoxCategoria.Text = "Categoria";
            this.cBoxCategoria.SelectedIndexChanged += new System.EventHandler(this.cBoxCategoria_SelectedIndexChanged);
            // 
            // gBoxMarca
            // 
            this.gBoxMarca.Controls.Add(this.cBoxMarca);
            this.gBoxMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxMarca.ForeColor = System.Drawing.Color.DimGray;
            this.gBoxMarca.Location = new System.Drawing.Point(6, 89);
            this.gBoxMarca.Name = "gBoxMarca";
            this.gBoxMarca.Size = new System.Drawing.Size(235, 65);
            this.gBoxMarca.TabIndex = 0;
            this.gBoxMarca.TabStop = false;
            this.gBoxMarca.Text = "Marca";
            // 
            // cBoxMarca
            // 
            this.cBoxMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxMarca.FormattingEnabled = true;
            this.cBoxMarca.Location = new System.Drawing.Point(17, 25);
            this.cBoxMarca.MaxDropDownItems = 10;
            this.cBoxMarca.Name = "cBoxMarca";
            this.cBoxMarca.Size = new System.Drawing.Size(208, 28);
            this.cBoxMarca.TabIndex = 1;
            this.cBoxMarca.Text = "Marca";
            this.cBoxMarca.SelectedIndexChanged += new System.EventHandler(this.cBoxMarca_SelectedIndexChanged);
            // 
            // cBoxUnMed
            // 
            this.cBoxUnMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxUnMed.FormattingEnabled = true;
            this.cBoxUnMed.Location = new System.Drawing.Point(8, 16);
            this.cBoxUnMed.MaxDropDownItems = 10;
            this.cBoxUnMed.Name = "cBoxUnMed";
            this.cBoxUnMed.Size = new System.Drawing.Size(217, 28);
            this.cBoxUnMed.TabIndex = 2;
            this.cBoxUnMed.Text = "Unidade de Medida";
            this.cBoxUnMed.SelectedIndexChanged += new System.EventHandler(this.cBoxUnMed_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gBoxUnMed);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox3.Location = new System.Drawing.Point(23, 309);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(249, 165);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estoque";
            // 
            // gBoxUnMed
            // 
            this.gBoxUnMed.Controls.Add(this.cBoxUnMed);
            this.gBoxUnMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxUnMed.ForeColor = System.Drawing.Color.DimGray;
            this.gBoxUnMed.Location = new System.Drawing.Point(6, 21);
            this.gBoxUnMed.Name = "gBoxUnMed";
            this.gBoxUnMed.Size = new System.Drawing.Size(235, 54);
            this.gBoxUnMed.TabIndex = 2;
            this.gBoxUnMed.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tBoxEMaximo);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox5.Location = new System.Drawing.Point(125, 91);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(116, 54);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Máximo";
            // 
            // tBoxEMaximo
            // 
            this.tBoxEMaximo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxEMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxEMaximo.Location = new System.Drawing.Point(8, 21);
            this.tBoxEMaximo.Name = "tBoxEMaximo";
            this.tBoxEMaximo.Size = new System.Drawing.Size(98, 26);
            this.tBoxEMaximo.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tBoxEMinimo);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox4.Location = new System.Drawing.Point(6, 91);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(116, 54);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Minimo";
            // 
            // tBoxEMinimo
            // 
            this.tBoxEMinimo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxEMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxEMinimo.Location = new System.Drawing.Point(8, 21);
            this.tBoxEMinimo.Name = "tBoxEMinimo";
            this.tBoxEMinimo.Size = new System.Drawing.Size(98, 26);
            this.tBoxEMinimo.TabIndex = 0;
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(319, 627);
            this.Name = "FrmProduto";
            this.Text = "C. Produto";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            this.pnCabecalho.ResumeLayout(false);
            this.pnCabecalho.PerformLayout();
            this.pnInfoCad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Icone)).EndInit();
            this.gBoxProduto.ResumeLayout(false);
            this.gBoxProduto.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.gBoxCategoria.ResumeLayout(false);
            this.gBoxMarca.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.gBoxUnMed.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gBoxProduto;
        private System.Windows.Forms.TextBox tBoxProduto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox gBoxUnMed;
        private System.Windows.Forms.ComboBox cBoxUnMed;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tBoxEMaximo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tBoxEMinimo;
        private System.Windows.Forms.GroupBox gBoxCategoria;
        private System.Windows.Forms.ComboBox cBoxCategoria;
        private System.Windows.Forms.GroupBox gBoxMarca;
        private System.Windows.Forms.ComboBox cBoxMarca;
        private System.Windows.Forms.TextBox tBoxDescricao;
    }
}

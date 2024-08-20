namespace ComboBox
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboLista = new System.Windows.Forms.ComboBox();
            this.texto = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.Inserir = new System.Windows.Forms.Button();
            this.Ordenar = new System.Windows.Forms.Button();
            this.txtlista = new System.Windows.Forms.Label();
            this.btncombo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.btnExibir = new System.Windows.Forms.Button();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConteudo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboLista
            // 
            this.cboLista.FormattingEnabled = true;
            this.cboLista.Items.AddRange(new object[] {
            "Computador",
            "Teclado",
            "Mouse",
            "Fonte",
            "Monitor",
            "Cabo de rede",
            "Fones ",
            "Microfones",
            "Processador",
            "HD"});
            this.cboLista.Location = new System.Drawing.Point(180, 162);
            this.cboLista.Name = "cboLista";
            this.cboLista.Size = new System.Drawing.Size(464, 21);
            this.cboLista.TabIndex = 0;
            this.cboLista.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // texto
            // 
            this.texto.AutoSize = true;
            this.texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto.Location = new System.Drawing.Point(114, 49);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(49, 18);
            this.texto.TabIndex = 1;
            this.texto.Text = "Texto:";
            this.texto.Click += new System.EventHandler(this.texto_Click);
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(180, 50);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(464, 20);
            this.txtTexto.TabIndex = 2;
            this.txtTexto.TextChanged += new System.EventHandler(this.txtTexto_TextChanged);
            // 
            // Inserir
            // 
            this.Inserir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Inserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Inserir.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inserir.Location = new System.Drawing.Point(237, 97);
            this.Inserir.Name = "Inserir";
            this.Inserir.Size = new System.Drawing.Size(146, 42);
            this.Inserir.TabIndex = 3;
            this.Inserir.Text = "Inserir no combo";
            this.Inserir.UseVisualStyleBackColor = false;
            this.Inserir.Click += new System.EventHandler(this.Inserir_Click);
            // 
            // Ordenar
            // 
            this.Ordenar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Ordenar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ordenar.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ordenar.Location = new System.Drawing.Point(437, 97);
            this.Ordenar.Name = "Ordenar";
            this.Ordenar.Size = new System.Drawing.Size(146, 42);
            this.Ordenar.TabIndex = 3;
            this.Ordenar.Text = "Ordenar o combo";
            this.Ordenar.UseVisualStyleBackColor = false;
            this.Ordenar.Click += new System.EventHandler(this.Ordenar_Click);
            // 
            // txtlista
            // 
            this.txtlista.AutoSize = true;
            this.txtlista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlista.Location = new System.Drawing.Point(114, 161);
            this.txtlista.Name = "txtlista";
            this.txtlista.Size = new System.Drawing.Size(43, 18);
            this.txtlista.TabIndex = 1;
            this.txtlista.Text = "Lista:";
            this.txtlista.Click += new System.EventHandler(this.texto_Click);
            // 
            // btncombo
            // 
            this.btncombo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncombo.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncombo.Location = new System.Drawing.Point(339, 208);
            this.btncombo.Name = "btncombo";
            this.btncombo.Size = new System.Drawing.Size(146, 38);
            this.btncombo.TabIndex = 4;
            this.btncombo.Text = "Remover do combo";
            this.btncombo.UseVisualStyleBackColor = false;
            this.btncombo.Click += new System.EventHandler(this.btncombo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quantidade de itens:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(287, 280);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(0, 18);
            this.lblQuantidade.TabIndex = 6;
            this.lblQuantidade.Click += new System.EventHandler(this.lblQuantidade_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExibir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExibir.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExibir.Location = new System.Drawing.Point(339, 306);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(146, 38);
            this.btnExibir.TabIndex = 7;
            this.btnExibir.Text = "Exibir dados do combo";
            this.btnExibir.UseVisualStyleBackColor = false;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // txtIndice
            // 
            this.txtIndice.Location = new System.Drawing.Point(242, 366);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.Size = new System.Drawing.Size(402, 20);
            this.txtIndice.TabIndex = 9;
            this.txtIndice.TextChanged += new System.EventHandler(this.txtIndice_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Índice do combo:";
            // 
            // txtConteudo
            // 
            this.txtConteudo.Location = new System.Drawing.Point(242, 418);
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.Size = new System.Drawing.Size(402, 20);
            this.txtConteudo.TabIndex = 11;
            this.txtConteudo.TextChanged += new System.EventHandler(this.txtConteudo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Texto do combo:";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSair.Location = new System.Drawing.Point(367, 457);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(92, 47);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 546);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtConteudo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIndice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncombo);
            this.Controls.Add(this.Ordenar);
            this.Controls.Add(this.Inserir);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.txtlista);
            this.Controls.Add(this.texto);
            this.Controls.Add(this.cboLista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboLista;
        private System.Windows.Forms.Label texto;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Button Inserir;
        private System.Windows.Forms.Button Ordenar;
        private System.Windows.Forms.Label txtlista;
        private System.Windows.Forms.Button btncombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConteudo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSair;
    }
}


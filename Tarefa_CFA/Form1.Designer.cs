﻿namespace Tarefa_CFA
{
    partial class Form1
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
            System.Windows.Forms.ListViewGroup listViewGroup41 = new System.Windows.Forms.ListViewGroup("Ação", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup42 = new System.Windows.Forms.ListViewGroup("Aventura", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup43 = new System.Windows.Forms.ListViewGroup("Comedia", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup44 = new System.Windows.Forms.ListViewGroup("Terror", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup45 = new System.Windows.Forms.ListViewGroup("Suspense", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup46 = new System.Windows.Forms.ListViewGroup("Documentário", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup47 = new System.Windows.Forms.ListViewGroup("Infantil", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup48 = new System.Windows.Forms.ListViewGroup("Romance", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup49 = new System.Windows.Forms.ListViewGroup("Ficção científica", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup50 = new System.Windows.Forms.ListViewGroup("Pesquisa", System.Windows.Forms.HorizontalAlignment.Left);
            this.LISTA_FILMES = new System.Windows.Forms.ListView();
            this.COLUNA_NOME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.COLUNA_GÊNERO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.COLUNA_DATA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.COLUNA_LOCAL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.TNOME = new System.Windows.Forms.TextBox();
            this.TGENERO = new System.Windows.Forms.ComboBox();
            this.TLOCAL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ADICIONAR = new System.Windows.Forms.Button();
            this.EXCLUIR = new System.Windows.Forms.Button();
            this.PERQUISA = new System.Windows.Forms.Button();
            this.ALTERAR = new System.Windows.Forms.Button();
            this.TDATA = new System.Windows.Forms.DateTimePicker();
            this.PESQUISAR = new System.Windows.Forms.Button();
            this.FECHAR_PESQUISA = new System.Windows.Forms.Button();
            this.TDATA_ATE = new System.Windows.Forms.DateTimePicker();
            this.ATE = new System.Windows.Forms.Label();
            this.ABILITAR_DATA = new System.Windows.Forms.RadioButton();
            this.DESABILITAR_DATA = new System.Windows.Forms.RadioButton();
            this.LFRASE = new System.Windows.Forms.Label();
            this.LMENSAGEM = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LISTA_FILMES
            // 
            this.LISTA_FILMES.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.COLUNA_NOME,
            this.COLUNA_GÊNERO,
            this.COLUNA_DATA,
            this.COLUNA_LOCAL});
            listViewGroup41.Header = "Ação";
            listViewGroup41.Name = "Ação";
            listViewGroup42.Header = "Aventura";
            listViewGroup42.Name = "Aventura";
            listViewGroup43.Header = "Comedia";
            listViewGroup43.Name = "Comedia";
            listViewGroup44.Header = "Terror";
            listViewGroup44.Name = "Terror";
            listViewGroup45.Header = "Suspense";
            listViewGroup45.Name = "Suspense";
            listViewGroup46.Header = "Documentário";
            listViewGroup46.Name = "Documentário";
            listViewGroup47.Header = "Infantil";
            listViewGroup47.Name = "Infantil";
            listViewGroup48.Header = "Romance";
            listViewGroup48.Name = "Romance";
            listViewGroup49.Header = "Ficção científica";
            listViewGroup49.Name = "Ficção científica";
            listViewGroup50.Header = "Pesquisa";
            listViewGroup50.Name = "Pesquisa";
            this.LISTA_FILMES.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup41,
            listViewGroup42,
            listViewGroup43,
            listViewGroup44,
            listViewGroup45,
            listViewGroup46,
            listViewGroup47,
            listViewGroup48,
            listViewGroup49,
            listViewGroup50});
            this.LISTA_FILMES.Location = new System.Drawing.Point(14, 137);
            this.LISTA_FILMES.Name = "LISTA_FILMES";
            this.LISTA_FILMES.Size = new System.Drawing.Size(760, 412);
            this.LISTA_FILMES.TabIndex = 0;
            this.LISTA_FILMES.UseCompatibleStateImageBehavior = false;
            this.LISTA_FILMES.View = System.Windows.Forms.View.Details;
            this.LISTA_FILMES.DoubleClick += new System.EventHandler(this.LISTA_FILMES_DoubleClick);
            // 
            // COLUNA_NOME
            // 
            this.COLUNA_NOME.Text = "Nome";
            this.COLUNA_NOME.Width = 257;
            // 
            // COLUNA_GÊNERO
            // 
            this.COLUNA_GÊNERO.Text = "Gênero";
            this.COLUNA_GÊNERO.Width = 118;
            // 
            // COLUNA_DATA
            // 
            this.COLUNA_DATA.Text = "Data";
            this.COLUNA_DATA.Width = 93;
            // 
            // COLUNA_LOCAL
            // 
            this.COLUNA_LOCAL.Text = "Local";
            this.COLUNA_LOCAL.Width = 287;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // TNOME
            // 
            this.TNOME.AutoCompleteCustomSource.AddRange(new string[] {
            "Transformes - A vingança dos derrotados",
            "Carros 1",
            "Tron - O legado",
            "Besouro verde"});
            this.TNOME.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TNOME.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TNOME.Location = new System.Drawing.Point(53, 49);
            this.TNOME.Name = "TNOME";
            this.TNOME.Size = new System.Drawing.Size(437, 20);
            this.TNOME.TabIndex = 2;
            // 
            // TGENERO
            // 
            this.TGENERO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TGENERO.FormattingEnabled = true;
            this.TGENERO.Items.AddRange(new object[] {
            "Ação",
            "Aventura",
            "Comédia",
            "Terror",
            "Suspense",
            "Documentário",
            "Infantil",
            "Romance",
            "Ficção científica"});
            this.TGENERO.Location = new System.Drawing.Point(547, 52);
            this.TGENERO.Name = "TGENERO";
            this.TGENERO.Size = new System.Drawing.Size(156, 21);
            this.TGENERO.TabIndex = 3;
            // 
            // TLOCAL
            // 
            this.TLOCAL.AutoCompleteCustomSource.AddRange(new string[] {
            "Na minha casa",
            "No cinema",
            "No serviço",
            "Na casa da sogra",
            "Não sei aonde estou"});
            this.TLOCAL.Location = new System.Drawing.Point(53, 76);
            this.TLOCAL.Name = "TLOCAL";
            this.TLOCAL.Size = new System.Drawing.Size(436, 20);
            this.TLOCAL.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Gênero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Local:";
            // 
            // ADICIONAR
            // 
            this.ADICIONAR.Location = new System.Drawing.Point(499, 76);
            this.ADICIONAR.Name = "ADICIONAR";
            this.ADICIONAR.Size = new System.Drawing.Size(75, 23);
            this.ADICIONAR.TabIndex = 9;
            this.ADICIONAR.Text = "Adicionar";
            this.ADICIONAR.UseVisualStyleBackColor = true;
            this.ADICIONAR.Click += new System.EventHandler(this.ADICIONAR_Click);
            // 
            // EXCLUIR
            // 
            this.EXCLUIR.Enabled = false;
            this.EXCLUIR.Location = new System.Drawing.Point(661, 76);
            this.EXCLUIR.Name = "EXCLUIR";
            this.EXCLUIR.Size = new System.Drawing.Size(75, 23);
            this.EXCLUIR.TabIndex = 10;
            this.EXCLUIR.Text = "Excluir";
            this.EXCLUIR.UseVisualStyleBackColor = true;
            this.EXCLUIR.Click += new System.EventHandler(this.EXCLUIR_Click);
            // 
            // PERQUISA
            // 
            this.PERQUISA.Location = new System.Drawing.Point(12, 568);
            this.PERQUISA.Name = "PERQUISA";
            this.PERQUISA.Size = new System.Drawing.Size(75, 23);
            this.PERQUISA.TabIndex = 11;
            this.PERQUISA.Text = "Pesquisa";
            this.PERQUISA.UseVisualStyleBackColor = true;
            this.PERQUISA.Click += new System.EventHandler(this.PERQUISA_Click);
            // 
            // ALTERAR
            // 
            this.ALTERAR.Location = new System.Drawing.Point(580, 76);
            this.ALTERAR.Name = "ALTERAR";
            this.ALTERAR.Size = new System.Drawing.Size(75, 23);
            this.ALTERAR.TabIndex = 14;
            this.ALTERAR.Text = "Alterar";
            this.ALTERAR.UseVisualStyleBackColor = true;
            this.ALTERAR.Click += new System.EventHandler(this.ALTERAR_Click);
            // 
            // TDATA
            // 
            this.TDATA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TDATA.Location = new System.Drawing.Point(53, 102);
            this.TDATA.Name = "TDATA";
            this.TDATA.Size = new System.Drawing.Size(102, 20);
            this.TDATA.TabIndex = 16;
            // 
            // PESQUISAR
            // 
            this.PESQUISAR.Location = new System.Drawing.Point(499, 77);
            this.PESQUISAR.Name = "PESQUISAR";
            this.PESQUISAR.Size = new System.Drawing.Size(108, 23);
            this.PESQUISAR.TabIndex = 17;
            this.PESQUISAR.Text = "Pesquisar";
            this.PESQUISAR.UseVisualStyleBackColor = true;
            this.PESQUISAR.Visible = false;
            this.PESQUISAR.Click += new System.EventHandler(this.PESQUISAR_Click);
            // 
            // FECHAR_PESQUISA
            // 
            this.FECHAR_PESQUISA.Location = new System.Drawing.Point(628, 76);
            this.FECHAR_PESQUISA.Name = "FECHAR_PESQUISA";
            this.FECHAR_PESQUISA.Size = new System.Drawing.Size(108, 23);
            this.FECHAR_PESQUISA.TabIndex = 18;
            this.FECHAR_PESQUISA.Text = "Sair da Pesquisa";
            this.FECHAR_PESQUISA.UseVisualStyleBackColor = true;
            this.FECHAR_PESQUISA.Visible = false;
            this.FECHAR_PESQUISA.Click += new System.EventHandler(this.FECHAR_PESQUISA_Click);
            // 
            // TDATA_ATE
            // 
            this.TDATA_ATE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TDATA_ATE.Location = new System.Drawing.Point(241, 102);
            this.TDATA_ATE.Name = "TDATA_ATE";
            this.TDATA_ATE.Size = new System.Drawing.Size(102, 20);
            this.TDATA_ATE.TabIndex = 19;
            this.TDATA_ATE.Visible = false;
            // 
            // ATE
            // 
            this.ATE.AutoSize = true;
            this.ATE.Location = new System.Drawing.Point(209, 105);
            this.ATE.Name = "ATE";
            this.ATE.Size = new System.Drawing.Size(26, 13);
            this.ATE.TabIndex = 20;
            this.ATE.Text = "Até:";
            this.ATE.Visible = false;
            // 
            // ABILITAR_DATA
            // 
            this.ABILITAR_DATA.AutoSize = true;
            this.ABILITAR_DATA.Checked = true;
            this.ABILITAR_DATA.Location = new System.Drawing.Point(499, 106);
            this.ABILITAR_DATA.Name = "ABILITAR_DATA";
            this.ABILITAR_DATA.Size = new System.Drawing.Size(80, 17);
            this.ABILITAR_DATA.TabIndex = 21;
            this.ABILITAR_DATA.TabStop = true;
            this.ABILITAR_DATA.Text = "Abilitar data";
            this.ABILITAR_DATA.UseVisualStyleBackColor = true;
            this.ABILITAR_DATA.Visible = false;
            // 
            // DESABILITAR_DATA
            // 
            this.DESABILITAR_DATA.AutoSize = true;
            this.DESABILITAR_DATA.Location = new System.Drawing.Point(586, 107);
            this.DESABILITAR_DATA.Name = "DESABILITAR_DATA";
            this.DESABILITAR_DATA.Size = new System.Drawing.Size(98, 17);
            this.DESABILITAR_DATA.TabIndex = 22;
            this.DESABILITAR_DATA.TabStop = true;
            this.DESABILITAR_DATA.Text = "Desabilitar data";
            this.DESABILITAR_DATA.UseVisualStyleBackColor = true;
            this.DESABILITAR_DATA.Visible = false;
            // 
            // LFRASE
            // 
            this.LFRASE.AutoSize = true;
            this.LFRASE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFRASE.Location = new System.Drawing.Point(15, 13);
            this.LFRASE.Name = "LFRASE";
            this.LFRASE.Size = new System.Drawing.Size(434, 20);
            this.LFRASE.TabIndex = 23;
            this.LFRASE.Text = "Para cadastrar insira os dados e clique em Adicionar.";
            // 
            // LMENSAGEM
            // 
            this.LMENSAGEM.AutoSize = true;
            this.LMENSAGEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMENSAGEM.ForeColor = System.Drawing.Color.Red;
            this.LMENSAGEM.Location = new System.Drawing.Point(256, 598);
            this.LMENSAGEM.Name = "LMENSAGEM";
            this.LMENSAGEM.Size = new System.Drawing.Size(532, 16);
            this.LMENSAGEM.TabIndex = 24;
            this.LMENSAGEM.Text = "Para atualizar ou excluir dados, de clique duplo em cima do item  desejado.";
            this.LMENSAGEM.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 612);
            this.Controls.Add(this.LMENSAGEM);
            this.Controls.Add(this.LFRASE);
            this.Controls.Add(this.DESABILITAR_DATA);
            this.Controls.Add(this.ABILITAR_DATA);
            this.Controls.Add(this.ATE);
            this.Controls.Add(this.TDATA_ATE);
            this.Controls.Add(this.FECHAR_PESQUISA);
            this.Controls.Add(this.PESQUISAR);
            this.Controls.Add(this.TDATA);
            this.Controls.Add(this.ALTERAR);
            this.Controls.Add(this.PERQUISA);
            this.Controls.Add(this.EXCLUIR);
            this.Controls.Add(this.ADICIONAR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TLOCAL);
            this.Controls.Add(this.TGENERO);
            this.Controls.Add(this.TNOME);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LISTA_FILMES);
            this.Name = "Form1";
            this.Text = "Cadastro de filmes Assistidos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LISTA_FILMES;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TNOME;
        private System.Windows.Forms.ComboBox TGENERO;
        private System.Windows.Forms.TextBox TLOCAL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ADICIONAR;
        private System.Windows.Forms.Button EXCLUIR;
        private System.Windows.Forms.Button PERQUISA;
        private System.Windows.Forms.ColumnHeader COLUNA_NOME;
        private System.Windows.Forms.ColumnHeader COLUNA_GÊNERO;
        private System.Windows.Forms.ColumnHeader COLUNA_DATA;
        private System.Windows.Forms.ColumnHeader COLUNA_LOCAL;
        private System.Windows.Forms.Button ALTERAR;
        private System.Windows.Forms.DateTimePicker TDATA;
        private System.Windows.Forms.Button PESQUISAR;
        private System.Windows.Forms.Button FECHAR_PESQUISA;
        private System.Windows.Forms.DateTimePicker TDATA_ATE;
        private System.Windows.Forms.Label ATE;
        private System.Windows.Forms.RadioButton ABILITAR_DATA;
        private System.Windows.Forms.RadioButton DESABILITAR_DATA;
        private System.Windows.Forms.Label LFRASE;
        private System.Windows.Forms.Label LMENSAGEM;
    }
}


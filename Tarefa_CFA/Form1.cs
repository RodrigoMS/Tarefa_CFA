using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tarefa_CFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

//------------------------------- Items para Teste ------------------------------------------------
        public void Incerção_de_item_para_teste()
        {
            //List<Filme> ListaFilmes = new List<Filme>();
            //Filme novoFilme = new Filme();
            //novoFilme.nome = "A Hora do Rush 4"; novoFilme.genero = "Ação"; novoFilme.data = DateTime.Parse("02/07/2011");
            //novoFilme.local = "No cimena"; ListViewItem FILME = new ListViewItem();
            //FILME.Text = novoFilme.nome; FILME.SubItems.Add(novoFilme.genero);
            //FILME.SubItems.Add(novoFilme.data.ToString());
            //FILME.SubItems.Add(novoFilme.local); FILME.Group = LISTA_FILMES.Groups[novoFilme.genero];
            //LISTA_FILMES.Items.Add(FILME);
            //if (Dicionario.ContainsKey(novoFilme.genero))
            //{
            //    ListaFilmes.Add(novoFilme);
            //    Dicionario[novoFilme.genero] = ListaFilmes;
            //}
            //else
            //{
            //    ListaFilmes = new List<Filme>(); ListaFilmes.Add(novoFilme);
            //    Dicionario.Add(novoFilme.genero, ListaFilmes);
            //}

            //novoFilme = new Filme();
            //novoFilme.nome = "Trasnformes 1"; novoFilme.genero = "Ação"; novoFilme.data = DateTime.Parse("04/08/2011");
            //novoFilme.local = "Em casa"; FILME = new ListViewItem();
            //FILME.Text = novoFilme.nome; FILME.SubItems.Add(novoFilme.genero);
            //FILME.SubItems.Add(novoFilme.data.ToString());
            //FILME.SubItems.Add(novoFilme.local); FILME.Group = LISTA_FILMES.Groups[novoFilme.genero];
            //LISTA_FILMES.Items.Add(FILME);
            //if (Dicionario.ContainsKey(novoFilme.genero))
            //{
            //    ListaFilmes.Add(novoFilme);
            //    Dicionario[novoFilme.genero] = ListaFilmes;
            //}
            //else
            //{
            //    ListaFilmes = new List<Filme>(); ListaFilmes.Add(novoFilme);
            //    Dicionario.Add(novoFilme.genero, ListaFilmes);
            //}

            //novoFilme = new Filme();
            //novoFilme.nome = "Hary Photer - E a pedra filisofal"; novoFilme.genero = "Aventura";
            //novoFilme.data = DateTime.Parse("24/06/2009"); novoFilme.local = "No cinema"; FILME = new ListViewItem();
            //FILME.Text = novoFilme.nome; FILME.SubItems.Add(novoFilme.genero);
            //FILME.SubItems.Add(novoFilme.data.ToString());
            //FILME.SubItems.Add(novoFilme.local); FILME.Group = LISTA_FILMES.Groups[novoFilme.genero];
            //LISTA_FILMES.Items.Add(FILME);
            //if (Dicionario.ContainsKey(novoFilme.genero))
            //{
            //    ListaFilmes.Add(novoFilme);
            //    Dicionario[novoFilme.genero] = ListaFilmes;
            //}
            //else
            //{
            //    ListaFilmes = new List<Filme>(); ListaFilmes.Add(novoFilme);
            //    Dicionario.Add(novoFilme.genero, ListaFilmes);
            //}
        }
            
//--------------------------------------------------------------------------------------
        public Dictionary<string, List<Filme>> Dicionario = new Dictionary<string, List<Filme>>();

        private void Form1_Load(object sender, EventArgs e)
        {
            LISTA_FILMES.Groups.Add("Grupo de filmes", "Lista de filmes");
            Incerção_de_item_para_teste();
            ALTERAR.Enabled = false;

            // Criar a lista para usar como fonte personalizado para o TextBox - TNOME.  
            //var COMPLETE = new AutoCompleteStringCollection();
            //COMPLETE.AddRange(new string[]
            //        {
            //            "Harry Photer",
            //            "2012"
            //        });

            //// Criar e inicializar a caixa de texto.

            //TNOME.AutoCompleteCustomSource = COMPLETE;
            //TNOME.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //TNOME.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        public List<Filme> ListaFilmes = new List<Filme>();

        private void ADICIONAR_Click(object sender, EventArgs e)
        {
            if (TGENERO.Text == String.Empty)
            {
                MessageBox.Show("O campo Genero esta em branco.\n Selecione um tipo para cadastrar.", "Campo não preenchido");
            }
            else
            {
                //Cria um objeto com referencia a class Filme
                Filme novoFilme = new Filme();
                //Atribui os valores digitados ao objeto da classe filme
                novoFilme.nome = TNOME.Text;
                novoFilme.genero = TGENERO.Text;
                novoFilme.data = TDATA.Value;
                novoFilme.local = TLOCAL.Text;

                //Mostra o conteúdo da lista de informações para o listView
                ListViewItem FILME = new ListViewItem();
                FILME.Text = novoFilme.nome;
                FILME.SubItems.Add(novoFilme.genero);
                FILME.SubItems.Add(novoFilme.data.ToString());
                FILME.SubItems.Add(novoFilme.local);
                
                //Define o grupo que pertencerá ao listview LISTA_FILME
                FILME.Group = LISTA_FILMES.Groups[novoFilme.genero];

                // Insere o objeto FILME no ListView LISTA_FILME
                LISTA_FILMES.Items.Add(FILME);

                //Insere a ListaFilme no Dicionário
                if (Dicionario.ContainsKey(novoFilme.genero))
                {
                    ListaFilmes.Add(novoFilme);
                    Dicionario[novoFilme.genero] = ListaFilmes;
                }
                else
                {
                    ListaFilmes = new List<Filme>();
                    ListaFilmes.Add(novoFilme);
                    Dicionario.Add(novoFilme.genero,ListaFilmes);
                }

                // Método Limpar
                LIMPAR();
            }
        }
        private void CANCELAR_Click(object sender, EventArgs e)
        {
            LIMPAR();
        }

        public void LIMPAR()
        {
            //Limpa todos os TextBox e posiciona o cursor no TexBox nome
            TNOME.Clear();
            TGENERO.Text = "";
            TLOCAL.Clear();
            TNOME.Focus();
        }

        public List<string> Altera = new List<string>();

        private void LISTA_FILMES_DoubleClick(object sender, EventArgs e)
        {
            foreach (ListViewItem item in LISTA_FILMES.SelectedItems)
            {
                ALTERAR.Enabled = true;
                Filme Filme = new Filme();
                Filme.Selecionado = item.Index;
                TNOME.Text = item.Text;
                TGENERO.Text = item.SubItems[1].Text;
                TDATA.Text = item.SubItems[2].Text;
                TLOCAL.Text = item.SubItems[3].Text;
                Altera.Add(TNOME.Text);
                string GeneroSelc = TGENERO.Text;
                string DataSelec = TDATA.Text;
                string LocalSelec = TLOCAL.Text;
            }
        }

        private void ALTERAR_Click(object sender, EventArgs e)
        {
            Filme Filme = new Filme();
            LISTA_FILMES.Items[Filme.Selecionado].Text = TNOME.Text;
        }

        private void PERQUISAR_Click(object sender, EventArgs e)
        {
            ALTERAR.Visible = false;
            ADICIONAR.Visible = false;
            CANCELAR.Visible = false;
            PERQUISA.Visible = false;
            PESQUISAR.Visible = true;
            FECHAR_PESQUISA.Visible = true;
        }
        private void PESQUISAR_Click(object sender, EventArgs e)
        {
            //Apaga os items do ListView 
            LISTA_FILMES.Items.Clear();
            //Retorna os filmes existentes
            List<Filme> Selecionados = new List<Filme>();
            bool Nome = false, Genero = false, Data = false, Local = false;
            bool NaoEncontrado = true;
            foreach(KeyValuePair<string,List<Filme>> pesq in Dicionario)
            {
                if(pesq.Key == TGENERO.Text)
                {
                    foreach (Filme Pesquisado in pesq.Value)
                    {
                        if (Pesquisado.nome == TNOME.Text)
                        {
                            Nome = true;
                        }
                        if (pesq.Key == TGENERO.Text)
                        {
                            NaoEncontrado = false;
                            Genero = true;
                        }
                        if (Pesquisado.data == TDATA.Value)
                        {
                            Data = true;
                        }
                        if (Pesquisado.local == TLOCAL.Text)
                        {
                            Local = true;
                        }
                        if ((Nome == true || TNOME.Text == "") && (Genero == true || TGENERO.Text == "") && (Data == true) && (Local == true || TLOCAL.Text == ""))
                        {
                            Selecionados.Add(Pesquisado);
                            Nome = false; Genero = false; Local = false; ; Data = false;
                        }
                    }
                }     
            }
            if(NaoEncontrado == true)
            {
                ListViewItem f = new ListViewItem();
                f.Text = "Não a filmes cadastrados neste gênero.";
                f.Group = LISTA_FILMES.Groups["Pesquisa"];
                LISTA_FILMES.Items.Add(f);
            }
            foreach (Filme Mostrar in Selecionados)
            {
                ListViewItem FILMEP = new ListViewItem();
                FILMEP.Text = Mostrar.nome;
                FILMEP.SubItems.Add(Mostrar.genero);
                FILMEP.SubItems.Add(Mostrar.data.ToString());
                FILMEP.SubItems.Add(Mostrar.local);

                FILMEP.Group = LISTA_FILMES.Groups[Mostrar.genero];
                LISTA_FILMES.Items.Add(FILMEP);
            }
        }

        private void FECHAR_PESQUISA_Click(object sender, EventArgs e)
        {
            ALTERAR.Visible = true;
            ADICIONAR.Visible = true;
            CANCELAR.Visible = true;
            PERQUISA.Visible = true;
            PESQUISAR.Visible = false;
            FECHAR_PESQUISA.Visible = false;
        }
    }
}
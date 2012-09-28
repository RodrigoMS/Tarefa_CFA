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

        public Dictionary<string, List<Filme>> Dicionario = new Dictionary<string, List<Filme>>();

        private void Form1_Load(object sender, EventArgs e)
        {
            LISTA_FILMES.Groups.Add("Grupo de filmes", "Lista de filmes");
            ALTERAR.Enabled = false;
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

                // Método Limpar
                LIMPAR();
            }
        }
        private void CANCELAR_Click(object sender, EventArgs e)
        {
            LIMPAR();
        }

        private Filme filmeSobAlteracao;

        private void LISTA_FILMES_DoubleClick(object sender, EventArgs e)
        {
            // O item selecionado é enviodo para os Text Box
            ADICIONAR.Enabled = false;
            foreach (ListViewItem item in LISTA_FILMES.SelectedItems)
            {
                ALTERAR.Enabled = true;
                filmeSobAlteracao = new Filme();
                filmeSobAlteracao.Selecionado = item.Index;
                TNOME.Text = item.Text;
                TGENERO.Text = item.SubItems[1].Text;
                TDATA.Text = item.SubItems[2].Text;
                TLOCAL.Text = item.SubItems[3].Text;
            }
        }

        private void ALTERAR_Click(object sender, EventArgs e)
        {
            //Os items existentes dentro da lista do dicionario são substituidos pelos do TextBox
            int Item;
            foreach (KeyValuePair<string, List<Filme>> Altera in Dicionario)
            {
                foreach (Filme AlterarFilme in Altera.Value)
                {
                    if (AlterarFilme.nome == TNOME.Text)
                    {
                        if (AlterarFilme.genero != TGENERO.Text)
                            Item = Altera.Value.Count;
                        else
                        {
                            AlterarFilme.nome = TNOME.Text;
                            AlterarFilme.genero = TGENERO.Text;
                            AlterarFilme.data = TDATA.Value;
                            AlterarFilme.local = TLOCAL.Text;
                        }
                    }
                } 
            }

            foreach (ListViewItem item in LISTA_FILMES.SelectedItems)
            {
                item.Text = TNOME.Text;
                item.SubItems[1].Text = TGENERO.Text;
                item.SubItems[2].Text = TDATA.Text;
                item.SubItems[3].Text = TLOCAL.Text;
            }
            ADICIONAR.Enabled = true;
            ALTERAR.Enabled = false;
            LIMPAR();
        }

        private void PESQUISAR_Click(object sender, EventArgs e)
        {
            //Apaga os items do ListView 
            LISTA_FILMES.Items.Clear();
            //Retorna os filmes existentes
            List<Filme> Selecionados = new List<Filme>();
            bool NaoEncontrado = true;
            foreach(KeyValuePair<string,List<Filme>> pesq in Dicionario)
            {
                if(pesq.Key == TGENERO.Text || TGENERO.Text == "Todos os gêneros")
                {
                    foreach (Filme Pesquisado in pesq.Value)
                    {
                        if ((Pesquisado.nome == TNOME.Text || TNOME.Text == "") 
                            && (pesq.Key == TGENERO.Text || TGENERO.Text == "Todos os gêneros") 
                            && (ABILITAR_DATA.Checked == false||(Pesquisado.data >= TDATA.Value && Pesquisado.data <= TDATA_ATE.Value)) 
                            && (Pesquisado.local == TLOCAL.Text || TLOCAL.Text == ""))
                        {
                            NaoEncontrado = false;
                            Selecionados.Add(Pesquisado);
                        }
                    }
                }     
            }
            if(NaoEncontrado == true)
            {
                ListViewItem f = new ListViewItem();
                f.Text = "Não a filmes cadastrados.";
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

        private void PERQUISA_Click(object sender, EventArgs e)
        {
            //Abilita e desabilita botões dentro do form
            ALTERAR.Visible = false;
            ADICIONAR.Visible = false;
            CANCELAR.Visible = false;
            PERQUISA.Visible = false;
            PESQUISAR.Visible = true;
            FECHAR_PESQUISA.Visible = true;
            TDATA_ATE.Visible = true;
            ATE.Visible = true;
            ABILITAR_DATA.Visible = true;
            DESABILITAR_DATA.Visible = true;
            TGENERO.Items.Add("Todos os gêneros");
        }

        private void FECHAR_PESQUISA_Click(object sender, EventArgs e)
        {
            //Abilita e desabilita botões dentro do form
            ALTERAR.Visible = true;
            ADICIONAR.Visible = true;
            CANCELAR.Visible = true;
            PERQUISA.Visible = true;
            PESQUISAR.Visible = false;
            FECHAR_PESQUISA.Visible = false;
            TDATA_ATE.Visible = false;
            ATE.Visible = false;
            ABILITAR_DATA.Visible = false;
            DESABILITAR_DATA.Visible = false;
            TGENERO.Items.Remove("Todos os gêneros");
        }

        public void LIMPAR()
        {
            //Limpa todos os TextBox e posiciona o cursor no TexBox nome
            TNOME.Clear();
            TGENERO.Text = "";
            TLOCAL.Clear();
            TNOME.Focus();
        }
    }
}
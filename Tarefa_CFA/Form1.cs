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

        public List<List<string>> ListaFilmes = new List<List<string>>();

        private void Form1_Load(object sender, EventArgs e)
        {
            LISTA_FILMES.Groups.Add("Grupo de filmes", "Lista de filmes");

            //// Criar a lista para usar como fonte personalizado.  
            //var COMPLETE = new AutoCompleteStringCollection();
            //COMPLETE.AddRange(new string[]
            //        {
            //            "Harry Photer",
            //            "2012"
            //        });

            //// Criar e inicializar a caixa de texto.

            //    NOME.AutoCompleteCustomSource = COMPLETE;
            //    NOME.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //    NOME.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void ADICIONAR_Click(object sender, EventArgs e)
        {
            //Cria um objeto com referencia a class Filme
            Filme novoFilme = new Filme();
            if (TGENERO.Text == String.Empty)
            {
                MessageBox.Show("O campo Genero esta em branco.\n Selecione um tipo para cadastrar.", "Campo não preenchido");
            }
            else
            {
                //Atribui os valores digitados ao objeto da classe filme
                novoFilme.nome = TNOME.Text;
                novoFilme.genero = TGENERO.Text;
                novoFilme.data = TDATA.Value;
                novoFilme.local = TLOCAL.Text;

                //Criará uma lista com todas as informações com referecia ao filme
                List<string> InfFilme = new List<string>();
                InfFilme.Add(novoFilme.nome);
                InfFilme.Add(novoFilme.genero);
                InfFilme.Add(novoFilme.data.ToString());
                InfFilme.Add(novoFilme.local);

                ListaFilmes.Add(InfFilme);

                //Mostra o conteúdo da lista de informações para o listView
                ListViewItem FILME = new ListViewItem();
                sbyte I = 0;
                foreach (string n in InfFilme)
                {
                    if (I == 0)
                    {
                        I++;
                        FILME.Text = n;
                    }
                    else
                        FILME.SubItems.Add(n);
                }

                //Define o grupo que pertencerá ao listview LISTA_FILME
                FILME.Group = LISTA_FILMES.Groups[TGENERO.Text];

                // Insere o objeto FILME no ListView LISTA_FILME
                LISTA_FILMES.Items.Add(FILME);

                //Insere o ListaFilme no Dicionário
                novoFilme.Dicionario.Add(TGENERO.Text, ListaFilmes);

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

        private void LISTA_FILMES_DoubleClick(object sender, EventArgs e)
        {
            foreach (ListViewItem item in LISTA_FILMES.SelectedItems)
            {
                Filme Filme = new Filme();
                Filme.Selecionado = item.Index;
                TNOME.Text = item.Text;
                TGENERO.Text = item.SubItems[1].Text;
                TDATA.Text = item.SubItems[2].Text;
                TLOCAL.Text = item.SubItems[3].Text;
            }
        }

        private void ALTERAR_Click(object sender, EventArgs e)
        {
            
            Filme Filme = new Filme();
            LISTA_FILMES.Items[Filme.Selecionado].Text = TNOME.Text;
        }

        private void PERQUISAR_Click(object sender, EventArgs e)
        {
            //Apaga os items do ListView 
            LISTA_FILMES.Items.Clear();

            //Retorna os filmes existentes
            Filme todos = new Filme();
            foreach (List<string> n in ListaFilmes)
            {
                ListViewItem FILMEP = new ListViewItem();
                FILMEP.Text = n[0];
                FILMEP.SubItems.Add(n[1]);
                FILMEP.SubItems.Add(n[2]);
                FILMEP.SubItems.Add(n[3]);

                FILMEP.Group = LISTA_FILMES.Groups[FILMEP.SubItems[1].Text];
                LISTA_FILMES.Items.Add(FILMEP);
            }
        }
    }
}
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

        //public Filme novoFilme = new Filme();

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
                novoFilme.data = TDATA.Text;
                novoFilme.local = TLOCAL.Text;

                //Insere o objeto no ListView 
                ListViewItem FILME = new ListViewItem();
                FILME.Text = novoFilme.nome;
                FILME.SubItems.Add(novoFilme.genero);
                FILME.SubItems.Add(novoFilme.data);
                FILME.SubItems.Add(novoFilme.local);

                //Insere o objeto novoFilme na ListaFilme da class Filme
                novoFilme.ListaFilme.Add(novoFilme.ToString());

                //Define o grupo que pertencerá ao listview LISTA_FILME
                FILME.Group = LISTA_FILMES.Groups[TGENERO.Text];

                // Insere o objeto FILME no ListView LISTA_FILME
                LISTA_FILMES.Items.Add(FILME);


                novoFilme.Dicionario.Add(TGENERO.Text, novoFilme.ListaFilme);
            }
       
            LIMPAR();

        }
        private void CANCELAR_Click(object sender, EventArgs e)
        {
            LIMPAR();
        }

        public void LIMPAR()
        {
            TNOME.Clear();
            TGENERO.Text = "";
            TDATA.Clear();
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
            
        }
    }
}

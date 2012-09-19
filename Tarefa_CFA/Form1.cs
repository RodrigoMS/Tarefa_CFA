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
            //Adicona um novo filme na lista
            Filme novoFilme = new Filme();
            novoFilme.nome = TNOME.Text;
            novoFilme.genero = TGENERO.Text;
            novoFilme.data = TDATA.Text;
            novoFilme.local = TLOCAL.Text;

            ListViewItem FILME = new ListViewItem();
            FILME.Text = novoFilme.nome;
            FILME.SubItems.Add(novoFilme.genero);
            FILME.SubItems.Add(novoFilme.data);
            FILME.SubItems.Add(novoFilme.local);

            novoFilme.L.Add(novoFilme.ToString());

            //L.Add(TGENERO.Text);
            //L.Add(TDATA.Text);
            //L.Add(TLOCAL.Text);
            

            FILME.Group = LISTA_FILMES.Groups[TGENERO.Text];

            LISTA_FILMES.Items.Add(FILME);

            Dictionary<string,List<string>> d = new Dictionary<string,List<string>>();
            d.Add(TGENERO.Text,novoFilme.L);

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
           //string selecionado;
           //foreach (ListViewItem item in LISTA_FILMES.SelectedItems)
           //{
           //    selecionado = LISTA_FILMES.SubItem[item].Text;
           //}

           // TNOME.Text = FILME_SELECT.Text;
           // TGENERO.Text = FILME_SELECT.SubItems[1].Text;
           // TDATA.Text = FILME_SELECT.SubItems[2].Text;
           // TLOCAL.Text = FILME_SELECT.SubItems[3].Text;
        }
    }
}

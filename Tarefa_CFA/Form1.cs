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

        //class filme : IComparable
        //{
        //    public string nome;
        //    public string genero;
        //    public int data;
        //    public string local;
        //}

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

            ListViewItem FILME = new ListViewItem();
            FILME.Text = NOME.Text;
            FILME.SubItems.Add(GENERO.Text);
            FILME.SubItems.Add(DATA.Text);
            FILME.SubItems.Add(LOCAL.Text);

            FILME.Group = LISTA_FILMES.Groups[GENERO.Text];

            LISTA_FILMES.Items.Add(FILME);

            Dictionary<string, int> d = new Dictionary<string, int>();
            

            LIMPAR();
        }

        private void CANCELAR_Click(object sender, EventArgs e)
        {
            LIMPAR();
        }

        public void LIMPAR()
        {
            NOME.Clear();
            GENERO.Text = "";
            DATA.Clear();
            LOCAL.Clear();
            NOME.Focus();
        }

        private void LISTA_FILMES_DoubleClick(object sender, EventArgs e)
        {
            //ListViewItem FILME_SELECT = new ListViewItem();
            //NOME.Text = FILME_SELECT.Text;
            //GENERO.Text = FILME_SELECT.SubItems[1].Text;
            //DATA.Text = FILME_SELECT.SubItems[2].Text;
            //LOCAL.Text = FILME_SELECT.SubItems[3].Text;
        }
    }
}

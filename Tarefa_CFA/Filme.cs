using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarefa_CFA
{
    class Filme
    {
        public string nome;
        public string genero;
        public DateTime data;
        public string local;
        public int Selecionado;

        //public Dictionary<string, List<string>> Dicionario = new Dictionary<string, List<string>>();
        public Dictionary<string, List<List<string>>> Dicionario = new Dictionary<string, List<List<string>>>();
    }
}

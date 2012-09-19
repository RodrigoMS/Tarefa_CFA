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
        public string data;
        public string local;

        public Dictionary<string, List<string>> D = new Dictionary<string, List<string>>();
        public List<string> L = new List<string>();
    }
}

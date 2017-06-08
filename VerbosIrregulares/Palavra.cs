using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerbosIrregulares
{

    //herança e interface
    class Palavra:Erro,IPalavra
    {
        public string infinitive, simplePresent, pastParticiple;


        public string getWord(int id_word)
        {
            //Conexão com banco de dados
            CSFerramentasEntities conn = new CSFerramentasEntities();
            
            //Selecionando a palavra para a questão
            string word = (from x in conn.fn_word(id_word) select x.translate).First();
            return word;
        }


    }
}

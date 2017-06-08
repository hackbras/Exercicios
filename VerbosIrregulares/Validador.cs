using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerbosIrregulares
{
    class Validador
    {
        //Instanciando objeto conexão
        CSFerramentasEntities conn = new CSFerramentasEntities();
        public string Validar(Label translate, TextBox infinitive, TextBox pastSimple, TextBox pastparticiple)
        {
            var result = (from x in conn.fn_verbos(translate.Text, infinitive.Text, pastSimple.Text, pastparticiple.Text) select x.resultado).First();
            result = (from x in conn.fn_verbos(translate.Text, infinitive.Text, pastSimple.Text, pastparticiple.Text) select x.resultado).First();
            
            return result;
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace VerbosIrregulares
{
    public partial class ScreenExercices : Form
    {
        //encapsulamento

        public string status,result;
        private string label;
        public const int questions = 5;
        public int count = 1;
        
        //Propriedades
        public string Label
        {
            get
            {
                return label;
            }
            set
            {
                label= value.ToString();
                lblChosenWord.Text = label;
            }
        }
        
        //Instanciando os objetos

        Random RN = new Random();
        Palavra word = new Palavra();
        CSFerramentasEntities conn = new CSFerramentasEntities();
        Stopwatch s = new Stopwatch();
        DateTime horario = DateTime.Now;
        Notificador msg = new Notificador();

        public ScreenExercices()
        {
            InitializeComponent();
            lblHorario.Text = horario.ToString("HH:mm:ss");

            lblChosenWord.Text = word.getWord(RN.Next(122, 241)); //"1,120 ou 122, 241"; //
            lblNumberExercice.Text = count.ToString();
        }

        private void tbInfinitive_Leave(object sender, EventArgs e)
        {
            tbInfinitive.Enabled = false;
            word.infinitive = lblStatusInfinitive.Text;
        }

        private void tbSimplePast_Leave(object sender, EventArgs e)
        {
            tbSimplePast.Enabled = false;
            word.simplePresent = lblStatusSimplePast.Text;

        }

        private void tbPastParticiple_Leave(object sender, EventArgs e)
        {
            tbPastParticiple.Enabled = false;
            word.pastParticiple = lblStatusPastParticiple.Text;

            msg.Formatar(lblChosenWord,tbInfinitive,tbSimplePast,tbPastParticiple,lblStatusWord, lblStatusInfinitive, lblStatusSimplePast, lblStatusPastParticiple);
         }


        private void ScreenExercices_Load(object sender, EventArgs e)
        {
            this.Location = new Point(990, 438);
        }

        private void btnNextVerb_Click(object sender, EventArgs e)
        {
            lblChosenWord.Text = word.getWord(RN.Next(122, 241)); //servico: 1,120 // note: 122, 241


            tbInfinitive.Text = "";
            tbInfinitive.Enabled = true;
            lblStatusInfinitive.Text = "";


            tbSimplePast.Text = "";
            tbSimplePast.Enabled = true;
            lblStatusSimplePast.Text = "";

            tbPastParticiple.Text = "";
            tbPastParticiple.Enabled = true;
            lblStatusPastParticiple.Text = "";

            lblStatusWord.Text = "";

            if (count < questions)
            {
                count = count + 1;
                lblNumberExercice.Text = count.ToString();
            }
            else this.Close();

        }


    }
}

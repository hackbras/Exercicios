using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerbosIrregulares
{
    class Notificador
    {
        public void Formatar(Label translate, TextBox infinitive, TextBox pastSimple, TextBox pastparticiple, Label status, Label lblStatusInfinitive, Label lblStatusSimplePast, Label lblStatusPastParticiple)
        {
            Validador check = new Validador();
            string result;

            result = check.Validar(translate, infinitive, pastSimple, pastparticiple);

            result.Substring(0, 1);

            switch (result.Substring(0, 1))
            {
                //
                case "N":
                    switch (result.Substring(1, 1))
                    {
                        case "N":
                            switch (result)
                            {
                                case "NNN": //infinitive.BackColor = Color.Yellow; pastSimple.BackColor = Color.Yellow; pastParticiple.BackColor = Color.Yellow; 
                                    status.Visible = true;
                                    status.Text = "Vazio";
                                    lblStatusInfinitive.Text = "Campo vazio";
                                    lblStatusSimplePast.Text = "Campo vazio";
                                    lblStatusPastParticiple.Text = "Campo vazio"; break;
                                case "NNE": //infinitive.BackColor = Color.Yellow; pastSimple.BackColor = Color.Yellow; pastParticiple.BackColor = Color.Red; 
                                    status.Visible = true;
                                    status.Text = "Campos Vazios";
                                    lblStatusInfinitive.Text = "Campo vazio";
                                    lblStatusSimplePast.Text = "Campo vazio";
                                    lblStatusPastParticiple.Text = "Errado"; break;
                                case "NNC": //infinitive.BackColor = Color.Yellow; pastSimple.BackColor = Color.Yellow; pastParticiple.BackColor = Color.Green; 
                                    status.Visible = true;
                                    status.Text = "Campos Vazios";
                                    lblStatusInfinitive.Text = "Campo vazio";
                                    lblStatusSimplePast.Text = "Campo vazio";
                                    lblStatusPastParticiple.Text = "Certo"; break;

                            }
                            break;

                        case "C":
                            switch (result)
                            {
                                case "NCC": //infinitive.BackColor = Color.Yellow; pastSimple.BackColor = Color.Green; pastParticiple.BackColor = Color.Green; 
                                    status.Visible = true;
                                    status.Text = "Campo Vazio";
                                    lblStatusInfinitive.Text = "Campo vazio";
                                    lblStatusSimplePast.Text = "Certo";
                                    lblStatusPastParticiple.Text = "Certo"; break;
                                case "NCN": //infinitive.BackColor = Color.Yellow; pastSimple.BackColor = Color.Green; pastParticiple.BackColor = Color.Yellow; 
                                    status.Visible = true;
                                    status.Text = "Campos Vazios";
                                    lblStatusInfinitive.Text = "Campo vazio";
                                    lblStatusSimplePast.Text = "certo";
                                    lblStatusPastParticiple.Text = "Campo vazio"; break;
                                case "NCE": //infinitive.BackColor = Color.Yellow; pastSimple.BackColor = Color.Green; pastParticiple.BackColor = Color.Red; 
                                    status.Visible = true;
                                    status.Text = "Campo Vazio";
                                    lblStatusInfinitive.Text = "Campo vazio";
                                    lblStatusSimplePast.Text = "Certo";
                                    lblStatusPastParticiple.Text = "Errado"; break;

                            }
                            break;

                        case "E":
                            switch (result)
                            {
                                case "NEC": //infinitive.BackColor = Color.Yellow; pastSimple.BackColor = Color.Red; pastParticiple.BackColor = Color.Green; 
                                    status.Visible = true;
                                    status.Text = "Campo Vazio";
                                    lblStatusInfinitive.Text = "Campo vazio";
                                    lblStatusSimplePast.Text = "Errado";
                                    lblStatusPastParticiple.Text = "Certo"; break;
                                case "NEN": //infinitive.BackColor = Color.Yellow; pastSimple.BackColor = Color.Red; pastParticiple.BackColor = Color.Yellow; 
                                    status.Visible = true;
                                    status.Text = "Campos Vazios";
                                    lblStatusInfinitive.Text = "Campo vazio";
                                    lblStatusSimplePast.Text = "Errado";
                                    lblStatusPastParticiple.Text = "Campo vazio"; break;
                                case "NEE": //infinitive.BackColor = Color.Yellow; pastSimple.BackColor = Color.Red; pastParticiple.BackColor = Color.Red; 
                                    status.Visible = true;
                                    status.Text = "Campos Vazios";
                                    lblStatusInfinitive.Text = "Campo vazio";
                                    lblStatusSimplePast.Text = "Errado";
                                    lblStatusPastParticiple.Text = "Errado"; break;

                            }
                            break;
                    }
                    break;


                //
                case "C":
                    switch (result.Substring(1, 1))
                    {
                        case "N":
                            switch (result)
                            {
                                case "CNN": //infinitive.BackColor = Color.Green; pastSimple.BackColor = Color.Yellow; pastParticiple.BackColor = Color.Yellow; 
                                    status.Visible = true;
                                    status.Text = "Campos Vazios";
                                    lblStatusInfinitive.Text = "Certo";
                                    lblStatusSimplePast.Text = "Campo vazio";
                                    lblStatusPastParticiple.Text = "Campo vazio"; break;
                                case "CNC": //infinitive.BackColor = Color.Green; pastSimple.BackColor = Color.Yellow; pastParticiple.BackColor = Color.Green; 
                                    status.Visible = true;
                                    status.Text = "Campo Vazio";
                                    lblStatusInfinitive.Text = "Certo";
                                    lblStatusSimplePast.Text = "Campo vazio";
                                    lblStatusPastParticiple.Text = "Certo"; break;
                                case "CNE": //infinitive.BackColor = Color.Green; pastSimple.BackColor = Color.Yellow; pastParticiple.BackColor = Color.Red; 
                                    status.Visible = true;
                                    status.Text = "Campo Vazio";
                                    lblStatusInfinitive.Text = "Certo";
                                    lblStatusSimplePast.Text = "Campo vazio";
                                    lblStatusPastParticiple.Text = "Errado"; break;
                            }
                            break;

                        case "C":
                            switch (result)
                            {
                                case "CCN": //infinitive.BackColor = Color.Green; pastSimple.BackColor = Color.Green; pastParticiple.BackColor = Color.Yellow; 
                                    status.Visible = true; status.Text = "Campo Vazio";
                                    lblStatusInfinitive.Text = "Certo";
                                    lblStatusSimplePast.Text = "Certo";
                                    lblStatusPastParticiple.Text = "Campo vazio"; break;
                                case "CCE": //infinitive.BackColor = Color.Green; pastSimple.BackColor = Color.Green; pastParticiple.BackColor = Color.Red; 
                                    status.Visible = true; status.Text = "Você está quase lá";
                                    lblStatusInfinitive.Text = "Certo";
                                    lblStatusSimplePast.Text = "Certo";
                                    lblStatusPastParticiple.Text = "Campo vazio"; break;
                                case "CCC": //infinitive.BackColor = Color.Green; pastSimple.BackColor = Color.Green; pastParticiple.BackColor = Color.Green; 
                                    status.Visible = true; status.Text = "Certo";
                                    lblStatusInfinitive.Text = "Certo";
                                    lblStatusSimplePast.Text = "Certo";
                                    lblStatusPastParticiple.Text = "Certo"; break;

                            }
                            break;

                        case "E":
                            switch (result)
                            {
                                case "CEE": //infinitive.BackColor = Color.Green; pastSimple.BackColor = Color.Red; pastParticiple.BackColor = Color.Red; 
                                    status.Visible = true; status.Text = "Estude  Mais";
                                    lblStatusInfinitive.Text = "Certo";
                                    lblStatusSimplePast.Text = "Errado";
                                    lblStatusPastParticiple.Text = "Errado"; break;
                                case "CEC": //infinitive.BackColor = Color.Green; pastSimple.BackColor = Color.Red; pastParticiple.BackColor = Color.Green; 
                                    status.Visible = true; status.Text = "Você está quase lá";
                                    lblStatusInfinitive.Text = "Certo";
                                    lblStatusSimplePast.Text = "Errado";
                                    lblStatusPastParticiple.Text = "Certo"; break;
                                case "CEN": //infinitive.BackColor = Color.Green; pastSimple.BackColor = Color.Red; pastParticiple.BackColor = Color.Yellow; 
                                    status.Visible = true; status.Text = "Campo Vazio";
                                    lblStatusInfinitive.Text = "Certo";
                                    lblStatusSimplePast.Text = "Errado";
                                    lblStatusPastParticiple.Text = "Campo vazio"; break;

                            }
                            break;
                    }
                    break;


                //
                case "E":
                    switch (result.Substring(1, 1))
                    {
                        case "N":
                            switch (result)
                            {
                                case "ENE": //infinitive.BackColor = Color.Red; pastSimple.BackColor = Color.Yellow; pastParticiple.BackColor = Color.Red; 
                                    status.Visible = true; status.Text = "Estude Mais";
                                    lblStatusInfinitive.Text = "Errado";
                                    lblStatusSimplePast.Text = "Campo vazio";
                                    lblStatusPastParticiple.Text = "Errado"; break;
                                case "ENC": //infinitive.BackColor = Color.Red; pastSimple.BackColor = Color.Yellow; pastParticiple.BackColor = Color.Green; 
                                    status.Visible = true; status.Text = "Campo Vazio";
                                    lblStatusInfinitive.Text = "Errado";
                                    lblStatusSimplePast.Text = "Campo vazio";
                                    lblStatusPastParticiple.Text = "Certo"; break;
                                case "ENN": //infinitive.BackColor = Color.Red; pastSimple.BackColor = Color.Yellow; pastParticiple.BackColor = Color.Yellow; 
                                    status.Visible = true; status.Text = "Campos Vazios";
                                    lblStatusInfinitive.Text = "Errado";
                                    lblStatusSimplePast.Text = "Campo vazio";
                                    lblStatusPastParticiple.Text = "Campo vazio"; break;

                            }
                            break;

                        case "C":
                            switch (result)
                            {
                                case "ECC": //infinitive.BackColor = Color.Red; pastSimple.BackColor = Color.Green; pastParticiple.BackColor = Color.Green; 
                                    status.Visible = true; status.Text = "Você está quase lá";
                                    lblStatusInfinitive.Text = "Errado";
                                    lblStatusSimplePast.Text = "Certo";
                                    lblStatusPastParticiple.Text = "Certo"; break;
                                case "ECE": //infinitive.BackColor = Color.Red; pastSimple.BackColor = Color.Green; pastParticiple.BackColor = Color.Red; 
                                    status.Visible = true; status.Text = "Estude  Mais";
                                    lblStatusInfinitive.Text = "Errado";
                                    lblStatusSimplePast.Text = "Certo";
                                    lblStatusPastParticiple.Text = "Errado"; break;
                                case "ECN": //infinitive.BackColor = Color.Red; pastSimple.BackColor = Color.Green; pastParticiple.BackColor = Color.Yellow; 
                                    status.Visible = true; status.Text = "Campo Vazio";
                                    lblStatusInfinitive.Text = "Errado";
                                    lblStatusSimplePast.Text = "Certo";
                                    lblStatusPastParticiple.Text = "Campo vazio"; break;

                            }
                            break;

                        case "E":
                            switch (result)
                            {
                                case "EEC": //infinitive.BackColor = Color.Red; pastSimple.BackColor = Color.Red; pastParticiple.BackColor = Color.Green; 
                                    status.Visible = true; status.Text = "Estude  Mais";
                                    lblStatusInfinitive.Text = "Errado";
                                    lblStatusSimplePast.Text = "Errado";
                                    lblStatusPastParticiple.Text = "Certo"; break;
                                case "EEE": //infinitive.BackColor = Color.Red; pastSimple.BackColor = Color.Red; pastParticiple.BackColor = Color.Red; 
                                    status.Visible = true; status.Text = "Todos Errados";
                                    lblStatusInfinitive.Text = "Errado";
                                    lblStatusSimplePast.Text = "Errado";
                                    lblStatusPastParticiple.Text = "Errado"; break;
                                case "EEN": //infinitive.BackColor = Color.Red; pastSimple.BackColor = Color.Red; pastParticiple.BackColor = Color.Red; 
                                    status.Visible = true; status.Text = "Campos Errados";
                                    lblStatusInfinitive.Text = "Errado";
                                    lblStatusSimplePast.Text = "Errado";
                                    lblStatusPastParticiple.Text = "Campo em branco"; break;
                            }
                            break;
                    }
                    break;

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApopeiStefan_CSI.Forms
{
    public partial class DecriptPlayfair : Form
    {
        private string TextforDecripting { get; set; }
        private string Cheie { get; set; }
        public DecriptPlayfair()
        {
            InitializeComponent();
        }

        private void OnClickDecriptPlayfaire(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxCheie.Text))
                {
                    MessageBox.Show("Trebuie sa dati o cheie", "Avertizare", MessageBoxButtons.OK);
                    return;
                }
                if (string.IsNullOrWhiteSpace(textBoxText.Text))
                {
                    MessageBox.Show("Trebuie sa dati un text", "Avertizare", MessageBoxButtons.OK);
                    return;
                }
                //pregatire text
                TextforDecripting = textBoxText.Text.ToUpper().Replace(" ", ""); ;
                //TextforDecripting = TextforDecripting.Replace('J', 'I');
                //for (int i = 1; i < TextforDecripting.Length; i++)
                //{
                //    if (TextforDecripting[i].Equals(TextforDecripting[i - 1]))
                //    {
                //        TextforDecripting = TextforDecripting.Insert(i, "X");
                //    }
                //}
                //if (TextforDecripting.Length % 2 == 1)
                //{
                //    TextforDecripting = TextforDecripting.Insert(TextforDecripting.Length, "X");
                //}
                for (int i = 2; i < TextforDecripting.Length; i += 2)
                {
                    TextforDecripting = TextforDecripting.Insert(i, " ");
                    i++;
                }
                //create matrice 5x5
                string[,] Matrice = new string[5, 5];
                Cheie = new string(textBoxCheie.Text.ToCharArray().Distinct().ToArray()).Replace(" ", "").ToUpper();
                string[] Alfabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
                int contorCheie = 0;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (contorCheie < Cheie.Length)
                        {
                            Matrice[i, j] = Cheie[contorCheie].ToString();
                            contorCheie++;
                        }
                        else
                        {
                            //trebuie sa complete cu literele alfabetic ce nu apar in cheie
                            Matrice[i, j] = Alfabet[0].ToString();
                        }
                        foreach (string litera in Alfabet)
                        {
                            if (litera.ToString().Contains(Matrice[i, j].ToString()))
                            {
                                Alfabet = Alfabet.Where(val => val != litera).ToArray();
                            }
                        }
                    }
                }
                textBoxTextCriptat.Text = ConstructDecriptedMessage(TextforDecripting.Replace(" ", ""), Matrice);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public static string RemoveDuplicates(string input)
        {
            return new string(input.ToCharArray().Distinct().ToArray());
        }
        public static string ConstructDecriptedMessage(string inputMessage, string[,] Matrice)
        {
            string[] inputString = new string[inputMessage.Length/2];
            string criptedMessage = "";
            int contorTemporar = 0;
            for (int i = 0; i < inputMessage.Length; i += 2)
            {
                inputString[contorTemporar] = inputMessage[i].ToString() + inputMessage[i + 1].ToString();
                contorTemporar++;
            }

            foreach (string cuplu in inputString)
            {
                string cupluLitera1 = cuplu[0].ToString(); int cupluLitera1CoordX = -1; int cupluLitera1CoordY = -1;
                string cupluLitera2 = cuplu[1].ToString(); int cupluLitera2CoordX = -1; int cupluLitera2CoordY = -1;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        //iau coordonatele
                        if (cupluLitera1.Contains(Matrice[i, j].ToString()))
                        {
                            cupluLitera1CoordX = i;
                            cupluLitera1CoordY = j;
                        }
                        if (cupluLitera2.Contains(Matrice[i, j].ToString()))
                        {
                            cupluLitera2CoordX = i;
                            cupluLitera2CoordY = j;
                        }
                        //vad care caz il aplic
                        if (cupluLitera1CoordX >= 0 && cupluLitera2CoordX >= 0)
                        {
                            //literele sunt pe aceeasi coloana
                            if (cupluLitera1CoordY == cupluLitera2CoordY)
                            {
                                if (cupluLitera2CoordX >0  && cupluLitera1CoordX >0) //sunt in mijloc
                                    criptedMessage = criptedMessage + Matrice[--cupluLitera1CoordX, cupluLitera1CoordY].ToString() + Matrice[--cupluLitera2CoordX, cupluLitera2CoordY].ToString();
                                else
                                if (cupluLitera2CoordX == 0 && cupluLitera1CoordX > 0)
                                    criptedMessage = criptedMessage + Matrice[--cupluLitera1CoordX, cupluLitera1CoordY].ToString() + Matrice[4, cupluLitera2CoordY].ToString();
                                else
                                if (cupluLitera2CoordX > 0 && cupluLitera1CoordX == 0)
                                    criptedMessage = criptedMessage + Matrice[4, cupluLitera1CoordY].ToString() + Matrice[--cupluLitera2CoordX, cupluLitera2CoordY].ToString();
                            }
                            else
                            //literele sunt pe aceasi linie
                            if (cupluLitera1CoordX == cupluLitera2CoordX)
                            {
                                if (cupluLitera2CoordY > 0 && cupluLitera1CoordY >0)
                                    criptedMessage = criptedMessage + Matrice[cupluLitera1CoordX, --cupluLitera1CoordY].ToString() + Matrice[cupluLitera2CoordX, --cupluLitera2CoordY].ToString();
                                else
                                if (cupluLitera2CoordY == 0 && cupluLitera1CoordY >0)
                                    criptedMessage = criptedMessage + Matrice[cupluLitera1CoordX, --cupluLitera1CoordY].ToString() + Matrice[cupluLitera2CoordX, 4].ToString();
                                else
                                if (cupluLitera2CoordY >0 && cupluLitera1CoordY == 0)
                                    criptedMessage = criptedMessage + Matrice[cupluLitera1CoordX, 4].ToString() + Matrice[cupluLitera2CoordX, --cupluLitera2CoordY].ToString();
                            }
                            else
                            {
                                criptedMessage = criptedMessage + Matrice[cupluLitera1CoordX, cupluLitera2CoordY].ToString() + Matrice[cupluLitera2CoordX, cupluLitera1CoordY].ToString();
                            }
                            i = 5; j = 5;
                            //fortez sa iasa din bucla cand am gasit cuplul
                        }
                    }
                }
            }
            return criptedMessage;
        }
    }
}

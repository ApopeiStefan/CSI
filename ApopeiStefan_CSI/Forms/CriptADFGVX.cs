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
    public partial class CriptADFGVX : Form
    {
        private string CheiaUnu { get; set; }
        private string CheiaDoi { get; set; }
        private string MesajDeCriptat { get; set; }
        public CriptADFGVX()
        {
            InitializeComponent();
        }

        private void OnClickCriptADFGVX(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxCheie1.Text) || string.IsNullOrWhiteSpace(textBoxCheie2.Text))
                {
                    MessageBox.Show("Trebuie sa dati dati ambele chei", "Avertizare", MessageBoxButtons.OK);
                    return;
                }
                if (string.IsNullOrWhiteSpace(textBoxText.Text))
                {
                    MessageBox.Show("Trebuie sa dati un text", "Avertizare", MessageBoxButtons.OK);
                    return;
                }
                CheiaUnu = PrelucrareCheie(textBoxCheie1.Text);
                CheiaDoi = PrelucrareCheie(textBoxCheie2.Text);
                MesajDeCriptat = textBoxText.Text.Replace(" ","");
                //create matrice 5x5
                string[,] Matrice = new string[7, 7];
                string[,] MatriceFinala = new string[CheiaDoi.Length, CheiaDoi.Length+1];
                Matrice[0, 1] = "A";
                Matrice[0, 2] = "D";
                Matrice[0, 3] = "F";
                Matrice[0, 4] = "G";
                Matrice[0, 5] = "V";
                Matrice[0, 6] = "X";
                Matrice[1, 0] = "A";
                Matrice[2, 0] = "D";
                Matrice[3, 0] = "F";
                Matrice[4, 0] = "G";
                Matrice[5, 0] = "V";
                Matrice[6, 0] = "X";
                Matrice = CreareMatrice1(Matrice, CheiaUnu);
                MatriceFinala = CreareMatriceFinala(MatriceFinala,CheiaDoi, MesajDeCriptat);
                for (int i = 0; i < 7; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        Console.Write(MatriceFinala[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Avertizare", MessageBoxButtons.OK);
            }
        }

        private string PrelucrareCheie(string cheie)
        {
            try
            {
                string cheieTemporara = "";
                cheieTemporara = cheie.ToUpper().Replace(" ", "");
                cheieTemporara = RemoveDuplicates(cheieTemporara);
                return cheieTemporara;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Avertizare", MessageBoxButtons.OK);
                return null;
            }
        }
        public static string RemoveDuplicates(string input)
        {
            return new string(input.ToCharArray().Distinct().ToArray());
        }
        public static string[,] CreareMatrice1(string[,] Matrice, string cheie)
        {
            try
            {
                string CheieUnu = cheie;
                string[] Alfabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I","J" ,"K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
                int contorCheie = 0;
                for (int i = 1; i < 7; i++)
                {
                    for (int j = 1; j < 7; j++)
                    {
                        if (contorCheie < CheieUnu.Length)
                        {
                            Matrice[i, j] = CheieUnu[contorCheie].ToString();
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
                return Matrice;
            }catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "Avertizare", MessageBoxButtons.OK);
                return null;
            }
        }
        public static string[,] CreareMatriceFinala(string[,] Matrice, string cheie,string text)
        { 
            try
            {
                string[] textCriptatVunu;
                foreach(char litera in text)
                {
                    for (int i = 1; i < 7; i++)
                    {
                        for (int j = 1; j < 7; j++)
                        {

                        }
                    }
                }
              
               return Matrice;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "Avertizare", MessageBoxButtons.OK);
                return null;
            }
        }

    }
}

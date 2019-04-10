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
    public partial class CriptACAHomofonic : Form
    {
        public string TextDeCriptat { get; set; }
        public string Cheia { get; set; }
        public CriptACAHomofonic()
        {
            InitializeComponent();
        }

        private void OnClickCriptare(object sender, EventArgs e)
        {
            try
            {
                textBoxTextDecriptat.Clear();
                if (string.IsNullOrWhiteSpace(textBoxText.Text))
                {
                    MessageBox.Show("Trebuie sa dati un text", "Avertizare", MessageBoxButtons.OK);
                    return;
                }
                if (string.IsNullOrWhiteSpace(textBoxCheie.Text))
                {
                    MessageBox.Show("Trebuie sa dati o cheie", "Avertizare", MessageBoxButtons.OK);
                    return;
                }
                if (textBoxCheie.Text.Length>4 || textBoxCheie.Text.Length < 4)
                {
                    MessageBox.Show("Cheia trebuie sa aiba exact 4 litere.", "Avertizare", MessageBoxButtons.OK);
                    return;
                }
                TextDeCriptat = textBoxText.Text.ToUpper().Replace(" ", "").TrimEnd();
                Cheia = textBoxCheie.Text.ToUpper();
                string[] alfabet = { "A","B","C","D","E","F","G","H","I/J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
                string[,] matrix = new string[4, alfabet.Length];
                matrix = CompleteazaMatricea(alfabet, matrix, Cheia);
                foreach(char litera in TextDeCriptat)
                {
                    int indice = GetIndexofLetter(alfabet, litera.ToString());
                    Random rnd = new Random();
                    int randomNumber = rnd.Next(0, 3);
                    textBoxTextDecriptat.Text = textBoxTextDecriptat.Text + matrix[randomNumber, indice].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private string[,] CompleteazaMatricea(string[] alfabet, string[,] matrice,string cheie)
        {
            try
            {
                string[] liniaUnu = {"01", "02", "03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25"};
                string[] liniaDoi = { "26","27","28","29","30","31","32","33","34","35","36","37","38","39","40","41","42","43","44","45","46","47","48","49","50" };
                string[] liniaTrei = { "51","52","53","54","55","56","57","58","59","60","61","62","63","64","65","66","67","68","69","70","71","72","73","74","75"};
                string[] liniaPatru = {"76","77","78","79","80","81","82","83","84","85","86","87","88","89","90","91","92","93","94","95","96","97","98","99","00"};

                //linia unu
                int indice = GetIndexofLetter(alfabet, (cheie.ToCharArray())[0].ToString());
                matrice = PopulateLine(matrice, liniaUnu, indice, 0);
                //linia doi
                indice = GetIndexofLetter(alfabet, (cheie.ToCharArray())[1].ToString());
                matrice = PopulateLine(matrice, liniaDoi, indice, 1);
                //linia trei
                indice = GetIndexofLetter(alfabet, (cheie.ToCharArray())[2].ToString());
                matrice = PopulateLine(matrice, liniaTrei, indice, 2);
                //linia patru
                indice = GetIndexofLetter(alfabet, (cheie.ToCharArray())[3].ToString());
                matrice = PopulateLine(matrice, liniaPatru, indice, 3);
                return matrice;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
        private int GetIndexofLetter(string[] alfabet, string litera)
        {
            try
            {
                for(int i=0;i<alfabet.Length;i++)
                {
                    int indice=int.MaxValue;
                    if(alfabet[i].Contains(litera))
                    {
                        indice = i;
                        return indice;
                    }
                        
                }
                return int.MaxValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return int.MaxValue;
            }
        }
        private string[,] PopulateLine(string[,] matrice, string[] lineNumbers, int startIndex, int linie)
        {
            try{
            int j = 0;
            for (int i = startIndex; i < lineNumbers.Length; i++)
            {
                matrice[linie,i] = lineNumbers[j];
                j++;
            }
            if (startIndex > 0)
            {
                int index = 0;
                while (index < startIndex)
                {
                    matrice[linie,index] = lineNumbers[j];
                    index++;
                }
            }
            return matrice;
        }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
    }
}

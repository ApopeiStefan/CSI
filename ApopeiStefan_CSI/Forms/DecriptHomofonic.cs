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
    public partial class DecriptHomofonic : Form
    {
        private string[] TextCriptat { get; set; }
        private string CurentLetterVector { get; set; }
        private string[] ReadingOrder = {"E","T","O","I","A","N","R","H","L","D","U","C","M","P","Y","F","G","W","B","V","K","X","J","Q","Z"};
        public DecriptHomofonic()
        {
            InitializeComponent();
        }

        private void OnClickDecriptare(object sender, EventArgs e)
        {
            try
            {
                textBoxTextDecriptat.Clear();
                if (string.IsNullOrWhiteSpace(textBoxText.Text))
                {
                    MessageBox.Show("Trebuie sa dati un text", "Avertizare", MessageBoxButtons.OK);
                    return;
                }
                TextCriptat = ConvertToVector(textBoxText.Text.ToUpper().Replace(" ",""));
                for(int i= 0; i < TextCriptat.Length;i+=2)
                {
                    string litera = TextCriptat[i]+ TextCriptat[i+1];
                    CurentLetterVector = GetCurentLetterVector(litera.ToString());
                    if(CurentLetterVector!=null)
                       textBoxTextDecriptat.Text = textBoxTextDecriptat.Text + CurentLetterVector; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private string GetCurentLetterVector(string currentLetter)
        {
            try
            {
                foreach(string vector in ReadingOrder)
                {
                    string[] CurentLetterVector = Properties.Resources.ResourceManager.GetString(vector).Split(',');
                    if (CurentLetterVector.Contains(currentLetter))
                        return vector;
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
        private string[] ConvertToVector(string text)
        {
            string[] vectorTemporar=new string[text.Length];
            int i = 0;
            foreach(char litera in text)
            {
                vectorTemporar[i] = litera.ToString();
                i++;
            }
            return vectorTemporar;
        }
    }
}

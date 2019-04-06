using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace ApopeiStefan_CSI.Forms
{
    public partial class CriptHomofonic : Form
    {
        private string TextDeCriptat { get; set; }
        private string[] CurentLetterVector { get; set; }
        public CriptHomofonic()
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
                TextDeCriptat = textBoxText.Text.ToUpper().Replace(" ","").TrimEnd();
                int curentLetterVectorLenght = 0;
                foreach (char litera in TextDeCriptat)
                {
                    CurentLetterVector = GetCurentLetterVector(litera.ToString());
                    curentLetterVectorLenght = CurentLetterVector.Length;
                    Random rnd = new Random();
                    int randomNumber = rnd.Next(0, curentLetterVectorLenght);
                    textBoxTextDecriptat.Text = textBoxTextDecriptat.Text + CurentLetterVector[randomNumber];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private string[] GetCurentLetterVector(string currentLetter)
        {
            try
            {
                string[] CurentLetterVector= Properties.Resources.ResourceManager.GetString(currentLetter).Split(',');
                return CurentLetterVector;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
    }
}

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
    public partial class CriptEnigma : Form
    {
        private string[] Alfabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};

        public CriptEnigma()
        {
            InitializeComponent();
        }

        private void OnClickCriptare(object sender, EventArgs e)
        {
            try
            {
                textBoxTextDecriptat.Clear();
                textBoxTextDecriptat.Clear();
                if (string.IsNullOrWhiteSpace(textBoxText.Text))
                {
                    MessageBox.Show("Trebuie sa dati un text", "Avertizare", MessageBoxButtons.OK);
                    return;
                }
                string[] Rotor1, Rotor2, Rotor3;
                Rotor1 = GetCurentRotorVector(comboBoxR1.SelectedItem.ToString().Replace(" ",""));
                Rotor2 = GetCurentRotorVector(comboBoxR2.SelectedItem.ToString().Replace(" ", ""));
                Rotor3 = GetCurentRotorVector(comboBoxR3.SelectedItem.ToString().Replace(" ", ""));
                string textDeCriptat = textBoxText.Text.ToUpper().Replace(" ","");
                foreach (char litera in textDeCriptat)
                {
                    int indexLiteraCurenta = GetCurentLetterIndex(litera.ToString(),Alfabet);
                    string literaActuala;
                    literaActuala = Rotor1[indexLiteraCurenta];
                    indexLiteraCurenta = GetCurentLetterIndex(literaActuala.ToString(), Alfabet); 
                    literaActuala = Rotor2[indexLiteraCurenta];
                    indexLiteraCurenta = GetCurentLetterIndex(literaActuala.ToString(), Alfabet);
                    literaActuala = Rotor3[indexLiteraCurenta];
                    literaActuala = GetCurentLeterFromReflector(literaActuala,comboBoxRf1.SelectedItem.ToString().Replace(" ", ""));
                    indexLiteraCurenta = GetCurentLetterIndex(literaActuala.ToString(), Rotor3);
                    literaActuala = Alfabet[indexLiteraCurenta];
                    indexLiteraCurenta = GetCurentLetterIndex(literaActuala.ToString(), Rotor2);
                    literaActuala = Alfabet[indexLiteraCurenta];
                    indexLiteraCurenta = GetCurentLetterIndex(literaActuala.ToString(), Rotor1);
                    literaActuala = Alfabet[indexLiteraCurenta];
                    textBoxTextDecriptat.Text = textBoxTextDecriptat.Text + literaActuala;
                }       
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private string[] GetCurentRotorVector(string currentRotor)
        {
            try
            {
                string text = Properties.Resources.ResourceManager.GetString(currentRotor);
                string[] CurentLetterVector=new string[text.Length];            
                int i = 0;
                foreach(char litera in text)
                {
                    CurentLetterVector[i] = litera.ToString();
                    i++;
                }
                return CurentLetterVector;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        private int GetCurentLetterIndex(string letter,string[] sirDate)
        {
            try
            {
                for (int i = 0; i < sirDate.Length; i++)
                if (sirDate[i].Equals(letter))
                    return i;
                return int.MaxValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return int.MaxValue;
            }
        }
        private string GetCurentLeterFromReflector(string leter,string reflector)
        {
            try
            {
                string[] CurentReflectorVector = Properties.Resources.ResourceManager.GetString(reflector).Split(')','(');
                foreach (string litera in CurentReflectorVector)
                {
                    if (!string.IsNullOrWhiteSpace(litera))
                    {
                        if (litera[0].ToString().Equals(leter))
                            return litera[1].ToString();
                        if (litera[1].ToString().Equals(leter))
                            return litera[0].ToString();
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
    }
}

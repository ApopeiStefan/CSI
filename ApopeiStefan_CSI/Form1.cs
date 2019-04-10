using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApopeiStefan_CSI.Forms;
using ApopeiStefan_CSI.Uc;

namespace ApopeiStefan_CSI
{
    public partial class MainForm : Form
    {
  
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnCriptPlayfair(object sender, EventArgs e)
        {
            try
            {
                Form CriptPlayfair = new CriptPlayfair();
                CriptPlayfair.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void OnClickCriptareADFGVX(object sender, EventArgs e)
        {
            try
            {
                Form CriptADFGVX = new CriptADFGVX();
                CriptADFGVX.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void OnClickDecriptPlayfair(object sender, EventArgs e)
        {
            try
            {
                Form DecriptPlayfair = new DecriptPlayfair();
                DecriptPlayfair.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void OnClickDecriptADFGVX(object sender, EventArgs e)
        {
            try
            {
                Form DecriptADFGVX = new DecriptADFGVX();
                DecriptADFGVX.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void OnClickCriptHomofonic(object sender, EventArgs e)
        {
            try
            {
                Form CriptHomofonic = new CriptHomofonic();
                CriptHomofonic.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void OnClickDecriptHomofonic(object sender, EventArgs e)
        {
            try
            {
                Form DecriptHomofonic = new DecriptHomofonic();
                DecriptHomofonic.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void OnClickCriptEnigma(object sender, EventArgs e)
        {
            try
            {
                Form CriptEnigma = new CriptEnigma();
                CriptEnigma.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void OnClickCriptACAHomofonic(object sender, EventArgs e)
        {
            try
            {
                Form CriptACAHomofonic = new CriptACAHomofonic();
                CriptACAHomofonic.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void OnClickACAHomofonic(object sender, EventArgs e)
        {
            try
            {
                Form DecriptACAHomofonic = new DecriptACAHomofonic();
                DecriptACAHomofonic.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

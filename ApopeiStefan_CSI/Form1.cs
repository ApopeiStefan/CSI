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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
* 01/29/2018
* CSC 153
* Brian Schweikart
* Language Translator
*/

namespace Language_Translator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void italianbutton_Click(object sender, EventArgs e)
        {
            // translation into Italian upon button press.
            translationLabel.Text = "Buongiorno";
        }

        private void spanishButton_Click(object sender, EventArgs e)
        {
            // translation into Spanish upon button press.
            translationLabel.Text = "Buenos Dias";

        }

        private void germanButton_Click(object sender, EventArgs e)
        {
            // translation into German upon button press.
            translationLabel.Text = "Guten Morgen";
        }
    }
}

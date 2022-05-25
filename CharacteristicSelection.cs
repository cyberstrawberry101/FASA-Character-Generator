using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FASA_Character_Generator
{
    public partial class CharacteristicSelection : Form
    {
        public CharacteristicSelection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rollCounter = int.Parse(txtRerollCounter.Text) + 1;
            txtRerollCounter.Text = rollCounter.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is as far as the GUI demo goes.  Press the re-roll button if you havn't already :3");
        }
    }
}

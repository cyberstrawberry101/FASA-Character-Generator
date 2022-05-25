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
    public partial class ServiceSelection : Form
    {
        public static ServiceSelection ServiceSelectionInstance;
        public ServiceSelection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var CharacteristicSelection = new CharacteristicSelection(); //create an instance of CharacteristicSelection
            Hide();             //hide me (ServiceSelection)
            CharacteristicSelection.Show();       //show CharacteristicSelection
            Close();            //close me (ServiceSelection), since WindowJumper is the message loop - no problem.
        }
    }
}

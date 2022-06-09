namespace FASA_Character_Generator
{
    public partial class Main : Form
    {
        public static Main MainInstance;
        public Main()
        {
            InitializeComponent();
        }

        private void newCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CharacteristicSelection = new CharacteristicSelection(); //create an instance of ServiceSelection
            //Hide();             //hide me (Main)
            CharacteristicSelection.Show();       //show ServiceSelection
            //Close();            //close me (Main), since WindowJumper is the message loop - no problem.
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            WindowJumper.WindowJumperInstance.Close(); //The User Wants to Exit the App - We Close the WindowJumper
        }

        private void dumpCharacterStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Strenth = " + WindowJumper.WindowJumperInstance.CharacterStats.Strength.ToString());
            MessageBox.Show("Intellect = " + WindowJumper.WindowJumperInstance.CharacterStats.Intellect.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radD3.Checked == true)
            {
                txtRollResult.Text = (WindowJumper.WindowJumperInstance.Roll("d3")).ToString();
            }
            if (radD4.Checked == true)
            {
                txtRollResult.Text = (WindowJumper.WindowJumperInstance.Roll("d4")).ToString();
            }
            if (radD6.Checked == true)
            {
                txtRollResult.Text = (WindowJumper.WindowJumperInstance.Roll("d6")).ToString();
            }
            if (radD8.Checked == true)
            {
                txtRollResult.Text = (WindowJumper.WindowJumperInstance.Roll("d8")).ToString();
            }
            if (radD10.Checked == true)
            {
                txtRollResult.Text = (WindowJumper.WindowJumperInstance.Roll("d10")).ToString();
            }
            if (radD12.Checked == true)
            {
                txtRollResult.Text = (WindowJumper.WindowJumperInstance.Roll("d12")).ToString();
            }
            if (radD20.Checked == true)
            {
                txtRollResult.Text = (WindowJumper.WindowJumperInstance.Roll("d20")).ToString();
            }
            if (radD30.Checked == true)
            {
                txtRollResult.Text = (WindowJumper.WindowJumperInstance.Roll("d30")).ToString();
            }
            if (radD100.Checked == true)
            {
                txtRollResult.Text = (WindowJumper.WindowJumperInstance.Roll("d100")).ToString();
            }
        }

        private void showDebugMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelDebugMenu.Visible = true;
            panelDebugMenu.Enabled = true;
        }
    }
}
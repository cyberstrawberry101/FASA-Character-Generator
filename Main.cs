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
            int arraySize = 10;
            if (radD3.Checked == true)
            {
                //Create an Array to Store 10 Rolls
                int[] rollArray = new int[arraySize];
                
                //Loop through the rolls 10 times and assign results to each array variable
                for (int roll = 0; roll < arraySize; roll++)
                {
                    rollArray[roll] = WindowJumper.WindowJumperInstance.RollD(3);
                }
                txtRollResult.Text = String.Join(", ", rollArray);
            }
            if (radD4.Checked == true)
            {
                //Create an Array to Store 10 Rolls
                int[] rollArray = new int[arraySize];

                //Loop through the rolls 10 times and assign results to each array variable
                for (int roll = 0; roll < arraySize; roll++)
                {
                    rollArray[roll] = WindowJumper.WindowJumperInstance.RollD(4);
                }
                txtRollResult.Text = String.Join(", ", rollArray);
            }
            if (radD6.Checked == true)
            {
                //Create an Array to Store 10 Rolls
                int[] rollArray = new int[arraySize];

                //Loop through the rolls 10 times and assign results to each array variable
                for (int roll = 0; roll < arraySize; roll++)
                {
                    rollArray[roll] = WindowJumper.WindowJumperInstance.RollD(6);
                }
                txtRollResult.Text = String.Join(", ", rollArray);
            }
            if (radD8.Checked == true)
            {
                //Create an Array to Store 10 Rolls
                int[] rollArray = new int[arraySize];

                //Loop through the rolls 10 times and assign results to each array variable
                for (int roll = 0; roll < arraySize; roll++)
                {
                    rollArray[roll] = WindowJumper.WindowJumperInstance.RollD(8);
                }
                txtRollResult.Text = String.Join(", ", rollArray);
            }
            if (radD10.Checked == true)
            {
                //Create an Array to Store 10 Rolls
                int[] rollArray = new int[arraySize];

                //Loop through the rolls 10 times and assign results to each array variable
                for (int roll = 0; roll < arraySize; roll++)
                {
                    rollArray[roll] = WindowJumper.WindowJumperInstance.RollD(10);
                }
                txtRollResult.Text = String.Join(", ", rollArray);
            }
            if (radD12.Checked == true)
            {
                //Create an Array to Store 10 Rolls
                int[] rollArray = new int[arraySize];

                //Loop through the rolls 10 times and assign results to each array variable
                for (int roll = 0; roll < arraySize; roll++)
                {
                    rollArray[roll] = WindowJumper.WindowJumperInstance.RollD(12);
                }
                txtRollResult.Text = String.Join(", ", rollArray);
            }
            if (radD20.Checked == true)
            {
                //Create an Array to Store 10 Rolls
                int[] rollArray = new int[arraySize];

                //Loop through the rolls 10 times and assign results to each array variable
                for (int roll = 0; roll < arraySize; roll++)
                {
                    rollArray[roll] = WindowJumper.WindowJumperInstance.RollD(20);
                }
                txtRollResult.Text = String.Join(", ", rollArray);
            }
            if (radD30.Checked == true)
            {
                //Create an Array to Store 10 Rolls
                int[] rollArray = new int[arraySize];

                //Loop through the rolls 10 times and assign results to each array variable
                for (int roll = 0; roll < arraySize; roll++)
                {
                    rollArray[roll] = WindowJumper.WindowJumperInstance.RollD(30);
                }
                txtRollResult.Text = String.Join(", ", rollArray);
            }
            if (radD100.Checked == true)
            {
                //Create an Array to Store 10 Rolls
                int[] rollArray = new int[arraySize];

                //Loop through the rolls 10 times and assign results to each array variable
                for (int roll = 0; roll < arraySize; roll++)
                {
                    //int debugRoll = WindowJumper.WindowJumperInstance.RollD(100);
                    //if (debugRoll == 100)
                    //{
                    //    MessageBox.Show("Rolled 100 in " + roll + " rolls.");
                    //    break;
                    //} 
                    rollArray[roll] = WindowJumper.WindowJumperInstance.RollD(100);
                }
                txtRollResult.Text = String.Join(", ", rollArray);
            }
        }

        private void showDebugMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelDebugMenu.Visible = true;
            panelDebugMenu.Enabled = true;
        }
    }
}
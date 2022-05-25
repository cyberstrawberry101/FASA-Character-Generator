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
            var ServiceSelection = new ServiceSelection(); //create an instance of ServiceSelection
            //Hide();             //hide me (Main)
            ServiceSelection.Show();       //show ServiceSelection
            //Close();            //close me (Main), since WindowJumper is the message loop - no problem.
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            WindowJumper.WindowJumperInstance.Close(); //The User Wants to Exit the App - We Close the WindowJumper
        }
    }
}
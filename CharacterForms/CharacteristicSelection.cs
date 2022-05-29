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

        private void CharacteristicSelection_Load(object sender, EventArgs e)
        {
            //Generate Random Numbers for the first column of the window stats (left-hand side) when window opens
            Random r = new Random(); //Create an instance of the Random Number Generator

            //Pick a random number between 3-30, then add 40
            txtStatCharisma.Text = (r.Next(3, 30) + 40).ToString(); 
            txtStatDexterity.Text = (r.Next(3, 30) + 40).ToString();
            txtStatEndurance.Text = (r.Next(3, 30) + 40).ToString();
            txtStatStrength.Text = (r.Next(3, 30) + 40).ToString();
            txtStatIntellect.Text = (r.Next(3, 30) + 40).ToString();
            //==================================================================

            //Pick a random number between 1-100
            txtStatLuck.Text = (r.Next(1, 100)).ToString();
            txtStatPsionic.Text = (r.Next(1, 100)).ToString();

            //Calculate grand total of left-side column stats
            int statTotal = int.Parse(txtStatCharisma.Text) + int.Parse(txtStatDexterity.Text) + int.Parse(txtStatEndurance.Text) + int.Parse(txtStatStrength.Text) + int.Parse(txtStatIntellect.Text) + int.Parse(txtStatLuck.Text) + int.Parse(txtStatPsionic.Text);
            txtStatTotal.Text = statTotal.ToString();
        }

        private void btnStoreStats_Click(object sender, EventArgs e)
        {
            //Store the character stats into the character stat class for use later
            WindowJumper.WindowJumperInstance.CharacterStats.Attitude = int.Parse(txtStatAttitude.Text);
            WindowJumper.WindowJumperInstance.CharacterStats.Bravery = int.Parse(txtStatBravery.Text);
            WindowJumper.WindowJumperInstance.CharacterStats.Charisma = int.Parse(txtStatCharisma.Text);
            WindowJumper.WindowJumperInstance.CharacterStats.Composure = int.Parse(txtStatComposure.Text);
            WindowJumper.WindowJumperInstance.CharacterStats.Coolness = int.Parse(txtStatCoolness.Text);
            WindowJumper.WindowJumperInstance.CharacterStats.Dexterity = int.Parse(txtStatDexterity.Text);
            WindowJumper.WindowJumperInstance.CharacterStats.Empathy = int.Parse(txtStatEmpathy.Text);
            WindowJumper.WindowJumperInstance.CharacterStats.Endurance = int.Parse(txtStatEndurance.Text);
            WindowJumper.WindowJumperInstance.CharacterStats.Energy = int.Parse(txtStatEnergy.Text);
            WindowJumper.WindowJumperInstance.CharacterStats.Ethics = int.Parse(txtStatEthics.Text);
            WindowJumper.WindowJumperInstance.CharacterStats.Humility = int.Parse(txtStatHumility.Text);
            WindowJumper.WindowJumperInstance.CharacterStats.Intellect = int.Parse(txtStatIntellect.Text);
            WindowJumper.WindowJumperInstance.CharacterStats.Luck = int.Parse(txtStatLuck.Text);
            WindowJumper.WindowJumperInstance.CharacterStats.Morality = int.Parse(txtStatMorality.Text);
            WindowJumper.WindowJumperInstance.CharacterStats.Motivation = int.Parse(txtStatMotivation.Text);
            WindowJumper.WindowJumperInstance.CharacterStats.Psionic = int.Parse(txtStatPsionic.Text);
            WindowJumper.WindowJumperInstance.CharacterStats.Strength = int.Parse(txtStatStrength.Text);
            WindowJumper.WindowJumperInstance.CharacterStats.Willpower = int.Parse(txtStatWillpower.Text);

            //Move onto the Race Selection Form
            var RaceSelection = new RaceSelection(); //create an instance of CharacteristicSelection
            Hide();             //hide me (ServiceSelection)
            RaceSelection.Show();       //show CharacteristicSelection
            Close();            //close me (ServiceSelection), since WindowJumper is the message loop - no problem.
        }
    }
}

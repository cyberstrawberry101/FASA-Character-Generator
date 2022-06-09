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
    public partial class BonusPoints : Form
    {
        //Store the total number of points on form load, and compare against every time a value is changed,
        //to understand the differential from the Bonus Points
        public int IntellectBonus;
        public BonusPoints()
        {
            InitializeComponent();
        }

        private void PopulateStatsFromClass()
        {
            //Retrieve the character stats and populate the fields
            txtStatAttitude.Text = WindowJumper.WindowJumperInstance.CharacterStats.Attitude.ToString();
            txtStatBravery.Text = WindowJumper.WindowJumperInstance.CharacterStats.Bravery.ToString();
            txtStatCharisma.Text = WindowJumper.WindowJumperInstance.CharacterStats.Charisma.ToString();
            txtStatComposure.Text = WindowJumper.WindowJumperInstance.CharacterStats.Composure.ToString();
            txtStatCoolness.Text = WindowJumper.WindowJumperInstance.CharacterStats.Coolness.ToString();
            txtStatDexterity.Text = WindowJumper.WindowJumperInstance.CharacterStats.Dexterity.ToString();
            txtStatEmpathy.Text = WindowJumper.WindowJumperInstance.CharacterStats.Empathy.ToString();
            txtStatEndurance.Text = WindowJumper.WindowJumperInstance.CharacterStats.Endurance.ToString();
            txtStatEnergy.Text = WindowJumper.WindowJumperInstance.CharacterStats.Energy.ToString();
            txtStatEthics.Text = WindowJumper.WindowJumperInstance.CharacterStats.Ethics.ToString();
            txtStatHumility.Text = WindowJumper.WindowJumperInstance.CharacterStats.Humility.ToString();
            txtStatIntellect.Text = WindowJumper.WindowJumperInstance.CharacterStats.Intellect.ToString();
            txtStatLuck.Text = WindowJumper.WindowJumperInstance.CharacterStats.Luck.ToString();
            txtStatMorality.Text = WindowJumper.WindowJumperInstance.CharacterStats.Morality.ToString();
            txtStatMotivation.Text = WindowJumper.WindowJumperInstance.CharacterStats.Motivation.ToString();
            txtStatPsionic.Text = WindowJumper.WindowJumperInstance.CharacterStats.Psionic.ToString();
            txtStatStrength.Text = WindowJumper.WindowJumperInstance.CharacterStats.Strength.ToString();
            txtStatWillpower.Text = WindowJumper.WindowJumperInstance.CharacterStats.Willpower.ToString();

            //Prevent users from lowering their stats below what they started with
            txtStatAttitude.Minimum = WindowJumper.WindowJumperInstance.CharacterStats.Attitude;
            txtStatBravery.Minimum = WindowJumper.WindowJumperInstance.CharacterStats.Bravery;
            txtStatCharisma.Minimum = WindowJumper.WindowJumperInstance.CharacterStats.Charisma;
            txtStatComposure.Minimum = WindowJumper.WindowJumperInstance.CharacterStats.Composure;
            txtStatCoolness.Minimum = WindowJumper.WindowJumperInstance.CharacterStats.Coolness;
            txtStatDexterity.Minimum = WindowJumper.WindowJumperInstance.CharacterStats.Dexterity;
            txtStatEmpathy.Minimum = WindowJumper.WindowJumperInstance.CharacterStats.Empathy;
            txtStatEndurance.Minimum = WindowJumper.WindowJumperInstance.CharacterStats.Endurance;
            txtStatEnergy.Minimum = WindowJumper.WindowJumperInstance.CharacterStats.Energy;
            txtStatEthics.Minimum = WindowJumper.WindowJumperInstance.CharacterStats.Ethics;
            txtStatHumility.Minimum = WindowJumper.WindowJumperInstance.CharacterStats.Humility;
            txtStatIntellect.Minimum = WindowJumper.WindowJumperInstance.CharacterStats.Intellect;
            txtStatLuck.Minimum = WindowJumper.WindowJumperInstance.CharacterStats.Luck;
            txtStatMorality.Minimum = WindowJumper.WindowJumperInstance.CharacterStats.Morality;
            txtStatMotivation.Minimum = WindowJumper.WindowJumperInstance.CharacterStats.Motivation;
            txtStatPsionic.Minimum = WindowJumper.WindowJumperInstance.CharacterStats.Psionic;
            txtStatStrength.Minimum = WindowJumper.WindowJumperInstance.CharacterStats.Strength;
            txtStatWillpower.Minimum = WindowJumper.WindowJumperInstance.CharacterStats.Willpower;
        }

        private void BonusPoints_Load(object sender, EventArgs e)
        {
            PopulateStatsFromClass();
                Random bonusD100 = new Random();
                double D100result = bonusD100.NextDouble() * 100;
                D100result = D100result / 2;
                if (D100result < 30)
                {
                    D100result = 30;
                }
            //Store the rounded-down value back into the bonus points window and into a global variable
            txtBonusPoints.Text = Convert.ToInt32(D100result).ToString();
        }

        private void CalculateDelta(string previousStat, string CurrentStat)
        {
            //Check if the stat is greater than the older stat, and that the bonus points are greater than 0
            if (int.Parse(CurrentStat) > int.Parse(previousStat))
            {
                txtBonusPoints.Text = (int.Parse(txtBonusPoints.Text) - 1).ToString();
            }
            if (int.Parse(CurrentStat) < int.Parse(previousStat))
            {
                txtBonusPoints.Text = (int.Parse(txtBonusPoints.Text) + 1).ToString();
            }
        }

        private void txtStatStrength_ValueChanged(object sender, EventArgs e)
        {
            CalculateDelta(((UpDownBase)sender).Text, ((NumericUpDown)sender).Value.ToString());
        }

        private void txtStatEndurance_ValueChanged(object sender, EventArgs e)
        {
            CalculateDelta(((UpDownBase)sender).Text, ((NumericUpDown)sender).Value.ToString());
        }

        private void txtStatIntellect_ValueChanged(object sender, EventArgs e)
        {
            CalculateDelta(((UpDownBase)sender).Text, ((NumericUpDown)sender).Value.ToString());
        }

        private void txtStatDexterity_ValueChanged(object sender, EventArgs e)
        {
            CalculateDelta(((UpDownBase)sender).Text, ((NumericUpDown)sender).Value.ToString());
        }

        private void txtStatCharisma_ValueChanged(object sender, EventArgs e)
        {
            CalculateDelta(((UpDownBase)sender).Text, ((NumericUpDown)sender).Value.ToString());
        }

        private void txtStatLuck_ValueChanged(object sender, EventArgs e)
        {
            CalculateDelta(((UpDownBase)sender).Text, ((NumericUpDown)sender).Value.ToString());
        }

        private void txtStatPsionic_ValueChanged(object sender, EventArgs e)
        {
            CalculateDelta(((UpDownBase)sender).Text, ((NumericUpDown)sender).Value.ToString());
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
            var BackgroundSkillSelection = new BackgroundSkillSelection(); //create an instance of CharacteristicSelection
            Hide();             //hide me (ServiceSelection)
            BackgroundSkillSelection.Show();       //show CharacteristicSelection
            Close();            //close me (ServiceSelection), since WindowJumper is the message loop - no problem.
        }
    }
}

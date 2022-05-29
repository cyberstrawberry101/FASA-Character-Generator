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
        public int StatPointRecord;
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

        private void RecalculateBonusBalance(int CurrentStat, int OriginalStat, int BonusNumber)
        {
            if ((BonusNumber >= 0) && (CurrentStat > OriginalStat)) //Good
            {
                txtBonusPoints.Text = (int.Parse(txtBonusPoints.Text) - 1).ToString();
            }
            if ((BonusNumber >= 0) && (CurrentStat > OriginalStat)) //Good
            {
                txtBonusPoints.Text = (int.Parse(txtBonusPoints.Text) - 1).ToString();
            }
        }
        private void BonusPoints_Load(object sender, EventArgs e)
        {
            PopulateStatsFromClass();
            //Take the intellect of the character, divide it in half, and store it as the bonus points
            //Convert to a double in case numbers are odd and leave us with decimal points
            double IntellectBonus = Convert.ToDouble((int.Parse(txtStatIntellect.Text)));

            //Take the Intellect and divide in half, then round down
            IntellectBonus = Math.Floor(IntellectBonus / 2);

            //Store the rounded-down value back into the bonus points window and into a global variable
            txtBonusPoints.Text = IntellectBonus.ToString();
            StatPointRecord = int.Parse(txtStatCharisma.Text) + int.Parse(txtStatDexterity.Text) + int.Parse(txtStatEndurance.Text) + int.Parse(txtStatStrength.Text) + int.Parse(txtStatIntellect.Text) + int.Parse(txtStatLuck.Text) + int.Parse(txtStatPsionic.Text);
        }

        private void txtStatStrength_ValueChanged(object sender, EventArgs e)
        {
            RecalculateBonusBalance(int.Parse(txtStatStrength.Text), WindowJumper.WindowJumperInstance.CharacterStats.Strength, IntellectBonus);
        }
    }
}

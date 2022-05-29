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
    public partial class RaceSelection : Form
    {
        public RaceSelection()
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
        }

        private void CalculateTotals()
        {
            //Calculate grand total of left-side column stats
            int statTotal = int.Parse(txtStatCharisma.Text) + int.Parse(txtStatDexterity.Text) + int.Parse(txtStatEndurance.Text) + int.Parse(txtStatStrength.Text) + int.Parse(txtStatIntellect.Text) + int.Parse(txtStatLuck.Text) + int.Parse(txtStatPsionic.Text);
            txtStatTotal.Text = statTotal.ToString();
        }

        private void RaceSelection_Load(object sender, EventArgs e)
        {
            //Pull character stats from global variables
            PopulateStatsFromClass();
            CalculateTotals();
        }

        private void listRace_SelectedValueChanged(object sender, EventArgs e)
        {
            //Adjust the stats based on the race selected
            switch (listRace.Text)
            {
                case "Andorian":
                    txtStatStrength.Text = Math.Max(0, (int.Parse(txtStatStrength.Text) + 10)).ToString(); // +10 Strength
                    txtStatEndurance.Text = Math.Max(0, (int.Parse(txtStatEndurance.Text) + 5)).ToString(); // +5 Endurance
                    txtStatLuck.Text = Math.Max(0, (int.Parse(txtStatLuck.Text) - 20)).ToString(); // -20 Luck
                    txtStatPsionic.Text = Math.Max(0, (int.Parse(txtStatPsionic.Text) - 20)).ToString(); // -20 Psionic
                    CalculateTotals();
                    break;
                case "Bajoran": //NOT APPLICABLE AT THIS TIME
                    PopulateStatsFromClass();
                    CalculateTotals();
                    break;
                case "Benzite": //NOT APPLICABLE AT THIS TIME
                    PopulateStatsFromClass();
                    CalculateTotals();
                    break;
                case "Betazoid": //NOT APPLICABLE AT THIS TIME
                    PopulateStatsFromClass();
                    CalculateTotals();
                    break;
                case "Bolian": //NOT APPLICABLE AT THIS TIME
                    PopulateStatsFromClass();
                    CalculateTotals();
                    break;
                case "Caitian":
                    PopulateStatsFromClass();
                    txtStatEndurance.Text = Math.Max(0, (int.Parse(txtStatEndurance.Text)) - 5).ToString(); // -5 Endurance
                    txtStatDexterity.Text = Math.Max(0, (int.Parse(txtStatDexterity.Text)) + 20).ToString(); // +20 Dexterity
                    txtStatCharisma.Text = Math.Max(0, (int.Parse(txtStatCharisma.Text) + 5)).ToString(); // +5 Charisma
                    txtStatLuck.Text = Math.Max(0, (int.Parse(txtStatLuck.Text) - 10)).ToString(); // -10 Luck
                    txtStatPsionic.Text = Math.Max(0, (int.Parse(txtStatPsionic.Text) - 30)).ToString(); // -30 Psionic
                    CalculateTotals();
                    break;
                case "Cardassian": //NOT APPLICABLE AT THIS TIME
                    PopulateStatsFromClass();
                    CalculateTotals();
                    break;
                case "Deltan": //NOT APPLICABLE AT THIS TIME
                    PopulateStatsFromClass();
                    CalculateTotals();
                    break;
                case "Edoan":
                    PopulateStatsFromClass();
                    txtStatStrength.Text = Math.Max(0, (int.Parse(txtStatStrength.Text) - 5)).ToString(); // -5 Strength
                    txtStatDexterity.Text = Math.Max(0, (int.Parse(txtStatDexterity.Text) + 15)).ToString(); // +15 Dexterity
                    txtStatLuck.Text = Math.Max(0, (int.Parse(txtStatLuck.Text) - 15)).ToString(); // -15 Luck
                    txtStatPsionic.Text = Math.Max(0, (int.Parse(txtStatPsionic.Text) - 35)).ToString(); // -35 Psionic
                    CalculateTotals();
                    break;
                case "Ferengi": //NOT APPLICABLE AT THIS TIME
                    PopulateStatsFromClass();
                    CalculateTotals();
                    break;
                case "Human":
                    PopulateStatsFromClass();
                    txtStatPsionic.Text = Math.Max(0, (int.Parse(txtStatPsionic.Text) - 30)).ToString(); // -30 Psionic
                    CalculateTotals();
                    break;
                case "Klingon - Human": //NOT APPLICABLE AT THIS TIME
                    PopulateStatsFromClass();
                    CalculateTotals();
                    break;
                case "Klingon - Imperial": //NOT APPLICABLE AT THIS TIME
                    PopulateStatsFromClass();
                    CalculateTotals();
                    break;
                case "Klingon - Romulan": //NOT APPLICABLE AT THIS TIME
                    PopulateStatsFromClass();
                    CalculateTotals();
                    break;
                case "Orion": //NOT APPLICABLE AT THIS TIME
                    PopulateStatsFromClass();
                    CalculateTotals();
                    break;
                case "Romulan": //NOT APPLICABLE AT THIS TIME
                    PopulateStatsFromClass();
                    CalculateTotals();
                    break;
                case "Tellarite":
                    PopulateStatsFromClass();
                    txtStatStrength.Text = Math.Max(0, (int.Parse(txtStatStrength.Text) + 5)).ToString(); // +5 Strength
                    txtStatEndurance.Text = Math.Max(0, (int.Parse(txtStatEndurance.Text) + 5)).ToString(); // +5 Endurance
                    txtStatCharisma.Text = Math.Max(0, (int.Parse(txtStatCharisma.Text) - 10)).ToString(); // -10 Charisma
                    txtStatLuck.Text = Math.Max(0, (int.Parse(txtStatLuck.Text) - 20)).ToString(); // -20 Luck
                    txtStatPsionic.Text = Math.Max(0, (int.Parse(txtStatPsionic.Text) - 40)).ToString(); // -40 Psionic
                    CalculateTotals();
                    break;
                case "Trill": //NOT APPLICABLE AT THIS TIME
                    PopulateStatsFromClass();
                    CalculateTotals();
                    break;
                case "Vulcan":
                    PopulateStatsFromClass();
                    txtStatStrength.Text = Math.Max(0, (int.Parse(txtStatStrength.Text) + 20)).ToString(); // +20 Strength
                    txtStatEndurance.Text = Math.Max(0, (int.Parse(txtStatEndurance.Text) + 10)).ToString(); // +10 Endurance
                    txtStatIntellect.Text = Math.Max(0, (int.Parse(txtStatIntellect.Text) + 10)).ToString(); // +10 Intellect
                    txtStatLuck.Text = Math.Max(0, (int.Parse(txtStatLuck.Text) - 40)).ToString(); // -40 Luck
                    CalculateTotals();
                    break;
                default:
                    PopulateStatsFromClass();
                    MessageBox.Show("No Race was Selected - How did you get here?");
                    CalculateTotals();
                    break;
            }
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
            var BonusPoints = new BonusPoints(); //create an instance of CharacteristicSelection
            Hide();             //hide me (ServiceSelection)
            BonusPoints.Show();       //show CharacteristicSelection
            Close();            //close me (ServiceSelection), since WindowJumper is the message loop - no problem.
        }
    }
}

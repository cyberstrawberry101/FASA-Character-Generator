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
    public partial class WindowJumper : Form
    {
        public static WindowJumper WindowJumperInstance;

        //Create a new list of character stats to populate in the program
        public Character.Stats CharacterStats = new Character.Stats();
        public Character.Race CharacterRace = new Character.Race();


        public WindowJumper()
            {
                //Everyone eveywhere in the app should know me as WindowJumper.WindowJumperInstance
                WindowJumperInstance = this;

                //Make sure I am kept hidden
                WindowState = FormWindowState.Minimized;
                ShowInTaskbar = false;
                Visible = false;

                InitializeComponent();

                //Open the main window form - the one the user sees
                var Main = new Main();
                Main.Show();
            }

        public int Roll(string diceType)
        {
            Random diceRoll = new Random();
            switch (diceType)
            {
                case "d3":
                    return diceRoll.Next(1, 3);
                case "d4":
                    return diceRoll.Next(1, 4);
                case "d6":
                    return diceRoll.Next(1, 6);
                case "d8":
                    return diceRoll.Next(1, 8);
                case "d10":
                    return diceRoll.Next(1, 10);
                case "d12":
                    return diceRoll.Next(1, 12);
                case "d20":
                    return diceRoll.Next(1, 20);
                case "d30":
                    return diceRoll.Next(1, 30);
                case "d100":
                    return diceRoll.Next(1, 100);
                default:
                    // Divide by Zero
                    return 0;
            }
              
        }
    }
}

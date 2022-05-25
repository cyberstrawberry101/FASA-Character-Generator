﻿using System;
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
    }
}

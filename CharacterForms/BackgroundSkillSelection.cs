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
    public partial class BackgroundSkillSelection : Form
    {
        public BackgroundSkillSelection()
        {
            InitializeComponent();
        }

        private void BackgroundSkillSelection_Load(object sender, EventArgs e)
        {
            backgroundSkillTree.ExpandAll();
        }
    }
}

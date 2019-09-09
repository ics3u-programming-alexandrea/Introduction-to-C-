﻿/*
 * Created by: Alexandrea Udechukwu
 * Created on: Sept. 6, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #4 - Program with Menu
 * This program displays my favorite soccer play and team with an exit menu
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramMenuAlex
{
    public partial class frmProgramMenu : Form
    {
        public frmProgramMenu()
        {
            InitializeComponent();
        }

        private void MniExit_Click(object sender, EventArgs e)
        {
            // this will close the program
            this.Close();
        }
    }
}

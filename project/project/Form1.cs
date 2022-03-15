using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void showPanel(string panelName)
        {

            if (panelName == "Fruit")
            {

                // hide all other panels

                // show 

            }
            else if (panelName == "Vlees")
            {
                // hide all other panels

                // show 

            }
            else if (panelName == "Vis")
            {
                // hide all other panels

                // show 

            }
        }
        private void fruitGroentenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vleesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void visToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Fruit.Hide();
            Vlees.Hide();
            Vis.Hide();
        }
    }
}

﻿using System;
using System.Collections.Generic;

using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
using Database;
using Modal;


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

            }
            else if (panelName == "Vlees")
            {
                // hide all other panels

                // show 

            }
            else if (panelName == "Vis")
            {
                // hide all other panels
                Vlees.Hide();
                Fruit.Hide();
                // show 
                Vis.Show();
                //get data
                VisDAO visDAO = new VisDAO();
                List<Vis> visList = visDAO.getVis();

                //clear listview
                LVVis.Clear();
                //grid
                LVVis.View = View.Details;
                LVVis.GridLines = true;
                LVVis.FullRowSelect = true;
                //header
                LVVis.Columns.Add("ID", 50);
                LVVis.Columns.Add("name", 150);
                LVVis.Columns.Add("Description", 565);
                foreach (Vis v in visList)
                {
                    string[] items = new string[3];
                    items[0] = v.id.ToString();
                    items[1] = v.name;
                    items[2] = v.description;
                    ListViewItem li = new ListViewItem(items);
                    LVVis.Items.Add(li);
                }

            }

        }
        private void vleesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Vis");
        }

        private void vleesToolStripMenuItem_Click(object sender, EventArgs e)

        {
            showPanel("Vis");
        }
        private void fruitGroentenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Fruit");
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //afsluiten
            this.Close();
        }

        private void BTNClear_Click(object sender, EventArgs e)
        {
            Vis.Hide();
            Vlees.Hide();
            Fruit.Hide();
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            else if (panelName == "Vis")
            {
              
            }

            else if (panelName == "Vlees")
            {
                Vis.Hide();
                Fruit.Hide();
                Vlees.Show();
                // show panel
                vleesListView.Show();

                // fill the vlees listview within the vlees panel with a list of vlees
                VleesDAO vleesDAO = new VleesDAO();
                List<Vlees> vleesList = vleesDAO.GetAll();

                // clear the listview befire filling it again
                vleesListView.Clear();

                // create grid
                vleesListView.View = View.Details;
                vleesListView.GridLines = true;
                vleesListView.FullRowSelect = true;

                // add column header
                vleesListView.Columns.Add("Id", 50);
                vleesListView.Columns.Add("Name", 150);
                vleesListView.Columns.Add("Description", 565);
              
                foreach (Vlees vlees in vleesList)
                {
                    // construct each row for the listview
                    string[] item = new string[3];
                    item[0] = vlees.id.ToString();
                    item[1] = vlees.name;
                    item[2] = vlees.description;
                    ListViewItem li = new ListViewItem(item);
                    vleesListView.Items.Add(li);
                }  
            }


        }
        private void vleesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Vlees");
        }
        private void fruitGroentenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Fruit");
        }

        private void visToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Vis");
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Close (Console) app
            System.Environment.Exit(1);
        }

        private void BTNClear_Click(object sender, EventArgs e)
        {
            Vis.Hide();
            Fruit.Hide();
            Vlees.Hide();
        }

        private void BTNClear_Click(object sender, EventArgs e)
        {
            Vlees.Hide();
            Fruit.Hide();
            Vis.Hide();
        }
    }
}

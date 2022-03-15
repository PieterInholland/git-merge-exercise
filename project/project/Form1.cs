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

                // hide all other panels
                Vlees.Hide();
                Vis.Hide();
                // show 
                Fruit.Show();
                //get data
                FruitDAO fruitDAO = new FruitDAO();
                List<Fruit> fruitList = fruitDAO.getFruit();

                //clear listview
                LVFruit.Clear();
                //grid
                LVFruit.View = View.Details;
                LVFruit.GridLines = true;
                LVFruit.FullRowSelect = true;
                //header
                LVFruit.Columns.Add("ID",50);
                LVFruit.Columns.Add("name",150);
                LVFruit.Columns.Add("Description",565);
                foreach (Fruit f in fruitList)
                {
                    string[] items = new string[3];
                    items[0] = f.id.ToString();
                    items[1] = f.name;
                    items[2] = f.description;
                    ListViewItem li = new ListViewItem(items);
                    LVFruit.Items.Add(li);
                }

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
            else if (panelName == "Vlees")
            {
                Vis.Hide();
                Fruit.Hide();

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
        private void fruitGroentenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Fruit");
        }

        private void vleesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Vlees");
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
    }
}

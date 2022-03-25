using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
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
        private void vleesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void fruitGroentenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Fruit");
        }

        private void visToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // WinForms app
            System.Windows.Forms.Application.Exit();
        }

    }
}

namespace project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.appToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fruitGroentenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vleesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Fruit = new System.Windows.Forms.Panel();
            this.LVFruit = new System.Windows.Forms.ListView();
            this.Vlees = new System.Windows.Forms.Panel();
            this.vleesListView = new System.Windows.Forms.ListView();
            this.Vis = new System.Windows.Forms.Panel();
            this.LVVis = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNClear = new System.Windows.Forms.Button();

            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.Fruit.SuspendLayout();
            this.Vlees.SuspendLayout();

            this.Vis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appToolStripMenuItem,
            this.fruitGroentenToolStripMenuItem,
            this.vleesToolStripMenuItem,
            this.visToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // appToolStripMenuItem
            // 
            this.appToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem1});
            this.appToolStripMenuItem.Name = "appToolStripMenuItem";
            this.appToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.appToolStripMenuItem.Text = "App";
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem1.Text = "Close";
            this.closeToolStripMenuItem1.Click += new System.EventHandler(this.closeToolStripMenuItem1_Click);
            // 
            // fruitGroentenToolStripMenuItem
            // 
            this.fruitGroentenToolStripMenuItem.Name = "fruitGroentenToolStripMenuItem";
            this.fruitGroentenToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.fruitGroentenToolStripMenuItem.Text = "Fruit-Groenten";
            this.fruitGroentenToolStripMenuItem.Click += new System.EventHandler(this.fruitGroentenToolStripMenuItem_Click);
            // 
            // vleesToolStripMenuItem
            // 
            this.vleesToolStripMenuItem.Name = "vleesToolStripMenuItem";
            this.vleesToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.vleesToolStripMenuItem.Text = "Vlees";
            this.vleesToolStripMenuItem.Click += new System.EventHandler(this.vleesToolStripMenuItem_Click);
            // 
            // visToolStripMenuItem
            // 
            this.visToolStripMenuItem.Name = "visToolStripMenuItem";
            this.visToolStripMenuItem.Size = new System.Drawing.Size(34, 20);
            this.visToolStripMenuItem.Text = "Vis";
            this.visToolStripMenuItem.Click += new System.EventHandler(this.visToolStripMenuItem_Click);
            // 
            // Fruit
            // 
            this.Fruit.Controls.Add(this.LVFruit);
            this.Fruit.Location = new System.Drawing.Point(12, 27);
            this.Fruit.Name = "Fruit";
            this.Fruit.Size = new System.Drawing.Size(776, 411);
            this.Fruit.TabIndex = 2;
            // 
            // LVFruit
            // 
            this.LVFruit.HideSelection = false;
            this.LVFruit.Location = new System.Drawing.Point(3, 3);
            this.LVFruit.Name = "LVFruit";
            this.LVFruit.Size = new System.Drawing.Size(770, 405);
            this.LVFruit.TabIndex = 0;
            this.LVFruit.UseCompatibleStateImageBehavior = false;
            // 
            // Vlees
            // 
            this.Vlees.Controls.Add(this.vleesListView);
            this.Vlees.Location = new System.Drawing.Point(12, 27);
            this.Vlees.Name = "Vlees";
            this.Vlees.Size = new System.Drawing.Size(776, 411);
            this.Vlees.TabIndex = 3;
            // 
            // vleesListView
            // 
            this.vleesListView.HideSelection = false;
            this.vleesListView.Location = new System.Drawing.Point(3, 3);
            this.vleesListView.Name = "vleesListView";
            this.vleesListView.Size = new System.Drawing.Size(770, 405);
            this.vleesListView.TabIndex = 0;
            this.vleesListView.UseCompatibleStateImageBehavior = false;
            // 
            // Vis
            // 
            this.Vis.Controls.Add(this.LVVis);
            this.Vis.Location = new System.Drawing.Point(12, 27);
            this.Vis.Name = "Vis";
            this.Vis.Size = new System.Drawing.Size(776, 411);
            this.Vis.TabIndex = 4;
            // 
            // LVVis
            // 
            this.LVVis.HideSelection = false;
            this.LVVis.Location = new System.Drawing.Point(3, 3);
            this.LVVis.Name = "LVVis";
            this.LVVis.Size = new System.Drawing.Size(770, 405);
            this.LVVis.TabIndex = 0;
            this.LVVis.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::project.Properties.Resources.gouda_jong_wiel_jhqj_q2;
            this.pictureBox1.Location = new System.Drawing.Point(794, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(795, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 73);
            this.label1.TabIndex = 6;
            this.label1.Text = "lekker ";
            // 
            // BTNClear
            // 

            this.BTNClear.BackColor = System.Drawing.Color.Chocolate;
            this.BTNClear.Location = new System.Drawing.Point(795, 411);

            this.BTNClear.Name = "BTNClear";
            this.BTNClear.Size = new System.Drawing.Size(75, 23);
            this.BTNClear.TabIndex = 7;
            this.BTNClear.Text = "Clear";

            this.BTNClear.UseVisualStyleBackColor = true;

            this.BTNClear.Click += new System.EventHandler(this.BTNClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.BTNClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Fruit);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Vis);
            this.Controls.Add(this.Vlees);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Fruit.ResumeLayout(false);

            this.Vlees.ResumeLayout(false);

            this.Vis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem appToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fruitGroentenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vleesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visToolStripMenuItem;
        private System.Windows.Forms.Panel Fruit;
        private System.Windows.Forms.Panel Vlees;
        private System.Windows.Forms.Panel Vis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ListView vleesListView;

        private System.Windows.Forms.ListView LVVis;

        private System.Windows.Forms.ListView LVFruit;
        private System.Windows.Forms.Button BTNClear;

        private System.ComponentModel.BackgroundWorker backgroundWorker1;

    }
}


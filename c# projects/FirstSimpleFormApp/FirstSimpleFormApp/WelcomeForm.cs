using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FirstSimpleFormApp
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
            Lable();
            Button();

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();         
            this.ClientSize = new System.Drawing.Size(674, 375);
            this.Name = "WelcomeForm";
            this.Text = "Hey Kunal";
            this.ResumeLayout(false);

        }

        private void Lable()
        {
            Label label = new Label();
            this.Controls.Add(label);
            label.Text = "Welcome to forms app";
            label.Height = 45;
            label.Width = 600;
            label.Font = new Font("Airel", 20.25F);
        }
        private void Button()
        {
            Button MyButton = new Button();
            this.Controls.Add(MyButton);
            MyButton.Location = new Point(5, 50);
            MyButton.Text = "Click Me!";
            MyButton.AutoSize = true;
            MyButton.BackColor = Color.LightBlue;
            MyButton.Padding = new Padding(2);
            MyButton.Font = new Font("Airel", 18);

            MyButton.Click += GodListenern;
            MyButton.Click += EvilListenern;
            this.Controls.Add(MyButton);
        }
        private void GodListenern(object sender, EventArgs e)
        {
            Console.WriteLine("God is listning");
        }
        private void EvilListenern(object sender, EventArgs e)
        {
            Console.WriteLine("Evil is listning");
        }
    }
}

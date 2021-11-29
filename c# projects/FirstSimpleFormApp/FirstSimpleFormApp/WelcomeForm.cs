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
    }
}

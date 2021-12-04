using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsynkProgrammingApproch
{
    public class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
            Buttons();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ClientSize = new Size(674, 375);
            this.Name = "WelcomeForm";
            this.Text = "Async Programming";
            this.ResumeLayout(false);

        }

        private void Buttons()
        {
            Button btn1 = new Button();
            this.Controls.Add(btn1);
            btn1.Location = new Point(60, 70);
            btn1.Text = "Hello";
            btn1.AutoSize = true;
            btn1.BackColor = Color.LightBlue;
            btn1.Padding = new Padding(2);
            btn1.Font = new Font("Airel", 18);
            btn1.Click += btn_Hello_click;

            Button btn2 = new Button();
            this.Controls.Add(btn2);
            btn2.Location = new Point(180, 70);
            btn2.Text = "Sync";
            btn2.AutoSize = true;
            btn2.BackColor = Color.LightBlue;
            btn2.Padding = new Padding(2);
            btn2.Font = new Font("Airel", 18);
            btn2.Click += btn_Sync_click;

            Button btn3 = new Button();
            this.Controls.Add(btn3);
            btn3.Location = new Point(300, 70);
            btn3.Text = "Thread";
            btn3.AutoSize = true;
            btn3.BackColor = Color.LightBlue;
            btn3.Padding = new Padding(2);
            btn3.Font = new Font("Airel", 18);
            btn3.Click += btn_Thread_click;

            Button btn4 = new Button();
            this.Controls.Add(btn4);
            btn4.Location = new Point(60, 130);
            btn4.Text = "Task";
            btn4.AutoSize = true;
            btn4.BackColor = Color.LightBlue;
            btn4.Padding = new Padding(2);
            btn4.Font = new Font("Airel", 18);
            btn4.Click += btn_Task_click;

            Button btn5 = new Button();
            this.Controls.Add(btn5);
            btn5.Location = new Point(180, 130);
            btn5.Text = "Async";
            btn5.AutoSize = true;
            btn5.BackColor = Color.LightBlue;
            btn5.Padding = new Padding(2);
            btn5.Font = new Font("Airel", 18);
            btn5.Click += btn_Async_click;

            Button btn6 = new Button();
            this.Controls.Add(btn6);
            btn6.Location= new Point(300, 130);
            btn6.Text = "Async result";
            btn6.AutoSize = true;
            btn6.BackColor = Color.LightBlue;
            btn6.Padding = new Padding(2);
            btn6.Font = new Font("Airel", 18);
            btn6.Click += btn_Async_Result_click;
        }
        private void GodListener(object sender, EventArgs e)
        {
            Console.WriteLine("god listinig");
        }
        private void btn_Hello_click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello\nTime is : " +DateTime.Now.ToString("hh:mm:ss"));
        }
        private void btn_Sync_click(object sender, EventArgs e)
        {
            new TimePrinter().Print();
        }
        private void btn_Thread_click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new TimePrinter().Print);
            thread.Start();
        }
        private void btn_Task_click(object sender, EventArgs e)
        {
            Task.Run(new TimePrinter().Print);
        }
        private void btn_Async_click(object sender, EventArgs e)
        {
            Task<int> r = new TimePrinter().PrintAsync();
            MessageBox.Show("End of btn_Async_click");
        }
        private async void btn_Async_Result_click(object sender, EventArgs e)
        {
            int r = await new TimePrinter().PrintAsync();
            MessageBox.Show(r.ToString());
        }
    }
}

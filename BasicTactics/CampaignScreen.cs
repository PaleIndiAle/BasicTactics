using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicTactics
{
    public partial class CampaignScreen : UserControl
    {
        public CampaignScreen()
        {
            InitializeComponent();
            textBox1.Text = $"Time: {Form1.IsTime} seconds";
            textBox2.Text = $"Time: {Form1.RsTime} seconds";
        }

        private void firstLevelButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new InitiationLevel());

            Form1.ImsTime = 0;
            Form1.IsTime = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Form1.level_condition == 1)
            {
                Form1.ChangeScreen(this, new RiverDanger());
                Form1.RmsTime = 0;
                Form1.RsTime = 0;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
